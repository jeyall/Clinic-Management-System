Imports MySql.Data.MySqlClient

Public Class lab_tab_register
    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 "

    Public Sub lab_tab_register_Load(sender As Object, e As EventArgs) Handles Me.Load
        autocompletesourcelist()

        Tb_infoTableAdapter.Fill(Db_cygnetmedDataSet.tb_info)
        Tb_labTableAdapter.Fill(Db_cygnetmedDataSet.tb_lab)
        Tb_packageTableAdapter.Fill(Db_cygnetmedDataSet.tb_package)

        doctors()

        mcb_all_search_CheckedChanged(sender, e)
        grid_patients_SelectionChanged(sender, e)

        Tb_infoBindingSource.Sort = "info_timestamp ASC"
    End Sub

    Private Sub mbtn_add_Click(sender As Object, e As EventArgs) Handles mbtn_add.Click
        'Datagrid Section
        grid_patients.Enabled = False
        mtxt_search.Enabled = False
        mdt_search.Enabled = False
        mcb_all_search.Enabled = False
        'Buttons
        mbtn_add.Enabled = False
        mbtn_save.Enabled = True
        'UI Behaviour/Packages
        If txt_hide_hema.Text <> Nothing Then
            mpnl_hema.Enabled = True
            mtxt_hema_hepab.Text = "NON-REACTIVE"
        Else
            mpnl_hema.Enabled = False
        End If

        Tb_labBindingSource.AddNew()

        If txt_hide_feca.Text <> Nothing Then
            mpnl_feca.Enabled = True
            mtxt_feca_occult.Text = "NONE"
            mtxt_feca_ascaris.Text = "NONE"
            mtxt_feca_trichuris.Text = "NONE"
            mtxt_feca_hook.Text = "NONE"
            mtxt_feca_enta.Text = "NONE"
            mtxt_feca_tropho.Text = "NONE"
        Else
            mpnl_feca.Enabled = False
        End If

        If txt_hide_uri.Text <> Nothing Then
            mpnl_uri.Enabled = True
            If mlbl_gender.Text = "FEMALE" Then
                mtxt_uri_pt.Text = "NEGATIVE"
            End If
        Else
            mpnl_uri.Enabled = False
        End If

        If txt_hide_blood.Text <> Nothing Then
            mpnl_blood.Enabled = True
        Else
            mpnl_blood.Enabled = False
        End If

        If txt_hide_others.Text <> Nothing Then
            mpnl_others.Enabled = True
        Else
            mpnl_others.Enabled = False
        End If

        mcbo_medtech.SelectedIndex = -1
        mcbo_medtech.Enabled = True
        mcbo_pathologist.SelectedIndex = -1
        mcbo_pathologist.Enabled = True

        mpnl_right.VerticalScroll.Value = 0
    End Sub

    Private Sub mbtn_save_Click(sender As Object, e As EventArgs) Handles mbtn_save.Click
        Dim total As Double

        total = Val(mtxt_hema_segmenters.Text) +
                Val(mtxt_hema_lympho.Text) +
                Val(mtxt_hema_eosino.Text) +
                Val(mtxt_hema_mono.Text) +
                Val(mtxt_hema_baso.Text)

        If total <> 100 AndAlso txt_hide_hema.Text <> Nothing Then
            MessageBox.Show("Value should should be equal to 100", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtxt_hema_segmenters.Focus()
        ElseIf mcbo_medtech.SelectedIndex = -1 Or mcbo_pathologist.SelectedIndex = -1 Then
            MessageBox.Show("There is no selected Medtech or Pathologist", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mcbo_medtech.Focus()
        Else
            Tb_logsBindingSource.AddNew()

            trimmed()

            With grid_lab.Rows(grid_lab.CurrentCell.RowIndex)
                .Cells(0).Value = mlbl_case.Text 'transno
                .Cells(1).Value = mlbl_patient.Text 'patientno
                .Cells(2).Value = mlbl_company.Text 'company
                .Cells(3).Value = mcbo_medtech.Text 'medtech
                .Cells(4).Value = mcbo_pathologist.Text 'pathologist
            End With

            If mlbl_status.Text = Nothing Then
                With grid_lab.Rows(grid_lab.CurrentCell.RowIndex)
                    .Cells(5).Value = DateTime.Now.ToString("MM/dd/yyyy") 'date
                    .Cells(6).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") 'timestamp
                End With

                mlbl_status.Text = "REGISTERED"

                txt_hide_namel.Text = xray.lbl_name.Text
                txt_hide_deptl.Text = login.txt_hide_dept.Text
                txt_hide_activityl.Text = "REGISTERED NEW LAB RECORD"
                txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                txt_hide_corrl.Text = mlbl_case.Text

                Tb_labBindingSource.EndEdit()
                Tb_labTableAdapter.Update(Db_cygnetmedDataSet.tb_lab)
                Tb_labTableAdapter.Fill(Db_cygnetmedDataSet.tb_lab)
                Tb_labBindingSource.MoveLast()
            Else
                txt_hide_namel.Text = xray.lbl_name.Text
                txt_hide_deptl.Text = login.txt_hide_dept.Text
                txt_hide_activityl.Text = "EDITED LAB RECORD"
                txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                txt_hide_corrl.Text = mlbl_case.Text

                Tb_labBindingSource.EndEdit()
                Tb_labTableAdapter.Update(Db_cygnetmedDataSet.tb_lab)
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

    Private Sub mcb_all_search_CheckedChanged(sender As Object, e As EventArgs) Handles mcb_all_search.CheckedChanged
        If mcb_all_search.Checked = True Then
            Tb_infoBindingSource.Filter = "info_lab IS NOT NULL"
        Else
            mdt_search_ValueChanged(sender, e)
        End If

        Tb_infoBindingSource.MoveLast()
    End Sub

    Private Sub mdt_search_ValueChanged(sender As Object, e As EventArgs) Handles mdt_search.ValueChanged
        Tb_infoBindingSource.Filter = "info_lab IS NOT NULL AND " &
            "info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") & "%'"

        Tb_infoBindingSource.MoveLast()
    End Sub

    Private Sub grid_patients_SelectionChanged(sender As Object, e As EventArgs) Handles grid_patients.SelectionChanged
        If grid_patients.Rows.Count > 0 Then
            Tb_labBindingSource.Filter = "transno = '" & mlbl_case.Text & "'"
            Tb_packageBindingSource.Filter = "package_code = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(5).Value.ToString & "'"

            'If grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value.ToString <> Nothing Then
            '    pb_patient.Image = Image.FromFile(grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value.ToString)
            'Else
            '    pb_patient.Image = Nothing
            'End If

            If mlbl_status.Text = Nothing Then
                mlbl_status.Text = "PENDING"
            End If
        Else
            Tb_labBindingSource.Filter = "transno = ' '"
            pb_patient.Image = Nothing
            mlbl_status.Text = Nothing
        End If

        UI(sender, e)
    End Sub

    Private Sub UI(sender As Object, e As EventArgs)
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
                'UI Behaviour/Packages
                mpnl_hema.Enabled = False
                mpnl_feca.Enabled = False
                mpnl_uri.Enabled = False
                mpnl_blood.Enabled = False
                mpnl_others.Enabled = False
                mcbo_medtech.SelectedIndex = -1
                mcbo_medtech.Enabled = False
                mcbo_pathologist.SelectedIndex = -1
                mcbo_pathologist.Enabled = False
            ElseIf mlbl_status.Text = "REGISTERED" Then
                'Buttons
                mbtn_add.Enabled = False
                mbtn_save.Enabled = True
                'UI Behaviour/Packages
                If txt_hide_hema.Text <> Nothing Then
                    mpnl_hema.Enabled = True
                Else
                    mpnl_hema.Enabled = False
                End If

                If txt_hide_feca.Text <> Nothing Then
                    mpnl_feca.Enabled = True
                Else
                    mpnl_feca.Enabled = False
                End If

                If txt_hide_uri.Text <> Nothing Then
                    mpnl_uri.Enabled = True
                Else
                    mpnl_uri.Enabled = False
                End If

                If txt_hide_blood.Text <> Nothing Then
                    mpnl_blood.Enabled = True
                Else
                    mpnl_blood.Enabled = False
                End If

                If txt_hide_others.Text <> Nothing Then
                    mpnl_others.Enabled = True
                Else
                    mpnl_others.Enabled = False
                End If

                mcbo_medtech.Enabled = True
                mcbo_pathologist.Enabled = True
            ElseIf mlbl_status.Text = "RELEASED" Then
                'Buttons
                mbtn_add.Enabled = False
                mbtn_save.Enabled = False
                'UI Behaviour/Packages
                mpnl_hema.Enabled = False
                mpnl_feca.Enabled = False
                mpnl_uri.Enabled = False
                mpnl_blood.Enabled = False
                mpnl_others.Enabled = False
                mcbo_medtech.Enabled = False
                mcbo_pathologist.Enabled = False
            End If
        Else
            'Buttons
            mbtn_add.Enabled = False
            mbtn_save.Enabled = False
            'UI Behaviour/Packages
            mpnl_hema.Enabled = False
            mpnl_feca.Enabled = False
            mpnl_uri.Enabled = False
            mpnl_blood.Enabled = False
            mpnl_others.Enabled = False
            mcbo_medtech.SelectedIndex = -1
            mcbo_medtech.Enabled = False
            mcbo_pathologist.SelectedIndex = -1
            mcbo_pathologist.Enabled = False
        End If
    End Sub

    Private Sub autocompletesourcelist()
        Dim hema_hepab, hema_bloodtype,
            feca_color, feca_consistency, feca_noneseen, feca_nonerare,
            uri_color, uri_trans, uri_gravity, uri_ph, uri_albumin, uri_pt As New AutoCompleteStringCollection()

        hema_hepab.AddRange(New String() _
                 {
                     "REACTIVE",
                     "NON-REACTIVE"
                 })
        mtxt_hema_hepab.AutoCompleteCustomSource = hema_hepab

        hema_bloodtype.AddRange(New String() _
                 {
                     "A+",
                     "B+",
                     "AB+",
                     "O+"
                 })
        mtxt_hema_blood.AutoCompleteCustomSource = hema_bloodtype

        feca_color.AddRange(New String() _
                        {
                            "BROWN",
                            "LIGHT BROWN",
                            "DARK BROWN",
                            "GREENISH BROWN",
                            "YELLOWISH BROWN",
                            "BLACK"
                        })
        mtxt_feca_color.AutoCompleteCustomSource = feca_color

        feca_consistency.AddRange(New String() _
                        {
                            "FORMED",
                            "SEMI FORMED",
                            "SOFT",
                            "MUCOID",
                            "WATERY"
                        })
        mtxt_feca_consist.AutoCompleteCustomSource = feca_consistency

        feca_noneseen.AddRange(New String() _
                        {
                            "NONE",
                            "SEEN"
                        })
        mtxt_feca_occult.AutoCompleteCustomSource = feca_noneseen
        mtxt_feca_ascaris.AutoCompleteCustomSource = feca_noneseen
        mtxt_feca_trichuris.AutoCompleteCustomSource = feca_noneseen
        mtxt_feca_hook.AutoCompleteCustomSource = feca_noneseen
        mtxt_feca_enta.AutoCompleteCustomSource = feca_noneseen
        mtxt_feca_tropho.AutoCompleteCustomSource = feca_noneseen

        feca_nonerare.AddRange(New String() _
                     {
                         "NONE",
                         "RARE",
                         "OCASSIONAL",
                         "FEW",
                         "MODERATE",
                         "MANY",
                         "LOADED"
                     })
        mtxt_feca_fats.AutoCompleteCustomSource = feca_nonerare
        mtxt_feca_bacteria.AutoCompleteCustomSource = feca_nonerare
        mtxt_uri_epi.AutoCompleteCustomSource = feca_nonerare
        mtxt_uri_mucus.AutoCompleteCustomSource = feca_nonerare
        mtxt_uri_urates.AutoCompleteCustomSource = feca_nonerare
        mtxt_uri_phosphates.AutoCompleteCustomSource = feca_nonerare
        mtxt_uri_bacteria.AutoCompleteCustomSource = feca_nonerare


        uri_color.AddRange(New String() _
                        {
                            "STRAW",
                            "LIGHT YELLOW",
                            "DARK YELLOW",
                            "YELLOW",
                            "AMBER"
                        })
        mtxt_uri_color.AutoCompleteCustomSource = uri_color

        uri_trans.AddRange(New String() _
                       {
                           "CLEAR",
                           "SL. HAZY",
                           "HAZY",
                           "CLOUDY",
                           "TURBID"
                       })
        mtxt_uri_transparency.AutoCompleteCustomSource = uri_trans

        uri_gravity.AddRange(New String() _
                     {
                         "1.005",
                         "1.010",
                         "1.015",
                         "1.020",
                         "1.025",
                         "1.030"
                     })
        mtxt_uri_gravity.AutoCompleteCustomSource = uri_gravity

        uri_ph.AddRange(New String() _
                    {
                        "5.0",
                        "6.0",
                        "6.5",
                        "7.0",
                        "7.5",
                        "8.0",
                        "9.0"
                    })
        mtxt_uri_ph.AutoCompleteCustomSource = uri_ph

        uri_albumin.AddRange(New String() _
                   {
                       "NEGATIVE",
                       "TRACE",
                       "+1",
                       "+2",
                       "+3",
                       "+4"
                   })
        mtxt_uri_albu.AutoCompleteCustomSource = uri_albumin
        mtxt_uri_sugar.AutoCompleteCustomSource = uri_albumin

        uri_pt.AddRange(New String() _
                 {
                     "NEGATIVE",
                     "POSITIVE"
                 })
        mtxt_uri_pt.AutoCompleteCustomSource = uri_pt
    End Sub

    Private Sub doctors()
        Dim connection As New MySqlConnection
        Dim command, command2 As New MySqlCommand
        Dim adaptor, adaptor2 As New MySqlDataAdapter
        Dim datatable, datatable2 As New DataTable

        connection.ConnectionString = My.Settings.db_cygnetmedConnectionString
        command.CommandText = "SELECT DISTINCT doctors_name FROM tb_doctors WHERE doctors_field LIKE '%PATHOLOGIST%' ORDER BY doctors_name;"
        connection.Open()
        command.Connection = connection

        adaptor.SelectCommand = command
        adaptor.Fill(datatable)
        With mcbo_pathologist
            .DisplayMember = Nothing
            .ValueMember = Nothing
            .DataSource = Nothing

            .DisplayMember = "doctors_name"
            .ValueMember = "doctors_name"
            .DataSource = datatable.DefaultView.ToTable(True, "doctors_name")
        End With

        command2.CommandText = "SELECT DISTINCT doctors_name FROM tb_doctors WHERE doctors_field LIKE '%MEDICAL TECHNOLOGIST%' ORDER BY doctors_name;"
        command2.Connection = connection

        adaptor2.SelectCommand = command2
        adaptor2.Fill(datatable2)
        With mcbo_medtech
            .DisplayMember = Nothing
            .ValueMember = Nothing
            .DataSource = Nothing

            .DisplayMember = "doctors_name"
            .ValueMember = "doctors_name"
            .DataSource = datatable2.DefaultView.ToTable(True, "doctors_name")
        End With

        connection.Close()
    End Sub

    Private Sub mtxt_search_TextChanged(sender As Object, e As EventArgs) Handles mtxt_search.TextChanged
        If mcb_all_search.Checked = True Then
            Tb_infoBindingSource.Filter = "info_fullname LIKE '%" & mtxt_search.Text & "%' AND info_lab IS NOT NULL OR " &
                "transno LIKE '%" & mtxt_search.Text & "%' AND info_lab IS NOT NULL"
        Else
            Tb_infoBindingSource.Filter = "info_fullname LIKE '%" & mtxt_search.Text & "%' AND info_lab IS NOT NULL AND info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") & "%' OR " &
                "transno LIKE '%" & mtxt_search.Text & "%' AND info_lab IS NOT NULL AND info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") & "%'"
        End If
    End Sub

    Private Sub mtxt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_search.KeyPress
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

    Private Sub mtxt_limit(sender As Object, e As KeyPressEventArgs) Handles mtxt_hema_segmenters.KeyPress, mtxt_hema_mono.KeyPress,
        mtxt_hema_lympho.KeyPress, mtxt_hema_eosino.KeyPress, mtxt_hema_baso.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub mbtn_print_Click(sender As Object, e As EventArgs) Handles mbtn_print.Click
        lab_report.ShowDialog()
    End Sub

    Private Sub trimmed()
        Dim ctrl As Control

        If txt_hide_hema.Text <> Nothing Then
            For Each ctrl In mpnl_hema.Controls
                If TypeOf ctrl Is MetroFramework.Controls.MetroTextBox Then
                    ctrl.Text = ctrl.Text.Replace("  ", " ").Trim()
                End If
            Next
        End If

        If txt_hide_feca.Text <> Nothing Then
            For Each ctrl In mpnl_feca.Controls
                If TypeOf ctrl Is MetroFramework.Controls.MetroTextBox Then
                    ctrl.Text = ctrl.Text.Replace("  ", " ").Trim()
                End If
            Next
        End If

        If txt_hide_uri.Text <> Nothing Then
            For Each ctrl In mpnl_uri.Controls
                If TypeOf ctrl Is MetroFramework.Controls.MetroTextBox Then
                    ctrl.Text = ctrl.Text.Replace("  ", " ").Trim()
                End If
            Next
        End If

        If txt_hide_blood.Text <> Nothing Then
            For Each ctrl In mpnl_blood.Controls
                If TypeOf ctrl Is MetroFramework.Controls.MetroTextBox Then
                    ctrl.Text = ctrl.Text.Replace("  ", " ").Trim()
                End If
            Next
        End If

        If txt_hide_others.Text <> Nothing Then
            For Each ctrl In mpnl_others.Controls
                If TypeOf ctrl Is MetroFramework.Controls.MetroTextBox Then
                    ctrl.Text = ctrl.Text.Replace("  ", " ").Trim()
                End If
            Next
        End If
    End Sub
End Class
