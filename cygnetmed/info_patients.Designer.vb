<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_patients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info_patients))
        Me.Db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.Tb_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_infoTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter()
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.msm_style = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.grid_patients = New MetroFramework.Controls.MetroGrid()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfofullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_middlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_contactno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_civil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_picture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtile_remote = New MetroFramework.Controls.MetroTile()
        Me.mtxt_search = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_cygnetmedDataSet
        '
        Me.Db_cygnetmedDataSet.DataSetName = "db_cygnetmedDataSet"
        Me.Db_cygnetmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_doctorsTableAdapter = Nothing
        Me.TableAdapterManager.tb_hmoTableAdapter = Nothing
        Me.TableAdapterManager.tb_infoTableAdapter = Me.Tb_infoTableAdapter
        Me.TableAdapterManager.tb_labTableAdapter = Nothing
        Me.TableAdapterManager.tb_loginTableAdapter = Nothing
        Me.TableAdapterManager.tb_logsTableAdapter = Nothing
        Me.TableAdapterManager.tb_packageTableAdapter = Nothing
        Me.TableAdapterManager.tb_relTableAdapter = Nothing
        Me.TableAdapterManager.tb_xrayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'msm_style
        '
        Me.msm_style.Owner = Me
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
        Me.grid_patients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransnoDataGridViewTextBoxColumn, Me.patientno, Me.InfofullnameDataGridViewTextBoxColumn, Me.info_lastname, Me.info_firstname, Me.info_middlename, Me.info_gender, Me.info_contactno, Me.info_birthdate, Me.info_civil, Me.info_date, Me.info_picture})
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
        Me.grid_patients.Location = New System.Drawing.Point(9, 68)
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
        Me.grid_patients.Size = New System.Drawing.Size(779, 267)
        Me.grid_patients.TabIndex = 558
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "transno"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "Case #"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'patientno
        '
        Me.patientno.DataPropertyName = "patientno"
        Me.patientno.HeaderText = "Patient #"
        Me.patientno.Name = "patientno"
        Me.patientno.ReadOnly = True
        '
        'InfofullnameDataGridViewTextBoxColumn
        '
        Me.InfofullnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InfofullnameDataGridViewTextBoxColumn.DataPropertyName = "info_fullname"
        Me.InfofullnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.InfofullnameDataGridViewTextBoxColumn.Name = "InfofullnameDataGridViewTextBoxColumn"
        Me.InfofullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'info_lastname
        '
        Me.info_lastname.DataPropertyName = "info_lastname"
        Me.info_lastname.HeaderText = "info_lastname"
        Me.info_lastname.Name = "info_lastname"
        Me.info_lastname.ReadOnly = True
        Me.info_lastname.Visible = False
        '
        'info_firstname
        '
        Me.info_firstname.DataPropertyName = "info_firstname"
        Me.info_firstname.HeaderText = "info_firstname"
        Me.info_firstname.Name = "info_firstname"
        Me.info_firstname.ReadOnly = True
        Me.info_firstname.Visible = False
        '
        'info_middlename
        '
        Me.info_middlename.DataPropertyName = "info_middlename"
        Me.info_middlename.HeaderText = "info_middlename"
        Me.info_middlename.Name = "info_middlename"
        Me.info_middlename.ReadOnly = True
        Me.info_middlename.Visible = False
        '
        'info_gender
        '
        Me.info_gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.info_gender.DataPropertyName = "info_gender"
        Me.info_gender.HeaderText = "Gender"
        Me.info_gender.Name = "info_gender"
        Me.info_gender.ReadOnly = True
        '
        'info_contactno
        '
        Me.info_contactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.info_contactno.DataPropertyName = "info_contactno"
        Me.info_contactno.HeaderText = "Contact #"
        Me.info_contactno.Name = "info_contactno"
        Me.info_contactno.ReadOnly = True
        '
        'info_birthdate
        '
        Me.info_birthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.info_birthdate.DataPropertyName = "info_birthdate"
        Me.info_birthdate.HeaderText = "Birthdate"
        Me.info_birthdate.Name = "info_birthdate"
        Me.info_birthdate.ReadOnly = True
        '
        'info_civil
        '
        Me.info_civil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.info_civil.DataPropertyName = "info_civil"
        Me.info_civil.HeaderText = "Civil Status"
        Me.info_civil.Name = "info_civil"
        Me.info_civil.ReadOnly = True
        '
        'info_date
        '
        Me.info_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.info_date.DataPropertyName = "info_date"
        Me.info_date.HeaderText = "Date Reg."
        Me.info_date.Name = "info_date"
        Me.info_date.ReadOnly = True
        '
        'info_picture
        '
        Me.info_picture.DataPropertyName = "info_picture"
        Me.info_picture.HeaderText = "info_picture"
        Me.info_picture.Name = "info_picture"
        Me.info_picture.ReadOnly = True
        Me.info_picture.Visible = False
        '
        'mtile_remote
        '
        Me.mtile_remote.ActiveControl = Nothing
        Me.mtile_remote.Enabled = False
        Me.mtile_remote.Location = New System.Drawing.Point(242, 36)
        Me.mtile_remote.Name = "mtile_remote"
        Me.mtile_remote.Size = New System.Drawing.Size(28, 28)
        Me.mtile_remote.TabIndex = 562
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
        Me.mtxt_search.CustomButton.Location = New System.Drawing.Point(254, 1)
        Me.mtxt_search.CustomButton.Name = ""
        Me.mtxt_search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxt_search.CustomButton.TabIndex = 1
        Me.mtxt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxt_search.CustomButton.UseSelectable = True
        Me.mtxt_search.CustomButton.Visible = False
        Me.mtxt_search.Lines = New String(-1) {}
        Me.mtxt_search.Location = New System.Drawing.Point(278, 39)
        Me.mtxt_search.MaxLength = 32767
        Me.mtxt_search.Name = "mtxt_search"
        Me.mtxt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxt_search.PromptText = "Search by Name"
        Me.mtxt_search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxt_search.SelectedText = ""
        Me.mtxt_search.SelectionLength = 0
        Me.mtxt_search.SelectionStart = 0
        Me.mtxt_search.ShortcutsEnabled = True
        Me.mtxt_search.Size = New System.Drawing.Size(276, 23)
        Me.mtxt_search.TabIndex = 561
        Me.mtxt_search.UseSelectable = True
        Me.mtxt_search.WaterMark = "Search by Name"
        Me.mtxt_search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxt_search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(361, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(96, 25)
        Me.MetroLabel1.TabIndex = 563
        Me.MetroLabel1.Text = "Patient List"
        '
        'info_patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 347)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.mtile_remote)
        Me.Controls.Add(Me.mtxt_search)
        Me.Controls.Add(Me.grid_patients)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "info_patients"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.Db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msm_style, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_patients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents Tb_infoBindingSource As BindingSource
    Friend WithEvents Tb_infoTableAdapter As db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents msm_style As MetroFramework.Components.MetroStyleManager
    Friend WithEvents grid_patients As MetroFramework.Controls.MetroGrid
    Friend WithEvents mtile_remote As MetroFramework.Controls.MetroTile
    Friend WithEvents mtxt_search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TransnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents patientno As DataGridViewTextBoxColumn
    Friend WithEvents InfofullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents info_lastname As DataGridViewTextBoxColumn
    Friend WithEvents info_firstname As DataGridViewTextBoxColumn
    Friend WithEvents info_middlename As DataGridViewTextBoxColumn
    Friend WithEvents info_gender As DataGridViewTextBoxColumn
    Friend WithEvents info_contactno As DataGridViewTextBoxColumn
    Friend WithEvents info_birthdate As DataGridViewTextBoxColumn
    Friend WithEvents info_civil As DataGridViewTextBoxColumn
    Friend WithEvents info_date As DataGridViewTextBoxColumn
    Friend WithEvents info_picture As DataGridViewTextBoxColumn
End Class
