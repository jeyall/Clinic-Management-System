<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_archived
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info_archived))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_user = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_pass = New MetroFramework.Controls.MetroTextBox()
        Me.mtile_login = New MetroFramework.Controls.MetroTile()
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(44, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Access"
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Enabled = False
        Me.mtile_remote.Location = New System.Drawing.Point(10, 13)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(28, 28)
        Me.mtile_remote.TabIndex = 561
        Me.mtile_remote.TileImage = CType(resources.GetObject("mtile_remote.TileImage"), System.Drawing.Image)
        Me.mtile_remote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_remote.UseSelectable = True
        Me.mtile_remote.UseTileImage = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 79)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 562
        Me.MetroLabel2.Text = "Password:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 50)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel3.TabIndex = 563
        Me.MetroLabel3.Text = "Username:"
        '
        'mtxt_user
        '
        '
        '
        '
        Me.mtxt_user.CustomButton.Image = Nothing
        Me.mtxt_user.CustomButton.Location = New System.Drawing.Point(91, 1)
        Me.mtxt_user.CustomButton.Name = ""
        Me.mtxt_user.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_user.CustomButton.TabIndex = 1
        Me.mtxt_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_user.CustomButton.UseSelectable = True
        Me.mtxt_user.CustomButton.Visible = False
        Me.mtxt_user.Lines = New String(-1) {}
        Me.mtxt_user.Location = New System.Drawing.Point(95, 50)
        Me.mtxt_user.MaxLength = 32767
        Me.mtxt_user.Name = "mtxt_user"
        Me.mtxt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_user.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_user.SelectedText = ""
        Me.mtxt_user.SelectionLength = 0
        Me.mtxt_user.SelectionStart = 0
        Me.mtxt_user.ShortcutsEnabled = True
        Me.mtxt_user.Size = New System.Drawing.Size(113, 23)
        Me.mtxt_user.TabIndex = 564
        Me.mtxt_user.UseSelectable = True
        Me.mtxt_user.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_user.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_pass
        '
        '
        '
        '
        Me.mtxt_pass.CustomButton.Image = Nothing
        Me.mtxt_pass.CustomButton.Location = New System.Drawing.Point(91, 1)
        Me.mtxt_pass.CustomButton.Name = ""
        Me.mtxt_pass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_pass.CustomButton.TabIndex = 1
        Me.mtxt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_pass.CustomButton.UseSelectable = True
        Me.mtxt_pass.CustomButton.Visible = False
        Me.mtxt_pass.Lines = New String(-1) {}
        Me.mtxt_pass.Location = New System.Drawing.Point(95, 79)
        Me.mtxt_pass.MaxLength = 32767
        Me.mtxt_pass.Name = "mtxt_pass"
        Me.mtxt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.mtxt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_pass.SelectedText = ""
        Me.mtxt_pass.SelectionLength = 0
        Me.mtxt_pass.SelectionStart = 0
        Me.mtxt_pass.ShortcutsEnabled = True
        Me.mtxt_pass.Size = New System.Drawing.Size(113, 23)
        Me.mtxt_pass.TabIndex = 565
        Me.mtxt_pass.UseSelectable = True
        Me.mtxt_pass.UseSystemPasswordChar = True
        Me.mtxt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_pass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtile_login
        '
        Me.mtile_login.ActiveControl = Nothing
        Me.mtile_login.Location = New System.Drawing.Point(214, 50)
        Me.mtile_login.Name = "mtile_login"
        Me.mtile_login.Size = New System.Drawing.Size(50, 50)
        Me.mtile_login.TabIndex = 566
        Me.mtile_login.TileImage = CType(resources.GetObject("mtile_login.TileImage"), System.Drawing.Image)
        Me.mtile_login.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_login.UseSelectable = True
        Me.mtile_login.UseTileImage = True
        '
        'msm_style
        '
        Me.msm_style.Owner = Me
        '
        'info_archived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 108)
        Me.Controls.Add(Me.mtile_login)
        Me.Controls.Add(Me.mtxt_pass)
        Me.Controls.Add(Me.mtxt_user)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.mtile_remote)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "info_archived"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_user As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_pass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtile_login As MetroFramework.Controls.MetroTile
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
End Class
