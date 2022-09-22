<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lab_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lab_report))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.Tb_logsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.Tb_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_infoTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter()
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        Me.Tb_labBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_labTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_labTableAdapter()
        Me.mpnl_left = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mcbo_company = New MetroFramework.Controls.MetroComboBox()
        Me.mcbo_print = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mdt_to = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mdt_from = New MetroFramework.Controls.MetroDateTime()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.grid_patients = New MetroFramework.Controls.MetroGrid()
        Me.transno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lab_company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lab_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lab_medtech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lab_pathologist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_hide_logs = New System.Windows.Forms.Panel()
        Me.txt_hide_corrl = New System.Windows.Forms.TextBox()
        Me.txt_hide_activityl = New System.Windows.Forms.TextBox()
        Me.txt_hide_timestampl = New System.Windows.Forms.TextBox()
        Me.txt_hide_deptl = New System.Windows.Forms.TextBox()
        Me.txt_hide_namel = New System.Windows.Forms.TextBox()
        Me.txt_hide_medtech = New System.Windows.Forms.TextBox()
        Me.Tb_doctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_hide_patho = New System.Windows.Forms.TextBox()
        Me.Tb_doctorsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lab_reportbindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_doctorsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_doctorsTableAdapter()
        Me.lab_viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LabidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabcompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabmedtechDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabpathologistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemahemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemahemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemaerythroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemaleukocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemaesrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemaclotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemableedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemaplateletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemasegmentersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemalymphocytesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemaesoniphilsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemamonocytesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemabasophilsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemahepabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemahepaaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemabloodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabhemaothersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecacolorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecaconsistencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecaoccultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecaascarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecatrichurisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecahookwormDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecaentamoebaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecatrophoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Labfecaothers01DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecawbcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecarbcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecafatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabfecabacteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Labfecaothers02DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburicolorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburitransparencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburispecificDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburiphDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburialbuminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburisugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Laburiothers01DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburiwbcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburirbcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburiepthelialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburimucusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburiuratesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburiphosphatesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburicastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburicrystalsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburibacteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaburipregnancyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Laburiothers02DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcfbsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcbunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbccreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcuriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbccholeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbctriglyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbchdlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcldlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcvldlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbchdlratioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcsgptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcsgotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcsodiumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcpotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbchbaicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabbcothersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabotherstesttitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabotherstestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabotherspatientcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabothersvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabotherscutoffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabothersresultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabtimestampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_labBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mpnl_left.SuspendLayout()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_hide_logs.SuspendLayout()
        CType(Me.Tb_doctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_doctorsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lab_reportbindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Tb_infoBindingSource
        '
        Me.Tb_infoBindingSource.DataMember = "tb_info"
        Me.Tb_infoBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Tb_infoTableAdapter
        '
        Me.Tb_infoTableAdapter.ClearBeforeFill = True
        '
        'Tb_logsTableAdapter
        '
        Me.Tb_logsTableAdapter.ClearBeforeFill = True
        '
        'Tb_labBindingSource
        '
        Me.Tb_labBindingSource.DataMember = "tb_lab"
        Me.Tb_labBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Tb_labTableAdapter
        '
        Me.Tb_labTableAdapter.ClearBeforeFill = True
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
        Me.mpnl_left.Controls.Add(Me.txt_hide_medtech)
        Me.mpnl_left.Controls.Add(Me.txt_hide_patho)
        Me.mpnl_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.mpnl_left.HorizontalScrollbarBarColor = True
        Me.mpnl_left.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_left.HorizontalScrollbarSize = 10
        Me.mpnl_left.Location = New System.Drawing.Point(0, 0)
        Me.mpnl_left.Name = "mpnl_left"
        Me.mpnl_left.Size = New System.Drawing.Size(428, 490)
        Me.mpnl_left.TabIndex = 5
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
        Me.mcbo_print.Items.AddRange(New Object() {"RESULT", "HEMATOLOGY", "FECALYSIS", "URINALYSIS", "BLOOD CHEMISTRY", "OTHERS", "SUMMARY", "SUMMARY (COMPANY)"})
        Me.mcbo_print.Location = New System.Drawing.Point(78, 68)
        Me.mcbo_print.Name = "mcbo_print"
        Me.mcbo_print.Size = New System.Drawing.Size(138, 25)
        Me.mcbo_print.TabIndex = 635
        Me.mcbo_print.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(33, 70)
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
        Me.grid_patients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transno, Me.lab_company, Me.lab_status, Me.lab_medtech, Me.lab_pathologist, Me.LabidDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.PatientnoDataGridViewTextBoxColumn, Me.LabcompanyDataGridViewTextBoxColumn, Me.LabmedtechDataGridViewTextBoxColumn, Me.LabpathologistDataGridViewTextBoxColumn, Me.LabhemahemoDataGridViewTextBoxColumn, Me.LabhemahemaDataGridViewTextBoxColumn, Me.LabhemaerythroDataGridViewTextBoxColumn, Me.LabhemaleukocDataGridViewTextBoxColumn, Me.LabhemaesrDataGridViewTextBoxColumn, Me.LabhemaclotDataGridViewTextBoxColumn, Me.LabhemableedDataGridViewTextBoxColumn, Me.LabhemaplateletDataGridViewTextBoxColumn, Me.LabhemasegmentersDataGridViewTextBoxColumn, Me.LabhemalymphocytesDataGridViewTextBoxColumn, Me.LabhemaesoniphilsDataGridViewTextBoxColumn, Me.LabhemamonocytesDataGridViewTextBoxColumn, Me.LabhemabasophilsDataGridViewTextBoxColumn, Me.LabhemahepabDataGridViewTextBoxColumn, Me.LabhemahepaaDataGridViewTextBoxColumn, Me.LabhemabloodDataGridViewTextBoxColumn, Me.LabhemaothersDataGridViewTextBoxColumn, Me.LabfecacolorDataGridViewTextBoxColumn, Me.LabfecaconsistencyDataGridViewTextBoxColumn, Me.LabfecaoccultDataGridViewTextBoxColumn, Me.LabfecaascarisDataGridViewTextBoxColumn, Me.LabfecatrichurisDataGridViewTextBoxColumn, Me.LabfecahookwormDataGridViewTextBoxColumn, Me.LabfecaentamoebaDataGridViewTextBoxColumn, Me.LabfecatrophoDataGridViewTextBoxColumn, Me.Labfecaothers01DataGridViewTextBoxColumn, Me.LabfecawbcDataGridViewTextBoxColumn, Me.LabfecarbcDataGridViewTextBoxColumn, Me.LabfecafatsDataGridViewTextBoxColumn, Me.LabfecabacteriaDataGridViewTextBoxColumn, Me.Labfecaothers02DataGridViewTextBoxColumn, Me.LaburicolorDataGridViewTextBoxColumn, Me.LaburitransparencyDataGridViewTextBoxColumn, Me.LaburispecificDataGridViewTextBoxColumn, Me.LaburiphDataGridViewTextBoxColumn, Me.LaburialbuminDataGridViewTextBoxColumn, Me.LaburisugarDataGridViewTextBoxColumn, Me.Laburiothers01DataGridViewTextBoxColumn, Me.LaburiwbcDataGridViewTextBoxColumn, Me.LaburirbcDataGridViewTextBoxColumn, Me.LaburiepthelialDataGridViewTextBoxColumn, Me.LaburimucusDataGridViewTextBoxColumn, Me.LaburiuratesDataGridViewTextBoxColumn, Me.LaburiphosphatesDataGridViewTextBoxColumn, Me.LaburicastDataGridViewTextBoxColumn, Me.LaburicrystalsDataGridViewTextBoxColumn, Me.LaburibacteriaDataGridViewTextBoxColumn, Me.LaburipregnancyDataGridViewTextBoxColumn, Me.Laburiothers02DataGridViewTextBoxColumn, Me.LabbcfbsDataGridViewTextBoxColumn, Me.LabbcbunDataGridViewTextBoxColumn, Me.LabbccreaDataGridViewTextBoxColumn, Me.LabbcuriDataGridViewTextBoxColumn, Me.LabbccholeDataGridViewTextBoxColumn, Me.LabbctriglyDataGridViewTextBoxColumn, Me.LabbchdlDataGridViewTextBoxColumn, Me.LabbcldlDataGridViewTextBoxColumn, Me.LabbcvldlDataGridViewTextBoxColumn, Me.LabbchdlratioDataGridViewTextBoxColumn, Me.LabbcsgptDataGridViewTextBoxColumn, Me.LabbcsgotDataGridViewTextBoxColumn, Me.LabbcsodiumDataGridViewTextBoxColumn, Me.LabbcpotaDataGridViewTextBoxColumn, Me.LabbchbaicDataGridViewTextBoxColumn, Me.LabbcothersDataGridViewTextBoxColumn, Me.LabotherstesttitleDataGridViewTextBoxColumn, Me.LabotherstestDataGridViewTextBoxColumn, Me.LabotherspatientcountDataGridViewTextBoxColumn, Me.LabothersvalueDataGridViewTextBoxColumn, Me.LabotherscutoffDataGridViewTextBoxColumn, Me.LabothersresultDataGridViewTextBoxColumn, Me.LabdateDataGridViewTextBoxColumn, Me.LabtimestampDataGridViewTextBoxColumn, Me.LabstatusDataGridViewTextBoxColumn})
        Me.grid_patients.DataSource = Me.Tb_labBindingSource
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
        Me.grid_patients.TabIndex = 642
        '
        'transno
        '
        Me.transno.DataPropertyName = "transno"
        Me.transno.HeaderText = "Case #"
        Me.transno.Name = "transno"
        Me.transno.ReadOnly = True
        '
        'lab_company
        '
        Me.lab_company.DataPropertyName = "lab_company"
        Me.lab_company.HeaderText = "Company"
        Me.lab_company.Name = "lab_company"
        Me.lab_company.ReadOnly = True
        '
        'lab_status
        '
        Me.lab_status.DataPropertyName = "lab_status"
        Me.lab_status.HeaderText = "Status"
        Me.lab_status.Name = "lab_status"
        Me.lab_status.ReadOnly = True
        '
        'lab_medtech
        '
        Me.lab_medtech.DataPropertyName = "lab_medtech"
        Me.lab_medtech.HeaderText = "lab_medtech"
        Me.lab_medtech.Name = "lab_medtech"
        Me.lab_medtech.ReadOnly = True
        Me.lab_medtech.Visible = False
        '
        'lab_pathologist
        '
        Me.lab_pathologist.DataPropertyName = "lab_pathologist"
        Me.lab_pathologist.HeaderText = "lab_pathologist"
        Me.lab_pathologist.Name = "lab_pathologist"
        Me.lab_pathologist.ReadOnly = True
        Me.lab_pathologist.Visible = False
        '
        'pnl_hide_logs
        '
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_corrl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_activityl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_timestampl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_deptl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_namel)
        Me.pnl_hide_logs.Location = New System.Drawing.Point(196, 234)
        Me.pnl_hide_logs.Name = "pnl_hide_logs"
        Me.pnl_hide_logs.Size = New System.Drawing.Size(37, 23)
        Me.pnl_hide_logs.TabIndex = 639
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
        'txt_hide_medtech
        '
        Me.txt_hide_medtech.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_doctorsBindingSource, "doctors_license", True))
        Me.txt_hide_medtech.Location = New System.Drawing.Point(270, 149)
        Me.txt_hide_medtech.Name = "txt_hide_medtech"
        Me.txt_hide_medtech.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_medtech.TabIndex = 641
        '
        'Tb_doctorsBindingSource
        '
        Me.Tb_doctorsBindingSource.DataMember = "tb_doctors"
        Me.Tb_doctorsBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'txt_hide_patho
        '
        Me.txt_hide_patho.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_doctorsBindingSource1, "doctors_license", True))
        Me.txt_hide_patho.Location = New System.Drawing.Point(270, 175)
        Me.txt_hide_patho.Name = "txt_hide_patho"
        Me.txt_hide_patho.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_patho.TabIndex = 640
        '
        'Tb_doctorsBindingSource1
        '
        Me.Tb_doctorsBindingSource1.DataMember = "tb_doctors"
        Me.Tb_doctorsBindingSource1.DataSource = Me.Db_cygnetmedDataSet
        '
        'lab_reportbindingSource
        '
        Me.lab_reportbindingSource.DataMember = "tb_lab"
        Me.lab_reportbindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Tb_doctorsTableAdapter
        '
        Me.Tb_doctorsTableAdapter.ClearBeforeFill = True
        '
        'lab_viewer
        '
        Me.lab_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lab_viewer.LocalReport.EnableExternalImages = True
        Me.lab_viewer.LocalReport.EnableHyperlinks = True
        Me.lab_viewer.Location = New System.Drawing.Point(428, 0)
        Me.lab_viewer.Name = "lab_viewer"
        Me.lab_viewer.ServerReport.BearerToken = Nothing
        Me.lab_viewer.Size = New System.Drawing.Size(523, 490)
        Me.lab_viewer.TabIndex = 6
        '
        'LabidDataGridViewTextBoxColumn
        '
        Me.LabidDataGridViewTextBoxColumn.DataPropertyName = "lab_id"
        Me.LabidDataGridViewTextBoxColumn.HeaderText = "lab_id"
        Me.LabidDataGridViewTextBoxColumn.Name = "LabidDataGridViewTextBoxColumn"
        Me.LabidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "transno"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "transno"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientnoDataGridViewTextBoxColumn
        '
        Me.PatientnoDataGridViewTextBoxColumn.DataPropertyName = "patientno"
        Me.PatientnoDataGridViewTextBoxColumn.HeaderText = "patientno"
        Me.PatientnoDataGridViewTextBoxColumn.Name = "PatientnoDataGridViewTextBoxColumn"
        Me.PatientnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabcompanyDataGridViewTextBoxColumn
        '
        Me.LabcompanyDataGridViewTextBoxColumn.DataPropertyName = "lab_company"
        Me.LabcompanyDataGridViewTextBoxColumn.HeaderText = "lab_company"
        Me.LabcompanyDataGridViewTextBoxColumn.Name = "LabcompanyDataGridViewTextBoxColumn"
        Me.LabcompanyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabmedtechDataGridViewTextBoxColumn
        '
        Me.LabmedtechDataGridViewTextBoxColumn.DataPropertyName = "lab_medtech"
        Me.LabmedtechDataGridViewTextBoxColumn.HeaderText = "lab_medtech"
        Me.LabmedtechDataGridViewTextBoxColumn.Name = "LabmedtechDataGridViewTextBoxColumn"
        Me.LabmedtechDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabpathologistDataGridViewTextBoxColumn
        '
        Me.LabpathologistDataGridViewTextBoxColumn.DataPropertyName = "lab_pathologist"
        Me.LabpathologistDataGridViewTextBoxColumn.HeaderText = "lab_pathologist"
        Me.LabpathologistDataGridViewTextBoxColumn.Name = "LabpathologistDataGridViewTextBoxColumn"
        Me.LabpathologistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemahemoDataGridViewTextBoxColumn
        '
        Me.LabhemahemoDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_hemo"
        Me.LabhemahemoDataGridViewTextBoxColumn.HeaderText = "lab_hema_hemo"
        Me.LabhemahemoDataGridViewTextBoxColumn.Name = "LabhemahemoDataGridViewTextBoxColumn"
        Me.LabhemahemoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemahemaDataGridViewTextBoxColumn
        '
        Me.LabhemahemaDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_hema"
        Me.LabhemahemaDataGridViewTextBoxColumn.HeaderText = "lab_hema_hema"
        Me.LabhemahemaDataGridViewTextBoxColumn.Name = "LabhemahemaDataGridViewTextBoxColumn"
        Me.LabhemahemaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemaerythroDataGridViewTextBoxColumn
        '
        Me.LabhemaerythroDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_erythro"
        Me.LabhemaerythroDataGridViewTextBoxColumn.HeaderText = "lab_hema_erythro"
        Me.LabhemaerythroDataGridViewTextBoxColumn.Name = "LabhemaerythroDataGridViewTextBoxColumn"
        Me.LabhemaerythroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemaleukocDataGridViewTextBoxColumn
        '
        Me.LabhemaleukocDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_leukoc"
        Me.LabhemaleukocDataGridViewTextBoxColumn.HeaderText = "lab_hema_leukoc"
        Me.LabhemaleukocDataGridViewTextBoxColumn.Name = "LabhemaleukocDataGridViewTextBoxColumn"
        Me.LabhemaleukocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemaesrDataGridViewTextBoxColumn
        '
        Me.LabhemaesrDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_esr"
        Me.LabhemaesrDataGridViewTextBoxColumn.HeaderText = "lab_hema_esr"
        Me.LabhemaesrDataGridViewTextBoxColumn.Name = "LabhemaesrDataGridViewTextBoxColumn"
        Me.LabhemaesrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemaclotDataGridViewTextBoxColumn
        '
        Me.LabhemaclotDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_clot"
        Me.LabhemaclotDataGridViewTextBoxColumn.HeaderText = "lab_hema_clot"
        Me.LabhemaclotDataGridViewTextBoxColumn.Name = "LabhemaclotDataGridViewTextBoxColumn"
        Me.LabhemaclotDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemableedDataGridViewTextBoxColumn
        '
        Me.LabhemableedDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_bleed"
        Me.LabhemableedDataGridViewTextBoxColumn.HeaderText = "lab_hema_bleed"
        Me.LabhemableedDataGridViewTextBoxColumn.Name = "LabhemableedDataGridViewTextBoxColumn"
        Me.LabhemableedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemaplateletDataGridViewTextBoxColumn
        '
        Me.LabhemaplateletDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_platelet"
        Me.LabhemaplateletDataGridViewTextBoxColumn.HeaderText = "lab_hema_platelet"
        Me.LabhemaplateletDataGridViewTextBoxColumn.Name = "LabhemaplateletDataGridViewTextBoxColumn"
        Me.LabhemaplateletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemasegmentersDataGridViewTextBoxColumn
        '
        Me.LabhemasegmentersDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_segmenters"
        Me.LabhemasegmentersDataGridViewTextBoxColumn.HeaderText = "lab_hema_segmenters"
        Me.LabhemasegmentersDataGridViewTextBoxColumn.Name = "LabhemasegmentersDataGridViewTextBoxColumn"
        Me.LabhemasegmentersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemalymphocytesDataGridViewTextBoxColumn
        '
        Me.LabhemalymphocytesDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_lymphocytes"
        Me.LabhemalymphocytesDataGridViewTextBoxColumn.HeaderText = "lab_hema_lymphocytes"
        Me.LabhemalymphocytesDataGridViewTextBoxColumn.Name = "LabhemalymphocytesDataGridViewTextBoxColumn"
        Me.LabhemalymphocytesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemaesoniphilsDataGridViewTextBoxColumn
        '
        Me.LabhemaesoniphilsDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_esoniphils"
        Me.LabhemaesoniphilsDataGridViewTextBoxColumn.HeaderText = "lab_hema_esoniphils"
        Me.LabhemaesoniphilsDataGridViewTextBoxColumn.Name = "LabhemaesoniphilsDataGridViewTextBoxColumn"
        Me.LabhemaesoniphilsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemamonocytesDataGridViewTextBoxColumn
        '
        Me.LabhemamonocytesDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_monocytes"
        Me.LabhemamonocytesDataGridViewTextBoxColumn.HeaderText = "lab_hema_monocytes"
        Me.LabhemamonocytesDataGridViewTextBoxColumn.Name = "LabhemamonocytesDataGridViewTextBoxColumn"
        Me.LabhemamonocytesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemabasophilsDataGridViewTextBoxColumn
        '
        Me.LabhemabasophilsDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_basophils"
        Me.LabhemabasophilsDataGridViewTextBoxColumn.HeaderText = "lab_hema_basophils"
        Me.LabhemabasophilsDataGridViewTextBoxColumn.Name = "LabhemabasophilsDataGridViewTextBoxColumn"
        Me.LabhemabasophilsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemahepabDataGridViewTextBoxColumn
        '
        Me.LabhemahepabDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_hepab"
        Me.LabhemahepabDataGridViewTextBoxColumn.HeaderText = "lab_hema_hepab"
        Me.LabhemahepabDataGridViewTextBoxColumn.Name = "LabhemahepabDataGridViewTextBoxColumn"
        Me.LabhemahepabDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemahepaaDataGridViewTextBoxColumn
        '
        Me.LabhemahepaaDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_hepaa"
        Me.LabhemahepaaDataGridViewTextBoxColumn.HeaderText = "lab_hema_hepaa"
        Me.LabhemahepaaDataGridViewTextBoxColumn.Name = "LabhemahepaaDataGridViewTextBoxColumn"
        Me.LabhemahepaaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemabloodDataGridViewTextBoxColumn
        '
        Me.LabhemabloodDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_blood"
        Me.LabhemabloodDataGridViewTextBoxColumn.HeaderText = "lab_hema_blood"
        Me.LabhemabloodDataGridViewTextBoxColumn.Name = "LabhemabloodDataGridViewTextBoxColumn"
        Me.LabhemabloodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabhemaothersDataGridViewTextBoxColumn
        '
        Me.LabhemaothersDataGridViewTextBoxColumn.DataPropertyName = "lab_hema_others"
        Me.LabhemaothersDataGridViewTextBoxColumn.HeaderText = "lab_hema_others"
        Me.LabhemaothersDataGridViewTextBoxColumn.Name = "LabhemaothersDataGridViewTextBoxColumn"
        Me.LabhemaothersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecacolorDataGridViewTextBoxColumn
        '
        Me.LabfecacolorDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_color"
        Me.LabfecacolorDataGridViewTextBoxColumn.HeaderText = "lab_feca_color"
        Me.LabfecacolorDataGridViewTextBoxColumn.Name = "LabfecacolorDataGridViewTextBoxColumn"
        Me.LabfecacolorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecaconsistencyDataGridViewTextBoxColumn
        '
        Me.LabfecaconsistencyDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_consistency"
        Me.LabfecaconsistencyDataGridViewTextBoxColumn.HeaderText = "lab_feca_consistency"
        Me.LabfecaconsistencyDataGridViewTextBoxColumn.Name = "LabfecaconsistencyDataGridViewTextBoxColumn"
        Me.LabfecaconsistencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecaoccultDataGridViewTextBoxColumn
        '
        Me.LabfecaoccultDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_occult"
        Me.LabfecaoccultDataGridViewTextBoxColumn.HeaderText = "lab_feca_occult"
        Me.LabfecaoccultDataGridViewTextBoxColumn.Name = "LabfecaoccultDataGridViewTextBoxColumn"
        Me.LabfecaoccultDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecaascarisDataGridViewTextBoxColumn
        '
        Me.LabfecaascarisDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_ascaris"
        Me.LabfecaascarisDataGridViewTextBoxColumn.HeaderText = "lab_feca_ascaris"
        Me.LabfecaascarisDataGridViewTextBoxColumn.Name = "LabfecaascarisDataGridViewTextBoxColumn"
        Me.LabfecaascarisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecatrichurisDataGridViewTextBoxColumn
        '
        Me.LabfecatrichurisDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_trichuris"
        Me.LabfecatrichurisDataGridViewTextBoxColumn.HeaderText = "lab_feca_trichuris"
        Me.LabfecatrichurisDataGridViewTextBoxColumn.Name = "LabfecatrichurisDataGridViewTextBoxColumn"
        Me.LabfecatrichurisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecahookwormDataGridViewTextBoxColumn
        '
        Me.LabfecahookwormDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_hookworm"
        Me.LabfecahookwormDataGridViewTextBoxColumn.HeaderText = "lab_feca_hookworm"
        Me.LabfecahookwormDataGridViewTextBoxColumn.Name = "LabfecahookwormDataGridViewTextBoxColumn"
        Me.LabfecahookwormDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecaentamoebaDataGridViewTextBoxColumn
        '
        Me.LabfecaentamoebaDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_entamoeba"
        Me.LabfecaentamoebaDataGridViewTextBoxColumn.HeaderText = "lab_feca_entamoeba"
        Me.LabfecaentamoebaDataGridViewTextBoxColumn.Name = "LabfecaentamoebaDataGridViewTextBoxColumn"
        Me.LabfecaentamoebaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecatrophoDataGridViewTextBoxColumn
        '
        Me.LabfecatrophoDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_tropho"
        Me.LabfecatrophoDataGridViewTextBoxColumn.HeaderText = "lab_feca_tropho"
        Me.LabfecatrophoDataGridViewTextBoxColumn.Name = "LabfecatrophoDataGridViewTextBoxColumn"
        Me.LabfecatrophoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Labfecaothers01DataGridViewTextBoxColumn
        '
        Me.Labfecaothers01DataGridViewTextBoxColumn.DataPropertyName = "lab_feca_others_01"
        Me.Labfecaothers01DataGridViewTextBoxColumn.HeaderText = "lab_feca_others_01"
        Me.Labfecaothers01DataGridViewTextBoxColumn.Name = "Labfecaothers01DataGridViewTextBoxColumn"
        Me.Labfecaothers01DataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecawbcDataGridViewTextBoxColumn
        '
        Me.LabfecawbcDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_wbc"
        Me.LabfecawbcDataGridViewTextBoxColumn.HeaderText = "lab_feca_wbc"
        Me.LabfecawbcDataGridViewTextBoxColumn.Name = "LabfecawbcDataGridViewTextBoxColumn"
        Me.LabfecawbcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecarbcDataGridViewTextBoxColumn
        '
        Me.LabfecarbcDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_rbc"
        Me.LabfecarbcDataGridViewTextBoxColumn.HeaderText = "lab_feca_rbc"
        Me.LabfecarbcDataGridViewTextBoxColumn.Name = "LabfecarbcDataGridViewTextBoxColumn"
        Me.LabfecarbcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecafatsDataGridViewTextBoxColumn
        '
        Me.LabfecafatsDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_fats"
        Me.LabfecafatsDataGridViewTextBoxColumn.HeaderText = "lab_feca_fats"
        Me.LabfecafatsDataGridViewTextBoxColumn.Name = "LabfecafatsDataGridViewTextBoxColumn"
        Me.LabfecafatsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabfecabacteriaDataGridViewTextBoxColumn
        '
        Me.LabfecabacteriaDataGridViewTextBoxColumn.DataPropertyName = "lab_feca_bacteria"
        Me.LabfecabacteriaDataGridViewTextBoxColumn.HeaderText = "lab_feca_bacteria"
        Me.LabfecabacteriaDataGridViewTextBoxColumn.Name = "LabfecabacteriaDataGridViewTextBoxColumn"
        Me.LabfecabacteriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Labfecaothers02DataGridViewTextBoxColumn
        '
        Me.Labfecaothers02DataGridViewTextBoxColumn.DataPropertyName = "lab_feca_others_02"
        Me.Labfecaothers02DataGridViewTextBoxColumn.HeaderText = "lab_feca_others_02"
        Me.Labfecaothers02DataGridViewTextBoxColumn.Name = "Labfecaothers02DataGridViewTextBoxColumn"
        Me.Labfecaothers02DataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburicolorDataGridViewTextBoxColumn
        '
        Me.LaburicolorDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_color"
        Me.LaburicolorDataGridViewTextBoxColumn.HeaderText = "lab_uri_color"
        Me.LaburicolorDataGridViewTextBoxColumn.Name = "LaburicolorDataGridViewTextBoxColumn"
        Me.LaburicolorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburitransparencyDataGridViewTextBoxColumn
        '
        Me.LaburitransparencyDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_transparency"
        Me.LaburitransparencyDataGridViewTextBoxColumn.HeaderText = "lab_uri_transparency"
        Me.LaburitransparencyDataGridViewTextBoxColumn.Name = "LaburitransparencyDataGridViewTextBoxColumn"
        Me.LaburitransparencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburispecificDataGridViewTextBoxColumn
        '
        Me.LaburispecificDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_specific"
        Me.LaburispecificDataGridViewTextBoxColumn.HeaderText = "lab_uri_specific"
        Me.LaburispecificDataGridViewTextBoxColumn.Name = "LaburispecificDataGridViewTextBoxColumn"
        Me.LaburispecificDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburiphDataGridViewTextBoxColumn
        '
        Me.LaburiphDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_ph"
        Me.LaburiphDataGridViewTextBoxColumn.HeaderText = "lab_uri_ph"
        Me.LaburiphDataGridViewTextBoxColumn.Name = "LaburiphDataGridViewTextBoxColumn"
        Me.LaburiphDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburialbuminDataGridViewTextBoxColumn
        '
        Me.LaburialbuminDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_albumin"
        Me.LaburialbuminDataGridViewTextBoxColumn.HeaderText = "lab_uri_albumin"
        Me.LaburialbuminDataGridViewTextBoxColumn.Name = "LaburialbuminDataGridViewTextBoxColumn"
        Me.LaburialbuminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburisugarDataGridViewTextBoxColumn
        '
        Me.LaburisugarDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_sugar"
        Me.LaburisugarDataGridViewTextBoxColumn.HeaderText = "lab_uri_sugar"
        Me.LaburisugarDataGridViewTextBoxColumn.Name = "LaburisugarDataGridViewTextBoxColumn"
        Me.LaburisugarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Laburiothers01DataGridViewTextBoxColumn
        '
        Me.Laburiothers01DataGridViewTextBoxColumn.DataPropertyName = "lab_uri_others_01"
        Me.Laburiothers01DataGridViewTextBoxColumn.HeaderText = "lab_uri_others_01"
        Me.Laburiothers01DataGridViewTextBoxColumn.Name = "Laburiothers01DataGridViewTextBoxColumn"
        Me.Laburiothers01DataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburiwbcDataGridViewTextBoxColumn
        '
        Me.LaburiwbcDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_wbc"
        Me.LaburiwbcDataGridViewTextBoxColumn.HeaderText = "lab_uri_wbc"
        Me.LaburiwbcDataGridViewTextBoxColumn.Name = "LaburiwbcDataGridViewTextBoxColumn"
        Me.LaburiwbcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburirbcDataGridViewTextBoxColumn
        '
        Me.LaburirbcDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_rbc"
        Me.LaburirbcDataGridViewTextBoxColumn.HeaderText = "lab_uri_rbc"
        Me.LaburirbcDataGridViewTextBoxColumn.Name = "LaburirbcDataGridViewTextBoxColumn"
        Me.LaburirbcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburiepthelialDataGridViewTextBoxColumn
        '
        Me.LaburiepthelialDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_epthelial"
        Me.LaburiepthelialDataGridViewTextBoxColumn.HeaderText = "lab_uri_epthelial"
        Me.LaburiepthelialDataGridViewTextBoxColumn.Name = "LaburiepthelialDataGridViewTextBoxColumn"
        Me.LaburiepthelialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburimucusDataGridViewTextBoxColumn
        '
        Me.LaburimucusDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_mucus"
        Me.LaburimucusDataGridViewTextBoxColumn.HeaderText = "lab_uri_mucus"
        Me.LaburimucusDataGridViewTextBoxColumn.Name = "LaburimucusDataGridViewTextBoxColumn"
        Me.LaburimucusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburiuratesDataGridViewTextBoxColumn
        '
        Me.LaburiuratesDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_urates"
        Me.LaburiuratesDataGridViewTextBoxColumn.HeaderText = "lab_uri_urates"
        Me.LaburiuratesDataGridViewTextBoxColumn.Name = "LaburiuratesDataGridViewTextBoxColumn"
        Me.LaburiuratesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburiphosphatesDataGridViewTextBoxColumn
        '
        Me.LaburiphosphatesDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_phosphates"
        Me.LaburiphosphatesDataGridViewTextBoxColumn.HeaderText = "lab_uri_phosphates"
        Me.LaburiphosphatesDataGridViewTextBoxColumn.Name = "LaburiphosphatesDataGridViewTextBoxColumn"
        Me.LaburiphosphatesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburicastDataGridViewTextBoxColumn
        '
        Me.LaburicastDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_cast"
        Me.LaburicastDataGridViewTextBoxColumn.HeaderText = "lab_uri_cast"
        Me.LaburicastDataGridViewTextBoxColumn.Name = "LaburicastDataGridViewTextBoxColumn"
        Me.LaburicastDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburicrystalsDataGridViewTextBoxColumn
        '
        Me.LaburicrystalsDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_crystals"
        Me.LaburicrystalsDataGridViewTextBoxColumn.HeaderText = "lab_uri_crystals"
        Me.LaburicrystalsDataGridViewTextBoxColumn.Name = "LaburicrystalsDataGridViewTextBoxColumn"
        Me.LaburicrystalsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburibacteriaDataGridViewTextBoxColumn
        '
        Me.LaburibacteriaDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_bacteria"
        Me.LaburibacteriaDataGridViewTextBoxColumn.HeaderText = "lab_uri_bacteria"
        Me.LaburibacteriaDataGridViewTextBoxColumn.Name = "LaburibacteriaDataGridViewTextBoxColumn"
        Me.LaburibacteriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaburipregnancyDataGridViewTextBoxColumn
        '
        Me.LaburipregnancyDataGridViewTextBoxColumn.DataPropertyName = "lab_uri_pregnancy"
        Me.LaburipregnancyDataGridViewTextBoxColumn.HeaderText = "lab_uri_pregnancy"
        Me.LaburipregnancyDataGridViewTextBoxColumn.Name = "LaburipregnancyDataGridViewTextBoxColumn"
        Me.LaburipregnancyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Laburiothers02DataGridViewTextBoxColumn
        '
        Me.Laburiothers02DataGridViewTextBoxColumn.DataPropertyName = "lab_uri_others_02"
        Me.Laburiothers02DataGridViewTextBoxColumn.HeaderText = "lab_uri_others_02"
        Me.Laburiothers02DataGridViewTextBoxColumn.Name = "Laburiothers02DataGridViewTextBoxColumn"
        Me.Laburiothers02DataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcfbsDataGridViewTextBoxColumn
        '
        Me.LabbcfbsDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_fbs"
        Me.LabbcfbsDataGridViewTextBoxColumn.HeaderText = "lab_bc_fbs"
        Me.LabbcfbsDataGridViewTextBoxColumn.Name = "LabbcfbsDataGridViewTextBoxColumn"
        Me.LabbcfbsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcbunDataGridViewTextBoxColumn
        '
        Me.LabbcbunDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_bun"
        Me.LabbcbunDataGridViewTextBoxColumn.HeaderText = "lab_bc_bun"
        Me.LabbcbunDataGridViewTextBoxColumn.Name = "LabbcbunDataGridViewTextBoxColumn"
        Me.LabbcbunDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbccreaDataGridViewTextBoxColumn
        '
        Me.LabbccreaDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_crea"
        Me.LabbccreaDataGridViewTextBoxColumn.HeaderText = "lab_bc_crea"
        Me.LabbccreaDataGridViewTextBoxColumn.Name = "LabbccreaDataGridViewTextBoxColumn"
        Me.LabbccreaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcuriDataGridViewTextBoxColumn
        '
        Me.LabbcuriDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_uri"
        Me.LabbcuriDataGridViewTextBoxColumn.HeaderText = "lab_bc_uri"
        Me.LabbcuriDataGridViewTextBoxColumn.Name = "LabbcuriDataGridViewTextBoxColumn"
        Me.LabbcuriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbccholeDataGridViewTextBoxColumn
        '
        Me.LabbccholeDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_chole"
        Me.LabbccholeDataGridViewTextBoxColumn.HeaderText = "lab_bc_chole"
        Me.LabbccholeDataGridViewTextBoxColumn.Name = "LabbccholeDataGridViewTextBoxColumn"
        Me.LabbccholeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbctriglyDataGridViewTextBoxColumn
        '
        Me.LabbctriglyDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_trigly"
        Me.LabbctriglyDataGridViewTextBoxColumn.HeaderText = "lab_bc_trigly"
        Me.LabbctriglyDataGridViewTextBoxColumn.Name = "LabbctriglyDataGridViewTextBoxColumn"
        Me.LabbctriglyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbchdlDataGridViewTextBoxColumn
        '
        Me.LabbchdlDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_hdl"
        Me.LabbchdlDataGridViewTextBoxColumn.HeaderText = "lab_bc_hdl"
        Me.LabbchdlDataGridViewTextBoxColumn.Name = "LabbchdlDataGridViewTextBoxColumn"
        Me.LabbchdlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcldlDataGridViewTextBoxColumn
        '
        Me.LabbcldlDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_ldl"
        Me.LabbcldlDataGridViewTextBoxColumn.HeaderText = "lab_bc_ldl"
        Me.LabbcldlDataGridViewTextBoxColumn.Name = "LabbcldlDataGridViewTextBoxColumn"
        Me.LabbcldlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcvldlDataGridViewTextBoxColumn
        '
        Me.LabbcvldlDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_vldl"
        Me.LabbcvldlDataGridViewTextBoxColumn.HeaderText = "lab_bc_vldl"
        Me.LabbcvldlDataGridViewTextBoxColumn.Name = "LabbcvldlDataGridViewTextBoxColumn"
        Me.LabbcvldlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbchdlratioDataGridViewTextBoxColumn
        '
        Me.LabbchdlratioDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_hdlratio"
        Me.LabbchdlratioDataGridViewTextBoxColumn.HeaderText = "lab_bc_hdlratio"
        Me.LabbchdlratioDataGridViewTextBoxColumn.Name = "LabbchdlratioDataGridViewTextBoxColumn"
        Me.LabbchdlratioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcsgptDataGridViewTextBoxColumn
        '
        Me.LabbcsgptDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_sgpt"
        Me.LabbcsgptDataGridViewTextBoxColumn.HeaderText = "lab_bc_sgpt"
        Me.LabbcsgptDataGridViewTextBoxColumn.Name = "LabbcsgptDataGridViewTextBoxColumn"
        Me.LabbcsgptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcsgotDataGridViewTextBoxColumn
        '
        Me.LabbcsgotDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_sgot"
        Me.LabbcsgotDataGridViewTextBoxColumn.HeaderText = "lab_bc_sgot"
        Me.LabbcsgotDataGridViewTextBoxColumn.Name = "LabbcsgotDataGridViewTextBoxColumn"
        Me.LabbcsgotDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcsodiumDataGridViewTextBoxColumn
        '
        Me.LabbcsodiumDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_sodium"
        Me.LabbcsodiumDataGridViewTextBoxColumn.HeaderText = "lab_bc_sodium"
        Me.LabbcsodiumDataGridViewTextBoxColumn.Name = "LabbcsodiumDataGridViewTextBoxColumn"
        Me.LabbcsodiumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcpotaDataGridViewTextBoxColumn
        '
        Me.LabbcpotaDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_pota"
        Me.LabbcpotaDataGridViewTextBoxColumn.HeaderText = "lab_bc_pota"
        Me.LabbcpotaDataGridViewTextBoxColumn.Name = "LabbcpotaDataGridViewTextBoxColumn"
        Me.LabbcpotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbchbaicDataGridViewTextBoxColumn
        '
        Me.LabbchbaicDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_hbaic"
        Me.LabbchbaicDataGridViewTextBoxColumn.HeaderText = "lab_bc_hbaic"
        Me.LabbchbaicDataGridViewTextBoxColumn.Name = "LabbchbaicDataGridViewTextBoxColumn"
        Me.LabbchbaicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabbcothersDataGridViewTextBoxColumn
        '
        Me.LabbcothersDataGridViewTextBoxColumn.DataPropertyName = "lab_bc_others"
        Me.LabbcothersDataGridViewTextBoxColumn.HeaderText = "lab_bc_others"
        Me.LabbcothersDataGridViewTextBoxColumn.Name = "LabbcothersDataGridViewTextBoxColumn"
        Me.LabbcothersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabotherstesttitleDataGridViewTextBoxColumn
        '
        Me.LabotherstesttitleDataGridViewTextBoxColumn.DataPropertyName = "lab_others_testtitle"
        Me.LabotherstesttitleDataGridViewTextBoxColumn.HeaderText = "lab_others_testtitle"
        Me.LabotherstesttitleDataGridViewTextBoxColumn.Name = "LabotherstesttitleDataGridViewTextBoxColumn"
        Me.LabotherstesttitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabotherstestDataGridViewTextBoxColumn
        '
        Me.LabotherstestDataGridViewTextBoxColumn.DataPropertyName = "lab_others_test"
        Me.LabotherstestDataGridViewTextBoxColumn.HeaderText = "lab_others_test"
        Me.LabotherstestDataGridViewTextBoxColumn.Name = "LabotherstestDataGridViewTextBoxColumn"
        Me.LabotherstestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabotherspatientcountDataGridViewTextBoxColumn
        '
        Me.LabotherspatientcountDataGridViewTextBoxColumn.DataPropertyName = "lab_others_patientcount"
        Me.LabotherspatientcountDataGridViewTextBoxColumn.HeaderText = "lab_others_patientcount"
        Me.LabotherspatientcountDataGridViewTextBoxColumn.Name = "LabotherspatientcountDataGridViewTextBoxColumn"
        Me.LabotherspatientcountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabothersvalueDataGridViewTextBoxColumn
        '
        Me.LabothersvalueDataGridViewTextBoxColumn.DataPropertyName = "lab_others_value"
        Me.LabothersvalueDataGridViewTextBoxColumn.HeaderText = "lab_others_value"
        Me.LabothersvalueDataGridViewTextBoxColumn.Name = "LabothersvalueDataGridViewTextBoxColumn"
        Me.LabothersvalueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabotherscutoffDataGridViewTextBoxColumn
        '
        Me.LabotherscutoffDataGridViewTextBoxColumn.DataPropertyName = "lab_others_cutoff"
        Me.LabotherscutoffDataGridViewTextBoxColumn.HeaderText = "lab_others_cutoff"
        Me.LabotherscutoffDataGridViewTextBoxColumn.Name = "LabotherscutoffDataGridViewTextBoxColumn"
        Me.LabotherscutoffDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabothersresultDataGridViewTextBoxColumn
        '
        Me.LabothersresultDataGridViewTextBoxColumn.DataPropertyName = "lab_others_result"
        Me.LabothersresultDataGridViewTextBoxColumn.HeaderText = "lab_others_result"
        Me.LabothersresultDataGridViewTextBoxColumn.Name = "LabothersresultDataGridViewTextBoxColumn"
        Me.LabothersresultDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabdateDataGridViewTextBoxColumn
        '
        Me.LabdateDataGridViewTextBoxColumn.DataPropertyName = "lab_date"
        Me.LabdateDataGridViewTextBoxColumn.HeaderText = "lab_date"
        Me.LabdateDataGridViewTextBoxColumn.Name = "LabdateDataGridViewTextBoxColumn"
        Me.LabdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabtimestampDataGridViewTextBoxColumn
        '
        Me.LabtimestampDataGridViewTextBoxColumn.DataPropertyName = "lab_timestamp"
        Me.LabtimestampDataGridViewTextBoxColumn.HeaderText = "lab_timestamp"
        Me.LabtimestampDataGridViewTextBoxColumn.Name = "LabtimestampDataGridViewTextBoxColumn"
        Me.LabtimestampDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LabstatusDataGridViewTextBoxColumn
        '
        Me.LabstatusDataGridViewTextBoxColumn.DataPropertyName = "lab_status"
        Me.LabstatusDataGridViewTextBoxColumn.HeaderText = "lab_status"
        Me.LabstatusDataGridViewTextBoxColumn.Name = "LabstatusDataGridViewTextBoxColumn"
        Me.LabstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'lab_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 490)
        Me.Controls.Add(Me.lab_viewer)
        Me.Controls.Add(Me.mpnl_left)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "lab_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cygnetmed Health System - Laboratory Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_labBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mpnl_left.ResumeLayout(False)
        Me.mpnl_left.PerformLayout()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        CType(Me.Tb_doctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_doctorsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lab_reportbindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_infoBindingSource As BindingSource
    Friend WithEvents Tb_infoTableAdapter As db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents Tb_labBindingSource As BindingSource
    Friend WithEvents Tb_labTableAdapter As db_cygnetmedDataSetTableAdapters.tb_labTableAdapter
    Friend WithEvents mpnl_left As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcbo_company As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mcbo_print As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mdt_to As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mdt_from As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents lab_reportbindingSource As BindingSource
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents Tb_doctorsBindingSource As BindingSource
    Friend WithEvents Tb_doctorsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_doctorsTableAdapter
    Friend WithEvents lab_viewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tb_doctorsBindingSource1 As BindingSource
    Friend WithEvents txt_hide_medtech As TextBox
    Friend WithEvents txt_hide_patho As TextBox
    Friend WithEvents grid_patients As MetroFramework.Controls.MetroGrid
    Friend WithEvents transno As DataGridViewTextBoxColumn
    Friend WithEvents lab_company As DataGridViewTextBoxColumn
    Friend WithEvents lab_status As DataGridViewTextBoxColumn
    Friend WithEvents lab_medtech As DataGridViewTextBoxColumn
    Friend WithEvents lab_pathologist As DataGridViewTextBoxColumn
    Friend WithEvents LabidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabcompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabmedtechDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabpathologistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemahemoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemahemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemaerythroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemaleukocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemaesrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemaclotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemableedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemaplateletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemasegmentersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemalymphocytesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemaesoniphilsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemamonocytesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemabasophilsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemahepabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemahepaaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemabloodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabhemaothersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecacolorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecaconsistencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecaoccultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecaascarisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecatrichurisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecahookwormDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecaentamoebaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecatrophoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Labfecaothers01DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecawbcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecarbcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecafatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabfecabacteriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Labfecaothers02DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburicolorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburitransparencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburispecificDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburiphDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburialbuminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburisugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Laburiothers01DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburiwbcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburirbcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburiepthelialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburimucusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburiuratesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburiphosphatesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburicastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburicrystalsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburibacteriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaburipregnancyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Laburiothers02DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcfbsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcbunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbccreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcuriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbccholeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbctriglyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbchdlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcldlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcvldlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbchdlratioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcsgptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcsgotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcsodiumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcpotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbchbaicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabbcothersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabotherstesttitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabotherstestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabotherspatientcountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabothersvalueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabotherscutoffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabothersresultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabtimestampDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
