Imports MySql.Data.MySqlClient

Public Class info_package

    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789. "

    Private Sub info_package_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_packageTableAdapter.Fill(Db_cygnetmedDataSet.tb_package)
        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
        StyleManager = msm_style

        autocompletequery()

        mtxt_search.Focus()
        mtxt_search.Focus()
    End Sub

    Private Sub mbtn_add_Click(sender As Object, e As EventArgs) Handles mbtn_add.Click
        'UI Behaviour
        grid_packages.Enabled = False
        mtxt_search.Enabled = False

        mtxt_company.Focus()

        Tb_packageBindingSource.AddNew()
    End Sub

    Private Sub mbtn_save_Click(sender As Object, e As EventArgs) Handles mbtn_save.Click
        Tb_logsBindingSource.AddNew()

        trimmed()
        UI_save()

        If grid_packages.Enabled = False Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(12).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

            txt_hide_namel.Text = info.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "ADDED NEW PACKAGE"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = mtxt_code.Text
        Else
            txt_hide_namel.Text = info.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "EDITED PACKAGE"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = mtxt_code.Text
        End If

        Tb_packageBindingSource.EndEdit()
        Tb_packageTableAdapter.Update(Db_cygnetmedDataSet.tb_package)
        Db_cygnetmedDataSet.tb_package.AcceptChanges()
        Tb_packageTableAdapter.Fill(Db_cygnetmedDataSet.tb_package)
        Tb_logsBindingSource.EndEdit()
        Tb_logsTableAdapter.Update(Db_cygnetmedDataSet.tb_logs)
        info.Tab_register1.Tb_packageTableAdapter.Fill(info.Tab_register1.Db_cygnetmedDataSet.tb_package)
        info.Tab_register1.Tb_packageBindingSource.Filter = "package_code = '" & info.Tab_register1.grid_patients.Rows(info.Tab_register1.grid_patients.CurrentCell.RowIndex).Cells(5).Value & "'"

        'UI Behaviour
        grid_packages.Enabled = True
        mtxt_search.Enabled = True

        MessageBox.Show("Save successful!", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UI_save()
        'xray
        If mcb_radio.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(4).Value = "enable"
        End If
        'lab
        If mcb_lab.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(5).Value = "enable"
        End If
        'hema
        If mcb_hema.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(6).Value = "enabled"
        End If
        'feca
        If mcb_feca.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(7).Value = "enabled"
        End If
        'uri
        If mcb_uri.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(8).Value = "enabled"
        End If
        'blood
        If mcb_blood.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(9).Value = "enabled"
        End If
        'others
        If mcb_others.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(10).Value = "enabled"
        End If
        'noe
        If mcb_annual.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value = "APE"
        ElseIf mcb_pre.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value = "PRE-EMPLOYMENT"
        ElseIf mcb_walkin.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value = "WALK-IN"
        ElseIf mcb_consult.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value = "CONSULTATION"
        End If
        'PE
        If mcb_pe.Checked = True Then
            grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(12).Value = "YES"
        End If
    End Sub

    Private Sub grid_patients_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_packages.CellDoubleClick, grid_packages.CellContentDoubleClick
        info.Tab_register1.Tb_packageBindingSource.Filter = "package_code = '" & mtxt_code.Text & "'"
        If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value.ToString = "PRE-EMPLOYMENT" Or
           grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value.ToString = "APE" Then

            info.Tab_register1.mcb_company.Text = mtxt_company.Text
            info.Tab_register1.mtxt_discount_TextChanged(sender, e)
        End If

        If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(4).Value.ToString <> Nothing Then
            info.Tab_register1.grid_patients.Rows(info.Tab_register1.grid_patients.CurrentCell.RowIndex).Cells(9).Value = "REGISTERED"
        End If

        If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(5).Value.ToString <> Nothing Then
            info.Tab_register1.grid_patients.Rows(info.Tab_register1.grid_patients.CurrentCell.RowIndex).Cells(10).Value = "REGISTERED"
        End If

        Close()
    End Sub

    Private Sub bmbtn_delete_Click(sender As Object, e As EventArgs) Handles bmbtn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this package?", "Cygnetmed Health System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then
            Tb_logsBindingSource.AddNew()

            For Each oneCell As DataGridViewCell In grid_packages.SelectedCells
                If oneCell.Selected Then grid_packages.Rows.RemoveAt(oneCell.RowIndex)
            Next

            txt_hide_namel.Text = info.lbl_name.Text
            txt_hide_deptl.Text = login.txt_hide_dept.Text
            txt_hide_activityl.Text = "DELETED A PACKAGE"
            txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            txt_hide_corrl.Text = mtxt_code.Text

            Tb_packageBindingSource.EndEdit()
            Tb_packageTableAdapter.Update(Db_cygnetmedDataSet.tb_package)
            Tb_logsBindingSource.EndEdit()
            Tb_logsTableAdapter.Update(Db_cygnetmedDataSet.tb_logs)

            MessageBox.Show("Deleted successfully", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mtxt_search_TextChanged(sender As Object, e As EventArgs) Handles mtxt_search.TextChanged
        Tb_packageBindingSource.Filter =
            "package_code LIKE '%" & mtxt_search.Text &
            "%' OR package_company LIKE '%" & mtxt_search.Text &
            "%' OR package_procedure LIKE '%" & mtxt_search.Text & "%'"
    End Sub

    Private Sub mtxt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_search.KeyPress,
            mtxt_company.KeyPress, mtxt_code.KeyPress, mtxt_procedure.KeyPress, mtxt_price.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) AllowedKeys.Contains(c))

            Case Else ' Other key is pressed
                e.Handled = Not AllowedKeys.Contains(e.KeyChar)
        End Select
    End Sub

    Private Sub grid_patients_SelectionChanged(sender As Object, e As EventArgs) Handles grid_packages.SelectionChanged
        UI_grid()
    End Sub

    Private Sub UI_grid()
        Try
            'xray
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(4).Value.ToString <> Nothing Then
                mcb_radio.Checked = True
            Else
                mcb_radio.Checked = False
            End If
            'lab
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(5).Value.ToString <> Nothing Then
                mcb_lab.Checked = True
            Else
                mcb_lab.Checked = False
            End If
            'hema
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(6).Value.ToString <> Nothing Then
                mcb_hema.Checked = True
            Else
                mcb_hema.Checked = False
            End If
            'feca
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(7).Value.ToString <> Nothing Then
                mcb_feca.Checked = True
            Else
                mcb_feca.Checked = False
            End If
            'uri
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(8).Value.ToString <> Nothing Then
                mcb_uri.Checked = True
            Else
                mcb_uri.Checked = False
            End If
            'blood
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(9).Value.ToString <> Nothing Then
                mcb_blood.Checked = True
            Else
                mcb_blood.Checked = False
            End If
            'others
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(10).Value.ToString <> Nothing Then
                mcb_others.Checked = True
            Else
                mcb_others.Checked = False
            End If
            'NOE
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value.ToString = "APE" Then
                mcb_annual.Checked = True
                mcb_annual.Enabled = False
                mcb_pre.Checked = False
                mcb_pre.Enabled = True
                mcb_walkin.Checked = False
                mcb_walkin.Enabled = True
                mcb_consult.Checked = False
                mcb_consult.Enabled = True
            ElseIf grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value.ToString = "PRE-EMPLOYMENT" Then
                mcb_pre.Checked = True
                mcb_pre.Enabled = False
                mcb_annual.Checked = False
                mcb_annual.Enabled = True
                mcb_walkin.Checked = False
                mcb_walkin.Enabled = True
                mcb_consult.Checked = False
                mcb_consult.Enabled = True
            ElseIf grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value.ToString = "WALK-IN" Then
                mcb_walkin.Checked = True
                mcb_walkin.Enabled = False
                mcb_annual.Checked = False
                mcb_annual.Enabled = True
                mcb_pre.Checked = False
                mcb_pre.Enabled = True
                mcb_consult.Checked = False
                mcb_consult.Enabled = True
            ElseIf grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(11).Value.ToString = "CONSULTATION" Then
                mcb_consult.Checked = True
                mcb_consult.Enabled = False
                mcb_annual.Checked = False
                mcb_annual.Enabled = True
                mcb_pre.Checked = False
                mcb_pre.Enabled = True
                mcb_walkin.Checked = False
                mcb_walkin.Enabled = True
            Else
                mcb_consult.Checked = False
                mcb_consult.Enabled = True
                mcb_annual.Checked = False
                mcb_annual.Enabled = True
                mcb_pre.Checked = False
                mcb_pre.Enabled = True
                mcb_walkin.Checked = False
                mcb_walkin.Enabled = True
            End If
            'PE
            If grid_packages.Rows(grid_packages.CurrentCell.RowIndex).Cells(12).Value.ToString = "YES" Then
                mcb_pe.Checked = True
            Else
                mcb_pe.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mcb_annual_OnChange(sender As Object, e As EventArgs) Handles mcb_annual.CheckedChanged
        If mcb_annual.Checked = True Then
            mcb_annual.Enabled = False
            mcb_walkin.Checked = False
            mcb_walkin.Enabled = True
            mcb_pre.Checked = False
            mcb_pre.Enabled = True
            mcb_consult.Checked = False
            mcb_consult.Enabled = True
        End If
    End Sub

    Private Sub mcb_pre_OnChange(sender As Object, e As EventArgs) Handles mcb_pre.CheckedChanged
        If mcb_pre.Checked = True Then
            mcb_pre.Enabled = False
            mcb_annual.Checked = False
            mcb_annual.Enabled = True
            mcb_walkin.Checked = False
            mcb_walkin.Enabled = True
            mcb_consult.Checked = False
            mcb_consult.Enabled = True
        End If
    End Sub

    Private Sub mcb_walkin_OnChange(sender As Object, e As EventArgs) Handles mcb_walkin.CheckedChanged
        If mcb_walkin.Checked = True Then
            mcb_walkin.Enabled = False
            mcb_annual.Checked = False
            mcb_annual.Enabled = True
            mcb_pre.Checked = False
            mcb_pre.Enabled = True
            mcb_consult.Checked = False
            mcb_consult.Enabled = True
        End If
    End Sub

    Private Sub cb_consult_OnChange(sender As Object, e As EventArgs) Handles mcb_consult.CheckedChanged
        If mcb_consult.Checked = True Then
            mcb_consult.Enabled = False
            mcb_annual.Checked = False
            mcb_annual.Enabled = True
            mcb_pre.Checked = False
            mcb_pre.Enabled = True
            mcb_walkin.Checked = False
            mcb_walkin.Enabled = True
        End If
    End Sub

    Private Sub autocompletequery()
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim datatable As New DataTable
        Dim autocomplete As New AutoCompleteStringCollection

        connection.ConnectionString = My.Settings.db_cygnetmedConnectionString
        command.CommandText = "SELECT DISTINCT package_company FROM tb_package;"
        connection.Open()
        command.Connection = connection

        adaptor.SelectCommand = command
        adaptor.Fill(datatable)
        For i = 0 To datatable.Rows.Count - 1
            autocomplete.Add(datatable.Rows(i)("package_company").ToString())
        Next

        mtxt_company.AutoCompleteSource = AutoCompleteSource.CustomSource
        mtxt_company.AutoCompleteCustomSource = autocomplete
        mtxt_company.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub trimmed()
        mtxt_company.Text = mtxt_company.Text.Replace("  ", " ").Trim()
        mtxt_code.Text = mtxt_code.Text.Replace("  ", " ").Trim()
        mtxt_procedure.Text = mtxt_procedure.Text.Replace("  ", " ").Trim()
        mtxt_price.Text = mtxt_price.Text.Replace("  ", " ").Trim()
    End Sub

    Private Sub info_package_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dispose()
    End Sub
End Class