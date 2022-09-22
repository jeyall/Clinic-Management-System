Public Class info_patients

    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 "

    Private Sub info_patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_infoTableAdapter.Fill(Db_cygnetmedDataSet.tb_info)
        'UI Behaviour
        msm_style.Theme = My.Settings.theme
        msm_style.Style = My.Settings.style
        StyleManager = msm_style

        Tb_infoBindingSource.Sort = "info_timestamp DESC"

        mtxt_search.Focus()
    End Sub

    Private Sub mtxt_search_TextChanged(sender As Object, e As EventArgs) Handles mtxt_search.TextChanged
        Tb_infoBindingSource.Filter = "info_fullname LIKE '%" & mtxt_search.Text & "%'"
    End Sub

    Private Sub grid_patients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_patients.CellDoubleClick
        With info.Tab_register1
            .mlbl_patient.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(1).Value
            .mtxt_last.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(3).Value
            .mtxt_first.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(4).Value
            .mtxt_middle.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(5).Value
            .mcb_gender.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(6).Value
            .mtxt_contact.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(7).Value
            .mdt_birth.Value = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(8).Value
            .mcb_civil.Text = grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(9).Value
            .TmpPicCopy = Image.FromFile("" & grid_patients.Rows(grid_patients.CurrentCell.RowIndex).Cells(11).Value & "")
            .PicCopy = New Bitmap(info.Tab_register1.TmpPicCopy)
            .TmpPicCopy.Dispose()
            .pb_patient.Image = info.Tab_register1.PicCopy
        End With

        Dispose()
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
End Class