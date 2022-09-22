<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class info_reports
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info_reports))
        Me.tb_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_cygnetmedDataSet = New cygnetmed.db_cygnetmedDataSet()
        Me.tb_infoTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter()
        Me.tb_info_filter = New System.Windows.Forms.BindingSource(Me.components)
        Me.mgrid_tb_info = New MetroFramework.Controls.MetroGrid()
        Me.InfopriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tb_logsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_logsTableAdapter = New cygnetmed.db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter()
        Me.TableAdapterManager = New cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager()
        Me.pnl_hide_logs = New System.Windows.Forms.Panel()
        Me.txt_hide_corrl = New System.Windows.Forms.TextBox()
        Me.txt_hide_activityl = New System.Windows.Forms.TextBox()
        Me.txt_hide_timestampl = New System.Windows.Forms.TextBox()
        Me.txt_hide_deptl = New System.Windows.Forms.TextBox()
        Me.txt_hide_namel = New System.Windows.Forms.TextBox()
        Me.cbo_print = New MetroFramework.Controls.MetroComboBox()
        CType(Me.tb_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_info_filter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mgrid_tb_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_hide_logs.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_infoBindingSource
        '
        Me.tb_infoBindingSource.DataMember = "tb_info"
        Me.tb_infoBindingSource.DataSource = Me.db_cygnetmedDataSet
        '
        'db_cygnetmedDataSet
        '
        Me.db_cygnetmedDataSet.DataSetName = "db_cygnetmedDataSet"
        Me.db_cygnetmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_infoTableAdapter
        '
        Me.tb_infoTableAdapter.ClearBeforeFill = True
        '
        'tb_info_filter
        '
        Me.tb_info_filter.DataMember = "tb_info"
        Me.tb_info_filter.DataSource = Me.db_cygnetmedDataSet
        '
        'mgrid_tb_info
        '
        Me.mgrid_tb_info.AllowUserToAddRows = False
        Me.mgrid_tb_info.AllowUserToResizeRows = False
        Me.mgrid_tb_info.AutoGenerateColumns = False
        Me.mgrid_tb_info.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mgrid_tb_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mgrid_tb_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mgrid_tb_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mgrid_tb_info.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mgrid_tb_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mgrid_tb_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InfopriceDataGridViewTextBoxColumn})
        Me.mgrid_tb_info.DataSource = Me.tb_info_filter
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mgrid_tb_info.DefaultCellStyle = DataGridViewCellStyle2
        Me.mgrid_tb_info.EnableHeadersVisualStyles = False
        Me.mgrid_tb_info.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mgrid_tb_info.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mgrid_tb_info.Location = New System.Drawing.Point(424, 313)
        Me.mgrid_tb_info.Name = "mgrid_tb_info"
        Me.mgrid_tb_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mgrid_tb_info.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mgrid_tb_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mgrid_tb_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mgrid_tb_info.Size = New System.Drawing.Size(30, 16)
        Me.mgrid_tb_info.TabIndex = 1
        '
        'InfopriceDataGridViewTextBoxColumn
        '
        Me.InfopriceDataGridViewTextBoxColumn.DataPropertyName = "info_price"
        Me.InfopriceDataGridViewTextBoxColumn.HeaderText = "info_price"
        Me.InfopriceDataGridViewTextBoxColumn.Name = "InfopriceDataGridViewTextBoxColumn"
        '
        'info_viewer
        '
        Me.info_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.info_viewer.Location = New System.Drawing.Point(0, 0)
        Me.info_viewer.Name = "info_viewer"
        Me.info_viewer.ServerReport.BearerToken = Nothing
        Me.info_viewer.Size = New System.Drawing.Size(949, 450)
        Me.info_viewer.TabIndex = 3
        '
        'Tb_logsBindingSource
        '
        Me.Tb_logsBindingSource.DataMember = "tb_logs"
        Me.Tb_logsBindingSource.DataSource = Me.db_cygnetmedDataSet
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
        Me.TableAdapterManager.tb_infoTableAdapter = Me.tb_infoTableAdapter
        Me.TableAdapterManager.tb_labTableAdapter = Nothing
        Me.TableAdapterManager.tb_loginTableAdapter = Nothing
        Me.TableAdapterManager.tb_logsTableAdapter = Me.Tb_logsTableAdapter
        Me.TableAdapterManager.tb_packageTableAdapter = Nothing
        Me.TableAdapterManager.tb_relTableAdapter = Nothing
        Me.TableAdapterManager.tb_xrayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cygnetmed.db_cygnetmedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'pnl_hide_logs
        '
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_corrl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_activityl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_timestampl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_deptl)
        Me.pnl_hide_logs.Controls.Add(Me.txt_hide_namel)
        Me.pnl_hide_logs.Location = New System.Drawing.Point(388, 216)
        Me.pnl_hide_logs.Name = "pnl_hide_logs"
        Me.pnl_hide_logs.Size = New System.Drawing.Size(25, 19)
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
        'cbo_print
        '
        Me.cbo_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_print.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_print.FormattingEnabled = True
        Me.cbo_print.ItemHeight = 19
        Me.cbo_print.Items.AddRange(New Object() {"Daily Report", "MD Payroll"})
        Me.cbo_print.Location = New System.Drawing.Point(797, 0)
        Me.cbo_print.Name = "cbo_print"
        Me.cbo_print.Size = New System.Drawing.Size(152, 25)
        Me.cbo_print.TabIndex = 640
        Me.cbo_print.UseSelectable = True
        '
        'info_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 450)
        Me.Controls.Add(Me.cbo_print)
        Me.Controls.Add(Me.info_viewer)
        Me.Controls.Add(Me.mgrid_tb_info)
        Me.Controls.Add(Me.pnl_hide_logs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "info_reports"
        Me.Text = "Cygnetmed Health System - Info Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tb_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_cygnetmedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_info_filter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mgrid_tb_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_logsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_hide_logs.ResumeLayout(False)
        Me.pnl_hide_logs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_infoBindingSource As BindingSource
    Friend WithEvents db_cygnetmedDataSet As db_cygnetmedDataSet
    Friend WithEvents tb_infoTableAdapter As db_cygnetmedDataSetTableAdapters.tb_infoTableAdapter
    Friend WithEvents tb_info_filter As BindingSource
    Friend WithEvents mgrid_tb_info As MetroFramework.Controls.MetroGrid
    Friend WithEvents InfopriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InfoidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents info_viewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tb_logsBindingSource As BindingSource
    Friend WithEvents Tb_logsTableAdapter As db_cygnetmedDataSetTableAdapters.tb_logsTableAdapter
    Friend WithEvents TableAdapterManager As db_cygnetmedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pnl_hide_logs As Panel
    Friend WithEvents txt_hide_corrl As TextBox
    Friend WithEvents txt_hide_activityl As TextBox
    Friend WithEvents txt_hide_timestampl As TextBox
    Friend WithEvents txt_hide_deptl As TextBox
    Friend WithEvents txt_hide_namel As TextBox
    Friend WithEvents cbo_print As MetroFramework.Controls.MetroComboBox
End Class
