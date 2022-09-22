<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xray_report
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xray_report))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.xray_viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mdt_from = New MetroFramework.Controls.MetroDateTime()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.grid_patients = New MetroFramework.Controls.MetroGrid()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xray_company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xray_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tb_xrayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mpnl_left = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mcbo_company = New MetroFramework.Controls.MetroComboBox()
        Me.mcbo_print = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mdt_to = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.pnl_hide_logs = New System.Windows.Forms.Panel()
        Me.txt_hide_corrl = New System.Windows.Forms.TextBox()
        Me.Tb_logsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_hide_activityl = New System.Windows.Forms.TextBox()
        Me.txt_hide_timestampl = New System.Windows.Forms.TextBox()
        Me.txt_hide_deptl = New System.Windows.Forms.TextBox()
        Me.txt_hide_namel = New System.Windows.Forms.TextBox()
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.Tb_xrayTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_xrayTableAdapter()
        Me.Tb_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_infoTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter()
        Me.xray_reportbindingsource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_xrayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mpnl_left.SuspendLayout()
        Me.pnl_hide_logs.SuspendLayout()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xray_reportbindingsource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xray_viewer
        '
        Me.xray_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xray_viewer.LocalReport.EnableExternalImages = True
        Me.xray_viewer.LocalReport.EnableHyperlinks = True
        Me.xray_viewer.Location = New System.Drawing.Point(428, 0)
        Me.xray_viewer.Name = "xray_viewer"
        Me.xray_viewer.ServerReport.BearerToken = Nothing
        Me.xray_viewer.Size = New System.Drawing.Size(523, 490)
        Me.xray_viewer.TabIndex = 4
        '
        'mdt_from
        '
        Me.mdt_from.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mdt_from.DisplayFocus = True
        Me.mdt_from.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.mdt_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdt_from.Location = New System.Drawing.Point(128, 6)
        Me.mdt_from.MinimumSize = New System.Drawing.Size(0, 25)
        Me.mdt_from.Name = "mdt_from"
        Me.mdt_from.Size = New System.Drawing.Size(88, 25)
        Me.mdt_from.TabIndex = 624
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Enabled = False
        Me.mtile_remote.Location = New System.Drawing.Point(3, 3)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(28, 28)
        Me.mtile_remote.TabIndex = 622
        Me.mtile_remote.TileImage = CType(resources.GetObject("mtile_remote.TileImage"), System.Drawing.Image)
        Me.mtile_remote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_remote.UseSelectable = True
        Me.mtile_remote.UseTileImage = True
        '
        'grid_patients
        '
        Me.grid_patients.AllowUserToAddRows = False
        Me.grid_patients.AllowUserToDeleteRows = False
        Me.grid_patients.AllowUserToResizeRows = False
        Me.grid_patients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_patients.AutoGenerateColumns = False
        Me.grid_patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_patients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_patients.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_patients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_patients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_patients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_patients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_patients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransnoDataGridViewTextBoxColumn, Me.xray_company, Me.xray_status})
        Me.grid_patients.DataSource = Me.Tb_xrayBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_patients.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_patients.EnableHeadersVisualStyles = False
        Me.grid_patients.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_patients.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_patients.Location = New System.Drawing.Point(9, 99)
        Me.grid_patients.Name = "grid_patients"
        Me.grid_patients.ReadOnly = True
        Me.grid_patients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_patients.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_patients.RowHeadersVisible = False
        Me.grid_patients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_patients.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_patients.Size = New System.Drawing.Size(407, 379)
        Me.grid_patients.TabIndex = 623
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "transno"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "Case #"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'xray_company
        '
        Me.xray_company.DataPropertyName = "xray_company"
        Me.xray_company.HeaderText = "Company"
        Me.xray_company.Name = "xray_company"
        Me.xray_company.ReadOnly = True
        '
        'xray_status
        '
        Me.xray_status.DataPropertyName = "xray_status"
        Me.xray_status.HeaderText = "Status"
        Me.xray_status.Name = "xray_status"
        Me.xray_status.ReadOnly = True
        '
        'Tb_xrayBindingSource
        '
        Me.Tb_xrayBindingSource.DataMember = "tb_xray"
        Me.Tb_xrayBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Db_cygnetmedDataSet
        '
        Me.Db_cygnetmedDataSet.DataSetName = "db_cygnetmedDataSet"
        Me.Db_cygnetmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(49, 9)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel2.TabIndex = 631
        Me.MetroLabel2.Text = "Date From:"
        '
        'mpnl_left
        '
        Me.mpnl_left.Controls.Add(Me.MetroLabel4)
        Me.mpnl_left.Controls.Add(Me.mcbo_company)
        Me.mpnl_left.Controls.Add(Me.mcbo_print)
        Me.mpnl_left.Controls.Add(Me.MetroLabel3)
        Me.mpnl_left.Controls.Add(Me.mdt_to)
        Me.mpnl_left.Controls.Add(Me.MetroLabel1)
        Me.mpnl_left.Controls.Add(Me.MetroLabel2)
        Me.mpnl_left.Controls.Add(Me.mdt_from)
        Me.mpnl_left.Controls.Add(Me.mtile_remote)
        Me.mpnl_left.Controls.Add(Me.grid_patients)
        Me.mpnl_left.Controls.Add(Me.pnl_hide_logs)
        Me.mpnl_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.mpnl_left.HorizontalScrollbarBarColor = True
        Me.mpnl_left.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_left.HorizontalScrollbarSize = 10
        Me.mpnl_left.Location = New System.Drawing.Point(0, 0)
        Me.mpnl_left.Name = "mpnl_left"
        Me.mpnl_left.Size = New System.Drawing.Size(428, 490)
        Me.mpnl_left.TabIndex = 2
        Me.mpnl_left.VerticalScrollbarBarColor = True
        Me.mpnl_left.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_left.VerticalScrollbarSize = 10
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 37)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel4.TabIndex = 637
        Me.MetroLabel4.Text = "Company:"
        '
        'mcbo_company
        '
        Me.mcbo_company.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcbo_company.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.mcbo_company.FormattingEnabled = True
        Me.mcbo_company.ItemHeight = 19
        Me.mcbo_company.Items.AddRange(New Object() {"BLANK", "FINDINGS", "SUMMARY"})
        Me.mcbo_company.Location = New System.Drawing.Point(78, 37)
        Me.mcbo_company.Name = "mcbo_company"
        Me.mcbo_company.Size = New System.Drawing.Size(338, 25)
        Me.mcbo_company.TabIndex = 636
        Me.mcbo_company.UseSelectable = True
        '
        'mcbo_print
        '
        Me.mcbo_print.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcbo_print.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.mcbo_print.FormattingEnabled = True
        Me.mcbo_print.ItemHeight = 19
        Me.mcbo_print.Items.AddRange(New Object() {"BLANK", "FINDINGS", "SUMMARY", "SUMMARY (COMPANY)"})
        Me.mcbo_print.Location = New System.Drawing.Point(278, 68)
        Me.mcbo_print.Name = "mcbo_print"
        Me.mcbo_print.Size = New System.Drawing.Size(138, 25)
        Me.mcbo_print.TabIndex = 635
        Me.mcbo_print.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(233, 70)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 634
        Me.MetroLabel3.Text = "Print:"
        '
        'mdt_to
        '
        Me.mdt_to.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mdt_to.DisplayFocus = True
        Me.mdt_to.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.mdt_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdt_to.Location = New System.Drawing.Point(291, 6)
        Me.mdt_to.MinimumSize = New System.Drawing.Size(0, 25)
        Me.mdt_to.Name = "mdt_to"
        Me.mdt_to.Size = New System.Drawing.Size(88, 25)
        Me.mdt_to.TabIndex = 633
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(229, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 632
        Me.MetroLabel1.Text = "Date To:"
        '
        'pnl_hide_logs
        '
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_corrl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_activityl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_timestampl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_deptl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_namel)
        Me.pnl_hide_logs.Location = New System.Drawing.Point(202, 235)
        Me.pnl_hide_logs.Name = "pnl_hide_logs"
        Me.pnl_hide_logs.Size = New System.Drawing.Size(37, 23)
        Me.pnl_hide_logs.TabIndex = 638
        '
        'txt_hide_corrl
        '
        Me.txt_hide_corrl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_logsBindingSource, "logs_corr", True))
        Me.txt_hide_corrl.Location = New System.Drawing.Point(18, 124)
        Me.txt_hide_corrl.Name = "txt_hide_corrl"
        Me.txt_hide_corrl.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_corrl.TabIndex = 7
        '
        'Tb_logsBindingSource
        '
        Me.Tb_logsBindingSource.DataMember = "tb_logs"
        Me.Tb_logsBindingSource.DataSource = Me.Db_cygnetmedDataSet
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
        'msm_style
        '
        Me.msm_style.Owner = Me
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tb_doctorsTableAdapter = Nothing
        Me.TableAdapterManager.tb_hmoTableAdapter = Nothing
        Me.TableAdapterManager.tb_infoTableAdapter = Nothing
        Me.TableAdapterManager.tb_labTableAdapter = Nothing
        Me.TableAdapterManager.tb_loginTableAdapter = Nothing
        Me.TableAdapterManager.tb_logsTableAdapter = Nothing
        Me.TableAdapterManager.tb_packageTableAdapter = Nothing
        Me.TableAdapterManager.tb_relTableAdapter = Nothing
        Me.TableAdapterManager.tb_xrayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_xrayTableAdapter
        '
        Me.Tb_xrayTableAdapter.ClearBeforeFill = True
        '
        'Tb_infoBindingSource
        '
        Me.Tb_infoBindingSource.DataMember = "tb_info"
        Me.Tb_infoBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Tb_infoTableAdapter
        '
        Me.Tb_infoTableAdapter.ClearBeforeFill = True
        '
        'xray_reportbindingsource
        '
        Me.xray_reportbindingsource.DataMember = "tb_xray"
        Me.xray_reportbindingsource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Tb_logsTableAdapter
        '
        Me.Tb_logsTableAdapter.ClearBeforeFill = True
        '
        'xray_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 490)
        Me.Controls.Add(Me.xray_viewer)
        Me.Controls.Add(Me.mpnl_left)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "xray_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cygnetmed Health System - Radiology Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_xrayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mpnl_left.ResumeLayout(False)
        Me.mpnl_left.PerformLayout()
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xray_reportbindingsource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents xray_viewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents mdt_from As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents grid_patients As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mpnl_left As MetroFramework.Controls.MetroPanel
    Friend WithEvents mdt_to As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mcbo_print As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Tb_xrayTableAdapter As db_cygnetmedDataSetTableAdapters.tb_xrayTableAdapter
    Friend WithEvents Tb_infoBindingSource As BindingSource
    Friend WithEvents Tb_infoTableAdapter As db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter
    Friend WithEvents xray_reportbindingsource As BindingSource
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcbo_company As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents xray_company As DataGridViewTextBoxColumn
    Friend WithEvents xray_status As DataGridViewTextBoxColumn
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents TransnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tb_xrayBindingSource As BindingSource
End Class
