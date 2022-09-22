<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_package
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info_package))
        Me.grid_packages = New MetroFramework.Controls.MetroGrid()
        Me.PackagecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageprocedureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackagecompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackagepriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_xray = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_lab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_hema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_feca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_uri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_blood = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_others = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_noe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_pe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package_timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tb_packageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.Tb_packageTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_packageTableAdapter()
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.mtxt_search = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_company = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.mtxt_code = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_procedure = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_price = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_radio = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_lab = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_feca = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_hema = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_blood = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_uri = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_others = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_consult = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_walkin = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_pre = New MetroFramework.Controls.MetroCheckBox()
        Me.mcb_annual = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_pe = New MetroFramework.Controls.MetroCheckBox()
        Me.mbtn_save = New MetroFramework.Controls.MetroButton()
        Me.mbtn_add = New MetroFramework.Controls.MetroButton()
        Me.Tb_logsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        Me.pnl_hide_logs = New System.Windows.Forms.Panel()
        Me.txt_hide_corrl = New System.Windows.Forms.TextBox()
        Me.txt_hide_activityl = New System.Windows.Forms.TextBox()
        Me.txt_hide_timestampl = New System.Windows.Forms.TextBox()
        Me.txt_hide_deptl = New System.Windows.Forms.TextBox()
        Me.txt_hide_namel = New System.Windows.Forms.TextBox()
        Me.bmbtn_delete = New MetroFramework.Controls.MetroButton()
        CType(Me.grid_packages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_packageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_hide_logs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_packages
        '
        Me.grid_packages.AllowUserToAddRows = False
        Me.grid_packages.AllowUserToDeleteRows = False
        Me.grid_packages.AllowUserToResizeRows = False
        Me.grid_packages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_packages.AutoGenerateColumns = False
        Me.grid_packages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_packages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_packages.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_packages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_packages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_packages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_packages.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_packages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_packages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackagecodeDataGridViewTextBoxColumn, Me.PackageprocedureDataGridViewTextBoxColumn, Me.PackagecompanyDataGridViewTextBoxColumn, Me.PackagepriceDataGridViewTextBoxColumn, Me.package_xray, Me.package_lab, Me.package_hema, Me.package_feca, Me.package_uri, Me.package_blood, Me.package_others, Me.package_noe, Me.package_pe, Me.package_timestamp})
        Me.grid_packages.DataSource = Me.Tb_packageBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_packages.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_packages.EnableHeadersVisualStyles = False
        Me.grid_packages.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_packages.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_packages.Location = New System.Drawing.Point(11, 44)
        Me.grid_packages.MultiSelect = False
        Me.grid_packages.Name = "grid_packages"
        Me.grid_packages.ReadOnly = True
        Me.grid_packages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_packages.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_packages.RowHeadersVisible = False
        Me.grid_packages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_packages.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_packages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_packages.Size = New System.Drawing.Size(373, 423)
        Me.grid_packages.TabIndex = 558
        '
        'PackagecodeDataGridViewTextBoxColumn
        '
        Me.PackagecodeDataGridViewTextBoxColumn.DataPropertyName = "package_code"
        Me.PackagecodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.PackagecodeDataGridViewTextBoxColumn.Name = "PackagecodeDataGridViewTextBoxColumn"
        Me.PackagecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PackageprocedureDataGridViewTextBoxColumn
        '
        Me.PackageprocedureDataGridViewTextBoxColumn.DataPropertyName = "package_procedure"
        Me.PackageprocedureDataGridViewTextBoxColumn.HeaderText = "Procedure"
        Me.PackageprocedureDataGridViewTextBoxColumn.Name = "PackageprocedureDataGridViewTextBoxColumn"
        Me.PackageprocedureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PackagecompanyDataGridViewTextBoxColumn
        '
        Me.PackagecompanyDataGridViewTextBoxColumn.DataPropertyName = "package_company"
        Me.PackagecompanyDataGridViewTextBoxColumn.HeaderText = "Company"
        Me.PackagecompanyDataGridViewTextBoxColumn.Name = "PackagecompanyDataGridViewTextBoxColumn"
        Me.PackagecompanyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PackagepriceDataGridViewTextBoxColumn
        '
        Me.PackagepriceDataGridViewTextBoxColumn.DataPropertyName = "package_price"
        Me.PackagepriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PackagepriceDataGridViewTextBoxColumn.Name = "PackagepriceDataGridViewTextBoxColumn"
        Me.PackagepriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'package_xray
        '
        Me.package_xray.DataPropertyName = "package_xray"
        Me.package_xray.HeaderText = "package_xray"
        Me.package_xray.Name = "package_xray"
        Me.package_xray.ReadOnly = True
        Me.package_xray.Visible = False
        '
        'package_lab
        '
        Me.package_lab.DataPropertyName = "package_lab"
        Me.package_lab.HeaderText = "package_lab"
        Me.package_lab.Name = "package_lab"
        Me.package_lab.ReadOnly = True
        Me.package_lab.Visible = False
        '
        'package_hema
        '
        Me.package_hema.DataPropertyName = "package_hema"
        Me.package_hema.HeaderText = "package_hema"
        Me.package_hema.Name = "package_hema"
        Me.package_hema.ReadOnly = True
        Me.package_hema.Visible = False
        '
        'package_feca
        '
        Me.package_feca.DataPropertyName = "package_feca"
        Me.package_feca.HeaderText = "package_feca"
        Me.package_feca.Name = "package_feca"
        Me.package_feca.ReadOnly = True
        Me.package_feca.Visible = False
        '
        'package_uri
        '
        Me.package_uri.DataPropertyName = "package_uri"
        Me.package_uri.HeaderText = "package_uri"
        Me.package_uri.Name = "package_uri"
        Me.package_uri.ReadOnly = True
        Me.package_uri.Visible = False
        '
        'package_blood
        '
        Me.package_blood.DataPropertyName = "package_blood"
        Me.package_blood.HeaderText = "package_blood"
        Me.package_blood.Name = "package_blood"
        Me.package_blood.ReadOnly = True
        Me.package_blood.Visible = False
        '
        'package_others
        '
        Me.package_others.DataPropertyName = "package_others"
        Me.package_others.HeaderText = "package_others"
        Me.package_others.Name = "package_others"
        Me.package_others.ReadOnly = True
        Me.package_others.Visible = False
        '
        'package_noe
        '
        Me.package_noe.DataPropertyName = "package_noe"
        Me.package_noe.HeaderText = "package_noe"
        Me.package_noe.Name = "package_noe"
        Me.package_noe.ReadOnly = True
        Me.package_noe.Visible = False
        '
        'package_pe
        '
        Me.package_pe.DataPropertyName = "package_pe"
        Me.package_pe.HeaderText = "package_pe"
        Me.package_pe.Name = "package_pe"
        Me.package_pe.ReadOnly = True
        Me.package_pe.Visible = False
        '
        'package_timestamp
        '
        Me.package_timestamp.DataPropertyName = "package_timestamp"
        Me.package_timestamp.HeaderText = "package_timestamp"
        Me.package_timestamp.Name = "package_timestamp"
        Me.package_timestamp.ReadOnly = True
        Me.package_timestamp.Visible = False
        '
        'Tb_packageBindingSource
        '
        Me.Tb_packageBindingSource.DataMember = "tb_package"
        Me.Tb_packageBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Db_cygnetmedDataSet
        '
        Me.Db_cygnetmedDataSet.DataSetName = "db_cygnetmedDataSet"
        Me.Db_cygnetmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_packageTableAdapter
        '
        Me.Tb_packageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_doctorsTableAdapter = Nothing
        Me.TableAdapterManager.tb_hmoTableAdapter = Nothing
        Me.TableAdapterManager.tb_infoTableAdapter = Nothing
        Me.TableAdapterManager.tb_labTableAdapter = Nothing
        Me.TableAdapterManager.tb_loginTableAdapter = Nothing
        Me.TableAdapterManager.tb_logsTableAdapter = Nothing
        Me.TableAdapterManager.tb_packageTableAdapter = Me.Tb_packageTableAdapter
        Me.TableAdapterManager.tb_relTableAdapter = Nothing
        Me.TableAdapterManager.tb_xrayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Enabled = False
        Me.mtile_remote.Location = New System.Drawing.Point(11, 10)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(28, 28)
        Me.mtile_remote.TabIndex = 560
        Me.mtile_remote.TileImage = CType(resources.GetObject("mtile_remote.TileImage"), System.Drawing.Image)
        Me.mtile_remote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtile_remote.UseSelectable = True
        Me.mtile_remote.UseTileImage = True
        '
        'mtxt_search
        '
        Me.mtxt_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtxt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_search.CustomButton.Image = Nothing
        Me.mtxt_search.CustomButton.Location = New System.Drawing.Point(315, 1)
        Me.mtxt_search.CustomButton.Name = ""
        Me.mtxt_search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_search.CustomButton.TabIndex = 1
        Me.mtxt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_search.CustomButton.UseSelectable = True
        Me.mtxt_search.CustomButton.Visible = False
        Me.mtxt_search.Lines = New String(-1) {}
        Me.mtxt_search.Location = New System.Drawing.Point(47, 13)
        Me.mtxt_search.MaxLength = 32767
        Me.mtxt_search.Name = "mtxt_search"
        Me.mtxt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_search.PromptText = "Search by Code, Procedure, Company"
        Me.mtxt_search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_search.SelectedText = ""
        Me.mtxt_search.SelectionLength = 0
        Me.mtxt_search.SelectionStart = 0
        Me.mtxt_search.ShortcutsEnabled = True
        Me.mtxt_search.Size = New System.Drawing.Size(337, 23)
        Me.mtxt_search.TabIndex = 559
        Me.mtxt_search.UseSelectable = True
        Me.mtxt_search.WaterMark = "Search by Code, Procedure, Company"
        Me.mtxt_search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel13.Location = New System.Drawing.Point(390, 192)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel13.TabIndex = 580
        Me.MetroLabel13.Text = "Department:"
        '
        'mtxt_company
        '
        Me.mtxt_company.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtxt_company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_company.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_company.CustomButton.Image = Nothing
        Me.mtxt_company.CustomButton.Location = New System.Drawing.Point(182, 1)
        Me.mtxt_company.CustomButton.Name = ""
        Me.mtxt_company.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_company.CustomButton.TabIndex = 1
        Me.mtxt_company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_company.CustomButton.UseSelectable = True
        Me.mtxt_company.CustomButton.Visible = False
        Me.mtxt_company.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_company", True))
        Me.mtxt_company.Lines = New String(-1) {}
        Me.mtxt_company.Location = New System.Drawing.Point(472, 52)
        Me.mtxt_company.MaxLength = 32767
        Me.mtxt_company.Name = "mtxt_company"
        Me.mtxt_company.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_company.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_company.SelectedText = ""
        Me.mtxt_company.SelectionLength = 0
        Me.mtxt_company.SelectionStart = 0
        Me.mtxt_company.ShortcutsEnabled = True
        Me.mtxt_company.Size = New System.Drawing.Size(204, 23)
        Me.mtxt_company.TabIndex = 577
        Me.mtxt_company.UseSelectable = True
        Me.mtxt_company.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_company.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(390, 52)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel7.TabIndex = 579
        Me.MetroLabel7.Text = "Company:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(475, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(134, 25)
        Me.MetroLabel1.TabIndex = 581
        Me.MetroLabel1.Text = "Package Details"
        '
        'msm_style
        '
        Me.msm_style.Owner = Me
        '
        'mtxt_code
        '
        Me.mtxt_code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtxt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_code.CustomButton.Image = Nothing
        Me.mtxt_code.CustomButton.Location = New System.Drawing.Point(182, 1)
        Me.mtxt_code.CustomButton.Name = ""
        Me.mtxt_code.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_code.CustomButton.TabIndex = 1
        Me.mtxt_code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_code.CustomButton.UseSelectable = True
        Me.mtxt_code.CustomButton.Visible = False
        Me.mtxt_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_code", True))
        Me.mtxt_code.Lines = New String(-1) {}
        Me.mtxt_code.Location = New System.Drawing.Point(472, 81)
        Me.mtxt_code.MaxLength = 32767
        Me.mtxt_code.Name = "mtxt_code"
        Me.mtxt_code.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_code.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_code.SelectedText = ""
        Me.mtxt_code.SelectionLength = 0
        Me.mtxt_code.SelectionStart = 0
        Me.mtxt_code.ShortcutsEnabled = True
        Me.mtxt_code.Size = New System.Drawing.Size(204, 23)
        Me.mtxt_code.TabIndex = 582
        Me.mtxt_code.UseSelectable = True
        Me.mtxt_code.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_code.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(390, 81)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel2.TabIndex = 583
        Me.MetroLabel2.Text = "Code:"
        '
        'mtxt_procedure
        '
        Me.mtxt_procedure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtxt_procedure.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_procedure.CustomButton.Image = Nothing
        Me.mtxt_procedure.CustomButton.Location = New System.Drawing.Point(182, 1)
        Me.mtxt_procedure.CustomButton.Name = ""
        Me.mtxt_procedure.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_procedure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_procedure.CustomButton.TabIndex = 1
        Me.mtxt_procedure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_procedure.CustomButton.UseSelectable = True
        Me.mtxt_procedure.CustomButton.Visible = False
        Me.mtxt_procedure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_procedure", True))
        Me.mtxt_procedure.Lines = New String(-1) {}
        Me.mtxt_procedure.Location = New System.Drawing.Point(472, 110)
        Me.mtxt_procedure.MaxLength = 32767
        Me.mtxt_procedure.Name = "mtxt_procedure"
        Me.mtxt_procedure.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_procedure.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_procedure.SelectedText = ""
        Me.mtxt_procedure.SelectionLength = 0
        Me.mtxt_procedure.SelectionStart = 0
        Me.mtxt_procedure.ShortcutsEnabled = True
        Me.mtxt_procedure.Size = New System.Drawing.Size(204, 23)
        Me.mtxt_procedure.TabIndex = 584
        Me.mtxt_procedure.UseSelectable = True
        Me.mtxt_procedure.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_procedure.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(390, 110)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel3.TabIndex = 585
        Me.MetroLabel3.Text = "Procedure:"
        '
        'mtxt_price
        '
        Me.mtxt_price.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.mtxt_price.CustomButton.Image = Nothing
        Me.mtxt_price.CustomButton.Location = New System.Drawing.Point(182, 1)
        Me.mtxt_price.CustomButton.Name = ""
        Me.mtxt_price.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_price.CustomButton.TabIndex = 1
        Me.mtxt_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_price.CustomButton.UseSelectable = True
        Me.mtxt_price.CustomButton.Visible = False
        Me.mtxt_price.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_price", True))
        Me.mtxt_price.Lines = New String(-1) {}
        Me.mtxt_price.Location = New System.Drawing.Point(472, 139)
        Me.mtxt_price.MaxLength = 32767
        Me.mtxt_price.Name = "mtxt_price"
        Me.mtxt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_price.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_price.SelectedText = ""
        Me.mtxt_price.SelectionLength = 0
        Me.mtxt_price.SelectionStart = 0
        Me.mtxt_price.ShortcutsEnabled = True
        Me.mtxt_price.Size = New System.Drawing.Size(204, 23)
        Me.mtxt_price.TabIndex = 586
        Me.mtxt_price.UseSelectable = True
        Me.mtxt_price.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_price.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(390, 139)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 587
        Me.MetroLabel4.Text = "Price:"
        '
        'mcb_radio
        '
        Me.mcb_radio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_radio.AutoSize = True
        Me.mcb_radio.Location = New System.Drawing.Point(404, 214)
        Me.mcb_radio.Name = "mcb_radio"
        Me.mcb_radio.Size = New System.Drawing.Size(76, 15)
        Me.mcb_radio.TabIndex = 588
        Me.mcb_radio.Text = "Radiology"
        Me.mcb_radio.UseSelectable = True
        '
        'mcb_lab
        '
        Me.mcb_lab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_lab.AutoSize = True
        Me.mcb_lab.Location = New System.Drawing.Point(404, 235)
        Me.mcb_lab.Name = "mcb_lab"
        Me.mcb_lab.Size = New System.Drawing.Size(80, 15)
        Me.mcb_lab.TabIndex = 589
        Me.mcb_lab.Text = "Laboratory"
        Me.mcb_lab.UseSelectable = True
        '
        'mcb_feca
        '
        Me.mcb_feca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_feca.AutoSize = True
        Me.mcb_feca.Location = New System.Drawing.Point(404, 317)
        Me.mcb_feca.Name = "mcb_feca"
        Me.mcb_feca.Size = New System.Drawing.Size(69, 15)
        Me.mcb_feca.TabIndex = 592
        Me.mcb_feca.Text = "Fecalysis"
        Me.mcb_feca.UseSelectable = True
        '
        'mcb_hema
        '
        Me.mcb_hema.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_hema.AutoSize = True
        Me.mcb_hema.Location = New System.Drawing.Point(404, 296)
        Me.mcb_hema.Name = "mcb_hema"
        Me.mcb_hema.Size = New System.Drawing.Size(89, 15)
        Me.mcb_hema.TabIndex = 591
        Me.mcb_hema.Text = "Hematology"
        Me.mcb_hema.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(390, 274)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel5.TabIndex = 590
        Me.MetroLabel5.Text = "Lab Tests:"
        '
        'mcb_blood
        '
        Me.mcb_blood.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_blood.AutoSize = True
        Me.mcb_blood.Location = New System.Drawing.Point(404, 359)
        Me.mcb_blood.Name = "mcb_blood"
        Me.mcb_blood.Size = New System.Drawing.Size(111, 15)
        Me.mcb_blood.TabIndex = 594
        Me.mcb_blood.Text = "Blood Chemistry"
        Me.mcb_blood.UseSelectable = True
        '
        'mcb_uri
        '
        Me.mcb_uri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_uri.AutoSize = True
        Me.mcb_uri.Location = New System.Drawing.Point(404, 338)
        Me.mcb_uri.Name = "mcb_uri"
        Me.mcb_uri.Size = New System.Drawing.Size(73, 15)
        Me.mcb_uri.TabIndex = 593
        Me.mcb_uri.Text = "Urinalysis"
        Me.mcb_uri.UseSelectable = True
        '
        'mcb_others
        '
        Me.mcb_others.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_others.AutoSize = True
        Me.mcb_others.Location = New System.Drawing.Point(404, 380)
        Me.mcb_others.Name = "mcb_others"
        Me.mcb_others.Size = New System.Drawing.Size(58, 15)
        Me.mcb_others.TabIndex = 595
        Me.mcb_others.Text = "Others"
        Me.mcb_others.UseSelectable = True
        '
        'mcb_consult
        '
        Me.mcb_consult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_consult.AutoSize = True
        Me.mcb_consult.Location = New System.Drawing.Point(547, 277)
        Me.mcb_consult.Name = "mcb_consult"
        Me.mcb_consult.Size = New System.Drawing.Size(91, 15)
        Me.mcb_consult.TabIndex = 600
        Me.mcb_consult.Text = "Consultation"
        Me.mcb_consult.UseSelectable = True
        '
        'mcb_walkin
        '
        Me.mcb_walkin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_walkin.AutoSize = True
        Me.mcb_walkin.Location = New System.Drawing.Point(547, 256)
        Me.mcb_walkin.Name = "mcb_walkin"
        Me.mcb_walkin.Size = New System.Drawing.Size(64, 15)
        Me.mcb_walkin.TabIndex = 599
        Me.mcb_walkin.Text = "Walk-In"
        Me.mcb_walkin.UseSelectable = True
        '
        'mcb_pre
        '
        Me.mcb_pre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_pre.AutoSize = True
        Me.mcb_pre.Location = New System.Drawing.Point(547, 235)
        Me.mcb_pre.Name = "mcb_pre"
        Me.mcb_pre.Size = New System.Drawing.Size(113, 15)
        Me.mcb_pre.TabIndex = 598
        Me.mcb_pre.Text = "Pre-employment"
        Me.mcb_pre.UseSelectable = True
        '
        'mcb_annual
        '
        Me.mcb_annual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_annual.AutoSize = True
        Me.mcb_annual.Location = New System.Drawing.Point(547, 214)
        Me.mcb_annual.Name = "mcb_annual"
        Me.mcb_annual.Size = New System.Drawing.Size(61, 15)
        Me.mcb_annual.TabIndex = 597
        Me.mcb_annual.Text = "Annual"
        Me.mcb_annual.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(533, 192)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel6.TabIndex = 596
        Me.MetroLabel6.Text = "NOE:"
        '
        'mcb_pe
        '
        Me.mcb_pe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_pe.AutoSize = True
        Me.mcb_pe.Location = New System.Drawing.Point(547, 338)
        Me.mcb_pe.Name = "mcb_pe"
        Me.mcb_pe.Size = New System.Drawing.Size(89, 15)
        Me.mcb_pe.TabIndex = 601
        Me.mcb_pe.Text = "Requires PE?"
        Me.mcb_pe.UseSelectable = True
        '
        'mbtn_save
        '
        Me.mbtn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_save.Location = New System.Drawing.Point(601, 444)
        Me.mbtn_save.Name = "mbtn_save"
        Me.mbtn_save.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_save.TabIndex = 603
        Me.mbtn_save.Text = "Save"
        Me.mbtn_save.UseSelectable = True
        '
        'mbtn_add
        '
        Me.mbtn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_add.Location = New System.Drawing.Point(520, 444)
        Me.mbtn_add.Name = "mbtn_add"
        Me.mbtn_add.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_add.TabIndex = 602
        Me.mbtn_add.Text = "Add"
        Me.mbtn_add.UseSelectable = True
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
        'pnl_hide_logs
        '
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_corrl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_activityl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_timestampl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_deptl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_namel)
        Me.pnl_hide_logs.Location = New System.Drawing.Point(13, 13)
        Me.pnl_hide_logs.Name = "pnl_hide_logs"
        Me.pnl_hide_logs.Size = New System.Drawing.Size(23, 18)
        Me.pnl_hide_logs.TabIndex = 604
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
        'bmbtn_delete
        '
        Me.bmbtn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bmbtn_delete.Location = New System.Drawing.Point(439, 444)
        Me.bmbtn_delete.Name = "bmbtn_delete"
        Me.bmbtn_delete.Size = New System.Drawing.Size(75, 23)
        Me.bmbtn_delete.TabIndex = 605
        Me.bmbtn_delete.Text = "Delete"
        Me.bmbtn_delete.UseSelectable = True
        '
        'info_package
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 475)
        Me.Controls.Add(Me.bmbtn_delete)
        Me.Controls.Add(Me.mbtn_save)
        Me.Controls.Add(Me.mbtn_add)
        Me.Controls.Add(Me.mcb_pe)
        Me.Controls.Add(Me.mcb_consult)
        Me.Controls.Add(Me.mcb_walkin)
        Me.Controls.Add(Me.mcb_pre)
        Me.Controls.Add(Me.mcb_annual)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.mcb_others)
        Me.Controls.Add(Me.mcb_blood)
        Me.Controls.Add(Me.mcb_uri)
        Me.Controls.Add(Me.mcb_feca)
        Me.Controls.Add(Me.mcb_hema)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.mcb_lab)
        Me.Controls.Add(Me.mcb_radio)
        Me.Controls.Add(Me.mtxt_price)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.mtxt_procedure)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.mtxt_code)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.mtxt_company)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.mtile_remote)
        Me.Controls.Add(Me.mtxt_search)
        Me.Controls.Add(Me.grid_packages)
        Me.Controls.Add(Me.pnl_hide_logs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "info_package"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.grid_packages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_packageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_packages As MetroFramework.Controls.MetroGrid
    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents Tb_packageBindingSource As BindingSource
    Friend WithEvents Tb_packageTableAdapter As db_cygnetmedDataSetTableAdapters.tb_packageTableAdapter
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents mtxt_search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_company As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mtxt_code As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_procedure As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_price As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_radio As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_lab As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_feca As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_hema As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_blood As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_uri As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_others As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_consult As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_walkin As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_pre As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcb_annual As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_pe As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mbtn_save As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_add As MetroFramework.Controls.MetroButton
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents bmbtn_delete As MetroFramework.Controls.MetroButton
    Friend WithEvents PackagecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackageprocedureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackagecompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackagepriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents package_xray As DataGridViewTextBoxColumn
    Friend WithEvents package_lab As DataGridViewTextBoxColumn
    Friend WithEvents package_hema As DataGridViewTextBoxColumn
    Friend WithEvents package_feca As DataGridViewTextBoxColumn
    Friend WithEvents package_uri As DataGridViewTextBoxColumn
    Friend WithEvents package_blood As DataGridViewTextBoxColumn
    Friend WithEvents package_others As DataGridViewTextBoxColumn
    Friend WithEvents package_noe As DataGridViewTextBoxColumn
    Friend WithEvents package_pe As DataGridViewTextBoxColumn
    Friend WithEvents package_timestamp As DataGridViewTextBoxColumn
End Class
