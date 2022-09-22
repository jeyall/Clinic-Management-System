Public Class info_reports_payroll

    Private Sub info_reports_payroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        mtxt_doctor.Focus()
        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
        StyleManager = msm_style
    End Sub

    Private Sub mbtn_print_Click(sender As Object, e As EventArgs) Handles mbtn_print.Click
        If mtxt_doctor.Text = Nothing Or mtxt_hours.Text = Nothing Or mtxt_others.Text = Nothing Or mtxt_rate.Text = Nothing Then
            MessageBox.Show("Fill up the required fields", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            info_reports.md_payroll()
            Close()
        End If
    End Sub

    Private Sub info_reports_payroll_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dispose()
    End Sub

    Private Sub mtxt_rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_rate.KeyPress, mtxt_others.KeyPress, mtxt_hours.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class