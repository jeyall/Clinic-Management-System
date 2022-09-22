Imports Microsoft.Reporting.WinForms

Public Class info_reports
    Private Sub info_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_infoTableAdapter.Fill(db_cygnetmedDataSet.tb_info)
        info_viewer.LocalReport.DataSources.Clear()

        cbo_print.SelectedIndex = 0

        If cbo_print.Text = "Daily Report" Then
            daily_report()
        ElseIf cbo_print.Text = "MD Payroll" Then
            md_payroll()
        End If

        info_viewer.SetDisplayMode(DisplayMode.PrintLayout)
        info_viewer.ZoomMode = ZoomMode.PageWidth
        info_viewer.RefreshReport()
    End Sub

    Private Sub daily_report()
        info_viewer.LocalReport.ReportPath = "Reports\info\info_daily_report.rdlc"
        Dim rds As New ReportDataSource
        rds.Name = "report_info"
        rds.Value = tb_infoBindingSource
        info_viewer.LocalReport.DataSources.Add(rds)

        tb_infoBindingSource.Filter = "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_status <> 'ARCHIVED'"
        tb_infoBindingSource.Sort = "info_fullname ASC"

        Dim cash_total, charge_total As Double
        Dim param_cash, param_charge As New ReportParameter()
        Dim rpm_cash() As ReportParameter = {param_cash}
        param_cash.Name = "cash"
        Dim charge_param() As ReportParameter = {param_charge}
        param_charge.Name = "charge"

        tb_info_filter.Filter = "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_status <> 'ARCHIVED' AND info_mop = 'CASH'"

        For index As Integer = 0 To mgrid_tb_info.RowCount - 1
            cash_total += mgrid_tb_info.Rows(index).Cells(0).Value
        Next

        tb_info_filter.Filter = "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_status <> 'ARCHIVED' AND info_mop = 'CHARGE' OR " &
            "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_status <> 'ARCHIVED' AND info_mop = 'HMO'"

        For index As Integer = 0 To mgrid_tb_info.RowCount - 1
            charge_total += mgrid_tb_info.Rows(index).Cells(0).Value
        Next

        param_cash.Values.Add(cash_total)
        param_charge.Values.Add(charge_total)

        info_viewer.LocalReport.SetParameters(rpm_cash)
        info_viewer.LocalReport.SetParameters(charge_param)

        info_viewer.RefreshReport()
    End Sub

    Public Sub md_payroll()
        info_viewer.LocalReport.ReportPath = "Reports\info\info_md_payroll.rdlc"
        Dim rds As New ReportDataSource
        rds.Name = "tb_info_payroll"
        rds.Value = tb_info_filter
        info_viewer.LocalReport.DataSources.Add(rds)

        tb_info_filter.Filter = "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_noe = 'CONSULTATION'" &
            " AND info_code <> 'MEDCERT'" &
            " AND info_status <> 'ARCHIVED'"

        Dim consult As Double
        Dim param_consult As New ReportParameter()
        Dim rpm_consult() As ReportParameter = {param_consult}
        param_consult.Name = "consults"
        consult = mgrid_tb_info.Rows.Count
        param_consult.Values.Add(consult)
        info_viewer.LocalReport.SetParameters(rpm_consult)

        tb_info_filter.Filter = "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_code = 'MEDCERT'" &
            " AND info_status <> 'ARCHIVED'"

        Dim medcert As Double
        Dim param_medcert As New ReportParameter()
        Dim rpm_medcert() As ReportParameter = {param_medcert}
        param_medcert.Name = "medcert"
        medcert = mgrid_tb_info.Rows.Count * 100
        param_medcert.Values.Add(medcert)
        info_viewer.LocalReport.SetParameters(rpm_medcert)

        tb_info_filter.Filter = "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_noe = 'CONSULTATION' AND info_status <> 'ARCHIVED' OR " &
            "info_timestamp LIKE '" & info.Tab_register1.mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_code = 'MEDCERT' AND info_status <> 'ARCHIVED'"

        Dim pax, rate As Double
        Dim param_pax, param_rate As New ReportParameter()
        Dim rpm_pax() As ReportParameter = {param_pax}
        param_pax.Name = "pax"
        Dim rpm_rate() As ReportParameter = {param_rate}
        param_rate.Name = "rate"
        pax = mgrid_tb_info.Rows.Count
        rate = Val(info_reports_payroll.mtxt_rate.Text)
        param_pax.Values.Add(pax)
        param_rate.Values.Add(rate)
        info_viewer.LocalReport.SetParameters(rpm_pax)
        info_viewer.LocalReport.SetParameters(rpm_rate)

        Dim physician As String
        Dim param_physician As New ReportParameter()
        Dim rpm_physician() As ReportParameter = {param_physician}
        param_physician.Name = "info_physician"
        physician = info_reports_payroll.mtxt_doctor.Text
        param_physician.Values.Add(physician)
        info_viewer.LocalReport.SetParameters(rpm_physician)

        Dim hours As Integer
        Dim param_hours As New ReportParameter()
        Dim rpm_hours() As ReportParameter = {param_hours}
        param_hours.Name = "hours"
        hours = Val(info_reports_payroll.mtxt_hours.Text)
        param_hours.Values.Add(hours)
        info_viewer.LocalReport.SetParameters(rpm_hours)

        info_viewer.RefreshReport()
    End Sub

    Private Sub info_reports_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            info_reports_payroll.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub print_button() Handles info_viewer.PrintingBegin
        Tb_logsBindingSource.AddNew()

        If cbo_print.Text = "Daily Report" Then
            txt_hide_namel.Text = xray.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED DAILY REPORT"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ElseIf cbo_print.Text = "MD Payroll" Then
            txt_hide_namel.Text = xray.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED PAYROLL"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        End If

        Tb_logsBindingSource.EndEdit()
        Tb_logsTableAdapter.Update(db_cygnetmedDataSet.tb_logs)
    End Sub

    Private Sub cbo_print_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_print.SelectedIndexChanged
        If cbo_print.Text = "Daily Report" Then
            daily_report()
        ElseIf cbo_print.Text = "MD Payroll" Then
            info_reports_payroll.ShowDialog()
        End If
    End Sub
End Class