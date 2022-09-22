Imports MySql.Data.MySqlClient

Public Class login
    Dim os As String
    Dim connectionString As String
    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Db_cygnetmedDataSet.tb_login.CaseSensitive = True

        Dim connection As New MySqlConnection
        connection.ConnectionString = My.Settings.db_cygnetmedConnectionString

        Tb_logsTableAdapter.Fill(Db_cygnetmedDataSet.tb_logs)
        Tb_loginTableAdapter.Fill(Db_cygnetmedDataSet.tb_login)

        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
        StyleManager = msm_style

        mtxt_user.Focus()
    End Sub

    Private Sub mbtn_login_Click(sender As Object, e As EventArgs) Handles mbtn_login.Click
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim dataset As New DataSet

        connection.ConnectionString = My.Settings.db_cygnetmedConnectionString
        command.CommandText = "SELECT * FROM tb_login WHERE login_user= '" & mtxt_user.Text & "' AND login_pass= '" & mtxt_pass.Text & "'"
        connection.Open()
        command.Connection = connection
        adaptor.SelectCommand = command

        adaptor.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count

        If count > 0 Then
            Tb_loginBindingSource.Filter = "login_user = '" & mtxt_user.Text & "'AND login_pass = '" & mtxt_pass.Text & "'"

            If txt_hide_dept.Text = "INFORMATION" Then
                login()

                info.Show()
            ElseIf txt_hide_dept.Text = "ADMIN" Then
                login()

                'admin_main.Show()
            ElseIf txt_hide_dept.Text = "RADIOLOGY" Then
                login()

                xray.Show()
            ElseIf txt_hide_dept.Text = "LABORATORY" Then
                login()

                lab.Show()
            ElseIf txt_hide_dept.Text = "RELEASING" Then
                login()

                'result_main.Show()

                'result_main.Result_dashboard1.tab_xray.Show()
                'result_main.Result_dashboard1.tab_hema.Show()
                'result_main.Result_dashboard1.tab_feca.Show()
                'result_main.Result_dashboard1.tab_uris.Show()
                'result_main.Result_dashboard1.tab_bc.Show()
                'result_main.Result_dashboard1.tab_others.Show()
            ElseIf txt_hide_dept.Text = "REMOTE" Then
                login()

                'result_main.Show()
            End If
        Else
            MessageBox.Show("Wrong username or password", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtxt_user.Focus()
            mtxt_user.Clear()
            mtxt_pass.Clear()
        End If
    End Sub

    Private Sub login()
        Tb_logsBindingSource.AddNew()

        txt_hide_login.Text = Format(Now, "MM/dd/yyyy hh:mm:ss tt")
        txt_hide_logout.Text = Nothing
        txt_hide_status.Text = "LOGGED IN"

        Dim c As Date = DateTime.Now
        Dim a As String = c.ToString("MM/dd/yyyy")
        Dim b As String = c.ToString("hh:mm:ss tt")
        Dim d As String = c.ToString("yyyy/MM/dd HH:mm:ss")

        txt_hide_namel.Text = txt_hide_name.Text
        txt_hide_deptl.Text = txt_hide_dept.Text
        txt_hide_activityl.Text = "LOGGED IN"
        txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Tb_logsBindingSource.EndEdit()
        Tb_logsTableAdapter.Update(Db_cygnetmedDataSet.tb_logs)
        Tb_loginBindingSource.EndEdit()
        Tb_loginTableAdapter.Update(Db_cygnetmedDataSet.tb_login)

        MessageBox.Show("Welcome " & txt_hide_name.Text & "!", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        mtxt_user.Focus()
        mtxt_user.Clear()
        mtxt_pass.Clear()
        Hide()
    End Sub

    Private Sub mtxt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_user.KeyPress, mtxt_pass.KeyPress
        Select Case e.KeyChar

            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                mbtn_login.PerformClick()

            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) AllowedKeys.Contains(c))

            Case Else ' Other key is pressed
                e.Handled = Not AllowedKeys.Contains(e.KeyChar)

        End Select
    End Sub

    Private Sub mtile_settings_Click(sender As Object, e As EventArgs) Handles mtile_settings.Click
        settings_select.Show()
        Hide()
    End Sub
End Class