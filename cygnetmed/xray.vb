Public Class xray
    Private Sub xray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = login.txt_hide_name.Text

        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
        StyleManager = msm_style
        mtab_xray.SelectedTab = mtab_register
    End Sub

    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        lbl_clock.Text = Format(Now, "MM/dd/yyyy      hh:mm:ss tt")
    End Sub

    Private Sub mbtn_logout_Click(sender As Object, e As EventArgs) Handles mbtn_logout.Click
        Dim dialog As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Cygnetmed Health System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If dialog = Windows.Forms.DialogResult.Yes Then
            RemoveHandler Me.FormClosing, AddressOf info_FormClosing
            RemoveHandler Me.FormClosed, AddressOf info_FormClosed

            logout()

            Close()

            MessageBox.Show("Logged out successfully!", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            login.Show()
        End If
    End Sub

    Private Sub logout()
        login.Tb_loginTableAdapter.Fill(login.Db_cygnetmedDataSet.tb_login)

        login.Tb_loginBindingSource.Filter = "login_name = '" & lbl_name.Text & "'"

        Me.Tb_logsBindingSource.AddNew()

        login.txt_hide_logout.Text = Format(Now, "MM/dd/yyyy hh:mm:ss tt")
        login.txt_hide_status.Text = "LOGGED OUT"

        txt_hide_namel.Text = login.txt_hide_name.Text
        txt_hide_deptl.Text = login.txt_hide_dept.Text
        txt_hide_activityl.Text = "LOGGED OUT"
        txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Me.Tb_logsBindingSource.EndEdit()
        Me.Tb_logsTableAdapter.Update(Me.Db_cygnetmedDataSet.tb_logs)
        login.Tb_loginBindingSource.EndEdit()
        login.Tb_loginTableAdapter.Update(login.Db_cygnetmedDataSet.tb_login)
    End Sub

    Private Sub info_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        logout()

        Application.Exit()
    End Sub

    Private Sub info_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Cygnetmed Health System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If dialog = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mtile_refresh_Click(sender As Object, e As EventArgs) Handles mtile_refresh.Click
        Xray_tab_records1.xray_tab_records_Load(sender, e)
        Xray_tab_register1.xray_tab_register_Load(sender, e)
    End Sub
End Class