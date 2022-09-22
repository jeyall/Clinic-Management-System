Imports MySql.Data.MySqlClient
Imports Emgu
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports System.IO

'patientno = 3
'fullname = 4
'code = 5
'procedure = 6
'company = 7
'noe = 8
'xray = 9
'lab = 10
'date = 11
'timestamp = 12
'picture = 13

Public Class info_tab_register

    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 "

    Dim captures As New VideoCapture
    Dim images As Image(Of Bgr, Byte)
    Public PicCopy, TmpPicCopy As Image

    Public Sub tab_register_Load(sender As Object, e As EventArgs) Handles Me.Load
        Tb_infoTableAdapter.Fill(Db_cygnetmedDataSet.tb_info)
        Tb_packageTableAdapter.Fill(Db_cygnetmedDataSet.tb_package)
        Tb_hmoTableAdapter.Fill(Db_cygnetmedDataSet.tb_hmo)

        companyquery()

        'UI Behavior
        mdt_search_ValueChanged(sender, e)
        UI(sender, e)
        Tb_infoBindingSource.Sort = "info_timestamp ASC"
        Tb_infoBindingSourcePatient.Sort = "patientno DESC, info_timestamp DESC"
    End Sub

    'Add patient button
    Private Sub mbtn_add_Click(sender As Object, e As EventArgs) Handles mbtn_add.Click
        Tb_infoBindingSource.AddNew()

        'UI Behaviour
        'Datagrid Section
        mtxt_search.Enabled = False
        grid_patients.Enabled = False
        mdt_search.Enabled = False
        'All Combobox and TextBox
        mtxt_last.Enabled = True
        mtxt_first.Enabled = True
        mtxt_middle.Enabled = True
        mtxt_contact.Enabled = True
        mdt_birth.Enabled = True
        mdt_birth.Value = DateTime.Now
        mcb_gender.Enabled = True
        mcb_gender.Text = Nothing
        mcb_civil.Enabled = True
        mcb_civil.Text = Nothing
        mcb_company.Enabled = False
        mcb_company.Text = Nothing
        mdt_lmp.Enabled = False
        mdt_lmp.Value = DateTime.Now
        mdt_lmp.Tag = 0
        mcb_mens.Enabled = False
        mcb_mens.SelectedIndex = -1
        mtxt_discount.Enabled = True
        mtxt_discount.Text = 0
        'For HMO
        mcb_mop.Enabled = True
        mcb_mop.Text = Nothing
        'All Buttons
        mbtn_add.Enabled = False
        mbtn_save.Enabled = True
        mbtn_archive.Enabled = False
        mbtn_package.Enabled = True
        mtile_capture.Enabled = True
        mtile_play.Enabled = True
        mbtn_print.Enabled = False

        'Case # automation
        Tb_infoBindingSourcePosition.MoveLast()
        Dim a As String = DateTime.Now.ToString("yyMM")
        Dim b As Integer = Tb_infoBindingSourcePosition.Position + 1
        mlbl_case.Text = "C" & a & b

        Dim dialog As DialogResult = MessageBox.Show("Is the patient already registered?", "Cygnetmed Health System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)

        If dialog = Windows.Forms.DialogResult.Yes Then
            info_patients.ShowDialog()
        ElseIf dialog = Windows.Forms.DialogResult.Cancel Then
            info.mtile_refresh.PerformClick()
        Else
            mtxt_last.Focus()
        End If
    End Sub

    'Save patient info button
    Private Sub mbtn_save_Click(sender As Object, e As EventArgs) Handles mbtn_save.Click
        If String.IsNullOrWhiteSpace(mtxt_last.Text) Or String.IsNullOrWhiteSpace(mtxt_first.Text) Or
            String.IsNullOrWhiteSpace(mtxt_contact.Text) Or mcb_civil.Text = Nothing Or
            mcb_gender.Text = Nothing Or mcb_mop.Text = Nothing Then
            MessageBox.Show("Fill up the required fields in patient's information", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf pb_patient.Image Is Nothing Then
            MessageBox.Show("There is no picture of the patient", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf Val(mlbl_age.Text) < 0 Then
            MessageBox.Show("Input an invalid age", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            mdt_birth.Value = DateTime.Now
        ElseIf mcb_mens.SelectedIndex = -1 AndAlso mcb_gender.Text = "FEMALE" AndAlso mdt_lmp.Tag = 0 Then
            MessageBox.Show("Indicate the LMP of the patient", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            mdt_lmp.Focus()
        ElseIf String.IsNullOrWhiteSpace(mlbl_code.Text) Then
            MessageBox.Show("There is no package selected or list of packages is empty", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf mcb_mop.Text = "HMO" AndAlso String.IsNullOrWhiteSpace(mtxt_member.Text) AndAlso mlbl_noe.Text <> "APE" AndAlso Not mtxt_hmo.Text = "FRUTON" Then
            MessageBox.Show("Fill up the required fields in HMO", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            mtxt_member.Focus()
        Else
            Tb_logsBindingSource.AddNew()

            save_patientno() 'for generating patient #
            names() 'for getting full name

            videocaptureprocess.Stop()
            captures.Dispose()

            With grid_patients.Rows(grid_patients.CurrentCell.RowIndex)
                .Cells(5).Value = mlbl_code.Text 'package code
                .Cells(6).Value = mlbl_procedure.Text 'procedure
                .Cells(7).Value = mcb_company.Text 'company
                .Cells(8).Value = mlbl_noe.Text 'noe
            End With

            If grid_patients.Enabled = False Then
                PicCopy = pb_patient.Image
                PicCopy.Save("C:\Users\John Rey\Pictures\Patients\" & mlbl_patient.Text & ".jpg")

                grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(13).Value = "C:\Users\John Rey\Pictures\Patients\" & mlbl_patient.Text & ".jpg"

                If mcb_mop.Text = "HMO" Then
                    Tb_hmoBindingSource.AddNew()

                    hmo()
                End If

                With grid_patients.Rows(grid_patients.CurrentCell.RowIndex)
                    .Cells(11).Value = DateTime.Now.ToString("MM/dd/yyyy") 'date
                    .Cells(12).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") 'timestamp
                End With

                mlbl_status.Text = "REGISTERED"

                txt_hide_namel.Text = info.lbl_name.Text
                txt_hide_deptl.Text = login.txt_hide_dept.Text
                txt_hide_activityl.Text = "ADDED NEW TRANSACTION"
                txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                txt_hide_corrl.Text = mlbl_case.Text

                Tb_infoBindingSource.EndEdit()
                Tb_infoTableAdapter.Update(Db_cygnetmedDataSet.tb_info)
                Tb_infoTableAdapter.Fill(Db_cygnetmedDataSet.tb_info)
                Tb_infoBindingSource.MoveLast()
            Else
                '''''''Replace picture with new one/editing picture
                'pb_patient.Image = Nothing
                'pb_patient.Refresh()
                'GC.Collect()
                'File.Delete("" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(13).Value & "")
                'PicCopy = pb_patient.Image
                'PicCopy.Save("C:\Users\John Rey\Pictures\Patients" & mlbl_patient.Text & ".jpg")

                hmo()

                txt_hide_namel.Text = info.lbl_name.Text
                txt_hide_deptl.Text = login.txt_hide_dept.Text
                txt_hide_activityl.Text = "EDITED TRANSACTION"
                txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                txt_hide_corrl.Text = mlbl_case.Text

                Tb_infoBindingSource.EndEdit()
                Tb_infoTableAdapter.Update(Db_cygnetmedDataSet.tb_info)
            End If

            Tb_logsBindingSource.EndEdit()
            Tb_logsTableAdapter.Update(Db_cygnetmedDataSet.tb_logs)

            'UI Behaviour
            'Datagrid Section
            mtxt_search.Enabled = True
            grid_patients.Enabled = True
            mdt_search.Enabled = True
            'Buttons
            mbtn_add.Enabled = True
            mbtn_archive.Enabled = True
            'Print
            mbtn_print.Enabled = True

            MessageBox.Show("Save successful!", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Package list button
    Private Sub mbtn_package_Click(sender As Object, e As EventArgs) Handles mbtn_package.Click
        info_package.ShowDialog()
        info_package.mtxt_search.Focus()
    End Sub

    'archive button
    Private Sub mbtn_archive_Click(sender As Object, e As EventArgs) Handles mbtn_archive.Click
        info_archived.ShowDialog()
    End Sub

    'open webcam button
    Private Sub mtile_play_Click(sender As Object, e As EventArgs) Handles mtile_play.Click
        videocaptureprocess.Start()
    End Sub

    'capture webcam button
    Private Sub mtile_capture_Click(sender As Object, e As EventArgs) Handles mtile_capture.Click
        videocaptureprocess.Stop()
        captures.Dispose()
    End Sub

    'print preview button
    Private Sub mbtn_print_Click(sender As Object, e As EventArgs) Handles mbtn_print.Click
        info_reports.ShowDialog()
    End Sub

    'mode of payment
    Private Sub mcb_mop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcb_mop.SelectedIndexChanged
        If mcb_mop.Text = "HMO" Then
            mtxt_member.Enabled = True
            mtxt_approval.Enabled = True
            mtxt_hmo.Enabled = True
            mcbo_physician.Enabled = True
            doctors()
        Else
            mtxt_member.Enabled = False
            mtxt_approval.Enabled = False
            mtxt_hmo.Enabled = False
            mcbo_physician.Enabled = False
            mcbo_physician.Text = Nothing
        End If
    End Sub

    'combobox gender
    Private Sub mcb_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcb_gender.SelectedIndexChanged
        If mcb_gender.Text = "FEMALE" Then
            mdt_lmp.Enabled = True
            mcb_mens.Enabled = True
            If mbtn_add.Enabled = False Then
                mdt_lmp.Tag = 0
            End If
        Else
            mdt_lmp.Enabled = False
            mcb_mens.Enabled = False
            mcb_mens.Text = Nothing
            If mbtn_add.Enabled = False Then
                mdt_lmp.Tag = 1
            End If
        End If
    End Sub

    'search of packages
    Private Sub mlbl_code_TextChanged(sender As Object, e As EventArgs) Handles mlbl_code.TextChanged
        If mlbl_noe.Text = "WALK-IN" Then
            mcb_company.Enabled = True
        Else
            mcb_company.Enabled = False
            If mlbl_noe.Text = "CONSULTATION" Or mlbl_noe.Text = Nothing Then
                mcb_company.Text = Nothing
            Else
                If grid_patients.Rows.Count > 0 Then
                    mcb_company.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(7).Value.ToString
                End If
            End If
        End If
    End Sub

    'datetimepicker of mens
    Private Sub mdt_lmp_ValueChanged(sender As Object, e As EventArgs) Handles mdt_lmp.ValueChanged
        If mbtn_add.Enabled = False Then
            mdt_lmp.Tag = 1
        End If
    End Sub

    'datetimepicker birthday
    Public Sub mdt_birth_ValueChanged(sender As Object, e As EventArgs) Handles mdt_birth.ValueChanged
        If mbtn_add.Enabled = False Then
            With mdt_birth.Value
                Dim celebrate As DateTime = New DateTime(Now.Year, .Month, .Day)
                Dim age As Integer = Now.Year - .Year
                If celebrate > Now Then age -= 1
                mlbl_age.Text = CStr(age)
            End With
        End If
    End Sub

    'discount textbox
    Public Sub mtxt_discount_TextChanged(sender As Object, e As EventArgs) Handles mtxt_discount.TextChanged
        mlbl_amount.Text = Val(mlbl_price.Text) - Val(mtxt_discount.Text)
    End Sub

    'grid changes
    Private Sub grid_patients_SelectionChanged(sender As Object, e As EventArgs) Handles grid_patients.SelectionChanged
        If grid_patients.Rows.Count > 0 Then
            Tb_packageBindingSource.Filter = "package_code = '" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(5).Value & "'"
            Tb_hmoBindingSource.Filter = "caseno = '" & mlbl_case.Text & "'"

            If grid_patients.Enabled = True Then
                mtxt_discount.Text = Val(mlbl_price.Text) - Val(mlbl_amount.Text)
            End If

            Try
                TmpPicCopy = Image.FromFile("" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(13).Value.ToString & "")
                PicCopy = New Bitmap(TmpPicCopy)
                TmpPicCopy.Dispose()
                pb_patient.Image = PicCopy
            Catch ex As Exception
                pb_patient.Image = Nothing
            End Try

            If mcb_mop.Text = "HMO" Then
                Try
                    mtxt_member.Text = grid_hide_hmo.Rows(grid_hide_hmo.CurrentCell.RowIndex).Cells(2).Value.ToString
                    mtxt_approval.Text = grid_hide_hmo.Rows(grid_hide_hmo.CurrentCell.RowIndex).Cells(3).Value.ToString
                    mtxt_hmo.Text = grid_hide_hmo.Rows(grid_hide_hmo.CurrentCell.RowIndex).Cells(4).Value.ToString
                    mcbo_physician.Text = grid_hide_hmo.Rows(grid_hide_hmo.CurrentCell.RowIndex).Cells(5).Value.ToString
                Catch ex As Exception
                    mtxt_member.Text = Nothing
                    mtxt_approval.Text = Nothing
                    mtxt_hmo.Text = Nothing
                    mcbo_physician.SelectedIndex = -1
                End Try
            Else
                mtxt_member.Text = Nothing
                mtxt_approval.Text = Nothing
                mtxt_hmo.Text = Nothing
                mcbo_physician.SelectedIndex = -1
            End If
        Else
            Tb_packageBindingSource.Filter = "package_code = ' '"
            Tb_hmoBindingSource.Filter = "caseno = ' '"
            mtxt_discount.Text = 0
            pb_patient.Image = Nothing
            mtxt_member.Text = Nothing
            mtxt_approval.Text = Nothing
            mtxt_hmo.Text = Nothing
            mcbo_physician.SelectedIndex = -1
        End If
    End Sub

    'datetimepicker search
    Private Sub mdt_search_ValueChanged(sender As Object, e As EventArgs) Handles mdt_search.ValueChanged
        Tb_infoBindingSource.Filter = "info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' AND info_status <> 'ARCHIVED'"

        mtxt_search.Text = Nothing
        Tb_infoBindingSource.MoveLast()

        UI(sender, e)
    End Sub

    'textbox search case#, full name
    Private Sub mtxt_search_TextChanged(sender As Object, e As EventArgs) Handles mtxt_search.TextChanged
        Tb_infoBindingSource.Filter = "info_fullname LIKE '%" & mtxt_search.Text & "%' AND info_status <> 'ARCHIVED' AND info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") &
            "%' OR transno LIKE '%" & mtxt_search.Text & "%' AND info_status <> 'ARCHIVED' AND info_timestamp LIKE '" & mdt_search.Value.ToString("yyyy/MM/dd") & "%'"
    End Sub

    'algo for patientno
    Private Sub save_patientno()
        If String.IsNullOrWhiteSpace(mtxt_middle.Text) Then
            Tb_infoBindingSourcePatient.Filter = "info_lastname = '" & mtxt_last.Text &
                "'AND info_firstname = '" & mtxt_first.Text &
                "'AND info_birthdate = '" & mdt_birth.Value.ToString("MM/dd/yyyy") & "'"
        Else
            Tb_infoBindingSourcePatient.Filter = "info_lastname = '" & mtxt_last.Text &
                "'AND info_firstname = '" & mtxt_first.Text &
                "'AND info_middlename = '" & mtxt_middle.Text &
                "'AND info_birthdate = '" & mdt_birth.Value.ToString("MM/dd/yyyy") & "'"
        End If

        Try
            mlbl_patient.Text = grid_hide_patientno.Rows(0).Cells(0).Value
        Catch ex As Exception
            Dim patient_no As String

            Tb_infoBindingSourcePatient.RemoveFilter()
            Tb_infoBindingSourcePatient.MoveFirst()
            patient_no = Convert.ToInt32(grid_hide_patientno.Rows(0).Cells(0).Value.ToString.Remove(0, 5))
            patient_no += 1

            mlbl_patient.Text = "P" + DateTime.Now.ToString("yyMM") + patient_no.ToString
        End Try
    End Sub

    'saving fullname
    Private Sub names()
        mtxt_first.Text = mtxt_first.Text.ToString.Replace("  ", " ").Trim
        mtxt_last.Text = mtxt_last.Text.ToString.Replace("  ", " ").Trim
        mtxt_middle.Text = mtxt_middle.Text.ToString.Replace("  ", " ").Trim

        If String.IsNullOrWhiteSpace(mtxt_middle.Text) Then
            mtxt_middle.Text = Nothing
            grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value = mtxt_last.Text + ", " + mtxt_first.Text
        Else
            Dim f As String
            Dim g As String = Nothing
            Dim h As Integer

            Try
                f = mtxt_middle.Text.Substring(0, 1) & mtxt_middle.Text.Split(" ")(1).Substring(0, 1)

                For h = 0 To f.Length - 1
                    g &= f(h) & "."
                Next

                grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value = mtxt_last.Text + ", " + mtxt_first.Text + " " + g
            Catch ex As Exception
                f = mtxt_middle.Text(0)

                For h = 0 To f.Length - 1
                    g &= f(h) & "."
                Next

                grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value = mtxt_last.Text + ", " + mtxt_first.Text + " " + g
            End Try
        End If
    End Sub

    'algo for hmo
    Private Sub hmo()
        If mcb_mop.Text = "HMO" Then
            With grid_hide_hmo.Rows(grid_hide_hmo.CurrentCell.RowIndex)
                .Cells(0).Value = mlbl_case.Text
                .Cells(1).Value = mlbl_patient.Text
                .Cells(2).Value = mtxt_member.Text
                .Cells(3).Value = mtxt_approval.Text
                .Cells(4).Value = mtxt_hmo.Text
                .Cells(5).Value = mcbo_physician.Text
            End With

            If grid_patients.Enabled = False Then
                grid_hide_hmo.Rows(grid_hide_hmo.CurrentCell.RowIndex).Cells(6).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            End If

            Tb_hmoBindingSource.EndEdit()
            Tb_hmoTableAdapter.Update(Db_cygnetmedDataSet.tb_hmo)
        End If
    End Sub

    'query for populating company combobox
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

        With mcb_company
            .DisplayMember = Nothing
            .ValueMember = Nothing
            .DataSource = Nothing

            .DisplayMember = "package_company"
            .ValueMember = "package_company"
            .DataSource = datatable.DefaultView.ToTable(True, "package_company")
        End With
    End Sub

    'query for filtering/populating doctors combobox
    Private Sub doctors()
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim datatable As New DataTable

        connection.ConnectionString = My.Settings.db_cygnetmedConnectionString
        command.CommandText = "SELECT doctors_name FROM tb_doctors WHERE doctors_field LIKE '%PHYSICIAN%' ORDER BY doctors_name;"
        connection.Open()
        command.Connection = connection

        adaptor.SelectCommand = command
        adaptor.Fill(datatable)

        With mcbo_physician
            .DisplayMember = Nothing
            .ValueMember = Nothing
            .DataSource = Nothing

            .DisplayMember = "doctors_name"
            .ValueMember = "doctors_name"
            .DataSource = datatable.DefaultView.ToTable(True, "doctors_name")
        End With
    End Sub

    'UI Behaviour
    Private Sub UI(sender As Object, e As EventArgs)
        mdt_search.Enabled = True

        If grid_patients.Rows.Count <= 0 Then
            'Datagrid Section
            mtxt_search.Enabled = False
            grid_patients.Enabled = False
            'All Combobox and TextBox
            mtxt_last.Enabled = False
            mtxt_first.Enabled = False
            mtxt_middle.Enabled = False
            mtxt_contact.Enabled = False
            mdt_birth.Enabled = False
            mcb_gender.Enabled = False
            mcb_gender.Text = Nothing
            mcb_civil.Enabled = False
            mcb_civil.Text = Nothing
            mcb_company.Enabled = False
            mcb_company.Text = Nothing
            mdt_lmp.Enabled = False
            mcb_mens.Enabled = False
            mcb_mens.Text = Nothing
            mtxt_discount.Enabled = False
            mtxt_discount.Text = Nothing
            'For HMO
            mcb_mop.Enabled = False
            mcb_mop.Text = Nothing
            mcb_mop_SelectedIndexChanged(sender, e)
            'All Buttons
            mbtn_add.Enabled = True
            mbtn_save.Enabled = False
            mbtn_archive.Enabled = False
            mbtn_package.Enabled = False
            mtile_capture.Enabled = False
            mtile_play.Enabled = False
            'Print
            mbtn_print.Enabled = False

            Tb_packageBindingSource.Filter = "package_code = ' '"
            Tb_hmoBindingSource.Filter = "caseno = ' '"
        Else
            'Datagrid Section
            mtxt_search.Enabled = True
            grid_patients.Enabled = True
            'All Combobox and TextBox
            mtxt_last.Enabled = True
            mtxt_first.Enabled = True
            mtxt_middle.Enabled = True
            mtxt_contact.Enabled = True
            mdt_birth.Enabled = True
            mcb_gender.Enabled = True
            'mcb_gender_SelectedIndexChanged(sender, e)
            mcb_civil.Enabled = True
            mlbl_code_TextChanged(sender, e)
            mtxt_discount.Enabled = True
            'For HMO
            mcb_mop.Enabled = True
            'mcb_mop_SelectedIndexChanged(sender, e)
            'All Buttons
            mbtn_add.Enabled = True
            mbtn_save.Enabled = True
            mbtn_archive.Enabled = True
            mbtn_package.Enabled = True
            mtile_capture.Enabled = True
            mtile_play.Enabled = True
            'Print
            mbtn_print.Enabled = True
        End If
    End Sub

    'no symbols allowed
    Private Sub mtxt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_search.KeyPress,
        mtxt_last.KeyPress, mtxt_first.KeyPress, mtxt_middle.KeyPress,
        mtxt_hmo.KeyPress

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

    'only numbers texboxes
    Private Sub mtxt_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_member.KeyPress,
        mtxt_discount.KeyPress, mtxt_contact.KeyPress, mtxt_approval.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'algo process for webcam
    Private Sub videocaptureprocess_Tick(sender As Object, e As EventArgs) Handles videocaptureprocess.Tick
        Try
            images = captures.QuerySmallFrame.ToImage(Of Bgr, Byte)

            pb_patient.Image = images.ToBitmap
        Catch ex As Exception
            captures = New VideoCapture
        End Try
    End Sub
End Class
