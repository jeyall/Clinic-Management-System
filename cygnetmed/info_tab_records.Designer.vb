<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_tab_records
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mpnl_body = New MetroFramework.Controls.MetroPanel()
        Me.SuspendLayout()
        '
        'mpnl_body
        '
        Me.mpnl_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mpnl_body.HorizontalScrollbarBarColor = False
        Me.mpnl_body.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_body.HorizontalScrollbarSize = 0
        Me.mpnl_body.Location = New System.Drawing.Point(0, 0)
        Me.mpnl_body.Name = "mpnl_body"
        Me.mpnl_body.Size = New System.Drawing.Size(150, 150)
        Me.mpnl_body.TabIndex = 0
        Me.mpnl_body.VerticalScrollbarBarColor = False
        Me.mpnl_body.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_body.VerticalScrollbarSize = 0
        '
        'info_tab_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mpnl_body)
        Me.Name = "info_tab_records"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mpnl_body As MetroFramework.Controls.MetroPanel
End Class
