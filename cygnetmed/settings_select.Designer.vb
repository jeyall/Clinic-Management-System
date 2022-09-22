<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings_select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings_select))
        Me.mtile_lan = New MetroFramework.Controls.MetroTile()
        Me.mtile_back = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.mtile_default = New MetroFramework.Controls.MetroTile()
        Me.mtile_manual = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.mtile_save = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_style = New MetroFramework.Controls.MetroComboBox()
        Me.mcb_theme = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtile_lan
        '
        Me.mtile_lan.ActiveControl = Nothing
        Me.mtile_lan.Location = New System.Drawing.Point(13, 66)
        Me.mtile_lan.Name = "mtile_lan"
        Me.mtile_lan.Size = New System.Drawing.Size(128, 112)
        Me.mtile_lan.TabIndex = 10
        Me.mtile_lan.TileImage = CType(resources.GetObject("mtile_lan.TileImage"), System.Drawing.Image)
        Me.mtile_lan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_lan.UseSelectable = True
        Me.mtile_lan.UseTileImage = True
        '
        'mtile_back
        '
        Me.mtile_back.ActiveControl = Nothing
        Me.mtile_back.Location = New System.Drawing.Point(0, 5)
        Me.mtile_back.Name = "mtile_back"
        Me.mtile_back.Size = New System.Drawing.Size(32, 25)
        Me.mtile_back.TabIndex = 11
        Me.mtile_back.TileImage = CType(resources.GetObject("mtile_back.TileImage"), System.Drawing.Image)
        Me.mtile_back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_back.UseSelectable = True
        Me.mtile_back.UseTileImage = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(100, 28)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(132, 25)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Miscellaneous"
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Location = New System.Drawing.Point(184, 66)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(128, 112)
        Me.mtile_remote.TabIndex = 13
        Me.mtile_remote.TileImage = CType(resources.GetObject("mtile_remote.TileImage"), System.Drawing.Image)
        Me.mtile_remote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_remote.UseSelectable = True
        Me.mtile_remote.UseTileImage = True
        '
        'mtile_default
        '
        Me.mtile_default.ActiveControl = Nothing
        Me.mtile_default.Location = New System.Drawing.Point(13, 210)
        Me.mtile_default.Name = "mtile_default"
        Me.mtile_default.Size = New System.Drawing.Size(128, 112)
        Me.mtile_default.TabIndex = 14
        Me.mtile_default.TileImage = CType(resources.GetObject("mtile_default.TileImage"), System.Drawing.Image)
        Me.mtile_default.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_default.UseSelectable = True
        Me.mtile_default.UseTileImage = True
        '
        'mtile_manual
        '
        Me.mtile_manual.ActiveControl = Nothing
        Me.mtile_manual.Location = New System.Drawing.Point(184, 210)
        Me.mtile_manual.Name = "mtile_manual"
        Me.mtile_manual.Size = New System.Drawing.Size(128, 112)
        Me.mtile_manual.TabIndex = 15
        Me.mtile_manual.TileImage = CType(resources.GetObject("mtile_manual.TileImage"), System.Drawing.Image)
        Me.mtile_manual.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_manual.UseSelectable = True
        Me.mtile_manual.UseTileImage = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(60, 181)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel2.TabIndex = 16
        Me.MetroLabel2.Text = "LAN"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(223, 181)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel3.TabIndex = 17
        Me.MetroLabel3.Text = "Remote"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(13, 325)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(128, 43)
        Me.MetroLabel4.TabIndex = 18
        Me.MetroLabel4.Text = "Default Connection " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "String"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(224, 325)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel5.TabIndex = 19
        Me.MetroLabel5.Text = "Manual"
        '
        'msm_style
        '
        Me.msm_style.Owner = Me
        '
        'mtile_save
        '
        Me.mtile_save.ActiveControl = Nothing
        Me.mtile_save.Location = New System.Drawing.Point(224, 410)
        Me.mtile_save.Name = "mtile_save"
        Me.mtile_save.Size = New System.Drawing.Size(58, 62)
        Me.mtile_save.TabIndex = 24
        Me.mtile_save.TileImage = CType(resources.GetObject("mtile_save.TileImage"), System.Drawing.Image)
        Me.mtile_save.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtile_save.UseSelectable = True
        Me.mtile_save.UseTileImage = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(39, 447)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel6.TabIndex = 23
        Me.MetroLabel6.Text = "Theme:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(39, 410)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel7.TabIndex = 22
        Me.MetroLabel7.Text = "Style:"
        '
        'mcb_style
        '
        Me.mcb_style.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcb_style.FormattingEnabled = True
        Me.mcb_style.ItemHeight = 19
        Me.mcb_style.Items.AddRange(New Object() {"1 - Black", "2 - White", "3 - Silver", "4 - Blue", "5 - Green", "6 - Lime", "7 - Teal", "8 - Orange", "9 - Brown", "10 - Pink", "11 - Magenta", "12 - Purple", "13 - Red", "14 - Yellow"})
        Me.mcb_style.Location = New System.Drawing.Point(97, 410)
        Me.mcb_style.Name = "mcb_style"
        Me.mcb_style.Size = New System.Drawing.Size(121, 25)
        Me.mcb_style.TabIndex = 21
        Me.mcb_style.UseSelectable = True
        '
        'mcb_theme
        '
        Me.mcb_theme.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcb_theme.FormattingEnabled = True
        Me.mcb_theme.ItemHeight = 19
        Me.mcb_theme.Items.AddRange(New Object() {"1 - Light", "2 - Dark"})
        Me.mcb_theme.Location = New System.Drawing.Point(97, 447)
        Me.mcb_theme.Name = "mcb_theme"
        Me.mcb_theme.Size = New System.Drawing.Size(121, 25)
        Me.mcb_theme.TabIndex = 20
        Me.mcb_theme.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(133, 379)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(57, 25)
        Me.MetroLabel8.TabIndex = 25
        Me.MetroLabel8.Text = "Color"
        '
        'settings_select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 499)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.mtile_save)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.mcb_style)
        Me.Controls.Add(Me.mcb_theme)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.mtile_manual)
        Me.Controls.Add(Me.mtile_default)
        Me.Controls.Add(Me.mtile_remote)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.mtile_back)
        Me.Controls.Add(Me.mtile_lan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "settings_select"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtile_lan As MetroFramework.Controls.MetroTile
    Friend WithEvents mtile_back As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents mtile_default As MetroFramework.Controls.MetroTile
    Friend WithEvents mtile_manual As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mtile_save As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_style As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mcb_theme As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
End Class
