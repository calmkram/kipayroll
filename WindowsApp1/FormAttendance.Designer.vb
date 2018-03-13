<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance
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
        Me.lblSelectMonth = New System.Windows.Forms.Label()
        Me.cmbViewMonth = New System.Windows.Forms.ComboBox()
        Me.grpAddAttdRecords = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvRecordAttendance = New System.Windows.Forms.DataGridView()
        Me.EmpID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AttdDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRecordAttd = New System.Windows.Forms.Button()
        Me.btnViewAttdRecords = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.KIPayrollDataSet = New KIPayroll.KIPayrollDataSet()
        Me.AttendanceTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.AttendanceTableAdapter()
        Me.EmployeeMasterTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter()
        Me.grpViewAttdRecords = New System.Windows.Forms.GroupBox()
        Me.dgvViewAttdRecords = New System.Windows.Forms.DataGridView()
        Me.AttendanceQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceQueryTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.AttendanceQueryTableAdapter()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.cmbEmpName = New System.Windows.Forms.ComboBox()
        Me.btnClearSelections = New System.Windows.Forms.Button()
        Me.grpAddAttdRecords.SuspendLayout()
        CType(Me.dgvRecordAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpViewAttdRecords.SuspendLayout()
        CType(Me.dgvViewAttdRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectMonth
        '
        Me.lblSelectMonth.AutoSize = True
        Me.lblSelectMonth.Location = New System.Drawing.Point(13, 13)
        Me.lblSelectMonth.Name = "lblSelectMonth"
        Me.lblSelectMonth.Size = New System.Drawing.Size(73, 13)
        Me.lblSelectMonth.TabIndex = 0
        Me.lblSelectMonth.Text = "Select Month:"
        '
        'cmbViewMonth
        '
        Me.cmbViewMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewMonth.FormattingEnabled = True
        Me.cmbViewMonth.Location = New System.Drawing.Point(92, 10)
        Me.cmbViewMonth.Name = "cmbViewMonth"
        Me.cmbViewMonth.Size = New System.Drawing.Size(131, 21)
        Me.cmbViewMonth.TabIndex = 1
        '
        'grpAddAttdRecords
        '
        Me.grpAddAttdRecords.Controls.Add(Me.btnCancel)
        Me.grpAddAttdRecords.Controls.Add(Me.btnSave)
        Me.grpAddAttdRecords.Controls.Add(Me.dgvRecordAttendance)
        Me.grpAddAttdRecords.Location = New System.Drawing.Point(16, 37)
        Me.grpAddAttdRecords.Name = "grpAddAttdRecords"
        Me.grpAddAttdRecords.Size = New System.Drawing.Size(640, 340)
        Me.grpAddAttdRecords.TabIndex = 2
        Me.grpAddAttdRecords.TabStop = False
        Me.grpAddAttdRecords.Text = "Record Daily Attendance"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(308, 310)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(181, 310)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvRecordAttendance
        '
        Me.dgvRecordAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecordAttendance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpID, Me.EmpName, Me.AttdDate, Me.StartTime, Me.EndTime, Me.RegHours, Me.OTHours, Me.TotalHrs})
        Me.dgvRecordAttendance.Location = New System.Drawing.Point(6, 19)
        Me.dgvRecordAttendance.Name = "dgvRecordAttendance"
        Me.dgvRecordAttendance.Size = New System.Drawing.Size(628, 285)
        Me.dgvRecordAttendance.TabIndex = 0
        '
        'EmpID
        '
        Me.EmpID.HeaderText = "Employee ID"
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Width = 75
        '
        'EmpName
        '
        Me.EmpName.HeaderText = "Employee Name"
        Me.EmpName.Name = "EmpName"
        '
        'AttdDate
        '
        Me.AttdDate.HeaderText = "Attendance Date"
        Me.AttdDate.Name = "AttdDate"
        Me.AttdDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttdDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'StartTime
        '
        Me.StartTime.HeaderText = "Start Time"
        Me.StartTime.Name = "StartTime"
        Me.StartTime.Width = 80
        '
        'EndTime
        '
        Me.EndTime.HeaderText = "End Time"
        Me.EndTime.Name = "EndTime"
        Me.EndTime.Width = 80
        '
        'RegHours
        '
        Me.RegHours.HeaderText = "Regular Hours"
        Me.RegHours.Name = "RegHours"
        Me.RegHours.Width = 50
        '
        'OTHours
        '
        Me.OTHours.HeaderText = "Overtime Hours"
        Me.OTHours.Name = "OTHours"
        Me.OTHours.Width = 50
        '
        'TotalHrs
        '
        Me.TotalHrs.HeaderText = "Total Hours"
        Me.TotalHrs.Name = "TotalHrs"
        Me.TotalHrs.Width = 50
        '
        'btnRecordAttd
        '
        Me.btnRecordAttd.Location = New System.Drawing.Point(65, 394)
        Me.btnRecordAttd.Name = "btnRecordAttd"
        Me.btnRecordAttd.Size = New System.Drawing.Size(115, 23)
        Me.btnRecordAttd.TabIndex = 3
        Me.btnRecordAttd.Text = "Record Attendance"
        Me.btnRecordAttd.UseVisualStyleBackColor = True
        '
        'btnViewAttdRecords
        '
        Me.btnViewAttdRecords.Location = New System.Drawing.Point(268, 394)
        Me.btnViewAttdRecords.Name = "btnViewAttdRecords"
        Me.btnViewAttdRecords.Size = New System.Drawing.Size(141, 23)
        Me.btnViewAttdRecords.TabIndex = 4
        Me.btnViewAttdRecords.Text = "View Attendance Records"
        Me.btnViewAttdRecords.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(497, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'KIPayrollDataSet
        '
        Me.KIPayrollDataSet.DataSetName = "KIPayrollDataSet"
        Me.KIPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'EmployeeMasterTableAdapter
        '
        Me.EmployeeMasterTableAdapter.ClearBeforeFill = True
        '
        'grpViewAttdRecords
        '
        Me.grpViewAttdRecords.Controls.Add(Me.dgvViewAttdRecords)
        Me.grpViewAttdRecords.Location = New System.Drawing.Point(678, 37)
        Me.grpViewAttdRecords.Name = "grpViewAttdRecords"
        Me.grpViewAttdRecords.Size = New System.Drawing.Size(640, 340)
        Me.grpViewAttdRecords.TabIndex = 6
        Me.grpViewAttdRecords.TabStop = False
        Me.grpViewAttdRecords.Text = "View Attendance Records"
        Me.grpViewAttdRecords.Visible = False
        '
        'dgvViewAttdRecords
        '
        Me.dgvViewAttdRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewAttdRecords.Location = New System.Drawing.Point(6, 19)
        Me.dgvViewAttdRecords.Name = "dgvViewAttdRecords"
        Me.dgvViewAttdRecords.Size = New System.Drawing.Size(628, 314)
        Me.dgvViewAttdRecords.TabIndex = 0
        '
        'AttendanceQueryBindingSource
        '
        Me.AttendanceQueryBindingSource.DataMember = "AttendanceQuery"
        Me.AttendanceQueryBindingSource.DataSource = Me.KIPayrollDataSet
        '
        'AttendanceQueryTableAdapter
        '
        Me.AttendanceQueryTableAdapter.ClearBeforeFill = True
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(265, 13)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(89, 13)
        Me.lblEmpName.TabIndex = 7
        Me.lblEmpName.Text = "Select Employee:"
        '
        'cmbEmpName
        '
        Me.cmbEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpName.FormattingEnabled = True
        Me.cmbEmpName.Location = New System.Drawing.Point(360, 10)
        Me.cmbEmpName.Name = "cmbEmpName"
        Me.cmbEmpName.Size = New System.Drawing.Size(136, 21)
        Me.cmbEmpName.TabIndex = 8
        '
        'btnClearSelections
        '
        Me.btnClearSelections.Location = New System.Drawing.Point(550, 8)
        Me.btnClearSelections.Name = "btnClearSelections"
        Me.btnClearSelections.Size = New System.Drawing.Size(100, 23)
        Me.btnClearSelections.TabIndex = 9
        Me.btnClearSelections.Text = "Clear Selections"
        Me.btnClearSelections.UseVisualStyleBackColor = True
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 429)
        Me.Controls.Add(Me.btnClearSelections)
        Me.Controls.Add(Me.cmbEmpName)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.grpViewAttdRecords)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewAttdRecords)
        Me.Controls.Add(Me.btnRecordAttd)
        Me.Controls.Add(Me.grpAddAttdRecords)
        Me.Controls.Add(Me.cmbViewMonth)
        Me.Controls.Add(Me.lblSelectMonth)
        Me.Name = "Attendance"
        Me.Text = "Record Daily Attendance"
        Me.grpAddAttdRecords.ResumeLayout(False)
        CType(Me.dgvRecordAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpViewAttdRecords.ResumeLayout(False)
        CType(Me.dgvViewAttdRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectMonth As Label
    Friend WithEvents cmbViewMonth As ComboBox
    Friend WithEvents grpAddAttdRecords As GroupBox
    Friend WithEvents dgvRecordAttendance As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents EmpID As DataGridViewTextBoxColumn
    Friend WithEvents EmpName As DataGridViewComboBoxColumn
    Friend WithEvents AttdDate As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents EndTime As DataGridViewTextBoxColumn
    Friend WithEvents RegHours As DataGridViewTextBoxColumn
    Friend WithEvents OTHours As DataGridViewTextBoxColumn
    Friend WithEvents TotalHrs As DataGridViewTextBoxColumn
    Friend WithEvents btnRecordAttd As Button
    Friend WithEvents btnViewAttdRecords As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
    Friend WithEvents AttendanceTableAdapter As KIPayrollDataSetTableAdapters.AttendanceTableAdapter
    Friend WithEvents EmployeeMasterTableAdapter As KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter
    Friend WithEvents grpViewAttdRecords As GroupBox
    Friend WithEvents dgvViewAttdRecords As DataGridView
    Friend WithEvents AttendanceQueryBindingSource As BindingSource
    Friend WithEvents AttendanceQueryTableAdapter As KIPayrollDataSetTableAdapters.AttendanceQueryTableAdapter
    Friend WithEvents lblEmpName As Label
    Friend WithEvents cmbEmpName As ComboBox
    Friend WithEvents btnClearSelections As Button
End Class
