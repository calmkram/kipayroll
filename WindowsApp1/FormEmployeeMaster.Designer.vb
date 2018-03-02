<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmpMaster
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
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.EmployeeMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KIPayrollDataSet = New KIPayroll.KIPayrollDataSet()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.lblEmpAddress = New System.Windows.Forms.Label()
        Me.grpEmpInfo = New System.Windows.Forms.GroupBox()
        Me.txtBasicSalary = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDOD = New System.Windows.Forms.DateTimePicker()
        Me.lblDOD = New System.Windows.Forms.Label()
        Me.txtEmpStatus = New System.Windows.Forms.TextBox()
        Me.lblEmpStatus = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpSalaryEffDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSalEffDate = New System.Windows.Forms.Label()
        Me.dtpDOJ = New System.Windows.Forms.DateTimePicker()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.lblDOJ = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.lblPincode = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lstbxCurrentEmpList = New System.Windows.Forms.ListBox()
        Me.lblCurrentEmpList = New System.Windows.Forms.Label()
        Me.btnAddEmpInfo = New System.Windows.Forms.Button()
        Me.btnModEmpInfo = New System.Windows.Forms.Button()
        Me.EmployeeMasterTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdateEmpResign = New System.Windows.Forms.Button()
        Me.EmpInfoArchiveTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.EmpInfoArchiveTableAdapter()
        CType(Me.EmployeeMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(35, 40)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(70, 13)
        Me.lblEmpID.TabIndex = 0
        Me.lblEmpID.Text = "Employee ID:"
        '
        'EmployeeMasterBindingSource
        '
        Me.EmployeeMasterBindingSource.DataMember = "EmployeeMaster"
        Me.EmployeeMasterBindingSource.DataSource = Me.KIPayrollDataSet
        '
        'KIPayrollDataSet
        '
        Me.KIPayrollDataSet.DataSetName = "KIPayrollDataSet"
        Me.KIPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEmpName
        '
        Me.txtEmpName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeMasterBindingSource, "EmpName", True))
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Location = New System.Drawing.Point(157, 70)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(194, 20)
        Me.txtEmpName.TabIndex = 1
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(35, 73)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(87, 13)
        Me.lblEmpName.TabIndex = 2
        Me.lblEmpName.Text = "Employee Name:"
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeMasterBindingSource, "HomeAddress", True))
        Me.txtEmpAddress.Enabled = False
        Me.txtEmpAddress.Location = New System.Drawing.Point(157, 107)
        Me.txtEmpAddress.Multiline = True
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.Size = New System.Drawing.Size(194, 82)
        Me.txtEmpAddress.TabIndex = 2
        '
        'lblEmpAddress
        '
        Me.lblEmpAddress.AutoSize = True
        Me.lblEmpAddress.Location = New System.Drawing.Point(35, 110)
        Me.lblEmpAddress.Name = "lblEmpAddress"
        Me.lblEmpAddress.Size = New System.Drawing.Size(79, 13)
        Me.lblEmpAddress.TabIndex = 4
        Me.lblEmpAddress.Text = "Home Address:"
        '
        'grpEmpInfo
        '
        Me.grpEmpInfo.Controls.Add(Me.txtBasicSalary)
        Me.grpEmpInfo.Controls.Add(Me.dtpDOD)
        Me.grpEmpInfo.Controls.Add(Me.lblDOD)
        Me.grpEmpInfo.Controls.Add(Me.txtEmpStatus)
        Me.grpEmpInfo.Controls.Add(Me.lblEmpStatus)
        Me.grpEmpInfo.Controls.Add(Me.txtEmpID)
        Me.grpEmpInfo.Controls.Add(Me.btnCancel)
        Me.grpEmpInfo.Controls.Add(Me.btnSave)
        Me.grpEmpInfo.Controls.Add(Me.dtpSalaryEffDate)
        Me.grpEmpInfo.Controls.Add(Me.lblSalEffDate)
        Me.grpEmpInfo.Controls.Add(Me.dtpDOJ)
        Me.grpEmpInfo.Controls.Add(Me.dtpDOB)
        Me.grpEmpInfo.Controls.Add(Me.lblBasicSalary)
        Me.grpEmpInfo.Controls.Add(Me.lblDOJ)
        Me.grpEmpInfo.Controls.Add(Me.lblDOB)
        Me.grpEmpInfo.Controls.Add(Me.txtPincode)
        Me.grpEmpInfo.Controls.Add(Me.lblPincode)
        Me.grpEmpInfo.Controls.Add(Me.txtCity)
        Me.grpEmpInfo.Controls.Add(Me.lblCity)
        Me.grpEmpInfo.Location = New System.Drawing.Point(12, 13)
        Me.grpEmpInfo.Name = "grpEmpInfo"
        Me.grpEmpInfo.Size = New System.Drawing.Size(670, 297)
        Me.grpEmpInfo.TabIndex = 6
        Me.grpEmpInfo.TabStop = False
        Me.grpEmpInfo.Text = "Employee Information"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.BeepOnError = True
        Me.txtBasicSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeMasterBindingSource, "BasicSalary", True))
        Me.txtBasicSalary.Enabled = False
        Me.txtBasicSalary.HidePromptOnLeave = True
        Me.txtBasicSalary.Location = New System.Drawing.Point(539, 92)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtBasicSalary.TabIndex = 26
        '
        'dtpDOD
        '
        Me.dtpDOD.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDOD.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeMasterBindingSource, "DateOfDeparture", True))
        Me.dtpDOD.Enabled = False
        Me.dtpDOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOD.Location = New System.Drawing.Point(539, 60)
        Me.dtpDOD.Name = "dtpDOD"
        Me.dtpDOD.Size = New System.Drawing.Size(100, 20)
        Me.dtpDOD.TabIndex = 24
        Me.dtpDOD.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'lblDOD
        '
        Me.lblDOD.AutoSize = True
        Me.lblDOD.Location = New System.Drawing.Point(417, 63)
        Me.lblDOD.Name = "lblDOD"
        Me.lblDOD.Size = New System.Drawing.Size(95, 13)
        Me.lblDOD.TabIndex = 25
        Me.lblDOD.Text = "Date of Departure:"
        '
        'txtEmpStatus
        '
        Me.txtEmpStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeMasterBindingSource, "EmpStatus", True))
        Me.txtEmpStatus.Enabled = False
        Me.txtEmpStatus.Location = New System.Drawing.Point(539, 165)
        Me.txtEmpStatus.Name = "txtEmpStatus"
        Me.txtEmpStatus.Size = New System.Drawing.Size(60, 20)
        Me.txtEmpStatus.TabIndex = 23
        '
        'lblEmpStatus
        '
        Me.lblEmpStatus.AutoSize = True
        Me.lblEmpStatus.Location = New System.Drawing.Point(417, 168)
        Me.lblEmpStatus.Name = "lblEmpStatus"
        Me.lblEmpStatus.Size = New System.Drawing.Size(89, 13)
        Me.lblEmpStatus.TabIndex = 22
        Me.lblEmpStatus.Text = "Employee Status:"
        '
        'txtEmpID
        '
        Me.txtEmpID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeMasterBindingSource, "EmpID", True))
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(145, 24)
        Me.txtEmpID.Mask = "KI-###"
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(51, 20)
        Me.txtEmpID.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(564, 262)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(455, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'dtpSalaryEffDate
        '
        Me.dtpSalaryEffDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpSalaryEffDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeMasterBindingSource, "EffDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.dtpSalaryEffDate.Enabled = False
        Me.dtpSalaryEffDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSalaryEffDate.Location = New System.Drawing.Point(539, 129)
        Me.dtpSalaryEffDate.Name = "dtpSalaryEffDate"
        Me.dtpSalaryEffDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpSalaryEffDate.TabIndex = 8
        Me.dtpSalaryEffDate.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'lblSalEffDate
        '
        Me.lblSalEffDate.AutoSize = True
        Me.lblSalEffDate.Location = New System.Drawing.Point(417, 132)
        Me.lblSalEffDate.Name = "lblSalEffDate"
        Me.lblSalEffDate.Size = New System.Drawing.Size(110, 13)
        Me.lblSalEffDate.TabIndex = 19
        Me.lblSalEffDate.Text = "Salary Effective Date:"
        '
        'dtpDOJ
        '
        Me.dtpDOJ.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDOJ.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeMasterBindingSource, "DateOfJoining", True))
        Me.dtpDOJ.Enabled = False
        Me.dtpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOJ.Location = New System.Drawing.Point(539, 27)
        Me.dtpDOJ.Name = "dtpDOJ"
        Me.dtpDOJ.Size = New System.Drawing.Size(100, 20)
        Me.dtpDOJ.TabIndex = 6
        Me.dtpDOJ.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDOB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeMasterBindingSource, "DateOfBirth", True))
        Me.dtpDOB.Enabled = False
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(145, 256)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(100, 20)
        Me.dtpDOB.TabIndex = 5
        Me.dtpDOB.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Location = New System.Drawing.Point(417, 95)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(68, 13)
        Me.lblBasicSalary.TabIndex = 15
        Me.lblBasicSalary.Text = "Basic Salary:"
        '
        'lblDOJ
        '
        Me.lblDOJ.AutoSize = True
        Me.lblDOJ.Location = New System.Drawing.Point(417, 30)
        Me.lblDOJ.Name = "lblDOJ"
        Me.lblDOJ.Size = New System.Drawing.Size(81, 13)
        Me.lblDOJ.TabIndex = 13
        Me.lblDOJ.Text = "Date of Joining:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(23, 262)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(69, 13)
        Me.lblDOB.TabIndex = 11
        Me.lblDOB.Text = "Date of Birth:"
        '
        'txtPincode
        '
        Me.txtPincode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeMasterBindingSource, "PinCode", True))
        Me.txtPincode.Enabled = False
        Me.txtPincode.Location = New System.Drawing.Point(145, 224)
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(100, 20)
        Me.txtPincode.TabIndex = 4
        '
        'lblPincode
        '
        Me.lblPincode.AutoSize = True
        Me.lblPincode.Location = New System.Drawing.Point(23, 227)
        Me.lblPincode.Name = "lblPincode"
        Me.lblPincode.Size = New System.Drawing.Size(53, 13)
        Me.lblPincode.TabIndex = 9
        Me.lblPincode.Text = "Pin Code:"
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeMasterBindingSource, "City", True))
        Me.txtCity.Enabled = False
        Me.txtCity.Location = New System.Drawing.Point(145, 190)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(194, 20)
        Me.txtCity.TabIndex = 3
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(23, 193)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 7
        Me.lblCity.Text = "City:"
        '
        'lstbxCurrentEmpList
        '
        Me.lstbxCurrentEmpList.DataSource = Me.EmployeeMasterBindingSource
        Me.lstbxCurrentEmpList.DisplayMember = "EmpName"
        Me.lstbxCurrentEmpList.FormattingEnabled = True
        Me.lstbxCurrentEmpList.Location = New System.Drawing.Point(714, 33)
        Me.lstbxCurrentEmpList.Name = "lstbxCurrentEmpList"
        Me.lstbxCurrentEmpList.Size = New System.Drawing.Size(240, 277)
        Me.lstbxCurrentEmpList.TabIndex = 11
        '
        'lblCurrentEmpList
        '
        Me.lblCurrentEmpList.AutoSize = True
        Me.lblCurrentEmpList.Location = New System.Drawing.Point(714, 14)
        Me.lblCurrentEmpList.Name = "lblCurrentEmpList"
        Me.lblCurrentEmpList.Size = New System.Drawing.Size(117, 13)
        Me.lblCurrentEmpList.TabIndex = 8
        Me.lblCurrentEmpList.Text = "Current Employees List:"
        '
        'btnAddEmpInfo
        '
        Me.btnAddEmpInfo.Location = New System.Drawing.Point(38, 325)
        Me.btnAddEmpInfo.Name = "btnAddEmpInfo"
        Me.btnAddEmpInfo.Size = New System.Drawing.Size(147, 23)
        Me.btnAddEmpInfo.TabIndex = 12
        Me.btnAddEmpInfo.Text = "Add New Employee Record"
        Me.btnAddEmpInfo.UseVisualStyleBackColor = True
        '
        'btnModEmpInfo
        '
        Me.btnModEmpInfo.Enabled = False
        Me.btnModEmpInfo.Location = New System.Drawing.Point(294, 325)
        Me.btnModEmpInfo.Name = "btnModEmpInfo"
        Me.btnModEmpInfo.Size = New System.Drawing.Size(147, 23)
        Me.btnModEmpInfo.TabIndex = 13
        Me.btnModEmpInfo.Text = "Modify Employee Record"
        Me.btnModEmpInfo.UseVisualStyleBackColor = True
        '
        'EmployeeMasterTableAdapter
        '
        Me.EmployeeMasterTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(825, 325)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdateEmpResign
        '
        Me.btnUpdateEmpResign.Location = New System.Drawing.Point(550, 325)
        Me.btnUpdateEmpResign.Name = "btnUpdateEmpResign"
        Me.btnUpdateEmpResign.Size = New System.Drawing.Size(166, 23)
        Me.btnUpdateEmpResign.TabIndex = 15
        Me.btnUpdateEmpResign.Text = "Update Employee Resignation"
        Me.btnUpdateEmpResign.UseVisualStyleBackColor = True
        '
        'EmpInfoArchiveTableAdapter
        '
        Me.EmpInfoArchiveTableAdapter.ClearBeforeFill = True
        '
        'EmpMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 368)
        Me.Controls.Add(Me.btnUpdateEmpResign)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModEmpInfo)
        Me.Controls.Add(Me.btnAddEmpInfo)
        Me.Controls.Add(Me.lblCurrentEmpList)
        Me.Controls.Add(Me.lstbxCurrentEmpList)
        Me.Controls.Add(Me.txtEmpAddress)
        Me.Controls.Add(Me.lblEmpAddress)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.grpEmpInfo)
        Me.Name = "EmpMaster"
        Me.Text = "Employee Master"
        CType(Me.EmployeeMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmpInfo.ResumeLayout(False)
        Me.grpEmpInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmpID As Label
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents lblEmpName As Label
    Friend WithEvents txtEmpAddress As TextBox
    Friend WithEvents lblEmpAddress As Label
    Friend WithEvents grpEmpInfo As GroupBox
    Friend WithEvents dtpSalaryEffDate As DateTimePicker
    Friend WithEvents lblSalEffDate As Label
    Friend WithEvents dtpDOJ As DateTimePicker
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents lblDOJ As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents lblPincode As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lstbxCurrentEmpList As ListBox
    Friend WithEvents lblCurrentEmpList As Label
    Friend WithEvents btnAddEmpInfo As Button
    Friend WithEvents btnModEmpInfo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
    Friend WithEvents EmployeeMasterBindingSource As BindingSource
    Friend WithEvents EmployeeMasterTableAdapter As KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter
    Friend WithEvents txtEmpID As MaskedTextBox
    Friend WithEvents txtEmpStatus As TextBox
    Friend WithEvents lblEmpStatus As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents dtpDOD As DateTimePicker
    Friend WithEvents lblDOD As Label
    Friend WithEvents btnUpdateEmpResign As Button
    Friend WithEvents txtBasicSalary As MaskedTextBox
    Friend WithEvents EmpInfoArchiveTableAdapter As KIPayrollDataSetTableAdapters.EmpInfoArchiveTableAdapter
End Class
