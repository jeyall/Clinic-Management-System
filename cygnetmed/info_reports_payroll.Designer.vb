<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_reports_payroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info_reports_payroll))
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_rate = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_doctor = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hours = New MetroFramework.Controls.MetroTextBox()
        Me.mbtn_print = New MetroFramework.Controls.MetroButton()
        Me.mtxt_others = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msm_style
        '
        Me.msm_style.Owner = Me
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Enabled = False
        Me.mtile_remote.Location = New System.Drawing.Point(7, 12)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(28, 28)
        Me.mtile_remote.TabIndex = 563
        Me.mtile_remote.TileImage = CType(resources.GetObject("mtile_remote.TileImage"), System.Drawing.Image)
        Me.mtile_remote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_remote.UseSelectable = True
        Me.mtile_remote.UseTileImage = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(41, 12)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(156, 25)
        Me.MetroLabel1.TabIndex = 562
        Me.MetroLabel1.Text = "MD Payroll Details"
        '
        'mtxt_rate
        '
        '
        '
        '
        Me.mtxt_rate.CustomButton.Image = Nothing
        Me.mtxt_rate.CustomButton.Location = New System.Drawing.Point(35, 1)
        Me.mtxt_rate.CustomButton.Name = ""
        Me.mtxt_rate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_rate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_rate.CustomButton.TabIndex = 1
        Me.mtxt_rate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_rate.CustomButton.UseSelectable = True
        Me.mtxt_rate.CustomButton.Visible = False
        Me.mtxt_rate.Lines = New String(-1) {}
        Me.mtxt_rate.Location = New System.Drawing.Point(66, 89)
        Me.mtxt_rate.MaxLength = 32767
        Me.mtxt_rate.Name = "mtxt_rate"
        Me.mtxt_rate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_rate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_rate.SelectedText = ""
        Me.mtxt_rate.SelectionLength = 0
        Me.mtxt_rate.SelectionStart = 0
        Me.mtxt_rate.ShortcutsEnabled = True
        Me.mtxt_rate.Size = New System.Drawing.Size(57, 23)
        Me.mtxt_rate.TabIndex = 1
        Me.mtxt_rate.UseSelectable = True
        Me.mtxt_rate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_rate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_doctor
        '
        Me.mtxt_doctor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_doctor.CustomButton.Image = Nothing
        Me.mtxt_doctor.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.mtxt_doctor.CustomButton.Name = ""
        Me.mtxt_doctor.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_doctor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_doctor.CustomButton.TabIndex = 1
        Me.mtxt_doctor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_doctor.CustomButton.UseSelectable = True
        Me.mtxt_doctor.CustomButton.Visible = False
        Me.mtxt_doctor.Lines = New String(-1) {}
        Me.mtxt_doctor.Location = New System.Drawing.Point(66, 60)
        Me.mtxt_doctor.MaxLength = 32767
        Me.mtxt_doctor.Name = "mtxt_doctor"
        Me.mtxt_doctor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_doctor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_doctor.SelectedText = ""
        Me.mtxt_doctor.SelectionLength = 0
        Me.mtxt_doctor.SelectionStart = 0
        Me.mtxt_doctor.ShortcutsEnabled = True
        Me.mtxt_doctor.Size = New System.Drawing.Size(194, 23)
        Me.mtxt_doctor.TabIndex = 0
        Me.mtxt_doctor.UseSelectable = True
        Me.mtxt_doctor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_doctor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(7, 60)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel3.TabIndex = 567
        Me.MetroLabel3.Text = "Doctor:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(22, 89)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel2.TabIndex = 566
        Me.MetroLabel2.Text = "Rate:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(143, 89)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel4.TabIndex = 570
        Me.MetroLabel4.Text = "Hour(s):"
        '
        'mtxt_hours
        '
        '
        '
        '
        Me.mtxt_hours.CustomButton.Image = Nothing
        Me.mtxt_hours.CustomButton.Location = New System.Drawing.Point(35, 1)
        Me.mtxt_hours.CustomButton.Name = ""
        Me.mtxt_hours.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hours.CustomButton.TabIndex = 1
        Me.mtxt_hours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hours.CustomButton.UseSelectable = True
        Me.mtxt_hours.CustomButton.Visible = False
        Me.mtxt_hours.Lines = New String(-1) {}
        Me.mtxt_hours.Location = New System.Drawing.Point(203, 89)
        Me.mtxt_hours.MaxLength = 32767
        Me.mtxt_hours.Name = "mtxt_hours"
        Me.mtxt_hours.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hours.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hours.SelectedText = ""
        Me.mtxt_hours.SelectionLength = 0
        Me.mtxt_hours.SelectionStart = 0
        Me.mtxt_hours.ShortcutsEnabled = True
        Me.mtxt_hours.Size = New System.Drawing.Size(57, 23)
        Me.mtxt_hours.TabIndex = 2
        Me.mtxt_hours.UseSelectable = True
        Me.mtxt_hours.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hours.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mbtn_print
        '
        Me.mbtn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_print.Location = New System.Drawing.Point(167, 147)
        Me.mbtn_print.Name = "mbtn_print"
        Me.mbtn_print.Size = New System.Drawing.Size(93, 23)
        Me.mbtn_print.TabIndex = 4
        Me.mbtn_print.Text = "Print Preview"
        Me.mbtn_print.UseSelectable = True
        '
        'mtxt_others
        '
        '
        '
        '
        Me.mtxt_others.CustomButton.Image = Nothing
        Me.mtxt_others.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.mtxt_others.CustomButton.Name = ""
        Me.mtxt_others.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_others.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_others.CustomButton.TabIndex = 1
        Me.mtxt_others.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_others.CustomButton.UseSelectable = True
        Me.mtxt_others.CustomButton.Visible = False
        Me.mtxt_others.Lines = New String(-1) {}
        Me.mtxt_others.Location = New System.Drawing.Point(66, 118)
        Me.mtxt_others.MaxLength = 32767
        Me.mtxt_others.Name = "mtxt_others"
        Me.mtxt_others.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_others.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_others.SelectedText = ""
        Me.mtxt_others.SelectionLength = 0
        Me.mtxt_others.SelectionStart = 0
        Me.mtxt_others.ShortcutsEnabled = True
        Me.mtxt_others.Size = New System.Drawing.Size(194, 23)
        Me.mtxt_others.TabIndex = 3
        Me.mtxt_others.UseSelectable = True
        Me.mtxt_others.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_others.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(9, 118)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel5.TabIndex = 627
        Me.MetroLabel5.Text = "Others:"
        '
        'info_reports_payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 177)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.mtxt_others)
        Me.Controls.Add(Me.mbtn_print)
        Me.Controls.Add(Me.mtxt_hours)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.mtxt_rate)
        Me.Controls.Add(Me.mtxt_doctor)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.mtile_remote)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "info_reports_payroll"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hours As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_rate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_doctor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbtn_print As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_others As MetroFramework.Controls.MetroTextBox
End Class
