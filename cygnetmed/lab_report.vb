Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class lab_report

    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 "

    Private Sub lab_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_doctorsTableAdapter.Fill(Db_cygnetmedDataSet.tb_doctors)
        Tb_infoTableAdapter.Fill(Db_cygnetmedDataSet.tb_info)
        Tb_labTableAdapter.Fill(Db_cygnetmedDataSet.tb_lab)

        mcbo_print.SelectedIndex = 0
        mcbo_print_SelectedIndexChanged(sender, e)

        lab_viewer.SetDisplayMode(DisplayMode.PrintLayout)
        lab_viewer.ZoomMode = ZoomMode.PageWidth
        lab_viewer.RefreshReport()

        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
    End Sub

    Private Sub mcbo_print_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbo_print.SelectedIndexChanged
        If mcbo_print.Text = "RESULT" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Value = mdt_from.Value
            mdt_to.Enabled = False
            mcbo_company.Enabled = False
            blank(sender, e)
        ElseIf mcbo_print.Text = "HEMATOLOGY" Then
            mcbo_company.Enabled = True
            companyquery()
            mdt_from.Value = mdt_to.Value
            mdt_to.Enabled = True
            hematology(sender, e)
        ElseIf mcbo_print.Text = "FECALYSIS" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Value = mdt_from.Value
            mdt_to.Enabled = False
            mcbo_company.Enabled = False
            fecalysis(sender, e)
        ElseIf mcbo_print.Text = "URINALYSIS" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Value = mdt_from.Value
            mdt_to.Enabled = False
            mcbo_company.Enabled = False
            urinalysis(sender, e)
        ElseIf mcbo_print.Text = "BLOOD CHEMISTRY" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Value = mdt_from.Value
            mdt_to.Enabled = False
            mcbo_company.Enabled = False
            bloodchem(sender, e)
        ElseIf mcbo_print.Text = "OTHERS" Then
            mcbo_company.DataBindings.Clear()
            mdt_to.Value = mdt_from.Value
            mdt_to.Enabled = False
            mcbo_company.Enabled = False
            'blank(sender, e)
        ElseIf mcbo_print.Text = "SUMMARY" Then
            mcbo_company.Enabled = False
            companyquery()
            mdt_from.Value = mdt_to.Value
            mdt_to.Enabled = True
            summary(sender, e)
        ElseIf mcbo_print.Text = "SUMMARY" Or mcbo_print.Text = "SUMMARY (COMPANY)" Then
            mcbo_company.Enabled = True
            companyquery()
            mdt_from.Value = mdt_to.Value
            mdt_to.Enabled = True
            summary(sender, e)
        End If

        lab_viewer.RefreshReport()
    End Sub

    Private Sub dates_from_ValueChanged(sender As Object, e As EventArgs) Handles mdt_from.ValueChanged, mdt_to.ValueChanged
        If mcbo_print.Text = "SUMMARY" Or mcbo_print.Text = "SUMMARY (COMPANY)" Then
            Tb_labBindingSource.Filter = "lab_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND lab_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "'"
            lab_reportbindingSource.Filter = "lab_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND lab_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "'"
            Tb_infoBindingSource.Filter = "info_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND info_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND info_lab IS NOT NULL"

            lab_viewer.RefreshReport()
        Else
            mdt_to.Value = mdt_from.Value
            Tb_labBindingSource.Filter = "lab_timestamp LIKE '" & mdt_from.Value.ToString("yyyy/MM/dd") & "%'"
        End If
    End Sub

    Private Sub grid_patients_SelectionChanged(sender As Object, e As EventArgs) Handles grid_patients.SelectionChanged
        If grid_patients.Rows.Count > 0 Then
            If mcbo_print.Text <> "SUMMARY" And mcbo_print.Text <> "SUMMARY (COMPANY)" Then
                Tb_infoBindingSource.Filter = "transno = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value.ToString & "'"
                lab_reportbindingSource.Filter = "transno = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value.ToString & "'"
                Tb_doctorsBindingSource.Filter = "doctors_name = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(3).Value.ToString & "'"
                Tb_doctorsBindingSource1.Filter = "doctors_name = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value.ToString & "'"

                lab_viewer.RefreshReport()
            End If
        Else
            lab_reportbindingSource.Filter = "transno = ' '"
            Tb_infoBindingSource.Filter = "transno = ' '"

            lab_viewer.RefreshReport()
        End If
    End Sub

    Private Sub mcbo_company_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbo_company.SelectedIndexChanged
        If mcbo_print.Text = "SUMMARY" Or mcbo_print.Text = "SUMMARY (COMPANY)" Then
            Tb_labBindingSource.Filter = "lab_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND lab_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND lab_company = '" & mcbo_company.Text & "'"
            lab_reportbindingSource.Filter = "lab_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND lab_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND lab_company = '" & mcbo_company.Text & "'"
            Tb_infoBindingSource.Filter = "info_timestamp >= '" & mdt_from.Value.ToString("yyyy/MM/dd 00:00:00") & "' AND info_timestamp <= '" & mdt_to.Value.ToString("yyyy/MM/dd 23:59:59") & "' AND info_lab IS NOT NULL AND info_company = '" & mcbo_company.Text & "'"
        End If

        lab_viewer.RefreshReport()
    End Sub

    Private Sub print_button(sender As Object, e As ReportPrintEventArgs) Handles lab_viewer.PrintingBegin
        Tb_logsBindingSource.AddNew()

        If mcbo_print.Text = "RESULT" Then
            txt_hide_namel.Text = lab.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED LABORATORY RESULT"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(2).Value = "RELEASED"
        ElseIf mcbo_print.Text = "HEMATOLOGY" Then
            txt_hide_namel.Text = lab.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED HEMATOLOGY RESULT"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(2).Value = "RELEASED"
        ElseIf mcbo_print.Text = "FECALYSIS" Then
            txt_hide_namel.Text = lab.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED FECALYSIS RESULT"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(2).Value = "RELEASED"
        ElseIf mcbo_print.Text = "URINALYSIS" Then
            txt_hide_namel.Text = lab.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED URINALYSIS RESULT"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(2).Value = "RELEASED"
        ElseIf mcbo_print.Text = "BLOOD CHEMISTRY" Then
            txt_hide_namel.Text = lab.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED BLOOD CHEMISTRY RESULT"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(2).Value = "RELEASED"
        ElseIf mcbo_print.Text = "OTHERS" Then
            txt_hide_namel.Text = lab.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED OTHER RESULT"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(0).Value
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(2).Value = "RELEASED"
        Else
            txt_hide_namel.Text = lab.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "PRINTED LABORATORY SUMMARY"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(1).Value
        End If

        Tb_logsBindingSource.EndEdit()
        Tb_logsTableAdapter.Update(Db_cygnetmedDataSet.tb_logs)
        Tb_labTableAdapter.Update(Db_cygnetmedDataSet.tb_lab)
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

    Private Sub blank(sender As Object, e As EventArgs)
        lab_viewer.LocalReport.DataSources.Clear()

        lab_viewer.LocalReport.ReportPath = "Reports\lab\lab_result.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_lab"
        rds.Value = Tb_infoBindingSource
        rds2.Value = lab_reportbindingSource
        lab_viewer.LocalReport.DataSources.Add(rds)
        lab_viewer.LocalReport.DataSources.Add(rds2)

        doctors()
    End Sub

    Private Sub hematology(sender As Object, e As EventArgs)
        lab_viewer.LocalReport.DataSources.Clear()

        lab_viewer.LocalReport.ReportPath = "Reports\lab\lab_hematology.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_lab"
        rds.Value = Tb_infoBindingSource
        rds2.Value = lab_reportbindingSource
        lab_viewer.LocalReport.DataSources.Add(rds)
        lab_viewer.LocalReport.DataSources.Add(rds2)

        doctors()
    End Sub

    Private Sub fecalysis(sender As Object, e As EventArgs)
        lab_viewer.LocalReport.DataSources.Clear()

        lab_viewer.LocalReport.ReportPath = "Reports\lab\lab_fecalysis.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_lab"
        rds.Value = Tb_infoBindingSource
        rds2.Value = lab_reportbindingSource
        lab_viewer.LocalReport.DataSources.Add(rds)
        lab_viewer.LocalReport.DataSources.Add(rds2)

        doctors()
    End Sub

    Private Sub urinalysis(sender As Object, e As EventArgs)
        lab_viewer.LocalReport.DataSources.Clear()

        lab_viewer.LocalReport.ReportPath = "Reports\lab\lab_urinalysis.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_lab"
        rds.Value = Tb_infoBindingSource
        rds2.Value = lab_reportbindingSource
        lab_viewer.LocalReport.DataSources.Add(rds)
        lab_viewer.LocalReport.DataSources.Add(rds2)

        doctors()
    End Sub
    Private Sub bloodchem(sender As Object, e As EventArgs)
        lab_viewer.LocalReport.DataSources.Clear()

        lab_viewer.LocalReport.ReportPath = "Reports\lab\lab_bloodchem.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_lab"
        rds.Value = Tb_infoBindingSource
        rds2.Value = lab_reportbindingSource
        lab_viewer.LocalReport.DataSources.Add(rds)
        lab_viewer.LocalReport.DataSources.Add(rds2)

        doctors()
    End Sub

    Private Sub summary(sender As Object, e As EventArgs)
        lab_viewer.LocalReport.DataSources.Clear()

        lab_viewer.LocalReport.ReportPath = "Reports\lab\lab_summary.rdlc"
        Dim rds, rds2 As New ReportDataSource
        rds.Name = "report_info"
        rds2.Name = "report_lab"
        rds.Value = Tb_infoBindingSource
        rds2.Value = lab_reportbindingSource
        lab_viewer.LocalReport.DataSources.Add(rds)
        lab_viewer.LocalReport.DataSources.Add(rds2)

        Dim param_datefrom, param_dateto As New ReportParameter()
        Dim rpm_license_medtech() As ReportParameter = {param_datefrom}
        param_datefrom.Name = "datefrom"
        Dim rpm_license_patho() As ReportParameter = {param_dateto}
        param_dateto.Name = "dateto"

        param_datefrom.Values.Add(mdt_from.Value.ToString("MM/dd/yyyy"))
        lab_viewer.LocalReport.SetParameters(rpm_license_medtech)
        param_dateto.Values.Add(mdt_to.Value.ToString("MM/dd/yyyy"))
        lab_viewer.LocalReport.SetParameters(rpm_license_patho)
    End Sub

    Private Sub doctors()
        Dim license_medtech, license_patho
        Dim param_license_medtech, param_license_patho As New ReportParameter()
        Dim rpm_license_medtech() As ReportParameter = {param_license_medtech}
        param_license_medtech.Name = "license_medtech"
        Dim rpm_license_patho() As ReportParameter = {param_license_patho}
        param_license_patho.Name = "license_pathologist"

        license_medtech = txt_hide_medtech.Text
        license_patho = txt_hide_patho.Text
        param_license_medtech.Values.Add(license_medtech)
        lab_viewer.LocalReport.SetParameters(rpm_license_medtech)
        param_license_patho.Values.Add(license_patho)
        lab_viewer.LocalReport.SetParameters(rpm_license_patho)
    End Sub

    Private Sub lab_report_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub
End Class