<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lab))
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.Tb_logsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        Me.mtile_refresh = New MetroFramework.Controls.MetroTile()
        Me.mtab_lab = New MetroFramework.Controls.MetroTabControl()
        Me.mtab_register = New MetroFramework.Controls.MetroTabPage()
        Me.Lab_tab_register1 = New cygnetmed.lab_tab_register()
        Me.mtab_records = New MetroFramework.Controls.MetroTabPage()
        Me.Info_tab_records1 = New cygnetmed.info_tab_records()
        Me.mbtn_logout = New MetroFramework.Controls.MetroButton()
        Me.lbl_clock = New MetroFramework.Controls.MetroLabel()
        Me.lbl_name = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.pnl_hide_logs = New System.Windows.Forms.Panel()
        Me.txt_hide_corrl = New System.Windows.Forms.TextBox()
        Me.txt_hide_activityl = New System.Windows.Forms.TextBox()
        Me.txt_hide_timestampl = New System.Windows.Forms.TextBox()
        Me.txt_hide_deptl = New System.Windows.Forms.TextBox()
        Me.txt_hide_namel = New System.Windows.Forms.TextBox()
        Me.Lab_tab_records1 = New cygnetmed.lab_tab_records()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mtab_lab.SuspendLayout()
        Me.mtab_register.SuspendLayout()
        Me.mtab_records.SuspendLayout()
        Me.pnl_hide_logs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Db_cygnetmedDataSet
        '
        Me.Db_cygnetmedDataSet.DataSetName = "db_cygnetmedDataSet"
        Me.Db_cygnetmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_logsBindingSource
        '
        Me.Tb_logsBindingSource.DataMember = "tb_logs"
        Me.Tb_logsBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Tb_logsTableAdapter
        '
        Me.Tb_logsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_doctorsTableAdapter = Nothing
        Me.TableAdapterManager.tb_hmoTableAdapter = Nothing
        Me.TableAdapterManager.tb_infoTableAdapter = Nothing
        Me.TableAdapterManager.tb_labTableAdapter = Nothing
        Me.TableAdapterManager.tb_loginTableAdapter = Nothing
        Me.TableAdapterManager.tb_logsTableAdapter = Me.Tb_logsTableAdapter
        Me.TableAdapterManager.tb_packageTableAdapter = Nothing
        Me.TableAdapterManager.tb_relTableAdapter = Nothing
        Me.TableAdapterManager.tb_xrayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'msm_style
        '
        Me.msm_style.Owner = Me
        '
        'clock
        '
        Me.clock.Enabled = True
        Me.clock.Interval = 1000
        '
        'mtile_refresh
        '
        Me.mtile_refresh.ActiveControl = Nothing
        Me.mtile_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtile_refresh.Location = New System.Drawing.Point(1156, 43)
        Me.mtile_refresh.Name = "mtile_refresh"
        Me.mtile_refresh.Size = New System.Drawing.Size(28, 28)
        Me.mtile_refresh.TabIndex = 617
        Me.mtile_refresh.TileImage = CType(resources.GetObject("mtile_refresh.TileImage"), System.Drawing.Image)
        Me.mtile_refresh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_refresh.UseSelectable = True
        Me.mtile_refresh.UseTileImage = True
        '
        'mtab_lab
        '
        Me.mtab_lab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtab_lab.Controls.Add(Me.mtab_register)
        Me.mtab_lab.Controls.Add(Me.mtab_records)
        Me.mtab_lab.Location = New System.Drawing.Point(9, 41)
        Me.mtab_lab.Name = "mtab_lab"
        Me.mtab_lab.SelectedIndex = 0
        Me.mtab_lab.Size = New System.Drawing.Size(1179, 580)
        Me.mtab_lab.TabIndex = 615
        Me.mtab_lab.UseSelectable = True
        '
        'mtab_register
        '
        Me.mtab_register.Controls.Add(Me.Lab_tab_register1)
        Me.mtab_register.HorizontalScrollbarBarColor = False
        Me.mtab_register.HorizontalScrollbarHighlightOnWheel = False
        Me.mtab_register.HorizontalScrollbarSize = 0
        Me.mtab_register.Location = New System.Drawing.Point(4, 38)
        Me.mtab_register.Name = "mtab_register"
        Me.mtab_register.Size = New System.Drawing.Size(1171, 538)
        Me.mtab_register.TabIndex = 0
        Me.mtab_register.Text = "Register"
        Me.mtab_register.VerticalScrollbarBarColor = False
        Me.mtab_register.VerticalScrollbarHighlightOnWheel = False
        Me.mtab_register.VerticalScrollbarSize = 0
        '
        'Lab_tab_register1
        '
        Me.Lab_tab_register1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_tab_register1.Location = New System.Drawing.Point(0, 0)
        Me.Lab_tab_register1.Name = "Lab_tab_register1"
        Me.Lab_tab_register1.Size = New System.Drawing.Size(1171, 538)
        Me.Lab_tab_register1.TabIndex = 2
        '
        'mtab_records
        '
        Me.mtab_records.Controls.Add(Me.Lab_tab_records1)
        Me.mtab_records.Controls.Add(Me.Info_tab_records1)
        Me.mtab_records.HorizontalScrollbarBarColor = False
        Me.mtab_records.HorizontalScrollbarHighlightOnWheel = False
        Me.mtab_records.HorizontalScrollbarSize = 0
        Me.mtab_records.Location = New System.Drawing.Point(4, 38)
        Me.mtab_records.Name = "mtab_records"
        Me.mtab_records.Size = New System.Drawing.Size(1171, 538)
        Me.mtab_records.TabIndex = 1
        Me.mtab_records.Text = "Records"
        Me.mtab_records.VerticalScrollbarBarColor = False
        Me.mtab_records.VerticalScrollbarHighlightOnWheel = False
        Me.mtab_records.VerticalScrollbarSize = 0
        '
        'Info_tab_records1
        '
        Me.Info_tab_records1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Info_tab_records1.Location = New System.Drawing.Point(0, 0)
        Me.Info_tab_records1.Name = "Info_tab_records1"
        Me.Info_tab_records1.Size = New System.Drawing.Size(1171, 538)
        Me.Info_tab_records1.TabIndex = 2
        '
        'mbtn_logout
        '
        Me.mbtn_logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mbtn_logout.Location = New System.Drawing.Point(1, 627)
        Me.mbtn_logout.Name = "mbtn_logout"
        Me.mbtn_logout.Size = New System.Drawing.Size(45, 23)
        Me.mbtn_logout.TabIndex = 614
        Me.mbtn_logout.Text = "Logout"
        Me.mbtn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mbtn_logout.UseSelectable = True
        '
        'lbl_clock
        '
        Me.lbl_clock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clock.AutoSize = True
        Me.lbl_clock.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_clock.Location = New System.Drawing.Point(1057, 632)
        Me.lbl_clock.Name = "lbl_clock"
        Me.lbl_clock.Size = New System.Drawing.Size(70, 15)
        Me.lbl_clock.TabIndex = 613
        Me.lbl_clock.Text = "MetroLabel2"
        '
        'lbl_name
        '
        Me.lbl_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_name.AutoSize = True
        Me.lbl_name.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbl_name.Location = New System.Drawing.Point(50, 631)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(70, 15)
        Me.lbl_name.TabIndex = 612
        Me.lbl_name.Text = "MetroLabel2"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(40, 12)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 25)
        Me.MetroLabel1.TabIndex = 611
        Me.MetroLabel1.Text = "Laboratory"
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Enabled = False
        Me.mtile_remote.Location = New System.Drawing.Point(9, 11)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(28, 28)
        Me.mtile_remote.TabIndex = 610
        Me.mtile_remote.TileImage = CType(resources.GetObject("mtile_remote.TileImage"), System.Drawing.Image)
        Me.mtile_remote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_remote.UseSelectable = True
        Me.mtile_remote.UseTileImage = True
        '
        'pnl_hide_logs
        '
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_corrl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_activityl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_timestampl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_deptl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_namel)
        Me.pnl_hide_logs.Location = New System.Drawing.Point(11, 16)
        Me.pnl_hide_logs.Name = "pnl_hide_logs"
        Me.pnl_hide_logs.Size = New System.Drawing.Size(23, 18)
        Me.pnl_hide_logs.TabIndex = 616
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
        'txt_hide_namel
        '
        Me.txt_hide_namel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_logsBindingSource, "logs_name", True))
        Me.txt_hide_namel.Location = New System.Drawing.Point(18, 22)
        Me.txt_hide_namel.Name = "txt_hide_namel"
        Me.txt_hide_namel.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_namel.TabIndex = 3
        '
        'Lab_tab_records1
        '
        Me.Lab_tab_records1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_tab_records1.Location = New System.Drawing.Point(0, 0)
        Me.Lab_tab_records1.Name = "Lab_tab_records1"
        Me.Lab_tab_records1.Size = New System.Drawing.Size(1171, 538)
        Me.Lab_tab_records1.TabIndex = 4
        '
        'lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.mtile_refresh)
        Me.Controls.Add(Me.mtab_lab)
        Me.Controls.Add(Me.mbtn_logout)
        Me.Controls.Add(Me.lbl_clock)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.mtile_remote)
        Me.Controls.Add(Me.pnl_hide_logs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lab"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mtab_lab.ResumeLayout(False)
        Me.mtab_register.ResumeLayout(False)
        Me.mtab_records.ResumeLayout(False)
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents clock As Timer
    Friend WithEvents mtile_refresh As MetroFramework.Controls.MetroTile
    Friend WithEvents mtab_lab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents mtab_records As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Info_tab_records1 As info_tab_records
    Friend WithEvents mbtn_logout As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_clock As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_name As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents mtab_register As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Lab_tab_register1 As lab_tab_register
    Friend WithEvents Lab_tab_records1 As lab_tab_records
End Class
