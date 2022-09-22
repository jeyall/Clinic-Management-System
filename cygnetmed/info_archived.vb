Public Class info_archived

    Private Sub info_archived_Load(sender As Object, e As EventArgs) Handles Me.Load
        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
        StyleManager = msm_style

        mtxt_user.Focus()
    End Sub

    Private Sub mtile_login_Click(sender As Object, e As EventArgs) Handles mtile_login.Click
        If mtxt_user.Text = My.Settings.archived_user And mtxt_pass.Text = My.Settings.archived_pass Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to archive this patient?" + Environment.NewLine +
                                                           Environment.NewLine + "Case #: " & info.Tab_register1.mlbl_case.Text +
                                                           Environment.NewLine + "Name: " & info.Tab_register1.grid_patients.Rows(info.Tab_register1.grid_patients.CurrentCell.RowIndex).Cells(4).Value,
                                                         "Cygnetmed Health System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = Windows.Forms.DialogResult.Yes Then
                With info.Tab_register1
                    info.Tab_register1.Tb_logsBindingSource.AddNew()

                    info.Tab_register1.mlbl_status.Text = "ARCHIVED"

                    .txt_hide_namel.Text = info.lbl_name.Text
                    .txt_hide_deptl.Text = login.txt_hide_dept.Text
                    .txt_hide_activityl.Text = "ARCHIVED PATIENT"
                    .txt_hide_timestampl.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    .txt_hide_corrl.Text = info.Tab_register1.mlbl_case.Text

                    .Tb_infoBindingSource.EndEdit()
                    .Tb_infoTableAdapter.Update(info.Tab_register1.Db_cygnetmedDataSet.tb_info)
                    .Tb_logsBindingSource.EndEdit()
                    .Tb_logsTableAdapter.Update(info.Tab_register1.Db_cygnetmedDataSet.tb_logs)
                End With

                MessageBox.Show("Archived successfully.", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dispose()
        Else
            MessageBox.Show("Wrong username or password", "Cygnetmed Health System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            mtxt_user.Focus()
            mtxt_user.Clear()
            mtxt_pass.Clear()
        End If
    End Sub
End Class