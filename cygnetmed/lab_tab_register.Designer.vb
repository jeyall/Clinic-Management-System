<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lab_tab_register
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lab_tab_register))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mpnl_body = New MetroFramework.Controls.MetroPanel()
        Me.mbtn_print = New MetroFramework.Controls.MetroButton()
        Me.mbtn_save = New MetroFramework.Controls.MetroButton()
        Me.mbtn_add = New MetroFramework.Controls.MetroButton()
        Me.mpnl_right = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel86 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel83 = New MetroFramework.Controls.MetroLabel()
        Me.mcbo_pathologist = New MetroFramework.Controls.MetroComboBox()
        Me.Tb_labBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.mcbo_medtech = New MetroFramework.Controls.MetroComboBox()
        Me.mpnl_others = New MetroFramework.Controls.MetroPanel()
        Me.MetroComboBox23 = New MetroFramework.Controls.MetroComboBox()
        Me.mtxt_others_result = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel87 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_others_value = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_others_patient = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel85 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_others_test = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel81 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_others_testtitle = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel82 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel98 = New MetroFramework.Controls.MetroLabel()
        Me.mpnl_blood = New MetroFramework.Controls.MetroPanel()
        Me.mtxt_blood_others = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel80 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_hbaic = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_blood_pota = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel73 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel74 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_sodium = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel75 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_sgot = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_blood_sgpt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel76 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel77 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_hldratio = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_blood_vldl = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel78 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel79 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_ldl = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel65 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_hdl = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_blood_triglyceride = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel66 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel67 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_cholesterol = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel68 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_uric = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_blood_crea = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel69 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel70 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_blood_bun = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_blood_fbs = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel71 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel72 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel64 = New MetroFramework.Controls.MetroLabel()
        Me.mpnl_uri = New MetroFramework.Controls.MetroPanel()
        Me.mtxt_uri_bacteria = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_pt = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_phosphates = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_urates = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_mucus = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_epi = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_sugar = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_ph = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_albu = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_others2 = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_uri_gravity = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel63 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_uri_transparency = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel62 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_uri_color = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel61 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_uri_crystals = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel60 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_uri_cast = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel59 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel55 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel56 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel57 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel58 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_uri_rbc = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel52 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel53 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_uri_wbc = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel54 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel37 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel38 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel39 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel40 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel50 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel51 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel84 = New MetroFramework.Controls.MetroLabel()
        Me.mpnl_feca = New MetroFramework.Controls.MetroPanel()
        Me.mtxt_feca_bacteria = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_fats = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_tropho = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_enta = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_hook = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_trichuris = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_ascaris = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_occult = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_consist = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_color = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_others2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel36 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_feca_rbc = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_feca_others = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_feca_wbc = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel33 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel41 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel42 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel43 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel44 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel45 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel46 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel47 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel48 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel49 = New MetroFramework.Controls.MetroLabel()
        Me.mpnl_hema = New MetroFramework.Controls.MetroPanel()
        Me.mtxt_hema_others = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_blood = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_hepaa = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_hepab = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_hema_baso = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_mono = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_eosino = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_hema_lympho = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_segmenters = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_platelets = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_bleeding = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_hema_clotting = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_esr = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_leuko = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_hema_erythro = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_hema_hema = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_hema_hemo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_status = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_patient = New MetroFramework.Controls.MetroLabel()
        Me.Tb_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mlbl_case = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_company = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_gender = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_age = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_procedure = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_datereg = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_name = New MetroFramework.Controls.MetroLabel()
        Me.pb_patient = New System.Windows.Forms.PictureBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_all_search = New MetroFramework.Controls.MetroCheckBox()
        Me.mdt_search = New MetroFramework.Controls.MetroDateTime()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.mtxt_search = New MetroFramework.Controls.MetroTextBox()
        Me.pnl_hide_logs = New System.Windows.Forms.Panel()
        Me.txt_hide_corrl = New System.Windows.Forms.TextBox()
        Me.Tb_logsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_hide_activityl = New System.Windows.Forms.TextBox()
        Me.txt_hide_timestampl = New System.Windows.Forms.TextBox()
        Me.txt_hide_deptl = New System.Windows.Forms.TextBox()
        Me.txt_hide_namel = New System.Windows.Forms.TextBox()
        Me.grid_patients = New MetroFramework.Controls.MetroGrid()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_procedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_picture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_lab = New MetroFramework.Controls.MetroGrid()
        Me.TransnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabcompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabmedtechDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabpathologistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabtimestampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_hide = New System.Windows.Forms.Panel()
        Me.txt_hide_others = New System.Windows.Forms.TextBox()
        Me.Tb_packageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_hide_blood = New System.Windows.Forms.TextBox()
        Me.txt_hide_uri = New System.Windows.Forms.TextBox()
        Me.txt_hide_feca = New System.Windows.Forms.TextBox()
        Me.txt_hide_hema = New System.Windows.Forms.TextBox()
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.Tb_labTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_labTableAdapter()
        Me.Tb_infoTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter()
        Me.Tb_packageTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_packageTableAdapter()
        Me.mpnl_body.SuspendLayout()
        Me.mpnl_right.SuspendLayout()
        CType(Me.Tb_labBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mpnl_others.SuspendLayout()
        Me.mpnl_blood.SuspendLayout()
        Me.mpnl_uri.SuspendLayout()
        Me.mpnl_feca.SuspendLayout()
        Me.mpnl_hema.SuspendLayout()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_hide_logs.SuspendLayout()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_hide.SuspendLayout()
        CType(Me.Tb_packageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mpnl_body
        '
        Me.mpnl_body.Controls.Add(Me.mbtn_print)
        Me.mpnl_body.Controls.Add(Me.mbtn_save)
        Me.mpnl_body.Controls.Add(Me.mbtn_add)
        Me.mpnl_body.Controls.Add(Me.mpnl_right)
        Me.mpnl_body.Controls.Add(Me.MetroLabel2)
        Me.mpnl_body.Controls.Add(Me.mcb_all_search)
        Me.mpnl_body.Controls.Add(Me.mdt_search)
        Me.mpnl_body.Controls.Add(Me.mtile_remote)
        Me.mpnl_body.Controls.Add(Me.mtxt_search)
        Me.mpnl_body.Controls.Add(Me.pnl_hide_logs)
        Me.mpnl_body.Controls.Add(Me.grid_patients)
        Me.mpnl_body.Controls.Add(Me.grid_lab)
        Me.mpnl_body.Controls.Add(Me.pnl_hide)
        Me.mpnl_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mpnl_body.HorizontalScrollbarBarColor = True
        Me.mpnl_body.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_body.HorizontalScrollbarSize = 10
        Me.mpnl_body.Location = New System.Drawing.Point(0, 0)
        Me.mpnl_body.Name = "mpnl_body"
        Me.mpnl_body.Size = New System.Drawing.Size(1171, 512)
        Me.mpnl_body.TabIndex = 0
        Me.mpnl_body.VerticalScrollbarBarColor = True
        Me.mpnl_body.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_body.VerticalScrollbarSize = 10
        '
        'mbtn_print
        '
        Me.mbtn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mbtn_print.Location = New System.Drawing.Point(3, 484)
        Me.mbtn_print.Name = "mbtn_print"
        Me.mbtn_print.Size = New System.Drawing.Size(89, 23)
        Me.mbtn_print.TabIndex = 701
        Me.mbtn_print.Text = "Print Preview"
        Me.mbtn_print.UseSelectable = True
        '
        'mbtn_save
        '
        Me.mbtn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_save.Location = New System.Drawing.Point(460, 484)
        Me.mbtn_save.Name = "mbtn_save"
        Me.mbtn_save.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_save.TabIndex = 699
        Me.mbtn_save.Text = "Save"
        Me.mbtn_save.UseSelectable = True
        '
        'mbtn_add
        '
        Me.mbtn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_add.Location = New System.Drawing.Point(379, 484)
        Me.mbtn_add.Name = "mbtn_add"
        Me.mbtn_add.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_add.TabIndex = 698
        Me.mbtn_add.Text = "Add"
        Me.mbtn_add.UseSelectable = True
        '
        'mpnl_right
        '
        Me.mpnl_right.AutoScroll = True
        Me.mpnl_right.Controls.Add(Me.MetroLabel86)
        Me.mpnl_right.Controls.Add(Me.MetroLabel83)
        Me.mpnl_right.Controls.Add(Me.mcbo_pathologist)
        Me.mpnl_right.Controls.Add(Me.mcbo_medtech)
        Me.mpnl_right.Controls.Add(Me.mpnl_others)
        Me.mpnl_right.Controls.Add(Me.mpnl_blood)
        Me.mpnl_right.Controls.Add(Me.mpnl_uri)
        Me.mpnl_right.Controls.Add(Me.mpnl_feca)
        Me.mpnl_right.Controls.Add(Me.mpnl_hema)
        Me.mpnl_right.Controls.Add(Me.mlbl_status)
        Me.mpnl_right.Controls.Add(Me.MetroLabel1)
        Me.mpnl_right.Controls.Add(Me.mlbl_patient)
        Me.mpnl_right.Controls.Add(Me.mlbl_case)
        Me.mpnl_right.Controls.Add(Me.mlbl_company)
        Me.mpnl_right.Controls.Add(Me.mlbl_gender)
        Me.mpnl_right.Controls.Add(Me.mlbl_age)
        Me.mpnl_right.Controls.Add(Me.mlbl_procedure)
        Me.mpnl_right.Controls.Add(Me.mlbl_datereg)
        Me.mpnl_right.Controls.Add(Me.mlbl_name)
        Me.mpnl_right.Controls.Add(Me.pb_patient)
        Me.mpnl_right.Controls.Add(Me.MetroLabel11)
        Me.mpnl_right.Controls.Add(Me.MetroLabel10)
        Me.mpnl_right.Controls.Add(Me.MetroLabel9)
        Me.mpnl_right.Controls.Add(Me.MetroLabel8)
        Me.mpnl_right.Controls.Add(Me.MetroLabel7)
        Me.mpnl_right.Controls.Add(Me.MetroLabel6)
        Me.mpnl_right.Controls.Add(Me.MetroLabel5)
        Me.mpnl_right.Controls.Add(Me.MetroLabel4)
        Me.mpnl_right.Controls.Add(Me.MetroLabel3)
        Me.mpnl_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.mpnl_right.HorizontalScrollbar = True
        Me.mpnl_right.HorizontalScrollbarBarColor = False
        Me.mpnl_right.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_right.HorizontalScrollbarSize = 0
        Me.mpnl_right.Location = New System.Drawing.Point(541, 0)
        Me.mpnl_right.Name = "mpnl_right"
        Me.mpnl_right.Size = New System.Drawing.Size(630, 512)
        Me.mpnl_right.TabIndex = 697
        Me.mpnl_right.VerticalScrollbar = True
        Me.mpnl_right.VerticalScrollbarBarColor = True
        Me.mpnl_right.VerticalScrollbarHighlightOnWheel = True
        Me.mpnl_right.VerticalScrollbarSize = 10
        '
        'MetroLabel86
        '
        Me.MetroLabel86.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel86.AutoSize = True
        Me.MetroLabel86.Location = New System.Drawing.Point(16, 218)
        Me.MetroLabel86.Name = "MetroLabel86"
        Me.MetroLabel86.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel86.TabIndex = 768
        Me.MetroLabel86.Text = "Pathologist:"
        '
        'MetroLabel83
        '
        Me.MetroLabel83.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel83.AutoSize = True
        Me.MetroLabel83.Location = New System.Drawing.Point(16, 189)
        Me.MetroLabel83.Name = "MetroLabel83"
        Me.MetroLabel83.Size = New System.Drawing.Size(133, 19)
        Me.MetroLabel83.TabIndex = 767
        Me.MetroLabel83.Text = "Medical Technologist:"
        '
        'mcbo_pathologist
        '
        Me.mcbo_pathologist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcbo_pathologist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_pathologist", True))
        Me.mcbo_pathologist.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcbo_pathologist.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.mcbo_pathologist.FormattingEnabled = True
        Me.mcbo_pathologist.ItemHeight = 19
        Me.mcbo_pathologist.Location = New System.Drawing.Point(155, 220)
        Me.mcbo_pathologist.Name = "mcbo_pathologist"
        Me.mcbo_pathologist.Size = New System.Drawing.Size(199, 25)
        Me.mcbo_pathologist.TabIndex = 701
        Me.mcbo_pathologist.UseSelectable = True
        '
        'Tb_labBindingSource
        '
        Me.Tb_labBindingSource.DataMember = "tb_lab"
        Me.Tb_labBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'Db_cygnetmedDataSet
        '
        Me.Db_cygnetmedDataSet.DataSetName = "db_cygnetmedDataSet"
        Me.Db_cygnetmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mcbo_medtech
        '
        Me.mcbo_medtech.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcbo_medtech.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_medtech", True))
        Me.mcbo_medtech.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcbo_medtech.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.mcbo_medtech.FormattingEnabled = True
        Me.mcbo_medtech.ItemHeight = 19
        Me.mcbo_medtech.Location = New System.Drawing.Point(155, 189)
        Me.mcbo_medtech.Name = "mcbo_medtech"
        Me.mcbo_medtech.Size = New System.Drawing.Size(199, 25)
        Me.mcbo_medtech.TabIndex = 702
        Me.mcbo_medtech.UseSelectable = True
        '
        'mpnl_others
        '
        Me.mpnl_others.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mpnl_others.Controls.Add(Me.MetroComboBox23)
        Me.mpnl_others.Controls.Add(Me.mtxt_others_result)
        Me.mpnl_others.Controls.Add(Me.MetroLabel87)
        Me.mpnl_others.Controls.Add(Me.mtxt_others_value)
        Me.mpnl_others.Controls.Add(Me.mtxt_others_patient)
        Me.mpnl_others.Controls.Add(Me.MetroLabel85)
        Me.mpnl_others.Controls.Add(Me.mtxt_others_test)
        Me.mpnl_others.Controls.Add(Me.MetroLabel81)
        Me.mpnl_others.Controls.Add(Me.mtxt_others_testtitle)
        Me.mpnl_others.Controls.Add(Me.MetroLabel82)
        Me.mpnl_others.Controls.Add(Me.MetroLabel98)
        Me.mpnl_others.HorizontalScrollbarBarColor = True
        Me.mpnl_others.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_others.HorizontalScrollbarSize = 10
        Me.mpnl_others.Location = New System.Drawing.Point(406, 920)
        Me.mpnl_others.Name = "mpnl_others"
        Me.mpnl_others.Size = New System.Drawing.Size(201, 294)
        Me.mpnl_others.TabIndex = 766
        Me.mpnl_others.VerticalScrollbarBarColor = True
        Me.mpnl_others.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_others.VerticalScrollbarSize = 10
        '
        'MetroComboBox23
        '
        Me.MetroComboBox23.DisplayFocus = True
        Me.MetroComboBox23.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox23.FormattingEnabled = True
        Me.MetroComboBox23.ItemHeight = 19
        Me.MetroComboBox23.Items.AddRange(New Object() {"Cut-off Value:", "Normal Value:"})
        Me.MetroComboBox23.Location = New System.Drawing.Point(3, 120)
        Me.MetroComboBox23.Name = "MetroComboBox23"
        Me.MetroComboBox23.Size = New System.Drawing.Size(85, 25)
        Me.MetroComboBox23.TabIndex = 3
        Me.MetroComboBox23.UseSelectable = True
        '
        'mtxt_others_result
        '
        '
        '
        '
        Me.mtxt_others_result.CustomButton.Image = Nothing
        Me.mtxt_others_result.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_others_result.CustomButton.Name = ""
        Me.mtxt_others_result.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_others_result.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_others_result.CustomButton.TabIndex = 1
        Me.mtxt_others_result.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_others_result.CustomButton.UseSelectable = True
        Me.mtxt_others_result.CustomButton.Visible = False
        Me.mtxt_others_result.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_others_result", True))
        Me.mtxt_others_result.Lines = New String(-1) {}
        Me.mtxt_others_result.Location = New System.Drawing.Point(94, 149)
        Me.mtxt_others_result.MaxLength = 32767
        Me.mtxt_others_result.Name = "mtxt_others_result"
        Me.mtxt_others_result.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_others_result.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_others_result.SelectedText = ""
        Me.mtxt_others_result.SelectionLength = 0
        Me.mtxt_others_result.SelectionStart = 0
        Me.mtxt_others_result.ShortcutsEnabled = True
        Me.mtxt_others_result.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_others_result.TabIndex = 5
        Me.mtxt_others_result.UseSelectable = True
        Me.mtxt_others_result.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_others_result.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel87
        '
        Me.MetroLabel87.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel87.AutoSize = True
        Me.MetroLabel87.Location = New System.Drawing.Point(2, 149)
        Me.MetroLabel87.Name = "MetroLabel87"
        Me.MetroLabel87.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel87.TabIndex = 780
        Me.MetroLabel87.Text = "Result:"
        '
        'mtxt_others_value
        '
        '
        '
        '
        Me.mtxt_others_value.CustomButton.Image = Nothing
        Me.mtxt_others_value.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_others_value.CustomButton.Name = ""
        Me.mtxt_others_value.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_others_value.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_others_value.CustomButton.TabIndex = 1
        Me.mtxt_others_value.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_others_value.CustomButton.UseSelectable = True
        Me.mtxt_others_value.CustomButton.Visible = False
        Me.mtxt_others_value.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_others_value", True))
        Me.mtxt_others_value.Lines = New String(-1) {}
        Me.mtxt_others_value.Location = New System.Drawing.Point(94, 120)
        Me.mtxt_others_value.MaxLength = 32767
        Me.mtxt_others_value.Name = "mtxt_others_value"
        Me.mtxt_others_value.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_others_value.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_others_value.SelectedText = ""
        Me.mtxt_others_value.SelectionLength = 0
        Me.mtxt_others_value.SelectionStart = 0
        Me.mtxt_others_value.ShortcutsEnabled = True
        Me.mtxt_others_value.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_others_value.TabIndex = 4
        Me.mtxt_others_value.UseSelectable = True
        Me.mtxt_others_value.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_others_value.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_others_patient
        '
        '
        '
        '
        Me.mtxt_others_patient.CustomButton.Image = Nothing
        Me.mtxt_others_patient.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_others_patient.CustomButton.Name = ""
        Me.mtxt_others_patient.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_others_patient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_others_patient.CustomButton.TabIndex = 1
        Me.mtxt_others_patient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_others_patient.CustomButton.UseSelectable = True
        Me.mtxt_others_patient.CustomButton.Visible = False
        Me.mtxt_others_patient.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_others_patientcount", True))
        Me.mtxt_others_patient.Lines = New String(-1) {}
        Me.mtxt_others_patient.Location = New System.Drawing.Point(94, 91)
        Me.mtxt_others_patient.MaxLength = 32767
        Me.mtxt_others_patient.Name = "mtxt_others_patient"
        Me.mtxt_others_patient.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_others_patient.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_others_patient.SelectedText = ""
        Me.mtxt_others_patient.SelectionLength = 0
        Me.mtxt_others_patient.SelectionStart = 0
        Me.mtxt_others_patient.ShortcutsEnabled = True
        Me.mtxt_others_patient.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_others_patient.TabIndex = 2
        Me.mtxt_others_patient.UseSelectable = True
        Me.mtxt_others_patient.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_others_patient.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel85
        '
        Me.MetroLabel85.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel85.AutoSize = True
        Me.MetroLabel85.Location = New System.Drawing.Point(2, 91)
        Me.MetroLabel85.Name = "MetroLabel85"
        Me.MetroLabel85.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel85.TabIndex = 776
        Me.MetroLabel85.Text = "Patient Count:"
        '
        'mtxt_others_test
        '
        '
        '
        '
        Me.mtxt_others_test.CustomButton.Image = Nothing
        Me.mtxt_others_test.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_others_test.CustomButton.Name = ""
        Me.mtxt_others_test.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_others_test.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_others_test.CustomButton.TabIndex = 1
        Me.mtxt_others_test.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_others_test.CustomButton.UseSelectable = True
        Me.mtxt_others_test.CustomButton.Visible = False
        Me.mtxt_others_test.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_others_test", True))
        Me.mtxt_others_test.Lines = New String(-1) {}
        Me.mtxt_others_test.Location = New System.Drawing.Point(94, 62)
        Me.mtxt_others_test.MaxLength = 32767
        Me.mtxt_others_test.Name = "mtxt_others_test"
        Me.mtxt_others_test.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_others_test.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_others_test.SelectedText = ""
        Me.mtxt_others_test.SelectionLength = 0
        Me.mtxt_others_test.SelectionStart = 0
        Me.mtxt_others_test.ShortcutsEnabled = True
        Me.mtxt_others_test.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_others_test.TabIndex = 1
        Me.mtxt_others_test.UseSelectable = True
        Me.mtxt_others_test.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_others_test.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel81
        '
        Me.MetroLabel81.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel81.AutoSize = True
        Me.MetroLabel81.Location = New System.Drawing.Point(2, 62)
        Me.MetroLabel81.Name = "MetroLabel81"
        Me.MetroLabel81.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel81.TabIndex = 774
        Me.MetroLabel81.Text = "Test:"
        '
        'mtxt_others_testtitle
        '
        '
        '
        '
        Me.mtxt_others_testtitle.CustomButton.Image = Nothing
        Me.mtxt_others_testtitle.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_others_testtitle.CustomButton.Name = ""
        Me.mtxt_others_testtitle.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_others_testtitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_others_testtitle.CustomButton.TabIndex = 1
        Me.mtxt_others_testtitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_others_testtitle.CustomButton.UseSelectable = True
        Me.mtxt_others_testtitle.CustomButton.Visible = False
        Me.mtxt_others_testtitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_others_testtitle", True))
        Me.mtxt_others_testtitle.Lines = New String(-1) {}
        Me.mtxt_others_testtitle.Location = New System.Drawing.Point(94, 33)
        Me.mtxt_others_testtitle.MaxLength = 32767
        Me.mtxt_others_testtitle.Name = "mtxt_others_testtitle"
        Me.mtxt_others_testtitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_others_testtitle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_others_testtitle.SelectedText = ""
        Me.mtxt_others_testtitle.SelectionLength = 0
        Me.mtxt_others_testtitle.SelectionStart = 0
        Me.mtxt_others_testtitle.ShortcutsEnabled = True
        Me.mtxt_others_testtitle.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_others_testtitle.TabIndex = 0
        Me.mtxt_others_testtitle.UseSelectable = True
        Me.mtxt_others_testtitle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_others_testtitle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel82
        '
        Me.MetroLabel82.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel82.AutoSize = True
        Me.MetroLabel82.Location = New System.Drawing.Point(2, 33)
        Me.MetroLabel82.Name = "MetroLabel82"
        Me.MetroLabel82.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel82.TabIndex = 772
        Me.MetroLabel82.Text = "Test Title:"
        '
        'MetroLabel98
        '
        Me.MetroLabel98.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel98.AutoSize = True
        Me.MetroLabel98.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel98.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel98.Location = New System.Drawing.Point(69, 3)
        Me.MetroLabel98.Name = "MetroLabel98"
        Me.MetroLabel98.Size = New System.Drawing.Size(69, 25)
        Me.MetroLabel98.TabIndex = 699
        Me.MetroLabel98.Text = "Others"
        '
        'mpnl_blood
        '
        Me.mpnl_blood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_others)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel80)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_hbaic)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_pota)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel73)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel74)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_sodium)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel75)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_sgot)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_sgpt)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel76)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel77)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_hldratio)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_vldl)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel78)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel79)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_ldl)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel65)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_hdl)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_triglyceride)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel66)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel67)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_cholesterol)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel68)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_uric)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_crea)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel69)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel70)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_bun)
        Me.mpnl_blood.Controls.Add(Me.mtxt_blood_fbs)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel71)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel72)
        Me.mpnl_blood.Controls.Add(Me.MetroLabel64)
        Me.mpnl_blood.HorizontalScrollbarBarColor = True
        Me.mpnl_blood.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_blood.HorizontalScrollbarSize = 10
        Me.mpnl_blood.Location = New System.Drawing.Point(8, 920)
        Me.mpnl_blood.Name = "mpnl_blood"
        Me.mpnl_blood.Size = New System.Drawing.Size(399, 294)
        Me.mpnl_blood.TabIndex = 698
        Me.mpnl_blood.VerticalScrollbarBarColor = True
        Me.mpnl_blood.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_blood.VerticalScrollbarSize = 10
        '
        'mtxt_blood_others
        '
        '
        '
        '
        Me.mtxt_blood_others.CustomButton.Image = Nothing
        Me.mtxt_blood_others.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.mtxt_blood_others.CustomButton.Name = ""
        Me.mtxt_blood_others.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.mtxt_blood_others.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_others.CustomButton.TabIndex = 1
        Me.mtxt_blood_others.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_others.CustomButton.UseSelectable = True
        Me.mtxt_blood_others.CustomButton.Visible = False
        Me.mtxt_blood_others.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_others", True))
        Me.mtxt_blood_others.Lines = New String(-1) {}
        Me.mtxt_blood_others.Location = New System.Drawing.Point(295, 236)
        Me.mtxt_blood_others.MaxLength = 32767
        Me.mtxt_blood_others.Multiline = True
        Me.mtxt_blood_others.Name = "mtxt_blood_others"
        Me.mtxt_blood_others.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_others.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mtxt_blood_others.SelectedText = ""
        Me.mtxt_blood_others.SelectionLength = 0
        Me.mtxt_blood_others.SelectionStart = 0
        Me.mtxt_blood_others.ShortcutsEnabled = True
        Me.mtxt_blood_others.Size = New System.Drawing.Size(99, 47)
        Me.mtxt_blood_others.TabIndex = 15
        Me.mtxt_blood_others.UseSelectable = True
        Me.mtxt_blood_others.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_others.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel80
        '
        Me.MetroLabel80.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel80.AutoSize = True
        Me.MetroLabel80.Location = New System.Drawing.Point(200, 236)
        Me.MetroLabel80.Name = "MetroLabel80"
        Me.MetroLabel80.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel80.TabIndex = 764
        Me.MetroLabel80.Text = "Others:"
        '
        'mtxt_blood_hbaic
        '
        '
        '
        '
        Me.mtxt_blood_hbaic.CustomButton.Image = Nothing
        Me.mtxt_blood_hbaic.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_hbaic.CustomButton.Name = ""
        Me.mtxt_blood_hbaic.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_hbaic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_hbaic.CustomButton.TabIndex = 1
        Me.mtxt_blood_hbaic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_hbaic.CustomButton.UseSelectable = True
        Me.mtxt_blood_hbaic.CustomButton.Visible = False
        Me.mtxt_blood_hbaic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_hbaic", True))
        Me.mtxt_blood_hbaic.Lines = New String(-1) {}
        Me.mtxt_blood_hbaic.Location = New System.Drawing.Point(295, 207)
        Me.mtxt_blood_hbaic.MaxLength = 32767
        Me.mtxt_blood_hbaic.Name = "mtxt_blood_hbaic"
        Me.mtxt_blood_hbaic.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_hbaic.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_hbaic.SelectedText = ""
        Me.mtxt_blood_hbaic.SelectionLength = 0
        Me.mtxt_blood_hbaic.SelectionStart = 0
        Me.mtxt_blood_hbaic.ShortcutsEnabled = True
        Me.mtxt_blood_hbaic.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_hbaic.TabIndex = 14
        Me.mtxt_blood_hbaic.UseSelectable = True
        Me.mtxt_blood_hbaic.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_hbaic.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_blood_pota
        '
        '
        '
        '
        Me.mtxt_blood_pota.CustomButton.Image = Nothing
        Me.mtxt_blood_pota.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_pota.CustomButton.Name = ""
        Me.mtxt_blood_pota.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_pota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_pota.CustomButton.TabIndex = 1
        Me.mtxt_blood_pota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_pota.CustomButton.UseSelectable = True
        Me.mtxt_blood_pota.CustomButton.Visible = False
        Me.mtxt_blood_pota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_pota", True))
        Me.mtxt_blood_pota.Lines = New String(-1) {}
        Me.mtxt_blood_pota.Location = New System.Drawing.Point(295, 178)
        Me.mtxt_blood_pota.MaxLength = 32767
        Me.mtxt_blood_pota.Name = "mtxt_blood_pota"
        Me.mtxt_blood_pota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_pota.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_pota.SelectedText = ""
        Me.mtxt_blood_pota.SelectionLength = 0
        Me.mtxt_blood_pota.SelectionStart = 0
        Me.mtxt_blood_pota.ShortcutsEnabled = True
        Me.mtxt_blood_pota.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_pota.TabIndex = 13
        Me.mtxt_blood_pota.UseSelectable = True
        Me.mtxt_blood_pota.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_pota.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel73
        '
        Me.MetroLabel73.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel73.AutoSize = True
        Me.MetroLabel73.Location = New System.Drawing.Point(198, 207)
        Me.MetroLabel73.Name = "MetroLabel73"
        Me.MetroLabel73.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel73.TabIndex = 761
        Me.MetroLabel73.Text = "HBAIC:"
        '
        'MetroLabel74
        '
        Me.MetroLabel74.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel74.AutoSize = True
        Me.MetroLabel74.Location = New System.Drawing.Point(197, 178)
        Me.MetroLabel74.Name = "MetroLabel74"
        Me.MetroLabel74.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel74.TabIndex = 760
        Me.MetroLabel74.Text = "Potassium (K):"
        '
        'mtxt_blood_sodium
        '
        '
        '
        '
        Me.mtxt_blood_sodium.CustomButton.Image = Nothing
        Me.mtxt_blood_sodium.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_sodium.CustomButton.Name = ""
        Me.mtxt_blood_sodium.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_sodium.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_sodium.CustomButton.TabIndex = 1
        Me.mtxt_blood_sodium.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_sodium.CustomButton.UseSelectable = True
        Me.mtxt_blood_sodium.CustomButton.Visible = False
        Me.mtxt_blood_sodium.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_sodium", True))
        Me.mtxt_blood_sodium.Lines = New String(-1) {}
        Me.mtxt_blood_sodium.Location = New System.Drawing.Point(295, 149)
        Me.mtxt_blood_sodium.MaxLength = 32767
        Me.mtxt_blood_sodium.Name = "mtxt_blood_sodium"
        Me.mtxt_blood_sodium.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_sodium.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_sodium.SelectedText = ""
        Me.mtxt_blood_sodium.SelectionLength = 0
        Me.mtxt_blood_sodium.SelectionStart = 0
        Me.mtxt_blood_sodium.ShortcutsEnabled = True
        Me.mtxt_blood_sodium.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_sodium.TabIndex = 12
        Me.mtxt_blood_sodium.UseSelectable = True
        Me.mtxt_blood_sodium.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_sodium.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel75
        '
        Me.MetroLabel75.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel75.AutoSize = True
        Me.MetroLabel75.Location = New System.Drawing.Point(198, 149)
        Me.MetroLabel75.Name = "MetroLabel75"
        Me.MetroLabel75.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel75.TabIndex = 758
        Me.MetroLabel75.Text = "Sodium (Na):"
        '
        'mtxt_blood_sgot
        '
        '
        '
        '
        Me.mtxt_blood_sgot.CustomButton.Image = Nothing
        Me.mtxt_blood_sgot.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_sgot.CustomButton.Name = ""
        Me.mtxt_blood_sgot.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_sgot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_sgot.CustomButton.TabIndex = 1
        Me.mtxt_blood_sgot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_sgot.CustomButton.UseSelectable = True
        Me.mtxt_blood_sgot.CustomButton.Visible = False
        Me.mtxt_blood_sgot.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_sgot", True))
        Me.mtxt_blood_sgot.Lines = New String(-1) {}
        Me.mtxt_blood_sgot.Location = New System.Drawing.Point(295, 120)
        Me.mtxt_blood_sgot.MaxLength = 32767
        Me.mtxt_blood_sgot.Name = "mtxt_blood_sgot"
        Me.mtxt_blood_sgot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_sgot.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_sgot.SelectedText = ""
        Me.mtxt_blood_sgot.SelectionLength = 0
        Me.mtxt_blood_sgot.SelectionStart = 0
        Me.mtxt_blood_sgot.ShortcutsEnabled = True
        Me.mtxt_blood_sgot.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_sgot.TabIndex = 11
        Me.mtxt_blood_sgot.UseSelectable = True
        Me.mtxt_blood_sgot.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_sgot.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_blood_sgpt
        '
        '
        '
        '
        Me.mtxt_blood_sgpt.CustomButton.Image = Nothing
        Me.mtxt_blood_sgpt.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_sgpt.CustomButton.Name = ""
        Me.mtxt_blood_sgpt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_sgpt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_sgpt.CustomButton.TabIndex = 1
        Me.mtxt_blood_sgpt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_sgpt.CustomButton.UseSelectable = True
        Me.mtxt_blood_sgpt.CustomButton.Visible = False
        Me.mtxt_blood_sgpt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_sgpt", True))
        Me.mtxt_blood_sgpt.Lines = New String(-1) {}
        Me.mtxt_blood_sgpt.Location = New System.Drawing.Point(295, 91)
        Me.mtxt_blood_sgpt.MaxLength = 32767
        Me.mtxt_blood_sgpt.Name = "mtxt_blood_sgpt"
        Me.mtxt_blood_sgpt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_sgpt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_sgpt.SelectedText = ""
        Me.mtxt_blood_sgpt.SelectionLength = 0
        Me.mtxt_blood_sgpt.SelectionStart = 0
        Me.mtxt_blood_sgpt.ShortcutsEnabled = True
        Me.mtxt_blood_sgpt.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_sgpt.TabIndex = 10
        Me.mtxt_blood_sgpt.UseSelectable = True
        Me.mtxt_blood_sgpt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_sgpt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel76
        '
        Me.MetroLabel76.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel76.AutoSize = True
        Me.MetroLabel76.Location = New System.Drawing.Point(198, 120)
        Me.MetroLabel76.Name = "MetroLabel76"
        Me.MetroLabel76.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel76.TabIndex = 755
        Me.MetroLabel76.Text = "SGOT (ALT):"
        '
        'MetroLabel77
        '
        Me.MetroLabel77.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel77.AutoSize = True
        Me.MetroLabel77.Location = New System.Drawing.Point(198, 91)
        Me.MetroLabel77.Name = "MetroLabel77"
        Me.MetroLabel77.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel77.TabIndex = 754
        Me.MetroLabel77.Text = "SGPT (ALT):"
        '
        'mtxt_blood_hldratio
        '
        '
        '
        '
        Me.mtxt_blood_hldratio.CustomButton.Image = Nothing
        Me.mtxt_blood_hldratio.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_hldratio.CustomButton.Name = ""
        Me.mtxt_blood_hldratio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_hldratio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_hldratio.CustomButton.TabIndex = 1
        Me.mtxt_blood_hldratio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_hldratio.CustomButton.UseSelectable = True
        Me.mtxt_blood_hldratio.CustomButton.Visible = False
        Me.mtxt_blood_hldratio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_hdlratio", True))
        Me.mtxt_blood_hldratio.Lines = New String(-1) {}
        Me.mtxt_blood_hldratio.Location = New System.Drawing.Point(295, 62)
        Me.mtxt_blood_hldratio.MaxLength = 32767
        Me.mtxt_blood_hldratio.Name = "mtxt_blood_hldratio"
        Me.mtxt_blood_hldratio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_hldratio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_hldratio.SelectedText = ""
        Me.mtxt_blood_hldratio.SelectionLength = 0
        Me.mtxt_blood_hldratio.SelectionStart = 0
        Me.mtxt_blood_hldratio.ShortcutsEnabled = True
        Me.mtxt_blood_hldratio.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_hldratio.TabIndex = 9
        Me.mtxt_blood_hldratio.UseSelectable = True
        Me.mtxt_blood_hldratio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_hldratio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_blood_vldl
        '
        '
        '
        '
        Me.mtxt_blood_vldl.CustomButton.Image = Nothing
        Me.mtxt_blood_vldl.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_vldl.CustomButton.Name = ""
        Me.mtxt_blood_vldl.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_vldl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_vldl.CustomButton.TabIndex = 1
        Me.mtxt_blood_vldl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_vldl.CustomButton.UseSelectable = True
        Me.mtxt_blood_vldl.CustomButton.Visible = False
        Me.mtxt_blood_vldl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_vldl", True))
        Me.mtxt_blood_vldl.Lines = New String(-1) {}
        Me.mtxt_blood_vldl.Location = New System.Drawing.Point(295, 33)
        Me.mtxt_blood_vldl.MaxLength = 32767
        Me.mtxt_blood_vldl.Name = "mtxt_blood_vldl"
        Me.mtxt_blood_vldl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_vldl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_vldl.SelectedText = ""
        Me.mtxt_blood_vldl.SelectionLength = 0
        Me.mtxt_blood_vldl.SelectionStart = 0
        Me.mtxt_blood_vldl.ShortcutsEnabled = True
        Me.mtxt_blood_vldl.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_vldl.TabIndex = 8
        Me.mtxt_blood_vldl.UseSelectable = True
        Me.mtxt_blood_vldl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_vldl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel78
        '
        Me.MetroLabel78.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel78.AutoSize = True
        Me.MetroLabel78.Location = New System.Drawing.Point(198, 62)
        Me.MetroLabel78.Name = "MetroLabel78"
        Me.MetroLabel78.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel78.TabIndex = 751
        Me.MetroLabel78.Text = "HDL Ratio:"
        '
        'MetroLabel79
        '
        Me.MetroLabel79.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel79.AutoSize = True
        Me.MetroLabel79.Location = New System.Drawing.Point(198, 33)
        Me.MetroLabel79.Name = "MetroLabel79"
        Me.MetroLabel79.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel79.TabIndex = 750
        Me.MetroLabel79.Text = "VLDL:"
        '
        'mtxt_blood_ldl
        '
        '
        '
        '
        Me.mtxt_blood_ldl.CustomButton.Image = Nothing
        Me.mtxt_blood_ldl.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_ldl.CustomButton.Name = ""
        Me.mtxt_blood_ldl.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_ldl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_ldl.CustomButton.TabIndex = 1
        Me.mtxt_blood_ldl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_ldl.CustomButton.UseSelectable = True
        Me.mtxt_blood_ldl.CustomButton.Visible = False
        Me.mtxt_blood_ldl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_ldl", True))
        Me.mtxt_blood_ldl.Lines = New String(-1) {}
        Me.mtxt_blood_ldl.Location = New System.Drawing.Point(98, 236)
        Me.mtxt_blood_ldl.MaxLength = 32767
        Me.mtxt_blood_ldl.Name = "mtxt_blood_ldl"
        Me.mtxt_blood_ldl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_ldl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_ldl.SelectedText = ""
        Me.mtxt_blood_ldl.SelectionLength = 0
        Me.mtxt_blood_ldl.SelectionStart = 0
        Me.mtxt_blood_ldl.ShortcutsEnabled = True
        Me.mtxt_blood_ldl.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_ldl.TabIndex = 7
        Me.mtxt_blood_ldl.UseSelectable = True
        Me.mtxt_blood_ldl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_ldl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel65
        '
        Me.MetroLabel65.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel65.AutoSize = True
        Me.MetroLabel65.Location = New System.Drawing.Point(1, 236)
        Me.MetroLabel65.Name = "MetroLabel65"
        Me.MetroLabel65.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel65.TabIndex = 748
        Me.MetroLabel65.Text = "LDL:"
        '
        'mtxt_blood_hdl
        '
        '
        '
        '
        Me.mtxt_blood_hdl.CustomButton.Image = Nothing
        Me.mtxt_blood_hdl.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_hdl.CustomButton.Name = ""
        Me.mtxt_blood_hdl.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_hdl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_hdl.CustomButton.TabIndex = 1
        Me.mtxt_blood_hdl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_hdl.CustomButton.UseSelectable = True
        Me.mtxt_blood_hdl.CustomButton.Visible = False
        Me.mtxt_blood_hdl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_hdl", True))
        Me.mtxt_blood_hdl.Lines = New String(-1) {}
        Me.mtxt_blood_hdl.Location = New System.Drawing.Point(98, 207)
        Me.mtxt_blood_hdl.MaxLength = 32767
        Me.mtxt_blood_hdl.Name = "mtxt_blood_hdl"
        Me.mtxt_blood_hdl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_hdl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_hdl.SelectedText = ""
        Me.mtxt_blood_hdl.SelectionLength = 0
        Me.mtxt_blood_hdl.SelectionStart = 0
        Me.mtxt_blood_hdl.ShortcutsEnabled = True
        Me.mtxt_blood_hdl.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_hdl.TabIndex = 6
        Me.mtxt_blood_hdl.UseSelectable = True
        Me.mtxt_blood_hdl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_hdl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_blood_triglyceride
        '
        '
        '
        '
        Me.mtxt_blood_triglyceride.CustomButton.Image = Nothing
        Me.mtxt_blood_triglyceride.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_triglyceride.CustomButton.Name = ""
        Me.mtxt_blood_triglyceride.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_triglyceride.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_triglyceride.CustomButton.TabIndex = 1
        Me.mtxt_blood_triglyceride.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_triglyceride.CustomButton.UseSelectable = True
        Me.mtxt_blood_triglyceride.CustomButton.Visible = False
        Me.mtxt_blood_triglyceride.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_trigly", True))
        Me.mtxt_blood_triglyceride.Lines = New String(-1) {}
        Me.mtxt_blood_triglyceride.Location = New System.Drawing.Point(98, 178)
        Me.mtxt_blood_triglyceride.MaxLength = 32767
        Me.mtxt_blood_triglyceride.Name = "mtxt_blood_triglyceride"
        Me.mtxt_blood_triglyceride.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_triglyceride.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_triglyceride.SelectedText = ""
        Me.mtxt_blood_triglyceride.SelectionLength = 0
        Me.mtxt_blood_triglyceride.SelectionStart = 0
        Me.mtxt_blood_triglyceride.ShortcutsEnabled = True
        Me.mtxt_blood_triglyceride.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_triglyceride.TabIndex = 5
        Me.mtxt_blood_triglyceride.UseSelectable = True
        Me.mtxt_blood_triglyceride.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_triglyceride.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel66
        '
        Me.MetroLabel66.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel66.AutoSize = True
        Me.MetroLabel66.Location = New System.Drawing.Point(1, 207)
        Me.MetroLabel66.Name = "MetroLabel66"
        Me.MetroLabel66.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel66.TabIndex = 745
        Me.MetroLabel66.Text = "HDL:"
        '
        'MetroLabel67
        '
        Me.MetroLabel67.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel67.AutoSize = True
        Me.MetroLabel67.Location = New System.Drawing.Point(1, 178)
        Me.MetroLabel67.Name = "MetroLabel67"
        Me.MetroLabel67.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel67.TabIndex = 744
        Me.MetroLabel67.Text = "Triglyceride:"
        '
        'mtxt_blood_cholesterol
        '
        '
        '
        '
        Me.mtxt_blood_cholesterol.CustomButton.Image = Nothing
        Me.mtxt_blood_cholesterol.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_cholesterol.CustomButton.Name = ""
        Me.mtxt_blood_cholesterol.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_cholesterol.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_cholesterol.CustomButton.TabIndex = 1
        Me.mtxt_blood_cholesterol.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_cholesterol.CustomButton.UseSelectable = True
        Me.mtxt_blood_cholesterol.CustomButton.Visible = False
        Me.mtxt_blood_cholesterol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_chole", True))
        Me.mtxt_blood_cholesterol.Lines = New String(-1) {}
        Me.mtxt_blood_cholesterol.Location = New System.Drawing.Point(98, 149)
        Me.mtxt_blood_cholesterol.MaxLength = 32767
        Me.mtxt_blood_cholesterol.Name = "mtxt_blood_cholesterol"
        Me.mtxt_blood_cholesterol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_cholesterol.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_cholesterol.SelectedText = ""
        Me.mtxt_blood_cholesterol.SelectionLength = 0
        Me.mtxt_blood_cholesterol.SelectionStart = 0
        Me.mtxt_blood_cholesterol.ShortcutsEnabled = True
        Me.mtxt_blood_cholesterol.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_cholesterol.TabIndex = 4
        Me.mtxt_blood_cholesterol.UseSelectable = True
        Me.mtxt_blood_cholesterol.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_cholesterol.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel68
        '
        Me.MetroLabel68.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel68.AutoSize = True
        Me.MetroLabel68.Location = New System.Drawing.Point(1, 149)
        Me.MetroLabel68.Name = "MetroLabel68"
        Me.MetroLabel68.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel68.TabIndex = 742
        Me.MetroLabel68.Text = "Cholesterol:"
        '
        'mtxt_blood_uric
        '
        '
        '
        '
        Me.mtxt_blood_uric.CustomButton.Image = Nothing
        Me.mtxt_blood_uric.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_uric.CustomButton.Name = ""
        Me.mtxt_blood_uric.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_uric.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_uric.CustomButton.TabIndex = 1
        Me.mtxt_blood_uric.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_uric.CustomButton.UseSelectable = True
        Me.mtxt_blood_uric.CustomButton.Visible = False
        Me.mtxt_blood_uric.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_uri", True))
        Me.mtxt_blood_uric.Lines = New String(-1) {}
        Me.mtxt_blood_uric.Location = New System.Drawing.Point(98, 120)
        Me.mtxt_blood_uric.MaxLength = 32767
        Me.mtxt_blood_uric.Name = "mtxt_blood_uric"
        Me.mtxt_blood_uric.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_uric.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_uric.SelectedText = ""
        Me.mtxt_blood_uric.SelectionLength = 0
        Me.mtxt_blood_uric.SelectionStart = 0
        Me.mtxt_blood_uric.ShortcutsEnabled = True
        Me.mtxt_blood_uric.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_uric.TabIndex = 3
        Me.mtxt_blood_uric.UseSelectable = True
        Me.mtxt_blood_uric.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_uric.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_blood_crea
        '
        '
        '
        '
        Me.mtxt_blood_crea.CustomButton.Image = Nothing
        Me.mtxt_blood_crea.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_crea.CustomButton.Name = ""
        Me.mtxt_blood_crea.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_crea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_crea.CustomButton.TabIndex = 1
        Me.mtxt_blood_crea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_crea.CustomButton.UseSelectable = True
        Me.mtxt_blood_crea.CustomButton.Visible = False
        Me.mtxt_blood_crea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_crea", True))
        Me.mtxt_blood_crea.Lines = New String(-1) {}
        Me.mtxt_blood_crea.Location = New System.Drawing.Point(98, 91)
        Me.mtxt_blood_crea.MaxLength = 32767
        Me.mtxt_blood_crea.Name = "mtxt_blood_crea"
        Me.mtxt_blood_crea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_crea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_crea.SelectedText = ""
        Me.mtxt_blood_crea.SelectionLength = 0
        Me.mtxt_blood_crea.SelectionStart = 0
        Me.mtxt_blood_crea.ShortcutsEnabled = True
        Me.mtxt_blood_crea.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_crea.TabIndex = 2
        Me.mtxt_blood_crea.UseSelectable = True
        Me.mtxt_blood_crea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_crea.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel69
        '
        Me.MetroLabel69.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel69.AutoSize = True
        Me.MetroLabel69.Location = New System.Drawing.Point(1, 120)
        Me.MetroLabel69.Name = "MetroLabel69"
        Me.MetroLabel69.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel69.TabIndex = 739
        Me.MetroLabel69.Text = "Uric Acid:"
        '
        'MetroLabel70
        '
        Me.MetroLabel70.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel70.AutoSize = True
        Me.MetroLabel70.Location = New System.Drawing.Point(1, 91)
        Me.MetroLabel70.Name = "MetroLabel70"
        Me.MetroLabel70.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel70.TabIndex = 738
        Me.MetroLabel70.Text = "Creatinine:"
        '
        'mtxt_blood_bun
        '
        '
        '
        '
        Me.mtxt_blood_bun.CustomButton.Image = Nothing
        Me.mtxt_blood_bun.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_bun.CustomButton.Name = ""
        Me.mtxt_blood_bun.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_bun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_bun.CustomButton.TabIndex = 1
        Me.mtxt_blood_bun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_bun.CustomButton.UseSelectable = True
        Me.mtxt_blood_bun.CustomButton.Visible = False
        Me.mtxt_blood_bun.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_bun", True))
        Me.mtxt_blood_bun.Lines = New String(-1) {}
        Me.mtxt_blood_bun.Location = New System.Drawing.Point(98, 62)
        Me.mtxt_blood_bun.MaxLength = 32767
        Me.mtxt_blood_bun.Name = "mtxt_blood_bun"
        Me.mtxt_blood_bun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_bun.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_bun.SelectedText = ""
        Me.mtxt_blood_bun.SelectionLength = 0
        Me.mtxt_blood_bun.SelectionStart = 0
        Me.mtxt_blood_bun.ShortcutsEnabled = True
        Me.mtxt_blood_bun.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_bun.TabIndex = 1
        Me.mtxt_blood_bun.UseSelectable = True
        Me.mtxt_blood_bun.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_bun.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_blood_fbs
        '
        '
        '
        '
        Me.mtxt_blood_fbs.CustomButton.Image = Nothing
        Me.mtxt_blood_fbs.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_blood_fbs.CustomButton.Name = ""
        Me.mtxt_blood_fbs.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_blood_fbs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_blood_fbs.CustomButton.TabIndex = 1
        Me.mtxt_blood_fbs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_blood_fbs.CustomButton.UseSelectable = True
        Me.mtxt_blood_fbs.CustomButton.Visible = False
        Me.mtxt_blood_fbs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_bc_fbs", True))
        Me.mtxt_blood_fbs.Lines = New String(-1) {}
        Me.mtxt_blood_fbs.Location = New System.Drawing.Point(98, 33)
        Me.mtxt_blood_fbs.MaxLength = 32767
        Me.mtxt_blood_fbs.Name = "mtxt_blood_fbs"
        Me.mtxt_blood_fbs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_blood_fbs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_blood_fbs.SelectedText = ""
        Me.mtxt_blood_fbs.SelectionLength = 0
        Me.mtxt_blood_fbs.SelectionStart = 0
        Me.mtxt_blood_fbs.ShortcutsEnabled = True
        Me.mtxt_blood_fbs.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_blood_fbs.TabIndex = 0
        Me.mtxt_blood_fbs.UseSelectable = True
        Me.mtxt_blood_fbs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_blood_fbs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel71
        '
        Me.MetroLabel71.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel71.AutoSize = True
        Me.MetroLabel71.Location = New System.Drawing.Point(1, 62)
        Me.MetroLabel71.Name = "MetroLabel71"
        Me.MetroLabel71.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel71.TabIndex = 735
        Me.MetroLabel71.Text = "BUN:"
        '
        'MetroLabel72
        '
        Me.MetroLabel72.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel72.AutoSize = True
        Me.MetroLabel72.Location = New System.Drawing.Point(1, 33)
        Me.MetroLabel72.Name = "MetroLabel72"
        Me.MetroLabel72.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel72.TabIndex = 734
        Me.MetroLabel72.Text = "FBS:"
        '
        'MetroLabel64
        '
        Me.MetroLabel64.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel64.AutoSize = True
        Me.MetroLabel64.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel64.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel64.Location = New System.Drawing.Point(122, 3)
        Me.MetroLabel64.Name = "MetroLabel64"
        Me.MetroLabel64.Size = New System.Drawing.Size(153, 25)
        Me.MetroLabel64.TabIndex = 699
        Me.MetroLabel64.Text = "Blood Chemistry"
        '
        'mpnl_uri
        '
        Me.mpnl_uri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_bacteria)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_pt)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_phosphates)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_urates)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_mucus)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_epi)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_sugar)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_ph)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_albu)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_others2)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_gravity)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel63)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_transparency)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel62)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_color)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel61)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_crystals)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel60)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_cast)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel59)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel55)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel56)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel57)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel58)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_rbc)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel52)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel53)
        Me.mpnl_uri.Controls.Add(Me.mtxt_uri_wbc)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel54)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel37)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel38)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel39)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel40)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel50)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel51)
        Me.mpnl_uri.Controls.Add(Me.MetroLabel84)
        Me.mpnl_uri.HorizontalScrollbarBarColor = True
        Me.mpnl_uri.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_uri.HorizontalScrollbarSize = 10
        Me.mpnl_uri.Location = New System.Drawing.Point(406, 248)
        Me.mpnl_uri.Name = "mpnl_uri"
        Me.mpnl_uri.Size = New System.Drawing.Size(200, 673)
        Me.mpnl_uri.TabIndex = 756
        Me.mpnl_uri.VerticalScrollbarBarColor = True
        Me.mpnl_uri.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_uri.VerticalScrollbarSize = 10
        '
        'mtxt_uri_bacteria
        '
        Me.mtxt_uri_bacteria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_bacteria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_bacteria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_bacteria.CustomButton.Image = Nothing
        Me.mtxt_uri_bacteria.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_bacteria.CustomButton.Name = ""
        Me.mtxt_uri_bacteria.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_bacteria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_bacteria.CustomButton.TabIndex = 1
        Me.mtxt_uri_bacteria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_bacteria.CustomButton.UseSelectable = True
        Me.mtxt_uri_bacteria.CustomButton.Visible = False
        Me.mtxt_uri_bacteria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_bacteria", True))
        Me.mtxt_uri_bacteria.Lines = New String(-1) {}
        Me.mtxt_uri_bacteria.Location = New System.Drawing.Point(94, 504)
        Me.mtxt_uri_bacteria.MaxLength = 32767
        Me.mtxt_uri_bacteria.Name = "mtxt_uri_bacteria"
        Me.mtxt_uri_bacteria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_bacteria.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_bacteria.SelectedText = ""
        Me.mtxt_uri_bacteria.SelectionLength = 0
        Me.mtxt_uri_bacteria.SelectionStart = 0
        Me.mtxt_uri_bacteria.ShortcutsEnabled = True
        Me.mtxt_uri_bacteria.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_bacteria.TabIndex = 14
        Me.mtxt_uri_bacteria.UseSelectable = True
        Me.mtxt_uri_bacteria.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_bacteria.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_pt
        '
        Me.mtxt_uri_pt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_pt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_pt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_pt.CustomButton.Image = Nothing
        Me.mtxt_uri_pt.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_pt.CustomButton.Name = ""
        Me.mtxt_uri_pt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_pt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_pt.CustomButton.TabIndex = 1
        Me.mtxt_uri_pt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_pt.CustomButton.UseSelectable = True
        Me.mtxt_uri_pt.CustomButton.Visible = False
        Me.mtxt_uri_pt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_pregnancy", True))
        Me.mtxt_uri_pt.Lines = New String(-1) {}
        Me.mtxt_uri_pt.Location = New System.Drawing.Point(94, 562)
        Me.mtxt_uri_pt.MaxLength = 32767
        Me.mtxt_uri_pt.Name = "mtxt_uri_pt"
        Me.mtxt_uri_pt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_pt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_pt.SelectedText = ""
        Me.mtxt_uri_pt.SelectionLength = 0
        Me.mtxt_uri_pt.SelectionStart = 0
        Me.mtxt_uri_pt.ShortcutsEnabled = True
        Me.mtxt_uri_pt.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_pt.TabIndex = 15
        Me.mtxt_uri_pt.UseSelectable = True
        Me.mtxt_uri_pt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_pt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_phosphates
        '
        Me.mtxt_uri_phosphates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_phosphates.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_phosphates.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_phosphates.CustomButton.Image = Nothing
        Me.mtxt_uri_phosphates.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_phosphates.CustomButton.Name = ""
        Me.mtxt_uri_phosphates.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_phosphates.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_phosphates.CustomButton.TabIndex = 1
        Me.mtxt_uri_phosphates.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_phosphates.CustomButton.UseSelectable = True
        Me.mtxt_uri_phosphates.CustomButton.Visible = False
        Me.mtxt_uri_phosphates.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_phosphates", True))
        Me.mtxt_uri_phosphates.Lines = New String(-1) {}
        Me.mtxt_uri_phosphates.Location = New System.Drawing.Point(94, 391)
        Me.mtxt_uri_phosphates.MaxLength = 32767
        Me.mtxt_uri_phosphates.Name = "mtxt_uri_phosphates"
        Me.mtxt_uri_phosphates.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_phosphates.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_phosphates.SelectedText = ""
        Me.mtxt_uri_phosphates.SelectionLength = 0
        Me.mtxt_uri_phosphates.SelectionStart = 0
        Me.mtxt_uri_phosphates.ShortcutsEnabled = True
        Me.mtxt_uri_phosphates.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_phosphates.TabIndex = 11
        Me.mtxt_uri_phosphates.UseSelectable = True
        Me.mtxt_uri_phosphates.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_phosphates.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_urates
        '
        Me.mtxt_uri_urates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_urates.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_urates.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_urates.CustomButton.Image = Nothing
        Me.mtxt_uri_urates.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_urates.CustomButton.Name = ""
        Me.mtxt_uri_urates.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_urates.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_urates.CustomButton.TabIndex = 1
        Me.mtxt_uri_urates.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_urates.CustomButton.UseSelectable = True
        Me.mtxt_uri_urates.CustomButton.Visible = False
        Me.mtxt_uri_urates.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_urates", True))
        Me.mtxt_uri_urates.Lines = New String(-1) {}
        Me.mtxt_uri_urates.Location = New System.Drawing.Point(94, 362)
        Me.mtxt_uri_urates.MaxLength = 32767
        Me.mtxt_uri_urates.Name = "mtxt_uri_urates"
        Me.mtxt_uri_urates.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_urates.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_urates.SelectedText = ""
        Me.mtxt_uri_urates.SelectionLength = 0
        Me.mtxt_uri_urates.SelectionStart = 0
        Me.mtxt_uri_urates.ShortcutsEnabled = True
        Me.mtxt_uri_urates.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_urates.TabIndex = 10
        Me.mtxt_uri_urates.UseSelectable = True
        Me.mtxt_uri_urates.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_urates.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_mucus
        '
        Me.mtxt_uri_mucus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_mucus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_mucus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_mucus.CustomButton.Image = Nothing
        Me.mtxt_uri_mucus.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_mucus.CustomButton.Name = ""
        Me.mtxt_uri_mucus.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_mucus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_mucus.CustomButton.TabIndex = 1
        Me.mtxt_uri_mucus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_mucus.CustomButton.UseSelectable = True
        Me.mtxt_uri_mucus.CustomButton.Visible = False
        Me.mtxt_uri_mucus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_mucus", True))
        Me.mtxt_uri_mucus.Lines = New String(-1) {}
        Me.mtxt_uri_mucus.Location = New System.Drawing.Point(94, 331)
        Me.mtxt_uri_mucus.MaxLength = 32767
        Me.mtxt_uri_mucus.Name = "mtxt_uri_mucus"
        Me.mtxt_uri_mucus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_mucus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_mucus.SelectedText = ""
        Me.mtxt_uri_mucus.SelectionLength = 0
        Me.mtxt_uri_mucus.SelectionStart = 0
        Me.mtxt_uri_mucus.ShortcutsEnabled = True
        Me.mtxt_uri_mucus.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_mucus.TabIndex = 9
        Me.mtxt_uri_mucus.UseSelectable = True
        Me.mtxt_uri_mucus.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_mucus.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_epi
        '
        Me.mtxt_uri_epi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_epi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_epi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_epi.CustomButton.Image = Nothing
        Me.mtxt_uri_epi.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_epi.CustomButton.Name = ""
        Me.mtxt_uri_epi.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_epi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_epi.CustomButton.TabIndex = 1
        Me.mtxt_uri_epi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_epi.CustomButton.UseSelectable = True
        Me.mtxt_uri_epi.CustomButton.Visible = False
        Me.mtxt_uri_epi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_epthelial", True))
        Me.mtxt_uri_epi.Lines = New String(-1) {}
        Me.mtxt_uri_epi.Location = New System.Drawing.Point(94, 302)
        Me.mtxt_uri_epi.MaxLength = 32767
        Me.mtxt_uri_epi.Name = "mtxt_uri_epi"
        Me.mtxt_uri_epi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_epi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_epi.SelectedText = ""
        Me.mtxt_uri_epi.SelectionLength = 0
        Me.mtxt_uri_epi.SelectionStart = 0
        Me.mtxt_uri_epi.ShortcutsEnabled = True
        Me.mtxt_uri_epi.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_epi.TabIndex = 8
        Me.mtxt_uri_epi.UseSelectable = True
        Me.mtxt_uri_epi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_epi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_sugar
        '
        Me.mtxt_uri_sugar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_sugar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_sugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_sugar.CustomButton.Image = Nothing
        Me.mtxt_uri_sugar.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_sugar.CustomButton.Name = ""
        Me.mtxt_uri_sugar.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_sugar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_sugar.CustomButton.TabIndex = 1
        Me.mtxt_uri_sugar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_sugar.CustomButton.UseSelectable = True
        Me.mtxt_uri_sugar.CustomButton.Visible = False
        Me.mtxt_uri_sugar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_sugar", True))
        Me.mtxt_uri_sugar.Lines = New String(-1) {}
        Me.mtxt_uri_sugar.Location = New System.Drawing.Point(94, 186)
        Me.mtxt_uri_sugar.MaxLength = 32767
        Me.mtxt_uri_sugar.Name = "mtxt_uri_sugar"
        Me.mtxt_uri_sugar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_sugar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_sugar.SelectedText = ""
        Me.mtxt_uri_sugar.SelectionLength = 0
        Me.mtxt_uri_sugar.SelectionStart = 0
        Me.mtxt_uri_sugar.ShortcutsEnabled = True
        Me.mtxt_uri_sugar.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_sugar.TabIndex = 5
        Me.mtxt_uri_sugar.UseSelectable = True
        Me.mtxt_uri_sugar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_sugar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_ph
        '
        Me.mtxt_uri_ph.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_ph.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_ph.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_ph.CustomButton.Image = Nothing
        Me.mtxt_uri_ph.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_ph.CustomButton.Name = ""
        Me.mtxt_uri_ph.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_ph.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_ph.CustomButton.TabIndex = 1
        Me.mtxt_uri_ph.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_ph.CustomButton.UseSelectable = True
        Me.mtxt_uri_ph.CustomButton.Visible = False
        Me.mtxt_uri_ph.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_ph", True))
        Me.mtxt_uri_ph.Lines = New String(-1) {}
        Me.mtxt_uri_ph.Location = New System.Drawing.Point(94, 124)
        Me.mtxt_uri_ph.MaxLength = 32767
        Me.mtxt_uri_ph.Name = "mtxt_uri_ph"
        Me.mtxt_uri_ph.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_ph.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_ph.SelectedText = ""
        Me.mtxt_uri_ph.SelectionLength = 0
        Me.mtxt_uri_ph.SelectionStart = 0
        Me.mtxt_uri_ph.ShortcutsEnabled = True
        Me.mtxt_uri_ph.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_ph.TabIndex = 3
        Me.mtxt_uri_ph.UseSelectable = True
        Me.mtxt_uri_ph.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_ph.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_albu
        '
        Me.mtxt_uri_albu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_albu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_albu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_albu.CustomButton.Image = Nothing
        Me.mtxt_uri_albu.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_albu.CustomButton.Name = ""
        Me.mtxt_uri_albu.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_albu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_albu.CustomButton.TabIndex = 1
        Me.mtxt_uri_albu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_albu.CustomButton.UseSelectable = True
        Me.mtxt_uri_albu.CustomButton.Visible = False
        Me.mtxt_uri_albu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_albumin", True))
        Me.mtxt_uri_albu.Lines = New String(-1) {}
        Me.mtxt_uri_albu.Location = New System.Drawing.Point(94, 155)
        Me.mtxt_uri_albu.MaxLength = 32767
        Me.mtxt_uri_albu.Name = "mtxt_uri_albu"
        Me.mtxt_uri_albu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_albu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_albu.SelectedText = ""
        Me.mtxt_uri_albu.SelectionLength = 0
        Me.mtxt_uri_albu.SelectionStart = 0
        Me.mtxt_uri_albu.ShortcutsEnabled = True
        Me.mtxt_uri_albu.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_albu.TabIndex = 4
        Me.mtxt_uri_albu.UseSelectable = True
        Me.mtxt_uri_albu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_albu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_others2
        '
        '
        '
        '
        Me.mtxt_uri_others2.CustomButton.Image = Nothing
        Me.mtxt_uri_others2.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.mtxt_uri_others2.CustomButton.Name = ""
        Me.mtxt_uri_others2.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.mtxt_uri_others2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_others2.CustomButton.TabIndex = 1
        Me.mtxt_uri_others2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_others2.CustomButton.UseSelectable = True
        Me.mtxt_uri_others2.CustomButton.Visible = False
        Me.mtxt_uri_others2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_others_02", True))
        Me.mtxt_uri_others2.Lines = New String(-1) {}
        Me.mtxt_uri_others2.Location = New System.Drawing.Point(21, 613)
        Me.mtxt_uri_others2.MaxLength = 32767
        Me.mtxt_uri_others2.Multiline = True
        Me.mtxt_uri_others2.Name = "mtxt_uri_others2"
        Me.mtxt_uri_others2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_others2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mtxt_uri_others2.SelectedText = ""
        Me.mtxt_uri_others2.SelectionLength = 0
        Me.mtxt_uri_others2.SelectionStart = 0
        Me.mtxt_uri_others2.ShortcutsEnabled = True
        Me.mtxt_uri_others2.Size = New System.Drawing.Size(174, 47)
        Me.mtxt_uri_others2.TabIndex = 16
        Me.mtxt_uri_others2.UseSelectable = True
        Me.mtxt_uri_others2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_others2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_uri_gravity
        '
        Me.mtxt_uri_gravity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_gravity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_gravity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_gravity.CustomButton.Image = Nothing
        Me.mtxt_uri_gravity.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_gravity.CustomButton.Name = ""
        Me.mtxt_uri_gravity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_gravity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_gravity.CustomButton.TabIndex = 1
        Me.mtxt_uri_gravity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_gravity.CustomButton.UseSelectable = True
        Me.mtxt_uri_gravity.CustomButton.Visible = False
        Me.mtxt_uri_gravity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_specific", True))
        Me.mtxt_uri_gravity.Lines = New String(-1) {}
        Me.mtxt_uri_gravity.Location = New System.Drawing.Point(94, 93)
        Me.mtxt_uri_gravity.MaxLength = 32767
        Me.mtxt_uri_gravity.Name = "mtxt_uri_gravity"
        Me.mtxt_uri_gravity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_gravity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_gravity.SelectedText = ""
        Me.mtxt_uri_gravity.SelectionLength = 0
        Me.mtxt_uri_gravity.SelectionStart = 0
        Me.mtxt_uri_gravity.ShortcutsEnabled = True
        Me.mtxt_uri_gravity.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_gravity.TabIndex = 2
        Me.mtxt_uri_gravity.UseSelectable = True
        Me.mtxt_uri_gravity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_gravity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel63
        '
        Me.MetroLabel63.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel63.AutoSize = True
        Me.MetroLabel63.Location = New System.Drawing.Point(4, 591)
        Me.MetroLabel63.Name = "MetroLabel63"
        Me.MetroLabel63.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel63.TabIndex = 768
        Me.MetroLabel63.Text = "Others:"
        '
        'mtxt_uri_transparency
        '
        Me.mtxt_uri_transparency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_transparency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_transparency.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_transparency.CustomButton.Image = Nothing
        Me.mtxt_uri_transparency.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_transparency.CustomButton.Name = ""
        Me.mtxt_uri_transparency.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_transparency.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_transparency.CustomButton.TabIndex = 1
        Me.mtxt_uri_transparency.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_transparency.CustomButton.UseSelectable = True
        Me.mtxt_uri_transparency.CustomButton.Visible = False
        Me.mtxt_uri_transparency.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_transparency", True))
        Me.mtxt_uri_transparency.Lines = New String(-1) {}
        Me.mtxt_uri_transparency.Location = New System.Drawing.Point(94, 62)
        Me.mtxt_uri_transparency.MaxLength = 32767
        Me.mtxt_uri_transparency.Name = "mtxt_uri_transparency"
        Me.mtxt_uri_transparency.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_transparency.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_transparency.SelectedText = ""
        Me.mtxt_uri_transparency.SelectionLength = 0
        Me.mtxt_uri_transparency.SelectionStart = 0
        Me.mtxt_uri_transparency.ShortcutsEnabled = True
        Me.mtxt_uri_transparency.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_transparency.TabIndex = 1
        Me.mtxt_uri_transparency.UseSelectable = True
        Me.mtxt_uri_transparency.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_transparency.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel62
        '
        Me.MetroLabel62.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel62.AutoSize = True
        Me.MetroLabel62.Location = New System.Drawing.Point(2, 562)
        Me.MetroLabel62.Name = "MetroLabel62"
        Me.MetroLabel62.Size = New System.Drawing.Size(27, 19)
        Me.MetroLabel62.TabIndex = 783
        Me.MetroLabel62.Text = "PT:"
        '
        'mtxt_uri_color
        '
        Me.mtxt_uri_color.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_uri_color.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_uri_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_uri_color.CustomButton.Image = Nothing
        Me.mtxt_uri_color.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_color.CustomButton.Name = ""
        Me.mtxt_uri_color.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_color.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_color.CustomButton.TabIndex = 1
        Me.mtxt_uri_color.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_color.CustomButton.UseSelectable = True
        Me.mtxt_uri_color.CustomButton.Visible = False
        Me.mtxt_uri_color.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_color", True))
        Me.mtxt_uri_color.Lines = New String(-1) {}
        Me.mtxt_uri_color.Location = New System.Drawing.Point(94, 31)
        Me.mtxt_uri_color.MaxLength = 32767
        Me.mtxt_uri_color.Name = "mtxt_uri_color"
        Me.mtxt_uri_color.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_color.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_color.SelectedText = ""
        Me.mtxt_uri_color.SelectionLength = 0
        Me.mtxt_uri_color.SelectionStart = 0
        Me.mtxt_uri_color.ShortcutsEnabled = True
        Me.mtxt_uri_color.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_color.TabIndex = 0
        Me.mtxt_uri_color.UseSelectable = True
        Me.mtxt_uri_color.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_color.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel61
        '
        Me.MetroLabel61.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel61.AutoSize = True
        Me.MetroLabel61.Location = New System.Drawing.Point(2, 504)
        Me.MetroLabel61.Name = "MetroLabel61"
        Me.MetroLabel61.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel61.TabIndex = 768
        Me.MetroLabel61.Text = "Bacteria:"
        '
        'mtxt_uri_crystals
        '
        '
        '
        '
        Me.mtxt_uri_crystals.CustomButton.Image = Nothing
        Me.mtxt_uri_crystals.CustomButton.Location = New System.Drawing.Point(55, 1)
        Me.mtxt_uri_crystals.CustomButton.Name = ""
        Me.mtxt_uri_crystals.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.mtxt_uri_crystals.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_crystals.CustomButton.TabIndex = 1
        Me.mtxt_uri_crystals.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_crystals.CustomButton.UseSelectable = True
        Me.mtxt_uri_crystals.CustomButton.Visible = False
        Me.mtxt_uri_crystals.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_crystals", True))
        Me.mtxt_uri_crystals.Lines = New String(-1) {}
        Me.mtxt_uri_crystals.Location = New System.Drawing.Point(94, 449)
        Me.mtxt_uri_crystals.MaxLength = 32767
        Me.mtxt_uri_crystals.Multiline = True
        Me.mtxt_uri_crystals.Name = "mtxt_uri_crystals"
        Me.mtxt_uri_crystals.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_crystals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mtxt_uri_crystals.SelectedText = ""
        Me.mtxt_uri_crystals.SelectionLength = 0
        Me.mtxt_uri_crystals.SelectionStart = 0
        Me.mtxt_uri_crystals.ShortcutsEnabled = True
        Me.mtxt_uri_crystals.Size = New System.Drawing.Size(101, 47)
        Me.mtxt_uri_crystals.TabIndex = 13
        Me.mtxt_uri_crystals.UseSelectable = True
        Me.mtxt_uri_crystals.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_crystals.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel60
        '
        Me.MetroLabel60.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel60.AutoSize = True
        Me.MetroLabel60.Location = New System.Drawing.Point(2, 449)
        Me.MetroLabel60.Name = "MetroLabel60"
        Me.MetroLabel60.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel60.TabIndex = 768
        Me.MetroLabel60.Text = "Crystals:"
        '
        'mtxt_uri_cast
        '
        '
        '
        '
        Me.mtxt_uri_cast.CustomButton.Image = Nothing
        Me.mtxt_uri_cast.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_cast.CustomButton.Name = ""
        Me.mtxt_uri_cast.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_cast.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_cast.CustomButton.TabIndex = 1
        Me.mtxt_uri_cast.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_cast.CustomButton.UseSelectable = True
        Me.mtxt_uri_cast.CustomButton.Visible = False
        Me.mtxt_uri_cast.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_cast", True))
        Me.mtxt_uri_cast.Lines = New String(-1) {}
        Me.mtxt_uri_cast.Location = New System.Drawing.Point(94, 420)
        Me.mtxt_uri_cast.MaxLength = 32767
        Me.mtxt_uri_cast.Name = "mtxt_uri_cast"
        Me.mtxt_uri_cast.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_cast.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_cast.SelectedText = ""
        Me.mtxt_uri_cast.SelectionLength = 0
        Me.mtxt_uri_cast.SelectionStart = 0
        Me.mtxt_uri_cast.ShortcutsEnabled = True
        Me.mtxt_uri_cast.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_cast.TabIndex = 12
        Me.mtxt_uri_cast.UseSelectable = True
        Me.mtxt_uri_cast.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_cast.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel59
        '
        Me.MetroLabel59.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel59.AutoSize = True
        Me.MetroLabel59.Location = New System.Drawing.Point(2, 420)
        Me.MetroLabel59.Name = "MetroLabel59"
        Me.MetroLabel59.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel59.TabIndex = 781
        Me.MetroLabel59.Text = "Cast:"
        '
        'MetroLabel55
        '
        Me.MetroLabel55.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel55.AutoSize = True
        Me.MetroLabel55.Location = New System.Drawing.Point(2, 393)
        Me.MetroLabel55.Name = "MetroLabel55"
        Me.MetroLabel55.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel55.TabIndex = 776
        Me.MetroLabel55.Text = "A. Phosphates"
        '
        'MetroLabel56
        '
        Me.MetroLabel56.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel56.AutoSize = True
        Me.MetroLabel56.Location = New System.Drawing.Point(2, 362)
        Me.MetroLabel56.Name = "MetroLabel56"
        Me.MetroLabel56.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel56.TabIndex = 775
        Me.MetroLabel56.Text = "A. Urates:"
        '
        'MetroLabel57
        '
        Me.MetroLabel57.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel57.AutoSize = True
        Me.MetroLabel57.Location = New System.Drawing.Point(2, 333)
        Me.MetroLabel57.Name = "MetroLabel57"
        Me.MetroLabel57.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel57.TabIndex = 774
        Me.MetroLabel57.Text = "Mucus Thread:"
        '
        'MetroLabel58
        '
        Me.MetroLabel58.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel58.AutoSize = True
        Me.MetroLabel58.Location = New System.Drawing.Point(2, 302)
        Me.MetroLabel58.Name = "MetroLabel58"
        Me.MetroLabel58.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel58.TabIndex = 773
        Me.MetroLabel58.Text = "Epithelial Cell:"
        '
        'mtxt_uri_rbc
        '
        '
        '
        '
        Me.mtxt_uri_rbc.CustomButton.Image = Nothing
        Me.mtxt_uri_rbc.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_rbc.CustomButton.Name = ""
        Me.mtxt_uri_rbc.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_rbc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_rbc.CustomButton.TabIndex = 1
        Me.mtxt_uri_rbc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_rbc.CustomButton.UseSelectable = True
        Me.mtxt_uri_rbc.CustomButton.Visible = False
        Me.mtxt_uri_rbc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_rbc", True))
        Me.mtxt_uri_rbc.Lines = New String(-1) {}
        Me.mtxt_uri_rbc.Location = New System.Drawing.Point(94, 273)
        Me.mtxt_uri_rbc.MaxLength = 32767
        Me.mtxt_uri_rbc.Name = "mtxt_uri_rbc"
        Me.mtxt_uri_rbc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_rbc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_rbc.SelectedText = ""
        Me.mtxt_uri_rbc.SelectionLength = 0
        Me.mtxt_uri_rbc.SelectionStart = 0
        Me.mtxt_uri_rbc.ShortcutsEnabled = True
        Me.mtxt_uri_rbc.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_rbc.TabIndex = 7
        Me.mtxt_uri_rbc.UseSelectable = True
        Me.mtxt_uri_rbc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_rbc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel52
        '
        Me.MetroLabel52.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel52.AutoSize = True
        Me.MetroLabel52.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel52.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel52.Location = New System.Drawing.Point(44, 214)
        Me.MetroLabel52.Name = "MetroLabel52"
        Me.MetroLabel52.Size = New System.Drawing.Size(114, 25)
        Me.MetroLabel52.TabIndex = 772
        Me.MetroLabel52.Text = "Microscopic"
        '
        'MetroLabel53
        '
        Me.MetroLabel53.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel53.AutoSize = True
        Me.MetroLabel53.Location = New System.Drawing.Point(2, 273)
        Me.MetroLabel53.Name = "MetroLabel53"
        Me.MetroLabel53.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel53.TabIndex = 770
        Me.MetroLabel53.Text = "RBC:"
        '
        'mtxt_uri_wbc
        '
        '
        '
        '
        Me.mtxt_uri_wbc.CustomButton.Image = Nothing
        Me.mtxt_uri_wbc.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.mtxt_uri_wbc.CustomButton.Name = ""
        Me.mtxt_uri_wbc.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_uri_wbc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_uri_wbc.CustomButton.TabIndex = 1
        Me.mtxt_uri_wbc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_uri_wbc.CustomButton.UseSelectable = True
        Me.mtxt_uri_wbc.CustomButton.Visible = False
        Me.mtxt_uri_wbc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_uri_wbc", True))
        Me.mtxt_uri_wbc.Lines = New String(-1) {}
        Me.mtxt_uri_wbc.Location = New System.Drawing.Point(94, 244)
        Me.mtxt_uri_wbc.MaxLength = 32767
        Me.mtxt_uri_wbc.Name = "mtxt_uri_wbc"
        Me.mtxt_uri_wbc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_uri_wbc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_uri_wbc.SelectedText = ""
        Me.mtxt_uri_wbc.SelectionLength = 0
        Me.mtxt_uri_wbc.SelectionStart = 0
        Me.mtxt_uri_wbc.ShortcutsEnabled = True
        Me.mtxt_uri_wbc.Size = New System.Drawing.Size(101, 23)
        Me.mtxt_uri_wbc.TabIndex = 6
        Me.mtxt_uri_wbc.UseSelectable = True
        Me.mtxt_uri_wbc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_uri_wbc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel54
        '
        Me.MetroLabel54.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel54.AutoSize = True
        Me.MetroLabel54.Location = New System.Drawing.Point(2, 244)
        Me.MetroLabel54.Name = "MetroLabel54"
        Me.MetroLabel54.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel54.TabIndex = 768
        Me.MetroLabel54.Text = "WBC:"
        '
        'MetroLabel37
        '
        Me.MetroLabel37.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel37.AutoSize = True
        Me.MetroLabel37.Location = New System.Drawing.Point(2, 186)
        Me.MetroLabel37.Name = "MetroLabel37"
        Me.MetroLabel37.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel37.TabIndex = 765
        Me.MetroLabel37.Text = "Sugar:"
        '
        'MetroLabel38
        '
        Me.MetroLabel38.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel38.AutoSize = True
        Me.MetroLabel38.Location = New System.Drawing.Point(2, 155)
        Me.MetroLabel38.Name = "MetroLabel38"
        Me.MetroLabel38.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel38.TabIndex = 764
        Me.MetroLabel38.Text = "Albumin:"
        '
        'MetroLabel39
        '
        Me.MetroLabel39.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel39.AutoSize = True
        Me.MetroLabel39.Location = New System.Drawing.Point(2, 124)
        Me.MetroLabel39.Name = "MetroLabel39"
        Me.MetroLabel39.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel39.TabIndex = 763
        Me.MetroLabel39.Text = "pH:"
        '
        'MetroLabel40
        '
        Me.MetroLabel40.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel40.AutoSize = True
        Me.MetroLabel40.Location = New System.Drawing.Point(2, 93)
        Me.MetroLabel40.Name = "MetroLabel40"
        Me.MetroLabel40.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel40.TabIndex = 762
        Me.MetroLabel40.Text = "S. Gravity:"
        '
        'MetroLabel50
        '
        Me.MetroLabel50.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel50.AutoSize = True
        Me.MetroLabel50.Location = New System.Drawing.Point(2, 62)
        Me.MetroLabel50.Name = "MetroLabel50"
        Me.MetroLabel50.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel50.TabIndex = 761
        Me.MetroLabel50.Text = "Transparency:"
        '
        'MetroLabel51
        '
        Me.MetroLabel51.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel51.AutoSize = True
        Me.MetroLabel51.Location = New System.Drawing.Point(2, 31)
        Me.MetroLabel51.Name = "MetroLabel51"
        Me.MetroLabel51.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel51.TabIndex = 760
        Me.MetroLabel51.Text = "Color:"
        '
        'MetroLabel84
        '
        Me.MetroLabel84.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel84.AutoSize = True
        Me.MetroLabel84.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel84.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel84.Location = New System.Drawing.Point(56, -1)
        Me.MetroLabel84.Name = "MetroLabel84"
        Me.MetroLabel84.Size = New System.Drawing.Size(94, 25)
        Me.MetroLabel84.TabIndex = 698
        Me.MetroLabel84.Text = "Urinalysis"
        '
        'mpnl_feca
        '
        Me.mpnl_feca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_bacteria)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_fats)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_tropho)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_enta)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_hook)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_trichuris)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_ascaris)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_occult)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_consist)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_color)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_others2)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel36)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel34)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel35)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_rbc)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_others)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel32)
        Me.mpnl_feca.Controls.Add(Me.mtxt_feca_wbc)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel33)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel31)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel41)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel42)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel43)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel44)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel45)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel46)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel47)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel48)
        Me.mpnl_feca.Controls.Add(Me.MetroLabel49)
        Me.mpnl_feca.HorizontalScrollbarBarColor = True
        Me.mpnl_feca.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_feca.HorizontalScrollbarSize = 10
        Me.mpnl_feca.Location = New System.Drawing.Point(207, 248)
        Me.mpnl_feca.Name = "mpnl_feca"
        Me.mpnl_feca.Size = New System.Drawing.Size(200, 673)
        Me.mpnl_feca.TabIndex = 0
        Me.mpnl_feca.VerticalScrollbarBarColor = True
        Me.mpnl_feca.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_feca.VerticalScrollbarSize = 10
        '
        'mtxt_feca_bacteria
        '
        Me.mtxt_feca_bacteria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_bacteria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_bacteria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_bacteria.CustomButton.Image = Nothing
        Me.mtxt_feca_bacteria.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_bacteria.CustomButton.Name = ""
        Me.mtxt_feca_bacteria.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_bacteria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_bacteria.CustomButton.TabIndex = 1
        Me.mtxt_feca_bacteria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_bacteria.CustomButton.UseSelectable = True
        Me.mtxt_feca_bacteria.CustomButton.Visible = False
        Me.mtxt_feca_bacteria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_bacteria", True))
        Me.mtxt_feca_bacteria.Lines = New String(-1) {}
        Me.mtxt_feca_bacteria.Location = New System.Drawing.Point(93, 462)
        Me.mtxt_feca_bacteria.MaxLength = 32767
        Me.mtxt_feca_bacteria.Name = "mtxt_feca_bacteria"
        Me.mtxt_feca_bacteria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_bacteria.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_bacteria.SelectedText = ""
        Me.mtxt_feca_bacteria.SelectionLength = 0
        Me.mtxt_feca_bacteria.SelectionStart = 0
        Me.mtxt_feca_bacteria.ShortcutsEnabled = True
        Me.mtxt_feca_bacteria.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_bacteria.TabIndex = 12
        Me.mtxt_feca_bacteria.UseSelectable = True
        Me.mtxt_feca_bacteria.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_bacteria.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_fats
        '
        Me.mtxt_feca_fats.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_fats.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_fats.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_fats.CustomButton.Image = Nothing
        Me.mtxt_feca_fats.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_fats.CustomButton.Name = ""
        Me.mtxt_feca_fats.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_fats.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_fats.CustomButton.TabIndex = 1
        Me.mtxt_feca_fats.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_fats.CustomButton.UseSelectable = True
        Me.mtxt_feca_fats.CustomButton.Visible = False
        Me.mtxt_feca_fats.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_fats", True))
        Me.mtxt_feca_fats.Lines = New String(-1) {}
        Me.mtxt_feca_fats.Location = New System.Drawing.Point(93, 433)
        Me.mtxt_feca_fats.MaxLength = 32767
        Me.mtxt_feca_fats.Name = "mtxt_feca_fats"
        Me.mtxt_feca_fats.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_fats.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_fats.SelectedText = ""
        Me.mtxt_feca_fats.SelectionLength = 0
        Me.mtxt_feca_fats.SelectionStart = 0
        Me.mtxt_feca_fats.ShortcutsEnabled = True
        Me.mtxt_feca_fats.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_fats.TabIndex = 11
        Me.mtxt_feca_fats.UseSelectable = True
        Me.mtxt_feca_fats.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_fats.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_tropho
        '
        Me.mtxt_feca_tropho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_tropho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_tropho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_tropho.CustomButton.Image = Nothing
        Me.mtxt_feca_tropho.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_tropho.CustomButton.Name = ""
        Me.mtxt_feca_tropho.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_tropho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_tropho.CustomButton.TabIndex = 1
        Me.mtxt_feca_tropho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_tropho.CustomButton.UseSelectable = True
        Me.mtxt_feca_tropho.CustomButton.Visible = False
        Me.mtxt_feca_tropho.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_tropho", True))
        Me.mtxt_feca_tropho.Lines = New String(-1) {}
        Me.mtxt_feca_tropho.Location = New System.Drawing.Point(93, 242)
        Me.mtxt_feca_tropho.MaxLength = 32767
        Me.mtxt_feca_tropho.Name = "mtxt_feca_tropho"
        Me.mtxt_feca_tropho.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_tropho.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_tropho.SelectedText = ""
        Me.mtxt_feca_tropho.SelectionLength = 0
        Me.mtxt_feca_tropho.SelectionStart = 0
        Me.mtxt_feca_tropho.ShortcutsEnabled = True
        Me.mtxt_feca_tropho.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_tropho.TabIndex = 7
        Me.mtxt_feca_tropho.UseSelectable = True
        Me.mtxt_feca_tropho.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_tropho.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_enta
        '
        Me.mtxt_feca_enta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_enta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_enta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_enta.CustomButton.Image = Nothing
        Me.mtxt_feca_enta.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_enta.CustomButton.Name = ""
        Me.mtxt_feca_enta.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_enta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_enta.CustomButton.TabIndex = 1
        Me.mtxt_feca_enta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_enta.CustomButton.UseSelectable = True
        Me.mtxt_feca_enta.CustomButton.Visible = False
        Me.mtxt_feca_enta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_entamoeba", True))
        Me.mtxt_feca_enta.Lines = New String(-1) {}
        Me.mtxt_feca_enta.Location = New System.Drawing.Point(93, 213)
        Me.mtxt_feca_enta.MaxLength = 32767
        Me.mtxt_feca_enta.Name = "mtxt_feca_enta"
        Me.mtxt_feca_enta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_enta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_enta.SelectedText = ""
        Me.mtxt_feca_enta.SelectionLength = 0
        Me.mtxt_feca_enta.SelectionStart = 0
        Me.mtxt_feca_enta.ShortcutsEnabled = True
        Me.mtxt_feca_enta.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_enta.TabIndex = 6
        Me.mtxt_feca_enta.UseSelectable = True
        Me.mtxt_feca_enta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_enta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_hook
        '
        Me.mtxt_feca_hook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_hook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_hook.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_hook.CustomButton.Image = Nothing
        Me.mtxt_feca_hook.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_hook.CustomButton.Name = ""
        Me.mtxt_feca_hook.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_hook.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_hook.CustomButton.TabIndex = 1
        Me.mtxt_feca_hook.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_hook.CustomButton.UseSelectable = True
        Me.mtxt_feca_hook.CustomButton.Visible = False
        Me.mtxt_feca_hook.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_hookworm", True))
        Me.mtxt_feca_hook.Lines = New String(-1) {}
        Me.mtxt_feca_hook.Location = New System.Drawing.Point(93, 186)
        Me.mtxt_feca_hook.MaxLength = 32767
        Me.mtxt_feca_hook.Name = "mtxt_feca_hook"
        Me.mtxt_feca_hook.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_hook.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_hook.SelectedText = ""
        Me.mtxt_feca_hook.SelectionLength = 0
        Me.mtxt_feca_hook.SelectionStart = 0
        Me.mtxt_feca_hook.ShortcutsEnabled = True
        Me.mtxt_feca_hook.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_hook.TabIndex = 5
        Me.mtxt_feca_hook.UseSelectable = True
        Me.mtxt_feca_hook.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_hook.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_trichuris
        '
        Me.mtxt_feca_trichuris.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_trichuris.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_trichuris.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_trichuris.CustomButton.Image = Nothing
        Me.mtxt_feca_trichuris.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_trichuris.CustomButton.Name = ""
        Me.mtxt_feca_trichuris.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_trichuris.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_trichuris.CustomButton.TabIndex = 1
        Me.mtxt_feca_trichuris.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_trichuris.CustomButton.UseSelectable = True
        Me.mtxt_feca_trichuris.CustomButton.Visible = False
        Me.mtxt_feca_trichuris.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_trichuris", True))
        Me.mtxt_feca_trichuris.Lines = New String(-1) {}
        Me.mtxt_feca_trichuris.Location = New System.Drawing.Point(93, 155)
        Me.mtxt_feca_trichuris.MaxLength = 32767
        Me.mtxt_feca_trichuris.Name = "mtxt_feca_trichuris"
        Me.mtxt_feca_trichuris.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_trichuris.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_trichuris.SelectedText = ""
        Me.mtxt_feca_trichuris.SelectionLength = 0
        Me.mtxt_feca_trichuris.SelectionStart = 0
        Me.mtxt_feca_trichuris.ShortcutsEnabled = True
        Me.mtxt_feca_trichuris.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_trichuris.TabIndex = 4
        Me.mtxt_feca_trichuris.UseSelectable = True
        Me.mtxt_feca_trichuris.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_trichuris.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_ascaris
        '
        Me.mtxt_feca_ascaris.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_ascaris.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_ascaris.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_ascaris.CustomButton.Image = Nothing
        Me.mtxt_feca_ascaris.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_ascaris.CustomButton.Name = ""
        Me.mtxt_feca_ascaris.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_ascaris.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_ascaris.CustomButton.TabIndex = 1
        Me.mtxt_feca_ascaris.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_ascaris.CustomButton.UseSelectable = True
        Me.mtxt_feca_ascaris.CustomButton.Visible = False
        Me.mtxt_feca_ascaris.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_ascaris", True))
        Me.mtxt_feca_ascaris.Lines = New String(-1) {}
        Me.mtxt_feca_ascaris.Location = New System.Drawing.Point(93, 124)
        Me.mtxt_feca_ascaris.MaxLength = 32767
        Me.mtxt_feca_ascaris.Name = "mtxt_feca_ascaris"
        Me.mtxt_feca_ascaris.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_ascaris.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_ascaris.SelectedText = ""
        Me.mtxt_feca_ascaris.SelectionLength = 0
        Me.mtxt_feca_ascaris.SelectionStart = 0
        Me.mtxt_feca_ascaris.ShortcutsEnabled = True
        Me.mtxt_feca_ascaris.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_ascaris.TabIndex = 3
        Me.mtxt_feca_ascaris.UseSelectable = True
        Me.mtxt_feca_ascaris.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_ascaris.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_occult
        '
        Me.mtxt_feca_occult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_occult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_occult.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_occult.CustomButton.Image = Nothing
        Me.mtxt_feca_occult.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_occult.CustomButton.Name = ""
        Me.mtxt_feca_occult.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_occult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_occult.CustomButton.TabIndex = 1
        Me.mtxt_feca_occult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_occult.CustomButton.UseSelectable = True
        Me.mtxt_feca_occult.CustomButton.Visible = False
        Me.mtxt_feca_occult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_occult", True))
        Me.mtxt_feca_occult.Lines = New String(-1) {}
        Me.mtxt_feca_occult.Location = New System.Drawing.Point(93, 93)
        Me.mtxt_feca_occult.MaxLength = 32767
        Me.mtxt_feca_occult.Name = "mtxt_feca_occult"
        Me.mtxt_feca_occult.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_occult.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_occult.SelectedText = ""
        Me.mtxt_feca_occult.SelectionLength = 0
        Me.mtxt_feca_occult.SelectionStart = 0
        Me.mtxt_feca_occult.ShortcutsEnabled = True
        Me.mtxt_feca_occult.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_occult.TabIndex = 2
        Me.mtxt_feca_occult.UseSelectable = True
        Me.mtxt_feca_occult.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_occult.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_consist
        '
        Me.mtxt_feca_consist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_consist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_consist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_consist.CustomButton.Image = Nothing
        Me.mtxt_feca_consist.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_consist.CustomButton.Name = ""
        Me.mtxt_feca_consist.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_consist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_consist.CustomButton.TabIndex = 1
        Me.mtxt_feca_consist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_consist.CustomButton.UseSelectable = True
        Me.mtxt_feca_consist.CustomButton.Visible = False
        Me.mtxt_feca_consist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_consistency", True))
        Me.mtxt_feca_consist.Lines = New String(-1) {}
        Me.mtxt_feca_consist.Location = New System.Drawing.Point(93, 62)
        Me.mtxt_feca_consist.MaxLength = 32767
        Me.mtxt_feca_consist.Name = "mtxt_feca_consist"
        Me.mtxt_feca_consist.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_consist.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_consist.SelectedText = ""
        Me.mtxt_feca_consist.SelectionLength = 0
        Me.mtxt_feca_consist.SelectionStart = 0
        Me.mtxt_feca_consist.ShortcutsEnabled = True
        Me.mtxt_feca_consist.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_consist.TabIndex = 1
        Me.mtxt_feca_consist.UseSelectable = True
        Me.mtxt_feca_consist.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_consist.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_color
        '
        Me.mtxt_feca_color.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_feca_color.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_feca_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_feca_color.CustomButton.Image = Nothing
        Me.mtxt_feca_color.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_color.CustomButton.Name = ""
        Me.mtxt_feca_color.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_color.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_color.CustomButton.TabIndex = 1
        Me.mtxt_feca_color.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_color.CustomButton.UseSelectable = True
        Me.mtxt_feca_color.CustomButton.Visible = False
        Me.mtxt_feca_color.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_color", True))
        Me.mtxt_feca_color.Lines = New String(-1) {}
        Me.mtxt_feca_color.Location = New System.Drawing.Point(93, 31)
        Me.mtxt_feca_color.MaxLength = 32767
        Me.mtxt_feca_color.Name = "mtxt_feca_color"
        Me.mtxt_feca_color.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_color.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_color.SelectedText = ""
        Me.mtxt_feca_color.SelectionLength = 0
        Me.mtxt_feca_color.SelectionStart = 0
        Me.mtxt_feca_color.ShortcutsEnabled = True
        Me.mtxt_feca_color.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_color.TabIndex = 0
        Me.mtxt_feca_color.UseSelectable = True
        Me.mtxt_feca_color.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_color.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_others2
        '
        '
        '
        '
        Me.mtxt_feca_others2.CustomButton.Image = Nothing
        Me.mtxt_feca_others2.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.mtxt_feca_others2.CustomButton.Name = ""
        Me.mtxt_feca_others2.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.mtxt_feca_others2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_others2.CustomButton.TabIndex = 1
        Me.mtxt_feca_others2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_others2.CustomButton.UseSelectable = True
        Me.mtxt_feca_others2.CustomButton.Visible = False
        Me.mtxt_feca_others2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_others_02", True))
        Me.mtxt_feca_others2.Lines = New String(-1) {}
        Me.mtxt_feca_others2.Location = New System.Drawing.Point(18, 516)
        Me.mtxt_feca_others2.MaxLength = 32767
        Me.mtxt_feca_others2.Multiline = True
        Me.mtxt_feca_others2.Name = "mtxt_feca_others2"
        Me.mtxt_feca_others2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_others2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mtxt_feca_others2.SelectedText = ""
        Me.mtxt_feca_others2.SelectionLength = 0
        Me.mtxt_feca_others2.SelectionStart = 0
        Me.mtxt_feca_others2.ShortcutsEnabled = True
        Me.mtxt_feca_others2.Size = New System.Drawing.Size(174, 47)
        Me.mtxt_feca_others2.TabIndex = 13
        Me.mtxt_feca_others2.UseSelectable = True
        Me.mtxt_feca_others2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_others2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel36
        '
        Me.MetroLabel36.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel36.AutoSize = True
        Me.MetroLabel36.Location = New System.Drawing.Point(1, 494)
        Me.MetroLabel36.Name = "MetroLabel36"
        Me.MetroLabel36.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel36.TabIndex = 766
        Me.MetroLabel36.Text = "Others:"
        '
        'MetroLabel34
        '
        Me.MetroLabel34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.Location = New System.Drawing.Point(1, 464)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel34.TabIndex = 763
        Me.MetroLabel34.Text = "Bacteria:"
        '
        'MetroLabel35
        '
        Me.MetroLabel35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.Location = New System.Drawing.Point(1, 433)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel35.TabIndex = 762
        Me.MetroLabel35.Text = "Fats Globules:"
        '
        'mtxt_feca_rbc
        '
        '
        '
        '
        Me.mtxt_feca_rbc.CustomButton.Image = Nothing
        Me.mtxt_feca_rbc.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_rbc.CustomButton.Name = ""
        Me.mtxt_feca_rbc.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_rbc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_rbc.CustomButton.TabIndex = 1
        Me.mtxt_feca_rbc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_rbc.CustomButton.UseSelectable = True
        Me.mtxt_feca_rbc.CustomButton.Visible = False
        Me.mtxt_feca_rbc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_rbc", True))
        Me.mtxt_feca_rbc.Lines = New String(-1) {}
        Me.mtxt_feca_rbc.Location = New System.Drawing.Point(93, 404)
        Me.mtxt_feca_rbc.MaxLength = 32767
        Me.mtxt_feca_rbc.Name = "mtxt_feca_rbc"
        Me.mtxt_feca_rbc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_rbc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_rbc.SelectedText = ""
        Me.mtxt_feca_rbc.SelectionLength = 0
        Me.mtxt_feca_rbc.SelectionStart = 0
        Me.mtxt_feca_rbc.ShortcutsEnabled = True
        Me.mtxt_feca_rbc.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_rbc.TabIndex = 10
        Me.mtxt_feca_rbc.UseSelectable = True
        Me.mtxt_feca_rbc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_rbc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_feca_others
        '
        '
        '
        '
        Me.mtxt_feca_others.CustomButton.Image = Nothing
        Me.mtxt_feca_others.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.mtxt_feca_others.CustomButton.Name = ""
        Me.mtxt_feca_others.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.mtxt_feca_others.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_others.CustomButton.TabIndex = 1
        Me.mtxt_feca_others.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_others.CustomButton.UseSelectable = True
        Me.mtxt_feca_others.CustomButton.Visible = False
        Me.mtxt_feca_others.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_others_01", True))
        Me.mtxt_feca_others.Lines = New String(-1) {}
        Me.mtxt_feca_others.Location = New System.Drawing.Point(18, 299)
        Me.mtxt_feca_others.MaxLength = 32767
        Me.mtxt_feca_others.Multiline = True
        Me.mtxt_feca_others.Name = "mtxt_feca_others"
        Me.mtxt_feca_others.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_others.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mtxt_feca_others.SelectedText = ""
        Me.mtxt_feca_others.SelectionLength = 0
        Me.mtxt_feca_others.SelectionStart = 0
        Me.mtxt_feca_others.ShortcutsEnabled = True
        Me.mtxt_feca_others.Size = New System.Drawing.Size(174, 47)
        Me.mtxt_feca_others.TabIndex = 8
        Me.mtxt_feca_others.UseSelectable = True
        Me.mtxt_feca_others.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_others.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel32
        '
        Me.MetroLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.Location = New System.Drawing.Point(1, 404)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel32.TabIndex = 755
        Me.MetroLabel32.Text = "RBC:"
        '
        'mtxt_feca_wbc
        '
        '
        '
        '
        Me.mtxt_feca_wbc.CustomButton.Image = Nothing
        Me.mtxt_feca_wbc.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.mtxt_feca_wbc.CustomButton.Name = ""
        Me.mtxt_feca_wbc.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_feca_wbc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_feca_wbc.CustomButton.TabIndex = 1
        Me.mtxt_feca_wbc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_feca_wbc.CustomButton.UseSelectable = True
        Me.mtxt_feca_wbc.CustomButton.Visible = False
        Me.mtxt_feca_wbc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_feca_wbc", True))
        Me.mtxt_feca_wbc.Lines = New String(-1) {}
        Me.mtxt_feca_wbc.Location = New System.Drawing.Point(93, 375)
        Me.mtxt_feca_wbc.MaxLength = 32767
        Me.mtxt_feca_wbc.Name = "mtxt_feca_wbc"
        Me.mtxt_feca_wbc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_feca_wbc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_feca_wbc.SelectedText = ""
        Me.mtxt_feca_wbc.SelectionLength = 0
        Me.mtxt_feca_wbc.SelectionStart = 0
        Me.mtxt_feca_wbc.ShortcutsEnabled = True
        Me.mtxt_feca_wbc.Size = New System.Drawing.Size(99, 23)
        Me.mtxt_feca_wbc.TabIndex = 9
        Me.mtxt_feca_wbc.UseSelectable = True
        Me.mtxt_feca_wbc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_feca_wbc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel33
        '
        Me.MetroLabel33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel33.AutoSize = True
        Me.MetroLabel33.Location = New System.Drawing.Point(1, 375)
        Me.MetroLabel33.Name = "MetroLabel33"
        Me.MetroLabel33.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel33.TabIndex = 753
        Me.MetroLabel33.Text = "WBC:"
        '
        'MetroLabel31
        '
        Me.MetroLabel31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.Location = New System.Drawing.Point(1, 277)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel31.TabIndex = 753
        Me.MetroLabel31.Text = "Others:"
        '
        'MetroLabel41
        '
        Me.MetroLabel41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel41.AutoSize = True
        Me.MetroLabel41.Location = New System.Drawing.Point(1, 248)
        Me.MetroLabel41.Name = "MetroLabel41"
        Me.MetroLabel41.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel41.TabIndex = 732
        Me.MetroLabel41.Text = "Trophozoites:"
        '
        'MetroLabel42
        '
        Me.MetroLabel42.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel42.AutoSize = True
        Me.MetroLabel42.Location = New System.Drawing.Point(1, 217)
        Me.MetroLabel42.Name = "MetroLabel42"
        Me.MetroLabel42.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel42.TabIndex = 729
        Me.MetroLabel42.Text = "Entamoeba:"
        '
        'MetroLabel43
        '
        Me.MetroLabel43.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel43.AutoSize = True
        Me.MetroLabel43.Location = New System.Drawing.Point(1, 186)
        Me.MetroLabel43.Name = "MetroLabel43"
        Me.MetroLabel43.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel43.TabIndex = 728
        Me.MetroLabel43.Text = "Hookworm O.:"
        '
        'MetroLabel44
        '
        Me.MetroLabel44.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel44.AutoSize = True
        Me.MetroLabel44.Location = New System.Drawing.Point(1, 155)
        Me.MetroLabel44.Name = "MetroLabel44"
        Me.MetroLabel44.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel44.TabIndex = 726
        Me.MetroLabel44.Text = "Trichuris O.:"
        '
        'MetroLabel45
        '
        Me.MetroLabel45.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel45.AutoSize = True
        Me.MetroLabel45.Location = New System.Drawing.Point(1, 124)
        Me.MetroLabel45.Name = "MetroLabel45"
        Me.MetroLabel45.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel45.TabIndex = 723
        Me.MetroLabel45.Text = "Ascaris O.:"
        '
        'MetroLabel46
        '
        Me.MetroLabel46.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel46.AutoSize = True
        Me.MetroLabel46.Location = New System.Drawing.Point(1, 93)
        Me.MetroLabel46.Name = "MetroLabel46"
        Me.MetroLabel46.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel46.TabIndex = 722
        Me.MetroLabel46.Text = "Occult Blood:"
        '
        'MetroLabel47
        '
        Me.MetroLabel47.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel47.AutoSize = True
        Me.MetroLabel47.Location = New System.Drawing.Point(1, 62)
        Me.MetroLabel47.Name = "MetroLabel47"
        Me.MetroLabel47.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel47.TabIndex = 719
        Me.MetroLabel47.Text = "Consistency:"
        '
        'MetroLabel48
        '
        Me.MetroLabel48.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel48.AutoSize = True
        Me.MetroLabel48.Location = New System.Drawing.Point(1, 31)
        Me.MetroLabel48.Name = "MetroLabel48"
        Me.MetroLabel48.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel48.TabIndex = 718
        Me.MetroLabel48.Text = "Color:"
        '
        'MetroLabel49
        '
        Me.MetroLabel49.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel49.AutoSize = True
        Me.MetroLabel49.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel49.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel49.Location = New System.Drawing.Point(60, -1)
        Me.MetroLabel49.Name = "MetroLabel49"
        Me.MetroLabel49.Size = New System.Drawing.Size(86, 25)
        Me.MetroLabel49.TabIndex = 698
        Me.MetroLabel49.Text = "Fecalysis"
        '
        'mpnl_hema
        '
        Me.mpnl_hema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_others)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel30)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_blood)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel29)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_hepaa)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel22)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_hepab)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_baso)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel23)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel24)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_mono)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel25)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_eosino)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_lympho)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel26)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel27)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_segmenters)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel28)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel21)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_platelets)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel20)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_bleeding)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_clotting)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel17)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel18)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_esr)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel19)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_leuko)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_erythro)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel15)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel16)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_hema)
        Me.mpnl_hema.Controls.Add(Me.mtxt_hema_hemo)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel14)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel13)
        Me.mpnl_hema.Controls.Add(Me.MetroLabel12)
        Me.mpnl_hema.HorizontalScrollbarBarColor = True
        Me.mpnl_hema.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_hema.HorizontalScrollbarSize = 10
        Me.mpnl_hema.Location = New System.Drawing.Point(8, 248)
        Me.mpnl_hema.Name = "mpnl_hema"
        Me.mpnl_hema.Size = New System.Drawing.Size(200, 673)
        Me.mpnl_hema.TabIndex = 717
        Me.mpnl_hema.VerticalScrollbarBarColor = True
        Me.mpnl_hema.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_hema.VerticalScrollbarSize = 10
        '
        'mtxt_hema_others
        '
        '
        '
        '
        Me.mtxt_hema_others.CustomButton.Image = Nothing
        Me.mtxt_hema_others.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.mtxt_hema_others.CustomButton.Name = ""
        Me.mtxt_hema_others.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.mtxt_hema_others.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_others.CustomButton.TabIndex = 1
        Me.mtxt_hema_others.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_others.CustomButton.UseSelectable = True
        Me.mtxt_hema_others.CustomButton.Visible = False
        Me.mtxt_hema_others.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_others", True))
        Me.mtxt_hema_others.Lines = New String(-1) {}
        Me.mtxt_hema_others.Location = New System.Drawing.Point(18, 541)
        Me.mtxt_hema_others.MaxLength = 32767
        Me.mtxt_hema_others.Multiline = True
        Me.mtxt_hema_others.Name = "mtxt_hema_others"
        Me.mtxt_hema_others.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_others.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mtxt_hema_others.SelectedText = ""
        Me.mtxt_hema_others.SelectionLength = 0
        Me.mtxt_hema_others.SelectionStart = 0
        Me.mtxt_hema_others.ShortcutsEnabled = True
        Me.mtxt_hema_others.Size = New System.Drawing.Size(176, 47)
        Me.mtxt_hema_others.TabIndex = 16
        Me.mtxt_hema_others.UseSelectable = True
        Me.mtxt_hema_others.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_others.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel30
        '
        Me.MetroLabel30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.Location = New System.Drawing.Point(1, 519)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel30.TabIndex = 751
        Me.MetroLabel30.Text = "Others:"
        '
        'mtxt_hema_blood
        '
        Me.mtxt_hema_blood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_hema_blood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_hema_blood.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_hema_blood.CustomButton.Image = Nothing
        Me.mtxt_hema_blood.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_blood.CustomButton.Name = ""
        Me.mtxt_hema_blood.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_blood.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_blood.CustomButton.TabIndex = 1
        Me.mtxt_hema_blood.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_blood.CustomButton.UseSelectable = True
        Me.mtxt_hema_blood.CustomButton.Visible = False
        Me.mtxt_hema_blood.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_blood", True))
        Me.mtxt_hema_blood.Lines = New String(-1) {}
        Me.mtxt_hema_blood.Location = New System.Drawing.Point(98, 491)
        Me.mtxt_hema_blood.MaxLength = 32767
        Me.mtxt_hema_blood.Name = "mtxt_hema_blood"
        Me.mtxt_hema_blood.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_blood.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_blood.SelectedText = ""
        Me.mtxt_hema_blood.SelectionLength = 0
        Me.mtxt_hema_blood.SelectionStart = 0
        Me.mtxt_hema_blood.ShortcutsEnabled = True
        Me.mtxt_hema_blood.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_blood.TabIndex = 15
        Me.mtxt_hema_blood.UseSelectable = True
        Me.mtxt_hema_blood.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_blood.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel29
        '
        Me.MetroLabel29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.Location = New System.Drawing.Point(1, 491)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel29.TabIndex = 749
        Me.MetroLabel29.Text = "Blood Typing:"
        '
        'mtxt_hema_hepaa
        '
        '
        '
        '
        Me.mtxt_hema_hepaa.CustomButton.Image = Nothing
        Me.mtxt_hema_hepaa.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_hepaa.CustomButton.Name = ""
        Me.mtxt_hema_hepaa.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_hepaa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_hepaa.CustomButton.TabIndex = 1
        Me.mtxt_hema_hepaa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_hepaa.CustomButton.UseSelectable = True
        Me.mtxt_hema_hepaa.CustomButton.Visible = False
        Me.mtxt_hema_hepaa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_hepaa", True))
        Me.mtxt_hema_hepaa.Lines = New String(-1) {}
        Me.mtxt_hema_hepaa.Location = New System.Drawing.Point(98, 462)
        Me.mtxt_hema_hepaa.MaxLength = 32767
        Me.mtxt_hema_hepaa.Name = "mtxt_hema_hepaa"
        Me.mtxt_hema_hepaa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_hepaa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_hepaa.SelectedText = ""
        Me.mtxt_hema_hepaa.SelectionLength = 0
        Me.mtxt_hema_hepaa.SelectionStart = 0
        Me.mtxt_hema_hepaa.ShortcutsEnabled = True
        Me.mtxt_hema_hepaa.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_hepaa.TabIndex = 14
        Me.mtxt_hema_hepaa.UseSelectable = True
        Me.mtxt_hema_hepaa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_hepaa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel22
        '
        Me.MetroLabel22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(1, 462)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel22.TabIndex = 747
        Me.MetroLabel22.Text = "Hepa A:"
        '
        'mtxt_hema_hepab
        '
        Me.mtxt_hema_hepab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_hema_hepab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_hema_hepab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_hema_hepab.CustomButton.Image = Nothing
        Me.mtxt_hema_hepab.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_hepab.CustomButton.Name = ""
        Me.mtxt_hema_hepab.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_hepab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_hepab.CustomButton.TabIndex = 1
        Me.mtxt_hema_hepab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_hepab.CustomButton.UseSelectable = True
        Me.mtxt_hema_hepab.CustomButton.Visible = False
        Me.mtxt_hema_hepab.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_hepab", True))
        Me.mtxt_hema_hepab.Lines = New String(-1) {}
        Me.mtxt_hema_hepab.Location = New System.Drawing.Point(98, 433)
        Me.mtxt_hema_hepab.MaxLength = 32767
        Me.mtxt_hema_hepab.Name = "mtxt_hema_hepab"
        Me.mtxt_hema_hepab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_hepab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_hepab.SelectedText = ""
        Me.mtxt_hema_hepab.SelectionLength = 0
        Me.mtxt_hema_hepab.SelectionStart = 0
        Me.mtxt_hema_hepab.ShortcutsEnabled = True
        Me.mtxt_hema_hepab.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_hepab.TabIndex = 13
        Me.mtxt_hema_hepab.UseSelectable = True
        Me.mtxt_hema_hepab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_hepab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_hema_baso
        '
        '
        '
        '
        Me.mtxt_hema_baso.CustomButton.Image = Nothing
        Me.mtxt_hema_baso.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_baso.CustomButton.Name = ""
        Me.mtxt_hema_baso.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_baso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_baso.CustomButton.TabIndex = 1
        Me.mtxt_hema_baso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_baso.CustomButton.UseSelectable = True
        Me.mtxt_hema_baso.CustomButton.Visible = False
        Me.mtxt_hema_baso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_basophils", True))
        Me.mtxt_hema_baso.Lines = New String(-1) {}
        Me.mtxt_hema_baso.Location = New System.Drawing.Point(98, 404)
        Me.mtxt_hema_baso.MaxLength = 32767
        Me.mtxt_hema_baso.Name = "mtxt_hema_baso"
        Me.mtxt_hema_baso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_baso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_baso.SelectedText = ""
        Me.mtxt_hema_baso.SelectionLength = 0
        Me.mtxt_hema_baso.SelectionStart = 0
        Me.mtxt_hema_baso.ShortcutsEnabled = True
        Me.mtxt_hema_baso.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_baso.TabIndex = 12
        Me.mtxt_hema_baso.UseSelectable = True
        Me.mtxt_hema_baso.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_baso.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel23
        '
        Me.MetroLabel23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(1, 433)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel23.TabIndex = 744
        Me.MetroLabel23.Text = "Hepa B:"
        '
        'MetroLabel24
        '
        Me.MetroLabel24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.Location = New System.Drawing.Point(1, 404)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel24.TabIndex = 743
        Me.MetroLabel24.Text = "Basophils:"
        '
        'mtxt_hema_mono
        '
        '
        '
        '
        Me.mtxt_hema_mono.CustomButton.Image = Nothing
        Me.mtxt_hema_mono.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_mono.CustomButton.Name = ""
        Me.mtxt_hema_mono.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_mono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_mono.CustomButton.TabIndex = 1
        Me.mtxt_hema_mono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_mono.CustomButton.UseSelectable = True
        Me.mtxt_hema_mono.CustomButton.Visible = False
        Me.mtxt_hema_mono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_monocytes", True))
        Me.mtxt_hema_mono.Lines = New String(-1) {}
        Me.mtxt_hema_mono.Location = New System.Drawing.Point(98, 375)
        Me.mtxt_hema_mono.MaxLength = 32767
        Me.mtxt_hema_mono.Name = "mtxt_hema_mono"
        Me.mtxt_hema_mono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_mono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_mono.SelectedText = ""
        Me.mtxt_hema_mono.SelectionLength = 0
        Me.mtxt_hema_mono.SelectionStart = 0
        Me.mtxt_hema_mono.ShortcutsEnabled = True
        Me.mtxt_hema_mono.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_mono.TabIndex = 11
        Me.mtxt_hema_mono.UseSelectable = True
        Me.mtxt_hema_mono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_mono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel25
        '
        Me.MetroLabel25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.Location = New System.Drawing.Point(1, 375)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel25.TabIndex = 741
        Me.MetroLabel25.Text = "Monocytes:"
        '
        'mtxt_hema_eosino
        '
        '
        '
        '
        Me.mtxt_hema_eosino.CustomButton.Image = Nothing
        Me.mtxt_hema_eosino.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_eosino.CustomButton.Name = ""
        Me.mtxt_hema_eosino.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_eosino.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_eosino.CustomButton.TabIndex = 1
        Me.mtxt_hema_eosino.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_eosino.CustomButton.UseSelectable = True
        Me.mtxt_hema_eosino.CustomButton.Visible = False
        Me.mtxt_hema_eosino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_esoniphils", True))
        Me.mtxt_hema_eosino.Lines = New String(-1) {}
        Me.mtxt_hema_eosino.Location = New System.Drawing.Point(98, 346)
        Me.mtxt_hema_eosino.MaxLength = 32767
        Me.mtxt_hema_eosino.Name = "mtxt_hema_eosino"
        Me.mtxt_hema_eosino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_eosino.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_eosino.SelectedText = ""
        Me.mtxt_hema_eosino.SelectionLength = 0
        Me.mtxt_hema_eosino.SelectionStart = 0
        Me.mtxt_hema_eosino.ShortcutsEnabled = True
        Me.mtxt_hema_eosino.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_eosino.TabIndex = 10
        Me.mtxt_hema_eosino.UseSelectable = True
        Me.mtxt_hema_eosino.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_eosino.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_hema_lympho
        '
        '
        '
        '
        Me.mtxt_hema_lympho.CustomButton.Image = Nothing
        Me.mtxt_hema_lympho.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_lympho.CustomButton.Name = ""
        Me.mtxt_hema_lympho.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_lympho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_lympho.CustomButton.TabIndex = 1
        Me.mtxt_hema_lympho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_lympho.CustomButton.UseSelectable = True
        Me.mtxt_hema_lympho.CustomButton.Visible = False
        Me.mtxt_hema_lympho.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_lymphocytes", True))
        Me.mtxt_hema_lympho.Lines = New String(-1) {}
        Me.mtxt_hema_lympho.Location = New System.Drawing.Point(98, 317)
        Me.mtxt_hema_lympho.MaxLength = 32767
        Me.mtxt_hema_lympho.Name = "mtxt_hema_lympho"
        Me.mtxt_hema_lympho.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_lympho.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_lympho.SelectedText = ""
        Me.mtxt_hema_lympho.SelectionLength = 0
        Me.mtxt_hema_lympho.SelectionStart = 0
        Me.mtxt_hema_lympho.ShortcutsEnabled = True
        Me.mtxt_hema_lympho.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_lympho.TabIndex = 9
        Me.mtxt_hema_lympho.UseSelectable = True
        Me.mtxt_hema_lympho.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_lympho.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel26
        '
        Me.MetroLabel26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.Location = New System.Drawing.Point(1, 346)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel26.TabIndex = 738
        Me.MetroLabel26.Text = "Eosinophils:"
        '
        'MetroLabel27
        '
        Me.MetroLabel27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.Location = New System.Drawing.Point(1, 317)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel27.TabIndex = 737
        Me.MetroLabel27.Text = "Lymphocytes:"
        '
        'mtxt_hema_segmenters
        '
        '
        '
        '
        Me.mtxt_hema_segmenters.CustomButton.Image = Nothing
        Me.mtxt_hema_segmenters.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_segmenters.CustomButton.Name = ""
        Me.mtxt_hema_segmenters.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_segmenters.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_segmenters.CustomButton.TabIndex = 1
        Me.mtxt_hema_segmenters.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_segmenters.CustomButton.UseSelectable = True
        Me.mtxt_hema_segmenters.CustomButton.Visible = False
        Me.mtxt_hema_segmenters.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_segmenters", True))
        Me.mtxt_hema_segmenters.Lines = New String(-1) {}
        Me.mtxt_hema_segmenters.Location = New System.Drawing.Point(98, 288)
        Me.mtxt_hema_segmenters.MaxLength = 32767
        Me.mtxt_hema_segmenters.Name = "mtxt_hema_segmenters"
        Me.mtxt_hema_segmenters.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_segmenters.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_segmenters.SelectedText = ""
        Me.mtxt_hema_segmenters.SelectionLength = 0
        Me.mtxt_hema_segmenters.SelectionStart = 0
        Me.mtxt_hema_segmenters.ShortcutsEnabled = True
        Me.mtxt_hema_segmenters.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_segmenters.TabIndex = 8
        Me.mtxt_hema_segmenters.UseSelectable = True
        Me.mtxt_hema_segmenters.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_segmenters.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel28
        '
        Me.MetroLabel28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.Location = New System.Drawing.Point(1, 288)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel28.TabIndex = 735
        Me.MetroLabel28.Text = "Segmenters:"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel21.Location = New System.Drawing.Point(16, 260)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(165, 25)
        Me.MetroLabel21.TabIndex = 734
        Me.MetroLabel21.Text = "Differential Count"
        '
        'mtxt_hema_platelets
        '
        '
        '
        '
        Me.mtxt_hema_platelets.CustomButton.Image = Nothing
        Me.mtxt_hema_platelets.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_platelets.CustomButton.Name = ""
        Me.mtxt_hema_platelets.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_platelets.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_platelets.CustomButton.TabIndex = 1
        Me.mtxt_hema_platelets.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_platelets.CustomButton.UseSelectable = True
        Me.mtxt_hema_platelets.CustomButton.Visible = False
        Me.mtxt_hema_platelets.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_platelet", True))
        Me.mtxt_hema_platelets.Lines = New String(-1) {}
        Me.mtxt_hema_platelets.Location = New System.Drawing.Point(98, 234)
        Me.mtxt_hema_platelets.MaxLength = 32767
        Me.mtxt_hema_platelets.Name = "mtxt_hema_platelets"
        Me.mtxt_hema_platelets.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_platelets.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_platelets.SelectedText = ""
        Me.mtxt_hema_platelets.SelectionLength = 0
        Me.mtxt_hema_platelets.SelectionStart = 0
        Me.mtxt_hema_platelets.ShortcutsEnabled = True
        Me.mtxt_hema_platelets.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_platelets.TabIndex = 7
        Me.mtxt_hema_platelets.UseSelectable = True
        Me.mtxt_hema_platelets.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_platelets.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel20
        '
        Me.MetroLabel20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(1, 234)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel20.TabIndex = 732
        Me.MetroLabel20.Text = "Platelets Count:"
        '
        'mtxt_hema_bleeding
        '
        '
        '
        '
        Me.mtxt_hema_bleeding.CustomButton.Image = Nothing
        Me.mtxt_hema_bleeding.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_bleeding.CustomButton.Name = ""
        Me.mtxt_hema_bleeding.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_bleeding.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_bleeding.CustomButton.TabIndex = 1
        Me.mtxt_hema_bleeding.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_bleeding.CustomButton.UseSelectable = True
        Me.mtxt_hema_bleeding.CustomButton.Visible = False
        Me.mtxt_hema_bleeding.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_bleed", True))
        Me.mtxt_hema_bleeding.Lines = New String(-1) {}
        Me.mtxt_hema_bleeding.Location = New System.Drawing.Point(98, 205)
        Me.mtxt_hema_bleeding.MaxLength = 32767
        Me.mtxt_hema_bleeding.Name = "mtxt_hema_bleeding"
        Me.mtxt_hema_bleeding.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_bleeding.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_bleeding.SelectedText = ""
        Me.mtxt_hema_bleeding.SelectionLength = 0
        Me.mtxt_hema_bleeding.SelectionStart = 0
        Me.mtxt_hema_bleeding.ShortcutsEnabled = True
        Me.mtxt_hema_bleeding.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_bleeding.TabIndex = 6
        Me.mtxt_hema_bleeding.UseSelectable = True
        Me.mtxt_hema_bleeding.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_bleeding.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_hema_clotting
        '
        '
        '
        '
        Me.mtxt_hema_clotting.CustomButton.Image = Nothing
        Me.mtxt_hema_clotting.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_clotting.CustomButton.Name = ""
        Me.mtxt_hema_clotting.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_clotting.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_clotting.CustomButton.TabIndex = 1
        Me.mtxt_hema_clotting.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_clotting.CustomButton.UseSelectable = True
        Me.mtxt_hema_clotting.CustomButton.Visible = False
        Me.mtxt_hema_clotting.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_clot", True))
        Me.mtxt_hema_clotting.Lines = New String(-1) {}
        Me.mtxt_hema_clotting.Location = New System.Drawing.Point(98, 176)
        Me.mtxt_hema_clotting.MaxLength = 32767
        Me.mtxt_hema_clotting.Name = "mtxt_hema_clotting"
        Me.mtxt_hema_clotting.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_clotting.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_clotting.SelectedText = ""
        Me.mtxt_hema_clotting.SelectionLength = 0
        Me.mtxt_hema_clotting.SelectionStart = 0
        Me.mtxt_hema_clotting.ShortcutsEnabled = True
        Me.mtxt_hema_clotting.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_clotting.TabIndex = 5
        Me.mtxt_hema_clotting.UseSelectable = True
        Me.mtxt_hema_clotting.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_clotting.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(1, 205)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel17.TabIndex = 729
        Me.MetroLabel17.Text = "Bleeding Time:"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(1, 176)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel18.TabIndex = 728
        Me.MetroLabel18.Text = "Clotting Time:"
        '
        'mtxt_hema_esr
        '
        '
        '
        '
        Me.mtxt_hema_esr.CustomButton.Image = Nothing
        Me.mtxt_hema_esr.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_esr.CustomButton.Name = ""
        Me.mtxt_hema_esr.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_esr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_esr.CustomButton.TabIndex = 1
        Me.mtxt_hema_esr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_esr.CustomButton.UseSelectable = True
        Me.mtxt_hema_esr.CustomButton.Visible = False
        Me.mtxt_hema_esr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_esr", True))
        Me.mtxt_hema_esr.Lines = New String(-1) {}
        Me.mtxt_hema_esr.Location = New System.Drawing.Point(98, 147)
        Me.mtxt_hema_esr.MaxLength = 32767
        Me.mtxt_hema_esr.Name = "mtxt_hema_esr"
        Me.mtxt_hema_esr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_esr.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_esr.SelectedText = ""
        Me.mtxt_hema_esr.SelectionLength = 0
        Me.mtxt_hema_esr.SelectionStart = 0
        Me.mtxt_hema_esr.ShortcutsEnabled = True
        Me.mtxt_hema_esr.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_esr.TabIndex = 4
        Me.mtxt_hema_esr.UseSelectable = True
        Me.mtxt_hema_esr.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_esr.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(1, 147)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel19.TabIndex = 726
        Me.MetroLabel19.Text = "ESR:"
        '
        'mtxt_hema_leuko
        '
        '
        '
        '
        Me.mtxt_hema_leuko.CustomButton.Image = Nothing
        Me.mtxt_hema_leuko.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_leuko.CustomButton.Name = ""
        Me.mtxt_hema_leuko.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_leuko.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_leuko.CustomButton.TabIndex = 1
        Me.mtxt_hema_leuko.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_leuko.CustomButton.UseSelectable = True
        Me.mtxt_hema_leuko.CustomButton.Visible = False
        Me.mtxt_hema_leuko.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_leukoc", True))
        Me.mtxt_hema_leuko.Lines = New String(-1) {}
        Me.mtxt_hema_leuko.Location = New System.Drawing.Point(98, 118)
        Me.mtxt_hema_leuko.MaxLength = 32767
        Me.mtxt_hema_leuko.Name = "mtxt_hema_leuko"
        Me.mtxt_hema_leuko.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_leuko.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_leuko.SelectedText = ""
        Me.mtxt_hema_leuko.SelectionLength = 0
        Me.mtxt_hema_leuko.SelectionStart = 0
        Me.mtxt_hema_leuko.ShortcutsEnabled = True
        Me.mtxt_hema_leuko.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_leuko.TabIndex = 3
        Me.mtxt_hema_leuko.UseSelectable = True
        Me.mtxt_hema_leuko.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_leuko.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_hema_erythro
        '
        '
        '
        '
        Me.mtxt_hema_erythro.CustomButton.Image = Nothing
        Me.mtxt_hema_erythro.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_erythro.CustomButton.Name = ""
        Me.mtxt_hema_erythro.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_erythro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_erythro.CustomButton.TabIndex = 1
        Me.mtxt_hema_erythro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_erythro.CustomButton.UseSelectable = True
        Me.mtxt_hema_erythro.CustomButton.Visible = False
        Me.mtxt_hema_erythro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_erythro", True))
        Me.mtxt_hema_erythro.Lines = New String(-1) {}
        Me.mtxt_hema_erythro.Location = New System.Drawing.Point(98, 89)
        Me.mtxt_hema_erythro.MaxLength = 32767
        Me.mtxt_hema_erythro.Name = "mtxt_hema_erythro"
        Me.mtxt_hema_erythro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_erythro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_erythro.SelectedText = ""
        Me.mtxt_hema_erythro.SelectionLength = 0
        Me.mtxt_hema_erythro.SelectionStart = 0
        Me.mtxt_hema_erythro.ShortcutsEnabled = True
        Me.mtxt_hema_erythro.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_erythro.TabIndex = 2
        Me.mtxt_hema_erythro.UseSelectable = True
        Me.mtxt_hema_erythro.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_erythro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(1, 118)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel15.TabIndex = 723
        Me.MetroLabel15.Text = "Leukocytes C.:"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(1, 89)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel16.TabIndex = 722
        Me.MetroLabel16.Text = "Erythrocytes C.:"
        '
        'mtxt_hema_hema
        '
        '
        '
        '
        Me.mtxt_hema_hema.CustomButton.Image = Nothing
        Me.mtxt_hema_hema.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_hema.CustomButton.Name = ""
        Me.mtxt_hema_hema.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_hema.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_hema.CustomButton.TabIndex = 1
        Me.mtxt_hema_hema.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_hema.CustomButton.UseSelectable = True
        Me.mtxt_hema_hema.CustomButton.Visible = False
        Me.mtxt_hema_hema.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_hema", True))
        Me.mtxt_hema_hema.Lines = New String(-1) {}
        Me.mtxt_hema_hema.Location = New System.Drawing.Point(98, 60)
        Me.mtxt_hema_hema.MaxLength = 32767
        Me.mtxt_hema_hema.Name = "mtxt_hema_hema"
        Me.mtxt_hema_hema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_hema.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_hema.SelectedText = ""
        Me.mtxt_hema_hema.SelectionLength = 0
        Me.mtxt_hema_hema.SelectionStart = 0
        Me.mtxt_hema_hema.ShortcutsEnabled = True
        Me.mtxt_hema_hema.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_hema.TabIndex = 1
        Me.mtxt_hema_hema.UseSelectable = True
        Me.mtxt_hema_hema.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_hema.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_hema_hemo
        '
        '
        '
        '
        Me.mtxt_hema_hemo.CustomButton.Image = Nothing
        Me.mtxt_hema_hemo.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.mtxt_hema_hemo.CustomButton.Name = ""
        Me.mtxt_hema_hemo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_hema_hemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_hema_hemo.CustomButton.TabIndex = 1
        Me.mtxt_hema_hemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_hema_hemo.CustomButton.UseSelectable = True
        Me.mtxt_hema_hemo.CustomButton.Visible = False
        Me.mtxt_hema_hemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_hema_hemo", True))
        Me.mtxt_hema_hemo.Lines = New String(-1) {}
        Me.mtxt_hema_hemo.Location = New System.Drawing.Point(98, 31)
        Me.mtxt_hema_hemo.MaxLength = 32767
        Me.mtxt_hema_hemo.Name = "mtxt_hema_hemo"
        Me.mtxt_hema_hemo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_hema_hemo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_hema_hemo.SelectedText = ""
        Me.mtxt_hema_hemo.SelectionLength = 0
        Me.mtxt_hema_hemo.SelectionStart = 0
        Me.mtxt_hema_hemo.ShortcutsEnabled = True
        Me.mtxt_hema_hemo.Size = New System.Drawing.Size(96, 23)
        Me.mtxt_hema_hemo.TabIndex = 0
        Me.mtxt_hema_hemo.UseSelectable = True
        Me.mtxt_hema_hemo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_hema_hemo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(1, 60)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel14.TabIndex = 719
        Me.MetroLabel14.Text = "Hematocrit:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(1, 31)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel13.TabIndex = 718
        Me.MetroLabel13.Text = "Hemogloblin:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.Location = New System.Drawing.Point(42, -1)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(117, 25)
        Me.MetroLabel12.TabIndex = 698
        Me.MetroLabel12.Text = "Hematology"
        '
        'mlbl_status
        '
        Me.mlbl_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_status.AutoSize = True
        Me.mlbl_status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_labBindingSource, "lab_status", True))
        Me.mlbl_status.Location = New System.Drawing.Point(525, 220)
        Me.mlbl_status.Name = "mlbl_status"
        Me.mlbl_status.Size = New System.Drawing.Size(81, 19)
        Me.mlbl_status.TabIndex = 716
        Me.mlbl_status.Text = "REGISTERED"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(473, 220)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 715
        Me.MetroLabel1.Text = "Status:"
        '
        'mlbl_patient
        '
        Me.mlbl_patient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_patient.AutoSize = True
        Me.mlbl_patient.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "patientno", True))
        Me.mlbl_patient.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.mlbl_patient.Location = New System.Drawing.Point(374, 36)
        Me.mlbl_patient.Name = "mlbl_patient"
        Me.mlbl_patient.Size = New System.Drawing.Size(121, 19)
        Me.mlbl_patient.TabIndex = 714
        Me.mlbl_patient.Text = "P1911654654654"
        '
        'Tb_infoBindingSource
        '
        Me.Tb_infoBindingSource.DataMember = "tb_info"
        Me.Tb_infoBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'mlbl_case
        '
        Me.mlbl_case.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_case.AutoSize = True
        Me.mlbl_case.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "transno", True))
        Me.mlbl_case.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.mlbl_case.Location = New System.Drawing.Point(91, 36)
        Me.mlbl_case.Name = "mlbl_case"
        Me.mlbl_case.Size = New System.Drawing.Size(122, 19)
        Me.mlbl_case.TabIndex = 713
        Me.mlbl_case.Text = "C1911654654654"
        '
        'mlbl_company
        '
        Me.mlbl_company.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_company.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_company", True))
        Me.mlbl_company.Location = New System.Drawing.Point(91, 120)
        Me.mlbl_company.Name = "mlbl_company"
        Me.mlbl_company.Size = New System.Drawing.Size(216, 43)
        Me.mlbl_company.TabIndex = 712
        Me.mlbl_company.Text = "FASTECH"
        Me.mlbl_company.WrapToLine = True
        '
        'mlbl_gender
        '
        Me.mlbl_gender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_gender.AutoSize = True
        Me.mlbl_gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_gender", True))
        Me.mlbl_gender.Location = New System.Drawing.Point(91, 91)
        Me.mlbl_gender.Name = "mlbl_gender"
        Me.mlbl_gender.Size = New System.Drawing.Size(38, 19)
        Me.mlbl_gender.TabIndex = 711
        Me.mlbl_gender.Text = "Male"
        '
        'mlbl_age
        '
        Me.mlbl_age.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_age.AutoSize = True
        Me.mlbl_age.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_age", True))
        Me.mlbl_age.Location = New System.Drawing.Point(374, 63)
        Me.mlbl_age.Name = "mlbl_age"
        Me.mlbl_age.Size = New System.Drawing.Size(23, 19)
        Me.mlbl_age.TabIndex = 710
        Me.mlbl_age.Text = "23"
        '
        'mlbl_procedure
        '
        Me.mlbl_procedure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_procedure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_procedure", True))
        Me.mlbl_procedure.Location = New System.Drawing.Point(91, 163)
        Me.mlbl_procedure.Name = "mlbl_procedure"
        Me.mlbl_procedure.Size = New System.Drawing.Size(216, 19)
        Me.mlbl_procedure.TabIndex = 709
        Me.mlbl_procedure.Text = "XRAY"
        Me.mlbl_procedure.WrapToLine = True
        '
        'mlbl_datereg
        '
        Me.mlbl_datereg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_datereg.AutoSize = True
        Me.mlbl_datereg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_date", True))
        Me.mlbl_datereg.Location = New System.Drawing.Point(375, 91)
        Me.mlbl_datereg.Name = "mlbl_datereg"
        Me.mlbl_datereg.Size = New System.Drawing.Size(67, 19)
        Me.mlbl_datereg.TabIndex = 708
        Me.mlbl_datereg.Text = "11/16/2019"
        '
        'mlbl_name
        '
        Me.mlbl_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_name.AutoSize = True
        Me.mlbl_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_fullname", True))
        Me.mlbl_name.Location = New System.Drawing.Point(91, 63)
        Me.mlbl_name.Name = "mlbl_name"
        Me.mlbl_name.Size = New System.Drawing.Size(102, 19)
        Me.mlbl_name.TabIndex = 707
        Me.mlbl_name.Text = "John Rey Tungul"
        '
        'pb_patient
        '
        Me.pb_patient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_patient.Location = New System.Drawing.Point(510, 36)
        Me.pb_patient.Name = "pb_patient"
        Me.pb_patient.Size = New System.Drawing.Size(90, 90)
        Me.pb_patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_patient.TabIndex = 706
        Me.pb_patient.TabStop = False
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(16, 163)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel11.TabIndex = 705
        Me.MetroLabel11.Text = "Procedure:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(296, 91)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel10.TabIndex = 704
        Me.MetroLabel10.Text = "Date Reg.:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(16, 120)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel9.TabIndex = 703
        Me.MetroLabel9.Text = "Company:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(16, 91)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel8.TabIndex = 702
        Me.MetroLabel8.Text = "Gender:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(296, 63)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel7.TabIndex = 701
        Me.MetroLabel7.Text = "Age:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(16, 63)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel6.TabIndex = 700
        Me.MetroLabel6.Text = "Name:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(296, 36)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel5.TabIndex = 699
        Me.MetroLabel5.Text = "Patient #:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 36)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel4.TabIndex = 698
        Me.MetroLabel4.Text = "Case #:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(180, 8)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(164, 25)
        Me.MetroLabel3.TabIndex = 697
        Me.MetroLabel3.Text = "Patient Information"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(357, 9)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 674
        Me.MetroLabel2.Text = "Date:"
        '
        'mcb_all_search
        '
        Me.mcb_all_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_all_search.AutoSize = True
        Me.mcb_all_search.Location = New System.Drawing.Point(496, 11)
        Me.mcb_all_search.Name = "mcb_all_search"
        Me.mcb_all_search.Size = New System.Drawing.Size(37, 15)
        Me.mcb_all_search.TabIndex = 673
        Me.mcb_all_search.Text = "All"
        Me.mcb_all_search.UseSelectable = True
        '
        'mdt_search
        '
        Me.mdt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mdt_search.DisplayFocus = True
        Me.mdt_search.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.mdt_search.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdt_search.Location = New System.Drawing.Point(402, 6)
        Me.mdt_search.MinimumSize = New System.Drawing.Size(0, 25)
        Me.mdt_search.Name = "mdt_search"
        Me.mdt_search.Size = New System.Drawing.Size(88, 25)
        Me.mdt_search.TabIndex = 671
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Enabled = False
        Me.mtile_remote.Location = New System.Drawing.Point(3, 3)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(28, 28)
        Me.mtile_remote.TabIndex = 669
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
        Me.mtxt_search.CustomButton.Location = New System.Drawing.Point(290, 1)
        Me.mtxt_search.CustomButton.Name = ""
        Me.mtxt_search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_search.CustomButton.TabIndex = 1
        Me.mtxt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_search.CustomButton.UseSelectable = True
        Me.mtxt_search.CustomButton.Visible = False
        Me.mtxt_search.Lines = New String(-1) {}
        Me.mtxt_search.Location = New System.Drawing.Point(39, 6)
        Me.mtxt_search.MaxLength = 32767
        Me.mtxt_search.Name = "mtxt_search"
        Me.mtxt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_search.PromptText = "Search by Case #, Name"
        Me.mtxt_search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_search.SelectedText = ""
        Me.mtxt_search.SelectionLength = 0
        Me.mtxt_search.SelectionStart = 0
        Me.mtxt_search.ShortcutsEnabled = True
        Me.mtxt_search.Size = New System.Drawing.Size(312, 23)
        Me.mtxt_search.TabIndex = 668
        Me.mtxt_search.UseSelectable = True
        Me.mtxt_search.WaterMark = "Search by Case #, Name"
        Me.mtxt_search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnl_hide_logs
        '
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_corrl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_activityl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_timestampl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_deptl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_namel)
        Me.pnl_hide_logs.Location = New System.Drawing.Point(3, 7)
        Me.pnl_hide_logs.Name = "pnl_hide_logs"
        Me.pnl_hide_logs.Size = New System.Drawing.Size(25, 20)
        Me.pnl_hide_logs.TabIndex = 672
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
        Me.grid_patients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransnoDataGridViewTextBoxColumn, Me.info_fullname, Me.info_procedure, Me.info_company, Me.info_picture, Me.info_code})
        Me.grid_patients.DataSource = Me.Tb_infoBindingSource
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
        Me.grid_patients.Location = New System.Drawing.Point(3, 36)
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
        Me.grid_patients.Size = New System.Drawing.Size(532, 442)
        Me.grid_patients.TabIndex = 676
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "transno"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "Case #"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'info_fullname
        '
        Me.info_fullname.DataPropertyName = "info_fullname"
        Me.info_fullname.HeaderText = "Name"
        Me.info_fullname.Name = "info_fullname"
        Me.info_fullname.ReadOnly = True
        '
        'info_procedure
        '
        Me.info_procedure.DataPropertyName = "info_procedure"
        Me.info_procedure.HeaderText = "Procedure"
        Me.info_procedure.Name = "info_procedure"
        Me.info_procedure.ReadOnly = True
        '
        'info_company
        '
        Me.info_company.DataPropertyName = "info_company"
        Me.info_company.HeaderText = "Company"
        Me.info_company.Name = "info_company"
        Me.info_company.ReadOnly = True
        '
        'info_picture
        '
        Me.info_picture.DataPropertyName = "info_picture"
        Me.info_picture.HeaderText = "info_picture"
        Me.info_picture.Name = "info_picture"
        Me.info_picture.ReadOnly = True
        Me.info_picture.Visible = False
        '
        'info_code
        '
        Me.info_code.DataPropertyName = "info_code"
        Me.info_code.HeaderText = "info_code"
        Me.info_code.Name = "info_code"
        Me.info_code.ReadOnly = True
        Me.info_code.Visible = False
        '
        'grid_lab
        '
        Me.grid_lab.AllowUserToAddRows = False
        Me.grid_lab.AllowUserToDeleteRows = False
        Me.grid_lab.AllowUserToResizeRows = False
        Me.grid_lab.AutoGenerateColumns = False
        Me.grid_lab.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_lab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_lab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_lab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_lab.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid_lab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_lab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransnoDataGridViewTextBoxColumn1, Me.PatientnoDataGridViewTextBoxColumn, Me.LabcompanyDataGridViewTextBoxColumn, Me.LabmedtechDataGridViewTextBoxColumn, Me.LabpathologistDataGridViewTextBoxColumn, Me.LabdateDataGridViewTextBoxColumn, Me.LabtimestampDataGridViewTextBoxColumn, Me.LabstatusDataGridViewTextBoxColumn})
        Me.grid_lab.DataSource = Me.Tb_labBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_lab.DefaultCellStyle = DataGridViewCellStyle6
        Me.grid_lab.EnableHeadersVisualStyles = False
        Me.grid_lab.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_lab.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_lab.Location = New System.Drawing.Point(37, 199)
        Me.grid_lab.Name = "grid_lab"
        Me.grid_lab.ReadOnly = True
        Me.grid_lab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_lab.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid_lab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_lab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_lab.Size = New System.Drawing.Size(93, 63)
        Me.grid_lab.TabIndex = 675
        '
        'TransnoDataGridViewTextBoxColumn1
        '
        Me.TransnoDataGridViewTextBoxColumn1.DataPropertyName = "transno"
        Me.TransnoDataGridViewTextBoxColumn1.HeaderText = "transno"
        Me.TransnoDataGridViewTextBoxColumn1.Name = "TransnoDataGridViewTextBoxColumn1"
        Me.TransnoDataGridViewTextBoxColumn1.ReadOnly = True
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
        'pnl_hide
        '
        Me.pnl_hide.Controls.Add(Me.txt_hide_others)
        Me.pnl_hide.Controls.Add(Me.txt_hide_blood)
        Me.pnl_hide.Controls.Add(Me.txt_hide_uri)
        Me.pnl_hide.Controls.Add(Me.txt_hide_feca)
        Me.pnl_hide.Controls.Add(Me.txt_hide_hema)
        Me.pnl_hide.Location = New System.Drawing.Point(134, 138)
        Me.pnl_hide.Name = "pnl_hide"
        Me.pnl_hide.Size = New System.Drawing.Size(33, 17)
        Me.pnl_hide.TabIndex = 700
        '
        'txt_hide_others
        '
        Me.txt_hide_others.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_others", True))
        Me.txt_hide_others.Location = New System.Drawing.Point(22, 115)
        Me.txt_hide_others.Name = "txt_hide_others"
        Me.txt_hide_others.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_others.TabIndex = 4
        '
        'Tb_packageBindingSource
        '
        Me.Tb_packageBindingSource.DataMember = "tb_package"
        Me.Tb_packageBindingSource.DataSource = Me.Db_cygnetmedDataSet
        '
        'txt_hide_blood
        '
        Me.txt_hide_blood.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_others", True))
        Me.txt_hide_blood.Location = New System.Drawing.Point(22, 87)
        Me.txt_hide_blood.Name = "txt_hide_blood"
        Me.txt_hide_blood.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_blood.TabIndex = 3
        '
        'txt_hide_uri
        '
        Me.txt_hide_uri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_uri", True))
        Me.txt_hide_uri.Location = New System.Drawing.Point(22, 61)
        Me.txt_hide_uri.Name = "txt_hide_uri"
        Me.txt_hide_uri.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_uri.TabIndex = 2
        '
        'txt_hide_feca
        '
        Me.txt_hide_feca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_feca", True))
        Me.txt_hide_feca.Location = New System.Drawing.Point(22, 35)
        Me.txt_hide_feca.Name = "txt_hide_feca"
        Me.txt_hide_feca.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_feca.TabIndex = 1
        '
        'txt_hide_hema
        '
        Me.txt_hide_hema.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_packageBindingSource, "package_hema", True))
        Me.txt_hide_hema.Location = New System.Drawing.Point(22, 9)
        Me.txt_hide_hema.Name = "txt_hide_hema"
        Me.txt_hide_hema.Size = New System.Drawing.Size(100, 20)
        Me.txt_hide_hema.TabIndex = 0
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
        'Tb_labTableAdapter
        '
        Me.Tb_labTableAdapter.ClearBeforeFill = True
        '
        'Tb_infoTableAdapter
        '
        Me.Tb_infoTableAdapter.ClearBeforeFill = True
        '
        'Tb_packageTableAdapter
        '
        Me.Tb_packageTableAdapter.ClearBeforeFill = True
        '
        'lab_tab_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mpnl_body)
        Me.Name = "lab_tab_register"
        Me.Size = New System.Drawing.Size(1171, 512)
        Me.mpnl_body.ResumeLayout(False)
        Me.mpnl_body.PerformLayout()
        Me.mpnl_right.ResumeLayout(False)
        Me.mpnl_right.PerformLayout()
        CType(Me.Tb_labBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mpnl_others.ResumeLayout(False)
        Me.mpnl_others.PerformLayout()
        Me.mpnl_blood.ResumeLayout(False)
        Me.mpnl_blood.PerformLayout()
        Me.mpnl_uri.ResumeLayout(False)
        Me.mpnl_uri.PerformLayout()
        Me.mpnl_feca.ResumeLayout(False)
        Me.mpnl_feca.PerformLayout()
        Me.mpnl_hema.ResumeLayout(False)
        Me.mpnl_hema.PerformLayout()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_patient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_hide.ResumeLayout(False)
        Me.pnl_hide.PerformLayout()
        CType(Me.Tb_packageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mpnl_body As MetroFramework.Controls.MetroPanel
    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_labBindingSource As BindingSource
    Friend WithEvents Tb_labTableAdapter As db_cygnetmedDataSetTableAdapters.tb_labTableAdapter
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_all_search As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mdt_search As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents mtxt_search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents grid_lab As MetroFramework.Controls.MetroGrid
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents Tb_infoBindingSource As BindingSource
    Friend WithEvents Tb_infoTableAdapter As db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter
    Friend WithEvents grid_patients As MetroFramework.Controls.MetroGrid
    Friend WithEvents mpnl_right As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlbl_status As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_patient As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_case As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_company As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_gender As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_age As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_procedure As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_datereg As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_name As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_patient As PictureBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mpnl_hema As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_leuko As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_hema_erythro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_hema As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_hema_hemo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_platelets As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_bleeding As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_hema_clotting As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_esr As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_others As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_blood As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_hepaa As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_hepab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_hema_baso As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_mono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_eosino As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_hema_lympho As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_hema_segmenters As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mpnl_feca As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel41 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel42 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel43 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel44 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel45 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel46 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel47 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel48 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel49 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mpnl_uri As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel84 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_feca_others2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel36 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_feca_rbc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_others As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel32 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_feca_wbc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel33 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel52 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel37 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel38 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel39 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel40 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel50 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel51 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_uri_others2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel63 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel62 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel61 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_uri_crystals As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel60 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_uri_cast As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel59 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel55 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel56 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel57 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel58 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_uri_rbc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel53 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_uri_wbc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel54 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mpnl_others As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroComboBox23 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mtxt_others_result As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel87 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_others_value As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_others_patient As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel85 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_others_test As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel81 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_others_testtitle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel82 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel98 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mpnl_blood As MetroFramework.Controls.MetroPanel
    Friend WithEvents mtxt_blood_others As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel80 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_hbaic As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_blood_pota As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel73 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel74 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_sodium As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel75 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_sgot As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_blood_sgpt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel76 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel77 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_hldratio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_blood_vldl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel78 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel79 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_ldl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel65 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_hdl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_blood_triglyceride As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel66 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel67 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_cholesterol As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel68 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_uric As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_blood_crea As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel69 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel70 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_blood_bun As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_blood_fbs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel71 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel72 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel64 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbtn_save As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_add As MetroFramework.Controls.MetroButton
    Friend WithEvents Tb_packageBindingSource As BindingSource
    Friend WithEvents Tb_packageTableAdapter As db_cygnetmedDataSetTableAdapters.tb_packageTableAdapter
    Friend WithEvents TransnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents info_fullname As DataGridViewTextBoxColumn
    Friend WithEvents info_procedure As DataGridViewTextBoxColumn
    Friend WithEvents info_company As DataGridViewTextBoxColumn
    Friend WithEvents info_picture As DataGridViewTextBoxColumn
    Friend WithEvents info_code As DataGridViewTextBoxColumn
    Friend WithEvents pnl_hide As Panel
    Friend WithEvents txt_hide_others As TextBox
    Friend WithEvents txt_hide_blood As TextBox
    Friend WithEvents txt_hide_uri As TextBox
    Friend WithEvents txt_hide_feca As TextBox
    Friend WithEvents txt_hide_hema As TextBox
    Friend WithEvents mtxt_feca_consist As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_color As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_bacteria As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_fats As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_tropho As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_enta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_hook As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_trichuris As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_ascaris As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_feca_occult As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_bacteria As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_pt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_phosphates As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_urates As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_mucus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_epi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_sugar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_ph As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_albu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_gravity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_transparency As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_uri_color As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TransnoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabcompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabmedtechDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabpathologistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabtimestampDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mcbo_pathologist As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mcbo_medtech As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel86 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel83 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbtn_print As MetroFramework.Controls.MetroButton
End Class
