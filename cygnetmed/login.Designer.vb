<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mpnl_right = New MetroFramework.Controls.MetroPanel()
        Me.mtile_settings = New MetroFramework.Controls.MetroTile()
        Me.mbtn_login = New MetroFramework.Controls.MetroButton()
        Me.mtxt_pass = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_user = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.Tb_loginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_loginTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_loginTableAdapter()
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        Me.Tb_logsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnl_hide_login = New System.Windows.Forms.Panel()
        Me.txt_hide_name = New System.Windows.Forms.TextBox()
        Me.txt_hide_dept = New System.Windows.Forms.TextBox()
        Me.txt_hide_status = New System.Windows.Forms.TextBox()
        Me.txt_hide_logout = New System.Windows.Forms.TextBox()
        Me.txt_hide_login = New System.Windows.Forms.TextBox()
        Me.txt_hide_namel = New System.Windows.Forms.TextBox()
        Me.pnl_hide_logs = New System.Windows.Forms.Panel()
        Me.txt_hide_corrl = New System.Windows.Forms.TextBox()
        Me.txt_hide_activityl = New System.Windows.Forms.TextBox()
        Me.txt_hide_timestampl = New System.Windows.Forms.TextBox()
        Me.txt_hide_deptl = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mpnl_right.SuspendLayout()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_loginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_hide_login.SuspendLayout()
        Me.pnl_hide_logs.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'mpnl_right
        '
        Me.mpnl_right.Controls.Add(Me.mtile_settings)
        Me.mpnl_right.Controls.Add(Me.mbtn_login)
        Me.mpnl_right.Controls.Add(Me.mtxt_pass)
        Me.mpnl_right.Controls.Add(Me.mtxt_user)
        Me.mpnl_right.Controls.Add(Me.MetroLabel1)
        Me.mpnl_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.mpnl_right.HorizontalScrollbarBarColor = False
        Me.mpnl_right.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_right.HorizontalScrollbarSize = 0
        Me.mpnl_right.Location = New System.Drawing.Point(276, 60)
        Me.mpnl_right.Name = "mpnl_right"
        Me.mpnl_right.Size = New System.Drawing.Size(298, 248)
        Me.mpnl_right.TabIndex = 1
        Me.mpnl_right.VerticalScrollbarBarColor = False
        Me.mpnl_right.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_right.VerticalScrollbarSize = 0
        '
        'mtile_settings
        '
        Me.mtile_settings.ActiveControl = Nothing
        Me.mtile_settings.Location = New System.Drawing.Point(0, 224)
        Me.mtile_settings.Name = "mtile_settings"
        Me.mtile_settings.Size = New System.Drawing.Size(32, 24)
        Me.mtile_settings.TabIndex = 9
        Me.mtile_settings.TileImage = CType(resources.GetObject("mtile_settings.TileImage"), System.Drawing.Image)
        Me.mtile_settings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_settings.UseSelectable = True
        Me.mtile_settings.UseTileImage = True
        '
        'mbtn_login
        '
        Me.mbtn_login.Location = New System.Drawing.Point(206, 224)
        Me.mbtn_login.Name = "mbtn_login"
        Me.mbtn_login.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_login.TabIndex = 8
        Me.mbtn_login.Text = "Login"
        Me.mbtn_login.UseSelectable = True
        '
        'mtxt_pass
        '
        '
        '
        '
        Me.mtxt_pass.CustomButton.Image = Nothing
        Me.mtxt_pass.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.mtxt_pass.CustomButton.Name = ""
        Me.mtxt_pass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_pass.CustomButton.TabIndex = 1
        Me.mtxt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_pass.CustomButton.UseSelectable = True
        Me.mtxt_pass.CustomButton.Visible = False
        Me.mtxt_pass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxt_pass.Lines = New String(-1) {}
        Me.mtxt_pass.Location = New System.Drawing.Point(34, 181)
        Me.mtxt_pass.MaxLength = 32767
        Me.mtxt_pass.Name = "mtxt_pass"
        Me.mtxt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.mtxt_pass.PromptText = "Password"
        Me.mtxt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_pass.SelectedText = ""
        Me.mtxt_pass.SelectionLength = 0
        Me.mtxt_pass.SelectionStart = 0
        Me.mtxt_pass.ShortcutsEnabled = True
        Me.mtxt_pass.Size = New System.Drawing.Size(247, 23)
        Me.mtxt_pass.TabIndex = 4
        Me.mtxt_pass.UseSelectable = True
        Me.mtxt_pass.UseSystemPasswordChar = True
        Me.mtxt_pass.WaterMark = "Password"
        Me.mtxt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_pass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_user
        '
        '
        '
        '
        Me.mtxt_user.CustomButton.Image = Nothing
        Me.mtxt_user.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.mtxt_user.CustomButton.Name = ""
        Me.mtxt_user.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_user.CustomButton.TabIndex = 1
        Me.mtxt_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_user.CustomButton.UseSelectable = True
        Me.mtxt_user.CustomButton.Visible = False
        Me.mtxt_user.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxt_user.Lines = New String(-1) {}
        Me.mtxt_user.Location = New System.Drawing.Point(34, 152)
        Me.mtxt_user.MaxLength = 32767
        Me.mtxt_user.Name = "mtxt_user"
        Me.mtxt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_user.PromptText = "Username"
        Me.mtxt_user.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_user.SelectedText = ""
        Me.mtxt_user.SelectionLength = 0
        Me.mtxt_user.SelectionStart = 0
        Me.mtxt_user.ShortcutsEnabled = True
        Me.mtxt_user.Size = New System.Drawing.Size(247, 23)
        Me.mtxt_user.TabIndex = 3
        Me.mtxt_user.UseSelectable = True
        Me.mtxt_user.WaterMark = "Username"
        Me.mtxt_user.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_user.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(46, 101)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(222, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Cygnetmed Health System"
        '
        'msm_style
        '
        Me.msm_style.Owner = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(365, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Db_cygnetmedDataSet
        '
        Me.Db_cygnetmedDataSet.DataSetName = "db_cygnetmedDataSet"
        Me.Db_cygnetmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_loginBindingSource
        '
        Me.Tb_loginBindingSource.DataMember = "tb_login"
        Me.Tb_loginBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Tb_loginTableAdapter
        '
        Me.Tb_loginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_doctorsTableAdapter = Nothing
        Me.TableAdapterManager.tb_hmoTableAdapter = Nothing
        Me.TableAdapterManager.tb_infoTableAdapter = Nothing
        Me.TableAdapterManager.tb_labTableAdapter = Nothing
        Me.TableAdapterManager.tb_loginTableAdapter = Me.Tb_loginTableAdapter
        Me.TableAdapterManager.tb_logsTableAdapter = Me.Tb_logsTableAdapter
        Me.TableAdapterManager.tb_packageTableAdapter = Nothing
        Me.TableAdapterManager.tb_relTableAdapter = Nothing
        Me.TableAdapterManager.tb_xrayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_logsTableAdapter
        '
        Me.Tb_logsTableAdapter.ClearBeforeFill = True
        '
        'Tb_logsBindingSource
        '
        Me.Tb_logsBindingSource.DataMember = "tb_logs"
        Me.Tb_logsBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'pnl_hide_login
        '
        Me.pnl_hide_login.Controls.Add(Me.txt_hide_name)
        Me.pnl_hide_login.Controls.Add(Me.txt_hide_dept)
        Me.pnl_hide_login.Controls.Add(Me.txt_hide_status)
        Me.pnl_hide_login.Controls.Add(Me.txt_hide_logout)
        Me.pnl_hide_login.Controls.Add(Me.txt_hide_login)
        Me.pnl_hide_login.Location = New System.Drawing.Point(108, 63)
        Me.pnl_hide_login.Name = "pnl_hide_login"
        Me.pnl_hide_login.Size = New System.Drawing.Size(10, 10)
        Me.pnl_hide_login.TabIndex = 4
        '
        'txt_hide_name
        '
        Me.txt_hide_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_loginBindingSource, "login_name", True))
        Me.txt_hide_name.Location = New System.Drawing.Point(23, 35)
        Me.txt_hide_name.Name = "txt_hide_name"
        Me.txt_hide_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_name.TabIndex = 4
        '
        'txt_hide_dept
        '
        Me.txt_hide_dept.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_loginBindingSource, "login_dept", True))
        Me.txt_hide_dept.Location = New System.Drawing.Point(23, 61)
        Me.txt_hide_dept.Name = "txt_hide_dept"
        Me.txt_hide_dept.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_dept.TabIndex = 3
        '
        'txt_hide_status
        '
        Me.txt_hide_status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_loginBindingSource, "login_status", True))
        Me.txt_hide_status.Location = New System.Drawing.Point(23, 138)
        Me.txt_hide_status.Name = "txt_hide_status"
        Me.txt_hide_status.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_status.TabIndex = 2
        '
        'txt_hide_logout
        '
        Me.txt_hide_logout.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_loginBindingSource, "login_out", True))
        Me.txt_hide_logout.Location = New System.Drawing.Point(23, 112)
        Me.txt_hide_logout.Name = "txt_hide_logout"
        Me.txt_hide_logout.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_logout.TabIndex = 1
        '
        'txt_hide_login
        '
        Me.txt_hide_login.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_loginBindingSource, "login_in", True))
        Me.txt_hide_login.Location = New System.Drawing.Point(23, 87)
        Me.txt_hide_login.Name = "txt_hide_login"
        Me.txt_hide_login.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_login.TabIndex = 0
        '
        'txt_hide_namel
        '
        Me.txt_hide_namel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_logsBindingSource, "logs_name", True))
        Me.txt_hide_namel.Location = New System.Drawing.Point(18, 22)
        Me.txt_hide_namel.Name = "txt_hide_namel"
        Me.txt_hide_namel.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_namel.TabIndex = 3
        '
        'pnl_hide_logs
        '
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_corrl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_activityl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_timestampl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_deptl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_namel)
        Me.pnl_hide_logs.Location = New System.Drawing.Point(197, 201)
        Me.pnl_hide_logs.Name = "pnl_hide_logs"
        Me.pnl_hide_logs.Size = New System.Drawing.Size(23, 18)
        Me.pnl_hide_logs.TabIndex = 5
        '
        'txt_hide_corrl
        '
        Me.txt_hide_corrl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_logsBindingSource, "logs_corr", True))
        Me.txt_hide_corrl.Location = New System.Drawing.Point(18, 124)
        Me.txt_hide_corrl.Name = "txt_hide_corrl"
        Me.txt_hide_corrl.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_corrl.TabIndex = 7
        '
        'txt_hide_activityl
        '
        Me.txt_hide_activityl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_logsBindingSource, "logs_activity", True))
        Me.txt_hide_activityl.Location = New System.Drawing.Point(18, 98)
        Me.txt_hide_activityl.Name = "txt_hide_activityl"
        Me.txt_hide_activityl.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_activityl.TabIndex = 6
        '
        'txt_hide_timestampl
        '
        Me.txt_hide_timestampl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_logsBindingSource, "logs_timestamp", True))
        Me.txt_hide_timestampl.Location = New System.Drawing.Point(18, 73)
        Me.txt_hide_timestampl.Name = "txt_hide_timestampl"
        Me.txt_hide_timestampl.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_timestampl.TabIndex = 5
        '
        'txt_hide_deptl
        '
        Me.txt_hide_deptl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_logsBindingSource, "logs_dept", True))
        Me.txt_hide_deptl.Location = New System.Drawing.Point(18, 47)
        Me.txt_hide_deptl.Name = "txt_hide_deptl"
        Me.txt_hide_deptl.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_deptl.TabIndex = 4
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 328)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.mpnl_right)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnl_hide_logs)
        Me.Controls.Add(Me.pnl_hide_login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mpnl_right.ResumeLayout(False)
        Me.mpnl_right.PerformLayout()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_loginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_hide_login.ResumeLayout(False)
        Me.pnl_hide_login.PerformLayout()
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mpnl_right As MetroFramework.Controls.MetroPanel
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtile_settings As MetroFramework.Controls.MetroTile
    Friend WithEvents mbtn_login As MetroFramework.Controls.MetroButton
    Friend WithEvents mtxt_pass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_user As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents Tb_loginBindingSource As BindingSource
    Friend WithEvents Tb_loginTableAdapter As db_cygnetmedDataSetTableAdapters.tb_loginTableAdapter
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents pnl_hide_login As Panel
    Friend WithEvents txt_hide_login As TextBox
    Friend WithEvents txt_hide_logout As TextBox
    Friend WithEvents txt_hide_status As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_name As TextBox
    Friend WithEvents txt_hide_dept As TextBox
End Class
