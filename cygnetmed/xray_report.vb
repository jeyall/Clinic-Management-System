Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class xray_report

    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 "

    Private Sub xray_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_infoTableAdapter.Fill(Db_cygnetmedDataSet.tb_info)
        Tb_xrayTableAdapter.Fill(Db_cygnetmedDataSet.tb_xray)

        mcbo_print.SelectedIndex = 0
        mcbo_print_SelectedIndexChanged(sender, e)

        xray_viewer.SetDisplayMode(DisplayMode.PrintLayout)
        xray_viewer.ZoomMode = ZoomMode.PageWidth
        xray_viewer.RefreshReport()

        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
    End Sub

    Private Sub mcbo_print_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbo_print.SelectedIndexChanged
        If mcbo_print.Text = "SUMMARY" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Enabled = True
            mdt_from.Value = mdt_to.Value
            mcbo_company.Enabled = False
            summary(sender, e)
        ElseIf mcbo_print.Text = "SUMMARY (COMPANY)" Then
            companyquery()
            mdt_to.Enabled = True
            mdt_from.Value = mdt_to.Value
            mcbo_company.Enabled = True
            summary(sender, e)
        ElseIf mcbo_print.Text = "BLANK" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Value = mdt_from.Value
            mdt_to.Enabled = False
            mcbo_company.Enabled = False
            blank(sender, e)
        ElseIf mcbo_print.Text = "FINDINGS" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Value = mdt_from.Value
            mdt_to.Enabled = False
            mcbo_company.Enabled = False
            findings(sender, e)
        End If

        xray_viewer.ResetPageSettings()
        xray_viewer.RefreshReport()
    End Sub

    Private Sub dates_from_ValueChanged(sender As Object, e As EventArgs) Handles mdt_from.ValueChanged, mdt_to.ValueChanged
        If mcbo_print.Text = "SUMMARY" Then
            Tb_xrayBindingSource.Filter = "xray_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND xray_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "'"
            xray_reportbindingsource.Filter = "xray_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND xray_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "'"
            Tb_infoBindingSource.Filter = "info_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND info_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND info_xray IS NOT NULL"

            xray_viewer.RefreshReport()
        ElseIf mcbo_print.Text = "SUMMARY (COMPANY)" Then
            Tb_xrayBindingSource.Filter = "xray_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND xray_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND xray_company = '" & mcbo_company.Text & "'"
            xray_reportbindingsource.Filter = "xray_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND xray_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND xray_company = '" & mcbo_company.Text & "'"
            Tb_infoBindingSource.Filter = "info_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND info_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND info_xray IS NOT NULL AND info_company = '" & mcbo_company.Text & "'"

            xray_viewer.RefreshReport()
        Else
            mdt_to.Value = mdt_from.Value
            Tb_xrayBindingSource.Filter = "xray_timestamp LIKE '" & mdt_from.Value.ToString("yyyy/MM/dd") & "%'"
        End If
    End Sub

    Private Sub grid_patients_SelectionChanged(sender As Object, e As EventArgs) Handles grid_patients.SelectionChanged
        If grid_patients.Rows.Count > 0 Then
            If mcbo_print.Text <> "SUMMARY" And mcbo_print.Text <> "SUMMARY (COMPANY)" Then
                Tb_infoBindingSource.Filter = "transno = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value.ToString & "'"
                xray_reportbindingsource.Filter = "transno = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value.ToString & "'"

                xray_viewer.RefreshReport()
            End If
        Else
            xray_reportbindingsource.Filter = "transno = ' '"
            Tb_infoBindingSource.Filter = "transno = ' '"

            xray_viewer.RefreshReport()
        End If
    End Sub

    Private Sub blank(sender As Object, e As EventArgs)
        xray_viewer.LocalReport.DataSources.Clear()

        xray_viewer.LocalReport.ReportPath = "Reports\xray\xray_result.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_xray"
        rds.Value = Tb_infoBindingSource
        rds2.Value = xray_reportbindingsource
        xray_viewer.LocalReport.DataSources.Add(rds)
        xray_viewer.LocalReport.DataSources.Add(rds2)

        mdt_to.Enabled = False
        mdt_to.Value = mdt_from.Value

        Dim blank_or_findings As String
        Dim param_blank_or_findings As New ReportParameter()
        Dim rpm_blank_or_findings() As ReportParameter = {param_blank_or_findings}
        param_blank_or_findings.Name = "blank_findings"

        blank_or_findings = 0

        param_blank_or_findings.Values.Add(blank_or_findings)
        xray_viewer.LocalReport.SetParameters(rpm_blank_or_findings)
    End Sub

    Private Sub findings(sender As Object, e As EventArgs)
        xray_viewer.LocalReport.DataSources.Clear()

        xray_viewer.LocalReport.ReportPath = "Reports\xray\xray_result.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_xray"
        rds.Value = Tb_infoBindingSource
        rds2.Value = xray_reportbindingsource
        xray_viewer.LocalReport.DataSources.Add(rds)
        xray_viewer.LocalReport.DataSources.Add(rds2)

        Dim blank_or_findings As String
        Dim param_blank_or_findings As New ReportParameter()
        Dim rpm_blank_or_findings() As ReportParameter = {param_blank_or_findings}
        param_blank_or_findings.Name = "blank_findings"

        blank_or_findings = 1

        param_blank_or_findings.Values.Add(blank_or_findings)
        xray_viewer.LocalReport.SetParameters(rpm_blank_or_findings)
    End Sub

    Private Sub summary(sender As Object, e As EventArgs)
        mdt_to.Enabled = True

        xray_viewer.LocalReport.DataSources.Clear()

        xray_viewer.LocalReport.ReportPath = "Reports\xray\xray_summary.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_xray"
        rds.Value = Tb_infoBindingSource
        rds2.Value = xray_reportbindingsource
        xray_viewer.LocalReport.DataSources.Add(rds)
        xray_viewer.LocalReport.DataSources.Add(rds2)

        Dim summary_company As String
        Dim param_summary_company As New ReportParameter()
        Dim rpm_summary_company() As ReportParameter = {param_summary_company}
        param_summary_company.Name = "summary"

        If mcbo_print.Text = "SUMMARY (COMPANY)" Then
            summary_company = "company"
        Else
            summary_company = " "
        End If

        param_summary_company.Values.Add(summary_company)
        xray_viewer.LocalReport.SetParameters(rpm_summary_company)
    End Sub

    Private Sub companyquery()
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim datatable As New DataTable

        connection.ConnectionString = My.Settings.db_cygnetmedConnectionString
        command.CommandText = "SELECT DISTINCT package_company FROM tb_package ORDER BY package_company;"
        connection.Open()
        command.Connection = connection

        adaptor.SelectCommand = command
        adaptor.Fill(datatable)

        With mcbo_company
            .DisplayMember = Nothing
            .ValueMember = Nothing
            .DataSource = Nothing

            .DisplayMember = "package_company"
            .ValueMember = "package_company"
            .DataSource = datatable.DefaultView.ToTable(True, "package_company")
        End With
    End Sub

    Private Sub mcbo_company_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbo_company.SelectedIndexChanged
        If mcbo_print.Text = "SUMMARY (COMPANY)" Then
            Tb_xrayBindingSource.Filter = "xray_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND xray_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND xray_company = '" & mcbo_company.Text & "'"
            xray_reportbindingsource.Filter = "xray_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND xray_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND xray_company = '" & mcbo_company.Text & "'"
            Tb_infoBindingSource.Filter = "info_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND info_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND info_xray IS NOT NULL AND info_company = '" & mcbo_company.Text & "'"
        End If

        xray_viewer.RefreshReport()
    End Sub

    Private Sub print_button(sender As Object, e As ReportPrintEventArgs) Handles xray_viewer.PrintingBegin
        Tb_logsBindingSource.AddNew()

        If mcbo_print.Text <> "SUMMARY" Or mcbo_print.Text <> "SUMMARY (COMPANY)" Then
            txt_hide_namel.Text = xray.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED X-RAY RECORD"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(2).Value = "RELEASED"
        Else
            txt_hide_namel.Text = xray.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED RADIOLOGY SUMMARY"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(1).Value
        End If

        Tb_logsBindingSource.EndEdit()
        Tb_logsTableAdapter.Update(Db_cygnetmedDataSet.tb_logs)
        Tb_xrayTableAdapter.Update(Db_cygnetmedDataSet.tb_xray)
    End Sub

    Private Sub xray_report_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub
End Class