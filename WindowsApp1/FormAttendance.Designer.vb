<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
    Inherits System.Windows.Forms.Form

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
        Me.cmbEmpName = New System.Windows.Forms.ComboBox()
        Me.lblSelectEmp = New System.Windows.Forms.Label()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.dtpAttdDate = New System.Windows.Forms.DateTimePicker()
        Me.lblAttdDate = New System.Windows.Forms.Label()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.txtRegularHrs = New System.Windows.Forms.TextBox()
        Me.lblRegHrs = New System.Windows.Forms.Label()
        Me.lblOvertimeHrs = New System.Windows.Forms.Label()
        Me.txtOvertimeHrs = New System.Windows.Forms.TextBox()
        Me.lblTotalHrs = New System.Windows.Forms.Label()
        Me.txtTotalHrs = New System.Windows.Forms.TextBox()
        Me.btnAddNewAttdRec = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpAddAttdRecord = New System.Windows.Forms.GroupBox()
        Me.grpViewAttdRecords = New System.Windows.Forms.GroupBox()
        Me.dgvViewAttdRecords = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttdDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OvertimeHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KIPayrollDataSet = New KIPayroll.KIPayrollDataSet()
        Me.btnViewAttdRecords = New System.Windows.Forms.Button()
        Me.AttendanceTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.AttendanceTableAdapter()
        Me.EmployeeMasterTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter()
        Me.grpAddAttdRecord.SuspendLayout()
        Me.grpViewAttdRecords.SuspendLayout()
        CType(Me.dgvViewAttdRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEmpName
        '
        Me.cmbEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpName.Enabled = False
        Me.cmbEmpName.FormattingEnabled = True
        Me.cmbEmpName.Location = New System.Drawing.Point(322, 16)
        Me.cmbEmpName.Name = "cmbEmpName"
        Me.cmbEmpName.Size = New System.Drawing.Size(141, 21)
        Me.cmbEmpName.TabIndex = 0
        '
        'lblSelectEmp
        '
        Me.lblSelectEmp.AutoSize = True
        Me.lblSelectEmp.Location = New System.Drawing.Point(226, 19)
        Me.lblSelectEmp.Name = "lblSelectEmp"
        Me.lblSelectEmp.Size = New System.Drawing.Size(89, 13)
        Me.lblSelectEmp.TabIndex = 1
        Me.lblSelectEmp.Text = "Select Employee:"
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(22, 19)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(70, 13)
        Me.lblEmpID.TabIndex = 2
        Me.lblEmpID.Text = "Employee ID:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(122, 16)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(63, 20)
        Me.txtEmpID.TabIndex = 3
        '
        'dtpAttdDate
        '
        Me.dtpAttdDate.Enabled = False
        Me.dtpAttdDate.Location = New System.Drawing.Point(118, 23)
        Me.dtpAttdDate.Name = "dtpAttdDate"
        Me.dtpAttdDate.Size = New System.Drawing.Size(190, 20)
        Me.dtpAttdDate.TabIndex = 4
        '
        'lblAttdDate
        '
        Me.lblAttdDate.AutoSize = True
        Me.lblAttdDate.Location = New System.Drawing.Point(18, 27)
        Me.lblAttdDate.Name = "lblAttdDate"
        Me.lblAttdDate.Size = New System.Drawing.Size(91, 13)
        Me.lblAttdDate.TabIndex = 5
        Me.lblAttdDate.Text = "Attendance Date:"
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Enabled = False
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(118, 61)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(96, 20)
        Me.dtpStartTime.TabIndex = 6
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(18, 65)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(82, 13)
        Me.lblStartTime.TabIndex = 7
        Me.lblStartTime.Text = "Shift Start Time:"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(18, 103)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(79, 13)
        Me.lblEndTime.TabIndex = 9
        Me.lblEndTime.Text = "Shift End Time:"
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "h:mm tt"
        Me.dtpEndTime.Enabled = False
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(118, 99)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(96, 20)
        Me.dtpEndTime.TabIndex = 8
        '
        'txtRegularHrs
        '
        Me.txtRegularHrs.Enabled = False
        Me.txtRegularHrs.Location = New System.Drawing.Point(118, 139)
        Me.txtRegularHrs.Name = "txtRegularHrs"
        Me.txtRegularHrs.Size = New System.Drawing.Size(100, 20)
        Me.txtRegularHrs.TabIndex = 10
        '
        'lblRegHrs
        '
        Me.lblRegHrs.AutoSize = True
        Me.lblRegHrs.Location = New System.Drawing.Point(18, 143)
        Me.lblRegHrs.Name = "lblRegHrs"
        Me.lblRegHrs.Size = New System.Drawing.Size(78, 13)
        Me.lblRegHrs.TabIndex = 11
        Me.lblRegHrs.Text = "Regular Hours:"
        '
        'lblOvertimeHrs
        '
        Me.lblOvertimeHrs.AutoSize = True
        Me.lblOvertimeHrs.Location = New System.Drawing.Point(18, 181)
        Me.lblOvertimeHrs.Name = "lblOvertimeHrs"
        Me.lblOvertimeHrs.Size = New System.Drawing.Size(83, 13)
        Me.lblOvertimeHrs.TabIndex = 13
        Me.lblOvertimeHrs.Text = "Overtime Hours:"
        '
        'txtOvertimeHrs
        '
        Me.txtOvertimeHrs.Enabled = False
        Me.txtOvertimeHrs.Location = New System.Drawing.Point(118, 177)
        Me.txtOvertimeHrs.Name = "txtOvertimeHrs"
        Me.txtOvertimeHrs.Size = New System.Drawing.Size(100, 20)
        Me.txtOvertimeHrs.TabIndex = 12
        '
        'lblTotalHrs
        '
        Me.lblTotalHrs.AutoSize = True
        Me.lblTotalHrs.Location = New System.Drawing.Point(18, 218)
        Me.lblTotalHrs.Name = "lblTotalHrs"
        Me.lblTotalHrs.Size = New System.Drawing.Size(65, 13)
        Me.lblTotalHrs.TabIndex = 15
        Me.lblTotalHrs.Text = "Total Hours:"
        '
        'txtTotalHrs
        '
        Me.txtTotalHrs.Enabled = False
        Me.txtTotalHrs.Location = New System.Drawing.Point(118, 214)
        Me.txtTotalHrs.Name = "txtTotalHrs"
        Me.txtTotalHrs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalHrs.TabIndex = 14
        '
        'btnAddNewAttdRec
        '
        Me.btnAddNewAttdRec.Location = New System.Drawing.Point(22, 309)
        Me.btnAddNewAttdRec.Name = "btnAddNewAttdRec"
        Me.btnAddNewAttdRec.Size = New System.Drawing.Size(114, 34)
        Me.btnAddNewAttdRec.TabIndex = 16
        Me.btnAddNewAttdRec.Text = "Add New Attendance Record"
        Me.btnAddNewAttdRec.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(325, 168)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 26)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(325, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(388, 309)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpAddAttdRecord
        '
        Me.grpAddAttdRecord.Controls.Add(Me.dtpAttdDate)
        Me.grpAddAttdRecord.Controls.Add(Me.lblAttdDate)
        Me.grpAddAttdRecord.Controls.Add(Me.btnCancel)
        Me.grpAddAttdRecord.Controls.Add(Me.dtpStartTime)
        Me.grpAddAttdRecord.Controls.Add(Me.btnSave)
        Me.grpAddAttdRecord.Controls.Add(Me.lblStartTime)
        Me.grpAddAttdRecord.Controls.Add(Me.dtpEndTime)
        Me.grpAddAttdRecord.Controls.Add(Me.lblTotalHrs)
        Me.grpAddAttdRecord.Controls.Add(Me.lblEndTime)
        Me.grpAddAttdRecord.Controls.Add(Me.txtTotalHrs)
        Me.grpAddAttdRecord.Controls.Add(Me.txtRegularHrs)
        Me.grpAddAttdRecord.Controls.Add(Me.lblOvertimeHrs)
        Me.grpAddAttdRecord.Controls.Add(Me.lblRegHrs)
        Me.grpAddAttdRecord.Controls.Add(Me.txtOvertimeHrs)
        Me.grpAddAttdRecord.Location = New System.Drawing.Point(25, 49)
        Me.grpAddAttdRecord.Name = "grpAddAttdRecord"
        Me.grpAddAttdRecord.Size = New System.Drawing.Size(438, 242)
        Me.grpAddAttdRecord.TabIndex = 20
        Me.grpAddAttdRecord.TabStop = False
        Me.grpAddAttdRecord.Text = "Add Attendance Record"
        '
        'grpViewAttdRecords
        '
        Me.grpViewAttdRecords.Controls.Add(Me.dgvViewAttdRecords)
        Me.grpViewAttdRecords.Location = New System.Drawing.Point(25, 50)
        Me.grpViewAttdRecords.Name = "grpViewAttdRecords"
        Me.grpViewAttdRecords.Size = New System.Drawing.Size(529, 242)
        Me.grpViewAttdRecords.TabIndex = 21
        Me.grpViewAttdRecords.TabStop = False
        Me.grpViewAttdRecords.Text = "View Attendance Records"
        Me.grpViewAttdRecords.Visible = False
        '
        'dgvViewAttdRecords
        '
        Me.dgvViewAttdRecords.AllowUserToAddRows = False
        Me.dgvViewAttdRecords.AllowUserToDeleteRows = False
        Me.dgvViewAttdRecords.AllowUserToResizeColumns = False
        Me.dgvViewAttdRecords.AutoGenerateColumns = False
        Me.dgvViewAttdRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvViewAttdRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvViewAttdRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewAttdRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.AttdDateDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.EndTimeDataGridViewTextBoxColumn, Me.TotalHoursDataGridViewTextBoxColumn, Me.OvertimeHoursDataGridViewTextBoxColumn})
        Me.dgvViewAttdRecords.DataSource = Me.AttendanceBindingSource
        Me.dgvViewAttdRecords.Location = New System.Drawing.Point(8, 19)
        Me.dgvViewAttdRecords.Name = "dgvViewAttdRecords"
        Me.dgvViewAttdRecords.ReadOnly = True
        Me.dgvViewAttdRecords.Size = New System.Drawing.Size(512, 212)
        Me.dgvViewAttdRecords.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpIDDataGridViewTextBoxColumn.Width = 64
        '
        'AttdDateDataGridViewTextBoxColumn
        '
        Me.AttdDateDataGridViewTextBoxColumn.DataPropertyName = "AttdDate"
        Me.AttdDateDataGridViewTextBoxColumn.HeaderText = "AttdDate"
        Me.AttdDateDataGridViewTextBoxColumn.Name = "AttdDateDataGridViewTextBoxColumn"
        Me.AttdDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.AttdDateDataGridViewTextBoxColumn.Width = 74
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        Me.StartTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.StartTimeDataGridViewTextBoxColumn.Width = 77
        '
        'EndTimeDataGridViewTextBoxColumn
        '
        Me.EndTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime"
        Me.EndTimeDataGridViewTextBoxColumn.HeaderText = "EndTime"
        Me.EndTimeDataGridViewTextBoxColumn.Name = "EndTimeDataGridViewTextBoxColumn"
        Me.EndTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EndTimeDataGridViewTextBoxColumn.Width = 74
        '
        'TotalHoursDataGridViewTextBoxColumn
        '
        Me.TotalHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalHours"
        Me.TotalHoursDataGridViewTextBoxColumn.HeaderText = "TotalHours"
        Me.TotalHoursDataGridViewTextBoxColumn.Name = "TotalHoursDataGridViewTextBoxColumn"
        Me.TotalHoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalHoursDataGridViewTextBoxColumn.Width = 84
        '
        'OvertimeHoursDataGridViewTextBoxColumn
        '
        Me.OvertimeHoursDataGridViewTextBoxColumn.DataPropertyName = "OvertimeHours"
        Me.OvertimeHoursDataGridViewTextBoxColumn.HeaderText = "OvertimeHours"
        Me.OvertimeHoursDataGridViewTextBoxColumn.Name = "OvertimeHoursDataGridViewTextBoxColumn"
        Me.OvertimeHoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.OvertimeHoursDataGridViewTextBoxColumn.Width = 102
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "Attendance"
        Me.AttendanceBindingSource.DataSource = Me.KIPayrollDataSet
        '
        'KIPayrollDataSet
        '
        Me.KIPayrollDataSet.DataSetName = "KIPayrollDataSet"
        Me.KIPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnViewAttdRecords
        '
        Me.btnViewAttdRecords.Location = New System.Drawing.Point(201, 309)
        Me.btnViewAttdRecords.Name = "btnViewAttdRecords"
        Me.btnViewAttdRecords.Size = New System.Drawing.Size(114, 34)
        Me.btnViewAttdRecords.TabIndex = 22
        Me.btnViewAttdRecords.Text = "View Attendance Records"
        Me.btnViewAttdRecords.UseVisualStyleBackColor = True
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'EmployeeMasterTableAdapter
        '
        Me.EmployeeMasterTableAdapter.ClearBeforeFill = True
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 368)
        Me.Controls.Add(Me.btnViewAttdRecords)
        Me.Controls.Add(Me.grpViewAttdRecords)
        Me.Controls.Add(Me.grpAddAttdRecord)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddNewAttdRec)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.lblSelectEmp)
        Me.Controls.Add(Me.cmbEmpName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Attendance"
        Me.ShowInTaskbar = False
        Me.Text = "Record Daily Attendance"
        Me.grpAddAttdRecord.ResumeLayout(False)
        Me.grpAddAttdRecord.PerformLayout()
        Me.grpViewAttdRecords.ResumeLayout(False)
        CType(Me.dgvViewAttdRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbEmpName As ComboBox
    Friend WithEvents lblSelectEmp As Label
    Friend WithEvents lblEmpID As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents dtpAttdDate As DateTimePicker
    Friend WithEvents lblAttdDate As Label
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents txtRegularHrs As TextBox
    Friend WithEvents lblRegHrs As Label
    Friend WithEvents lblOvertimeHrs As Label
    Friend WithEvents txtOvertimeHrs As TextBox
    Friend WithEvents lblTotalHrs As Label
    Friend WithEvents txtTotalHrs As TextBox
    Friend WithEvents AttendanceTableAdapter As KIPayrollDataSetTableAdapters.AttendanceTableAdapter
    Friend WithEvents EmployeeMasterTableAdapter As KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
    Friend WithEvents btnAddNewAttdRec As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents grpAddAttdRecord As GroupBox
    Friend WithEvents grpViewAttdRecords As GroupBox
    Friend WithEvents dgvViewAttdRecords As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttdDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OvertimeHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceBindingSource As BindingSource
    Friend WithEvents btnViewAttdRecords As Button
End Class
