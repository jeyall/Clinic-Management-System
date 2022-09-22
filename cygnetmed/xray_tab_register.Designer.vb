<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xray_tab_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xray_tab_register))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mpnl_body = New MetroFramework.Controls.MetroPanel()
        Me.mbtn_print = New MetroFramework.Controls.MetroButton()
        Me.mcbo_film = New MetroFramework.Controls.MetroComboBox()
        Me.Tb_xrayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.mlbl_status = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_impression = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_exam = New MetroFramework.Controls.MetroTextBox()
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
        Me.mbtn_save = New MetroFramework.Controls.MetroButton()
        Me.mbtn_add = New MetroFramework.Controls.MetroButton()
        Me.mcbo_radiologist = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.mcbo_radiotech = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_report = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
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
        Me.grid_xray = New MetroFramework.Controls.MetroGrid()
        Me.TransnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xray_radtech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xray_radiologist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XraydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XraytimestampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xray_company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.Tb_xrayTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_xrayTableAdapter()
        Me.Tb_infoTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter()
        Me.mpnl_body.SuspendLayout()
        CType(Me.Tb_xrayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_hide_logs.SuspendLayout()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_xray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mpnl_body
        '
        Me.mpnl_body.Controls.Add(Me.mbtn_print)
        Me.mpnl_body.Controls.Add(Me.mcbo_film)
        Me.mpnl_body.Controls.Add(Me.MetroLabel17)
        Me.mpnl_body.Controls.Add(Me.mlbl_status)
        Me.mpnl_body.Controls.Add(Me.MetroLabel1)
        Me.mpnl_body.Controls.Add(Me.mtxt_impression)
        Me.mpnl_body.Controls.Add(Me.mtxt_exam)
        Me.mpnl_body.Controls.Add(Me.mlbl_patient)
        Me.mpnl_body.Controls.Add(Me.mlbl_case)
        Me.mpnl_body.Controls.Add(Me.mlbl_company)
        Me.mpnl_body.Controls.Add(Me.mlbl_gender)
        Me.mpnl_body.Controls.Add(Me.mlbl_age)
        Me.mpnl_body.Controls.Add(Me.mlbl_procedure)
        Me.mpnl_body.Controls.Add(Me.mlbl_datereg)
        Me.mpnl_body.Controls.Add(Me.mlbl_name)
        Me.mpnl_body.Controls.Add(Me.pb_patient)
        Me.mpnl_body.Controls.Add(Me.mbtn_save)
        Me.mpnl_body.Controls.Add(Me.mbtn_add)
        Me.mpnl_body.Controls.Add(Me.mcbo_radiologist)
        Me.mpnl_body.Controls.Add(Me.MetroLabel16)
        Me.mpnl_body.Controls.Add(Me.mcbo_radiotech)
        Me.mpnl_body.Controls.Add(Me.MetroLabel15)
        Me.mpnl_body.Controls.Add(Me.MetroLabel14)
        Me.mpnl_body.Controls.Add(Me.mtxt_report)
        Me.mpnl_body.Controls.Add(Me.MetroLabel13)
        Me.mpnl_body.Controls.Add(Me.MetroLabel12)
        Me.mpnl_body.Controls.Add(Me.MetroLabel11)
        Me.mpnl_body.Controls.Add(Me.MetroLabel10)
        Me.mpnl_body.Controls.Add(Me.MetroLabel9)
        Me.mpnl_body.Controls.Add(Me.MetroLabel8)
        Me.mpnl_body.Controls.Add(Me.MetroLabel7)
        Me.mpnl_body.Controls.Add(Me.MetroLabel6)
        Me.mpnl_body.Controls.Add(Me.MetroLabel5)
        Me.mpnl_body.Controls.Add(Me.MetroLabel4)
        Me.mpnl_body.Controls.Add(Me.MetroLabel3)
        Me.mpnl_body.Controls.Add(Me.MetroLabel2)
        Me.mpnl_body.Controls.Add(Me.mcb_all_search)
        Me.mpnl_body.Controls.Add(Me.mdt_search)
        Me.mpnl_body.Controls.Add(Me.mtile_remote)
        Me.mpnl_body.Controls.Add(Me.mtxt_search)
        Me.mpnl_body.Controls.Add(Me.pnl_hide_logs)
        Me.mpnl_body.Controls.Add(Me.grid_patients)
        Me.mpnl_body.Controls.Add(Me.grid_xray)
        Me.mpnl_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mpnl_body.HorizontalScrollbarBarColor = False
        Me.mpnl_body.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnl_body.HorizontalScrollbarSize = 0
        Me.mpnl_body.Location = New System.Drawing.Point(0, 0)
        Me.mpnl_body.Name = "mpnl_body"
        Me.mpnl_body.Size = New System.Drawing.Size(993, 528)
        Me.mpnl_body.TabIndex = 0
        Me.mpnl_body.VerticalScrollbarBarColor = False
        Me.mpnl_body.VerticalScrollbarHighlightOnWheel = False
        Me.mpnl_body.VerticalScrollbarSize = 0
        '
        'mbtn_print
        '
        Me.mbtn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_print.Location = New System.Drawing.Point(458, 497)
        Me.mbtn_print.Name = "mbtn_print"
        Me.mbtn_print.Size = New System.Drawing.Size(89, 23)
        Me.mbtn_print.TabIndex = 669
        Me.mbtn_print.Text = "Print Preview"
        Me.mbtn_print.UseSelectable = True
        '
        'mcbo_film
        '
        Me.mcbo_film.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcbo_film.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_xrayBindingSource, "xray_film", True))
        Me.mcbo_film.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcbo_film.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.mcbo_film.FormattingEnabled = True
        Me.mcbo_film.ItemHeight = 19
        Me.mcbo_film.Items.AddRange(New Object() {"10", "11"})
        Me.mcbo_film.Location = New System.Drawing.Point(908, 281)
        Me.mcbo_film.Name = "mcbo_film"
        Me.mcbo_film.Size = New System.Drawing.Size(70, 25)
        Me.mcbo_film.TabIndex = 2
        Me.mcbo_film.UseSelectable = True
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
        'MetroLabel17
        '
        Me.MetroLabel17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(865, 283)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel17.TabIndex = 665
        Me.MetroLabel17.Text = "Film:"
        '
        'mlbl_status
        '
        Me.mlbl_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_status.AutoSize = True
        Me.mlbl_status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_xrayBindingSource, "xray_status", True))
        Me.mlbl_status.Location = New System.Drawing.Point(907, 160)
        Me.mlbl_status.Name = "mlbl_status"
        Me.mlbl_status.Size = New System.Drawing.Size(38, 19)
        Me.mlbl_status.TabIndex = 664
        Me.mlbl_status.Text = "Male"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(832, 160)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 663
        Me.MetroLabel1.Text = "Status:"
        '
        'mtxt_impression
        '
        Me.mtxt_impression.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtxt_impression.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_impression.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_impression.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_impression.CustomButton.Image = Nothing
        Me.mtxt_impression.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.mtxt_impression.CustomButton.Name = ""
        Me.mtxt_impression.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_impression.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_impression.CustomButton.TabIndex = 1
        Me.mtxt_impression.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_impression.CustomButton.UseSelectable = True
        Me.mtxt_impression.CustomButton.Visible = False
        Me.mtxt_impression.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_xrayBindingSource, "xray_impression", True))
        Me.mtxt_impression.Lines = New String(-1) {}
        Me.mtxt_impression.Location = New System.Drawing.Point(582, 281)
        Me.mtxt_impression.MaxLength = 32767
        Me.mtxt_impression.Name = "mtxt_impression"
        Me.mtxt_impression.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_impression.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_impression.SelectedText = ""
        Me.mtxt_impression.SelectionLength = 0
        Me.mtxt_impression.SelectionStart = 0
        Me.mtxt_impression.ShortcutsEnabled = True
        Me.mtxt_impression.Size = New System.Drawing.Size(277, 23)
        Me.mtxt_impression.TabIndex = 1
        Me.mtxt_impression.UseSelectable = True
        Me.mtxt_impression.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_impression.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxt_exam
        '
        Me.mtxt_exam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtxt_exam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.mtxt_exam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.mtxt_exam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_exam.CustomButton.Image = Nothing
        Me.mtxt_exam.CustomButton.Location = New System.Drawing.Point(374, 1)
        Me.mtxt_exam.CustomButton.Name = ""
        Me.mtxt_exam.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_exam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_exam.CustomButton.TabIndex = 1
        Me.mtxt_exam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_exam.CustomButton.UseSelectable = True
        Me.mtxt_exam.CustomButton.Visible = False
        Me.mtxt_exam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_xrayBindingSource, "xray_exam", True))
        Me.mtxt_exam.Lines = New String(-1) {}
        Me.mtxt_exam.Location = New System.Drawing.Point(582, 252)
        Me.mtxt_exam.MaxLength = 32767
        Me.mtxt_exam.Name = "mtxt_exam"
        Me.mtxt_exam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_exam.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_exam.SelectedText = ""
        Me.mtxt_exam.SelectionLength = 0
        Me.mtxt_exam.SelectionStart = 0
        Me.mtxt_exam.ShortcutsEnabled = True
        Me.mtxt_exam.Size = New System.Drawing.Size(396, 23)
        Me.mtxt_exam.TabIndex = 0
        Me.mtxt_exam.UseSelectable = True
        Me.mtxt_exam.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_exam.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mlbl_patient
        '
        Me.mlbl_patient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_patient.AutoSize = True
        Me.mlbl_patient.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "patientno", True))
        Me.mlbl_patient.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.mlbl_patient.Location = New System.Drawing.Point(726, 32)
        Me.mlbl_patient.Name = "mlbl_patient"
        Me.mlbl_patient.Size = New System.Drawing.Size(121, 19)
        Me.mlbl_patient.TabIndex = 660
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
        Me.mlbl_case.Location = New System.Drawing.Point(533, 32)
        Me.mlbl_case.Name = "mlbl_case"
        Me.mlbl_case.Size = New System.Drawing.Size(122, 19)
        Me.mlbl_case.TabIndex = 659
        Me.mlbl_case.Text = "C1911654654654"
        '
        'mlbl_company
        '
        Me.mlbl_company.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_company.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_company", True))
        Me.mlbl_company.Location = New System.Drawing.Point(533, 160)
        Me.mlbl_company.Name = "mlbl_company"
        Me.mlbl_company.Size = New System.Drawing.Size(293, 43)
        Me.mlbl_company.TabIndex = 658
        Me.mlbl_company.Text = "FASTECH"
        Me.mlbl_company.WrapToLine = True
        '
        'mlbl_gender
        '
        Me.mlbl_gender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_gender.AutoSize = True
        Me.mlbl_gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_gender", True))
        Me.mlbl_gender.Location = New System.Drawing.Point(533, 125)
        Me.mlbl_gender.Name = "mlbl_gender"
        Me.mlbl_gender.Size = New System.Drawing.Size(38, 19)
        Me.mlbl_gender.TabIndex = 657
        Me.mlbl_gender.Text = "Male"
        '
        'mlbl_age
        '
        Me.mlbl_age.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_age.AutoSize = True
        Me.mlbl_age.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_age", True))
        Me.mlbl_age.Location = New System.Drawing.Point(533, 91)
        Me.mlbl_age.Name = "mlbl_age"
        Me.mlbl_age.Size = New System.Drawing.Size(23, 19)
        Me.mlbl_age.TabIndex = 656
        Me.mlbl_age.Text = "23"
        '
        'mlbl_procedure
        '
        Me.mlbl_procedure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_procedure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_procedure", True))
        Me.mlbl_procedure.Location = New System.Drawing.Point(533, 198)
        Me.mlbl_procedure.Name = "mlbl_procedure"
        Me.mlbl_procedure.Size = New System.Drawing.Size(289, 19)
        Me.mlbl_procedure.TabIndex = 655
        Me.mlbl_procedure.Text = "XRAY"
        Me.mlbl_procedure.WrapToLine = True
        '
        'mlbl_datereg
        '
        Me.mlbl_datereg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_datereg.AutoSize = True
        Me.mlbl_datereg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_date", True))
        Me.mlbl_datereg.Location = New System.Drawing.Point(907, 185)
        Me.mlbl_datereg.Name = "mlbl_datereg"
        Me.mlbl_datereg.Size = New System.Drawing.Size(67, 19)
        Me.mlbl_datereg.TabIndex = 654
        Me.mlbl_datereg.Text = "11/16/2019"
        '
        'mlbl_name
        '
        Me.mlbl_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlbl_name.AutoSize = True
        Me.mlbl_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_infoBindingSource, "info_fullname", True))
        Me.mlbl_name.Location = New System.Drawing.Point(533, 59)
        Me.mlbl_name.Name = "mlbl_name"
        Me.mlbl_name.Size = New System.Drawing.Size(102, 19)
        Me.mlbl_name.TabIndex = 653
        Me.mlbl_name.Text = "John Rey Tungul"
        '
        'pb_patient
        '
        Me.pb_patient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_patient.Location = New System.Drawing.Point(854, 32)
        Me.pb_patient.Name = "pb_patient"
        Me.pb_patient.Size = New System.Drawing.Size(124, 124)
        Me.pb_patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_patient.TabIndex = 652
        Me.pb_patient.TabStop = False
        '
        'mbtn_save
        '
        Me.mbtn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_save.Location = New System.Drawing.Point(903, 497)
        Me.mbtn_save.Name = "mbtn_save"
        Me.mbtn_save.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_save.TabIndex = 7
        Me.mbtn_save.Text = "Save"
        Me.mbtn_save.UseSelectable = True
        '
        'mbtn_add
        '
        Me.mbtn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbtn_add.Location = New System.Drawing.Point(822, 497)
        Me.mbtn_add.Name = "mbtn_add"
        Me.mbtn_add.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_add.TabIndex = 6
        Me.mbtn_add.Text = "Add"
        Me.mbtn_add.UseSelectable = True
        '
        'mcbo_radiologist
        '
        Me.mcbo_radiologist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcbo_radiologist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_xrayBindingSource, "xray_radiologist", True))
        Me.mcbo_radiologist.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcbo_radiologist.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.mcbo_radiologist.FormattingEnabled = True
        Me.mcbo_radiologist.ItemHeight = 19
        Me.mcbo_radiologist.Location = New System.Drawing.Point(830, 463)
        Me.mcbo_radiologist.Name = "mcbo_radiologist"
        Me.mcbo_radiologist.Size = New System.Drawing.Size(148, 25)
        Me.mcbo_radiologist.TabIndex = 5
        Me.mcbo_radiologist.UseSelectable = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(753, 463)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel16.TabIndex = 648
        Me.MetroLabel16.Text = "Radiologist:"
        '
        'mcbo_radiotech
        '
        Me.mcbo_radiotech.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcbo_radiotech.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_xrayBindingSource, "xray_radtech", True))
        Me.mcbo_radiotech.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mcbo_radiotech.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.mcbo_radiotech.FormattingEnabled = True
        Me.mcbo_radiotech.ItemHeight = 19
        Me.mcbo_radiotech.Location = New System.Drawing.Point(613, 463)
        Me.mcbo_radiotech.Name = "mcbo_radiotech"
        Me.mcbo_radiotech.Size = New System.Drawing.Size(137, 25)
        Me.mcbo_radiotech.TabIndex = 4
        Me.mcbo_radiotech.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(458, 463)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(149, 19)
        Me.MetroLabel15.TabIndex = 646
        Me.MetroLabel15.Text = "Radiologic Technologist:"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(458, 281)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel14.TabIndex = 644
        Me.MetroLabel14.Text = "Impression:"
        '
        'mtxt_report
        '
        Me.mtxt_report.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.mtxt_report.CustomButton.Image = Nothing
        Me.mtxt_report.CustomButton.Location = New System.Drawing.Point(362, 2)
        Me.mtxt_report.CustomButton.Name = ""
        Me.mtxt_report.CustomButton.Size = New System.Drawing.Size(121, 121)
        Me.mtxt_report.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_report.CustomButton.TabIndex = 1
        Me.mtxt_report.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_report.CustomButton.UseSelectable = True
        Me.mtxt_report.CustomButton.Visible = False
        Me.mtxt_report.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_xrayBindingSource, "xray_report", True))
        Me.mtxt_report.Lines = New String(-1) {}
        Me.mtxt_report.Location = New System.Drawing.Point(492, 331)
        Me.mtxt_report.MaxLength = 32767
        Me.mtxt_report.Multiline = True
        Me.mtxt_report.Name = "mtxt_report"
        Me.mtxt_report.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_report.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_report.SelectedText = ""
        Me.mtxt_report.SelectionLength = 0
        Me.mtxt_report.SelectionStart = 0
        Me.mtxt_report.ShortcutsEnabled = True
        Me.mtxt_report.Size = New System.Drawing.Size(486, 126)
        Me.mtxt_report.TabIndex = 3
        Me.mtxt_report.UseSelectable = True
        Me.mtxt_report.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_report.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(458, 309)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(159, 19)
        Me.MetroLabel13.TabIndex = 642
        Me.MetroLabel13.Text = "Roentgenological Report:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(458, 252)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel12.TabIndex = 640
        Me.MetroLabel12.Text = "Examination Done:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(458, 198)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel11.TabIndex = 639
        Me.MetroLabel11.Text = "Procedure:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(832, 185)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel10.TabIndex = 638
        Me.MetroLabel10.Text = "Date Reg.:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(458, 160)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel9.TabIndex = 637
        Me.MetroLabel9.Text = "Company:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(458, 125)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel8.TabIndex = 636
        Me.MetroLabel8.Text = "Gender:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(458, 91)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel7.TabIndex = 635
        Me.MetroLabel7.Text = "Age:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(458, 59)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel6.TabIndex = 634
        Me.MetroLabel6.Text = "Name:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(648, 32)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel5.TabIndex = 633
        Me.MetroLabel5.Text = "Patient #:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(458, 32)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel4.TabIndex = 632
        Me.MetroLabel4.Text = "Case #:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(622, 4)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(164, 25)
        Me.MetroLabel3.TabIndex = 631
        Me.MetroLabel3.Text = "Patient Information"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(268, 8)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 630
        Me.MetroLabel2.Text = "Date:"
        '
        'mcb_all_search
        '
        Me.mcb_all_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcb_all_search.AutoSize = True
        Me.mcb_all_search.Location = New System.Drawing.Point(407, 10)
        Me.mcb_all_search.Name = "mcb_all_search"
        Me.mcb_all_search.Size = New System.Drawing.Size(37, 15)
        Me.mcb_all_search.TabIndex = 626
        Me.mcb_all_search.Text = "All"
        Me.mcb_all_search.UseSelectable = True
        '
        'mdt_search
        '
        Me.mdt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mdt_search.DisplayFocus = True
        Me.mdt_search.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.mdt_search.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdt_search.Location = New System.Drawing.Point(313, 5)
        Me.mdt_search.MinimumSize = New System.Drawing.Size(0, 25)
        Me.mdt_search.Name = "mdt_search"
        Me.mdt_search.Size = New System.Drawing.Size(88, 25)
        Me.mdt_search.TabIndex = 624
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
        'mtxt_search
        '
        Me.mtxt_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtxt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxt_search.CustomButton.Image = Nothing
        Me.mtxt_search.CustomButton.Location = New System.Drawing.Point(201, 1)
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
        Me.mtxt_search.Size = New System.Drawing.Size(223, 23)
        Me.mtxt_search.TabIndex = 621
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
        Me.pnl_hide_logs.TabIndex = 625
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
        Me.grid_patients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransnoDataGridViewTextBoxColumn, Me.info_fullname, Me.info_procedure, Me.info_company, Me.info_picture})
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
        Me.grid_patients.Size = New System.Drawing.Size(441, 484)
        Me.grid_patients.TabIndex = 623
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
        'grid_xray
        '
        Me.grid_xray.AllowUserToAddRows = False
        Me.grid_xray.AllowUserToDeleteRows = False
        Me.grid_xray.AllowUserToResizeRows = False
        Me.grid_xray.AutoGenerateColumns = False
        Me.grid_xray.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_xray.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_xray.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_xray.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_xray.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid_xray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_xray.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransnoDataGridViewTextBoxColumn1, Me.PatientnoDataGridViewTextBoxColumn, Me.xray_radtech, Me.xray_radiologist, Me.XraydateDataGridViewTextBoxColumn, Me.XraytimestampDataGridViewTextBoxColumn, Me.xray_company})
        Me.grid_xray.DataSource = Me.Tb_xrayBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_xray.DefaultCellStyle = DataGridViewCellStyle6
        Me.grid_xray.EnableHeadersVisualStyles = False
        Me.grid_xray.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_xray.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_xray.Location = New System.Drawing.Point(29, 139)
        Me.grid_xray.Name = "grid_xray"
        Me.grid_xray.ReadOnly = True
        Me.grid_xray.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_xray.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid_xray.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_xray.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_xray.Size = New System.Drawing.Size(92, 64)
        Me.grid_xray.TabIndex = 667
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
        'xray_radtech
        '
        Me.xray_radtech.DataPropertyName = "xray_radtech"
        Me.xray_radtech.HeaderText = "xray_radtech"
        Me.xray_radtech.Name = "xray_radtech"
        Me.xray_radtech.ReadOnly = True
        Me.xray_radtech.Visible = False
        '
        'xray_radiologist
        '
        Me.xray_radiologist.DataPropertyName = "xray_radiologist"
        Me.xray_radiologist.HeaderText = "xray_radiologist"
        Me.xray_radiologist.Name = "xray_radiologist"
        Me.xray_radiologist.ReadOnly = True
        Me.xray_radiologist.Visible = False
        '
        'XraydateDataGridViewTextBoxColumn
        '
        Me.XraydateDataGridViewTextBoxColumn.DataPropertyName = "xray_date"
        Me.XraydateDataGridViewTextBoxColumn.HeaderText = "xray_date"
        Me.XraydateDataGridViewTextBoxColumn.Name = "XraydateDataGridViewTextBoxColumn"
        Me.XraydateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'XraytimestampDataGridViewTextBoxColumn
        '
        Me.XraytimestampDataGridViewTextBoxColumn.DataPropertyName = "xray_timestamp"
        Me.XraytimestampDataGridViewTextBoxColumn.HeaderText = "xray_timestamp"
        Me.XraytimestampDataGridViewTextBoxColumn.Name = "XraytimestampDataGridViewTextBoxColumn"
        Me.XraytimestampDataGridViewTextBoxColumn.ReadOnly = True
        '
        'xray_company
        '
        Me.xray_company.DataPropertyName = "xray_company"
        Me.xray_company.HeaderText = "xray_company"
        Me.xray_company.Name = "xray_company"
        Me.xray_company.ReadOnly = True
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
        Me.TableAdapterManager.tb_xrayTableAdapter = Me.Tb_xrayTableAdapter
        Me.TableAdapterManager.UpdateOrder = cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_xrayTableAdapter
        '
        Me.Tb_xrayTableAdapter.ClearBeforeFill = True
        '
        'Tb_infoTableAdapter
        '
        Me.Tb_infoTableAdapter.ClearBeforeFill = True
        '
        'xray_tab_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mpnl_body)
        Me.Name = "xray_tab_register"
        Me.Size = New System.Drawing.Size(993, 528)
        Me.mpnl_body.ResumeLayout(False)
        Me.mpnl_body.PerformLayout()
        CType(Me.Tb_xrayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_patient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_xray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mpnl_body As MetroFramework.Controls.MetroPanel
    Friend WithEvents mdt_search As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents mtxt_search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents grid_patients As MetroFramework.Controls.MetroGrid
    Friend WithEvents Tb_xrayBindingSource As BindingSource
    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents mcb_all_search As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_xrayTableAdapter As db_cygnetmedDataSetTableAdapters.tb_xrayTableAdapter
    Friend WithEvents Tb_infoBindingSource As BindingSource
    Friend WithEvents Tb_infoTableAdapter As db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_report As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcbo_radiologist As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcbo_radiotech As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbtn_save As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_add As MetroFramework.Controls.MetroButton
    Friend WithEvents pb_patient As PictureBox
    Friend WithEvents mlbl_name As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_company As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_gender As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_age As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_procedure As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_datereg As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_patient As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbl_case As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_impression As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_exam As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TransnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents info_fullname As DataGridViewTextBoxColumn
    Friend WithEvents info_procedure As DataGridViewTextBoxColumn
    Friend WithEvents info_company As DataGridViewTextBoxColumn
    Friend WithEvents info_picture As DataGridViewTextBoxColumn
    Friend WithEvents mlbl_status As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcbo_film As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents grid_xray As MetroFramework.Controls.MetroGrid
    Friend WithEvents mbtn_print As MetroFramework.Controls.MetroButton
    Friend WithEvents TransnoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents xray_radtech As DataGridViewTextBoxColumn
    Friend WithEvents xray_radiologist As DataGridViewTextBoxColumn
    Friend WithEvents XraydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XraytimestampDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents xray_company As DataGridViewTextBoxColumn
End Class
