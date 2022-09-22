Public Class settings_select
    Dim themes, styles As Integer

    Private Sub settings_select_Load(sender As Object, e As EventArgs) Handles Me.Load
        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
        StyleManager = msm_style

        styles = Val(My.Settings.style) - 1
        themes = Val(My.Settings.theme) - 1
        mcb_style.SelectedIndex = styles
        mcb_theme.SelectedIndex = themes
    End Sub

    Private Sub mtile_back_Click(sender As Object, e As EventArgs) Handles mtile_back.Click
        RemoveHandler FormClosed, AddressOf settings_select_FormClosed
        Close()
        login.Show()
        login.mtxt_user.Focus()
    End Sub

    Private Sub mtile_save_Click(sender As Object, e As EventArgs) Handles mtile_save.Click
        If Val(mcb_style.Text) > 9 Then
            My.Settings.style = mcb_style.Text.ToString.Substring(0, 2)
        Else
            My.Settings.style = mcb_style.Text.ToString.Substring(0, 1)
        End If

        My.Settings.theme = mcb_theme.Text.ToString.Substring(0, 1)

        My.Settings.Save()

        login.msm_style.Theme = My.Settings.theme
        login.msm_style.Style = My.Settings.style
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style

        MessageBox.Show("Settings has been saved!", "NUPON IMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub settings_select_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim dialog As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class