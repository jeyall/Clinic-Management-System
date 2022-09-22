Imports MySql.Data.MySqlClient

'transno = 0
'patientno = 1
'radtech = 2
'radiologist = 3
'date = 4
'timestamp = 5

Public Class xray_tab_register

    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 "

    Public Sub xray_tab_register_Load(sender As Object, e As EventArgs) Handles Me.Load
        autocompletesourcelist()

        Tb_infoTableAdapter.Fill(Db_cygnetmedDataSet.tb_info)
        Tb_xrayTableAdapter.Fill(Db_cygnetmedDataSet.tb_xray)

        doctors()

        mcb_all_search_CheckedChanged(sender, e)
        grid_patients_SelectionChanged(sender, e)

        Tb_infoBindingSource.Sort = "info_timestamp ASC"
    End Sub

    Private Sub autocompletesourcelist()
        Dim exam, impression As New AutoCompleteStringCollection()
        exam.AddRange(New String() _
                        {
                            "CXR PA",
                            "APLV"
                        })
        impression.AddRange(New String() _
                        {
                            "ESSENTIALLY NORMAL CHEST",
                            "APICOLORDOTIC VIEW IS SUGGESTED",
                            "CLEAR LUNGS WITH MILD THORACIC SCOLIOSIS",
                            "CLEAR LUNGS CARDIOMEGALY"
                        })
        mtxt_exam.AutoCompleteCustomSource = exam
        mtxt_impression.AutoCompleteCustomSource = impression
    End Sub

    Private Sub mcb_all_search_CheckedChanged(sender As Object, e As EventArgs) Handles mcb_all_search.CheckedChanged
        If mcb_all_search.Checked = True Then
            Tb_infoBindingSource.Filter = "info_xray IS NOT NULL"
        Else
            mdt_search_ValueChanged(sender, e)
        End If

        Tb_infoBindingSource.MoveLast()
    End Sub

    Private Sub mdt_search_ValueChanged(sender As Object, e As EventArgs) Handles mdt_search.ValueChanged
        Tb_infoBindingSource.Filter = "info_xray IS NOT NULL AND " &
            "info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") & "%'"

        Tb_infoBindingSource.MoveLast()
    End Sub

    Private Sub grid_patients_SelectionChanged(sender As Object, e As EventArgs) Handles grid_patients.SelectionChanged
        If grid_patients.Rows.Count > 0 Then
            Tb_xrayBindingSource.Filter = "transno = '" & mlbl_case.Text & "'"

            'If grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value.ToString <> Nothing Then
            '    pb_patient.Image = Image.FromFile(grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value.ToString)
            'Else
            '    pb_patient.Image = Nothing
            'End If

            If mlbl_status.Text = Nothing Then
                mlbl_status.Text = "PENDING"
            End If
        Else
            Tb_xrayBindingSource.Filter = "transno = ' '"
            pb_patient.Image = Nothing
            mlbl_status.Text = Nothing
        End If

        UI()
    End Sub

    Private Sub mtxt_search_TextChanged(sender As Object, e As EventArgs) Handles mtxt_search.TextChanged
        If mcb_all_search.Checked = True Then
            Tb_infoBindingSource.Filter = "info_fullname LIKE '%" & mtxt_search.Text & "%' AND info_xray IS NOT NULL OR " &
                "transno LIKE '%" & mtxt_search.Text & "%' AND info_xray IS NOT NULL"
        Else
            Tb_infoBindingSource.Filter = "info_fullname LIKE '%" & mtxt_search.Text & "%' AND info_xray IS NOT NULL AND info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") & "%' OR " &
                "transno LIKE '%" & mtxt_search.Text & "%' AND info_xray IS NOT NULL AND info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") & "%'"
        End If
    End Sub

    Private Sub UI()
        'Datagrid Section
        grid_patients.Enabled = True
        mtxt_search.Enabled = True
        mdt_search.Enabled = True
        mcb_all_search.Enabled = True

        If grid_patients.Rows.Count > 0 Then
            If mlbl_status.Text = "PENDING" Then
                'Buttons
                mbtn_add.Enabled = True
                mbtn_save.Enabled = False
                'UI Behaviour
                mtxt_exam.Enabled = False
                mtxt_report.Enabled = False
                mtxt_impression.Enabled = False
                mcbo_radiotech.Enabled = False
                mcbo_radiotech.SelectedIndex = -1
                mcbo_radiologist.Enabled = False
                mcbo_radiologist.SelectedIndex = -1
                mcbo_film.Enabled = False
                mcbo_film.SelectedIndex = -1
            ElseIf mlbl_status.Text = "REGISTERED" Then
                'Buttons
                mbtn_add.Enabled = False
                mbtn_save.Enabled = True
                'UI Behaviour
                mtxt_exam.Enabled = True
                mtxt_report.Enabled = True
                mtxt_impression.Enabled = True
                mcbo_radiotech.Enabled = True
                mcbo_radiologist.Enabled = True
                mcbo_film.Enabled = True
            ElseIf mlbl_status.Text = "RELEASED" Then
                'Buttons
                mbtn_add.Enabled = False
                mbtn_save.Enabled = False
                'UI Behaviour
                mtxt_exam.Enabled = False
                mtxt_report.Enabled = False
                mtxt_impression.Enabled = False
                mcbo_radiotech.Enabled = False
                mcbo_radiotech.SelectedIndex = -1
                mcbo_radiologist.Enabled = False
                mcbo_radiologist.SelectedIndex = -1
                mcbo_film.Enabled = False
                mcbo_film.SelectedIndex = -1
            End If
        Else
            'Buttons
            mbtn_add.Enabled = False
            mbtn_save.Enabled = False
            'UI Behaviour
            mtxt_exam.Enabled = False
            mtxt_report.Enabled = False
            mtxt_impression.Enabled = False
            mcbo_radiotech.Enabled = False
            mcbo_radiotech.SelectedIndex = -1
            mcbo_radiologist.Enabled = False
            mcbo_radiologist.SelectedIndex = -1
            mcbo_film.Enabled = False
            mcbo_film.SelectedIndex = -1
        End If
    End Sub

    Private Sub mbtn_add_Click(sender As Object, e As EventArgs) Handles mbtn_add.Click
        Tb_xrayBindingSource.AddNew()

        'Datagrid Section
        grid_patients.Enabled = False
        mtxt_search.Enabled = False
        mdt_search.Enabled = False
        mcb_all_search.Enabled = False
        'Buttons
        mbtn_add.Enabled = False
        mbtn_save.Enabled = True
        'UI Behaviour
        mtxt_exam.Enabled = True
        mtxt_exam.Text = "CXR PA"
        mtxt_report.Enabled = True
        mtxt_impression.Enabled = True
        mtxt_impression.Text = "ESSENTIALLY NORMAL CHEST"
        mcbo_radiotech.Enabled = True
        mcbo_radiotech.SelectedIndex = -1
        mcbo_radiologist.Enabled = True
        mcbo_radiologist.SelectedIndex = -1
        mcbo_film.Enabled = True
        mcbo_film.SelectedIndex = -1

        mtxt_exam.Focus()
    End Sub

    Private Sub mbtn_save_Click(sender As Object, e As EventArgs) Handles mbtn_save.Click
        If String.IsNullOrWhiteSpace(mtxt_exam.Text) Or String.IsNullOrWhiteSpace(mtxt_report.Text) Or
            String.IsNullOrWhiteSpace(mtxt_impression.Text) Or mcbo_film.SelectedIndex = -1 Then
            MessageBox.Show("Fill up all fields in patient's information", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf mcbo_radiotech.SelectedIndex = -1 Or mcbo_radiologist.SelectedIndex = -1 Then
            MessageBox.Show("There is no selected Radtech or Radiologist", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            mcbo_radiotech.Focus()
        Else
            Tb_logsBindingSource.AddNew()

            trimmed()

            With grid_xray.Rows(grid_xray.CurrentCell.RowIndex)
                .Cells(0).Value = mlbl_case.Text 'transno
                .Cells(1).Value = mlbl_patient.Text 'patientno
                .Cells(2).Value = mcbo_radiotech.Text 'radtech
                .Cells(3).Value = mcbo_radiologist.Text 'radiologist
                .Cells(6).Value = mlbl_company.Text 'company
            End With

            If mlbl_status.Text = Nothing Then
                With grid_xray.Rows(grid_xray.CurrentCell.RowIndex)
                    .Cells(4).Value = DateTime.Now.ToString("MM/dd/yyyy") 'date
                    .Cells(5).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") 'timestamp
                End With

                mlbl_status.Text = "REGISTERED"

                txt_hide_namel.Text = xray.lbl_name.Text
                txt_hide_deptl.Text = login.txt_hide_dept.Text
                txt_hide_activityl.Text = "REGISTERED NEW X-RAY RECORD"
                txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                txt_hide_corrl.Text = mlbl_case.Text

                Tb_xrayBindingSource.EndEdit()
                Tb_xrayTableAdapter.Update(Db_cygnetmedDataSet.tb_xray)
                Tb_xrayTableAdapter.Fill(Db_cygnetmedDataSet.tb_xray)
                Tb_xrayBindingSource.MoveLast()
            Else
                txt_hide_namel.Text = xray.lbl_name.Text
                txt_hide_deptl.Text = login.txt_hide_dept.Text
                txt_hide_activityl.Text = "EDITED X-RAY RECORD"
                txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                txt_hide_corrl.Text = mlbl_case.Text

                Tb_xrayBindingSource.EndEdit()
                Tb_xrayTableAdapter.Update(Db_cygnetmedDataSet.tb_xray)
            End If

            Tb_logsBindingSource.EndEdit()
            Tb_logsTableAdapter.Update(Db_cygnetmedDataSet.tb_logs)

            'Datagrid Section
            grid_patients.Enabled = True
            mtxt_search.Enabled = True
            mdt_search.Enabled = True
            mcb_all_search.Enabled = True
            'Buttons
            mbtn_add.Enabled = True
            mbtn_save.Enabled = True

            MessageBox.Show("Save successful!", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub doctors()
        Dim connection As New MySqlConnection
        Dim command, command2 As New MySqlCommand
        Dim adaptor, adaptor2 As New MySqlDataAdapter
        Dim datatable, datatable2 As New DataTable

        connection.ConnectionString = My.Settings.db_cygnetmedConnectionString
        command.CommandText = "SELECT DISTINCT doctors_name FROM tb_doctors WHERE doctors_field LIKE '%RADIOLOGIC TECHNOLOGIST%' ORDER BY doctors_name;"
        connection.Open()
        command.Connection = connection

        adaptor.SelectCommand = command
        adaptor.Fill(datatable)

        With mcbo_radiotech
            .DisplayMember = Nothing
            .ValueMember = Nothing
            .DataSource = Nothing

            .DisplayMember = "doctors_name"
            .ValueMember = "doctors_name"
            .DataSource = datatable.DefaultView.ToTable(True, "doctors_name")
        End With

        command2.CommandText = "SELECT DISTINCT doctors_name FROM tb_doctors WHERE doctors_field LIKE '%RADIOLOGIST%' ORDER BY doctors_name;"
        command2.Connection = connection

        adaptor2.SelectCommand = command2
        adaptor2.Fill(datatable2)
        With mcbo_radiologist
            .DisplayMember = Nothing
            .ValueMember = Nothing
            .DataSource = Nothing

            .DisplayMember = "doctors_name"
            .ValueMember = "doctors_name"
            .DataSource = datatable2.DefaultView.ToTable(True, "doctors_name")
        End With

        connection.Close()
    End Sub

    Private Sub mtxt_exam_TextChanged(sender As Object, e As EventArgs) Handles mtxt_impression.TextChanged, mtxt_exam.TextChanged
        If mtxt_exam.Text = "CXR PA" And mtxt_impression.Text = "ESSENTIALLY NORMAL CHEST" Then
            mtxt_report.Text = "Lung fields are clear. Heart is not enlarged." & Environment.NewLine &
                    "Vascular distribution pattern is unaltered. " & Environment.NewLine &
                    "The diaphragm, its sulci, and the visualized chest structures are negative."
        ElseIf mtxt_exam.Text = "CXR PA" And mtxt_impression.Text = "APICOLORDOTIC VIEW IS SUGGESTED" Then
            mtxt_report.Text = "Suspicious densities, right upper lobe." & Environment.NewLine &
                    "Heart is not enlarged." & Environment.NewLine &
                    "The rest of the visualized chest structures are unremarkable."
        ElseIf mtxt_exam.Text = "CXR PA" And mtxt_impression.Text = "CLEAR LUNGS WITH MILD THORACIC SCOLIOSIS" Then
            mtxt_report.Text = "Lung fields are clear. Heart is not enlarged." & Environment.NewLine &
                    "There is a mild scoliosis in the thoracic spine." & Environment.NewLine &
                    "The rest of the visualized chest structures are unremarkable."
        ElseIf mtxt_exam.Text = "APLV" And mtxt_impression.Text = "ESSENTIALLY NORMAL CHEST" Then
            mtxt_report.Text = "Apicolordotic view shows no active parenchymal infiltrates."
        Else
            mtxt_report.Text = Nothing
        End If
    End Sub

    Private Sub mbtn_print_Click(sender As Object, e As EventArgs) Handles mbtn_print.Click
        xray_report.ShowDialog()
    End Sub

    Private Sub mtxt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_search.KeyPress,
            mtxt_exam.KeyPress, mtxt_impression.KeyPress, mtxt_report.KeyPress
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

    Private Sub trimmed()
        mtxt_exam.Text = mtxt_exam.Text.Replace("  ", " ").Trim()
        mtxt_impression.Text = mtxt_impression.Text.Replace("  ", " ").Trim()
        mtxt_report.Text = mtxt_report.Text.Replace("  ", " ").Trim()
    End Sub
End Class
