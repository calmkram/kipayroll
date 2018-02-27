<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollCalc
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
        Me.grpSalAbstract = New System.Windows.Forms.GroupBox()
        Me.txtTotalESIEmplContr = New System.Windows.Forms.TextBox()
        Me.txtTotalSalPaid = New System.Windows.Forms.TextBox()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.txtTotalProfTax = New System.Windows.Forms.TextBox()
        Me.txtTotalAdvDedn = New System.Windows.Forms.TextBox()
        Me.txtTotalESIDedn = New System.Windows.Forms.TextBox()
        Me.txtTotalNetPay = New System.Windows.Forms.TextBox()
        Me.txtTotalGrossPay = New System.Windows.Forms.TextBox()
        Me.txtNumDaysInMonth = New System.Windows.Forms.TextBox()
        Me.lblNumDaysInMonth = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblESIEmplContr = New System.Windows.Forms.Label()
        Me.lblSalaryPaid = New System.Windows.Forms.Label()
        Me.lblAmtToPay = New System.Windows.Forms.Label()
        Me.lblProfTax = New System.Windows.Forms.Label()
        Me.lblAdvDedn = New System.Windows.Forms.Label()
        Me.lblESIDedn = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblNSBF = New System.Windows.Forms.Label()
        Me.lblAttdBonus = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblOTDays = New System.Windows.Forms.Label()
        Me.lblOTHours = New System.Windows.Forms.Label()
        Me.lblAbsent = New System.Windows.Forms.Label()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.lblPayrollForMonth = New System.Windows.Forms.Label()
        Me.cmbPayrollForMonth = New System.Windows.Forms.ComboBox()
        Me.btnGeneratePayroll = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SalaryCalculationTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.SalaryCalculationTableAdapter()
        Me.EmployeeMasterTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter()
        Me.AttendanceTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.AttendanceTableAdapter()
        Me.SalaryAdvancesTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.SalaryAdvancesTableAdapter()
        Me.KIPayrollDataSet = New KIPayroll.KIPayrollDataSet()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpSalAbstract.SuspendLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSalAbstract
        '
        Me.grpSalAbstract.BackColor = System.Drawing.SystemColors.Control
        Me.grpSalAbstract.Controls.Add(Me.txtTotalESIEmplContr)
        Me.grpSalAbstract.Controls.Add(Me.txtTotalSalPaid)
        Me.grpSalAbstract.Controls.Add(Me.txtTotalAmt)
        Me.grpSalAbstract.Controls.Add(Me.txtTotalProfTax)
        Me.grpSalAbstract.Controls.Add(Me.txtTotalAdvDedn)
        Me.grpSalAbstract.Controls.Add(Me.txtTotalESIDedn)
        Me.grpSalAbstract.Controls.Add(Me.txtTotalNetPay)
        Me.grpSalAbstract.Controls.Add(Me.txtTotalGrossPay)
        Me.grpSalAbstract.Controls.Add(Me.txtNumDaysInMonth)
        Me.grpSalAbstract.Controls.Add(Me.lblNumDaysInMonth)
        Me.grpSalAbstract.Controls.Add(Me.lblLine)
        Me.grpSalAbstract.Controls.Add(Me.lblESIEmplContr)
        Me.grpSalAbstract.Controls.Add(Me.lblSalaryPaid)
        Me.grpSalAbstract.Controls.Add(Me.lblAmtToPay)
        Me.grpSalAbstract.Controls.Add(Me.lblProfTax)
        Me.grpSalAbstract.Controls.Add(Me.lblAdvDedn)
        Me.grpSalAbstract.Controls.Add(Me.lblESIDedn)
        Me.grpSalAbstract.Controls.Add(Me.lblNetPay)
        Me.grpSalAbstract.Controls.Add(Me.lblNSBF)
        Me.grpSalAbstract.Controls.Add(Me.lblAttdBonus)
        Me.grpSalAbstract.Controls.Add(Me.lblGrossPay)
        Me.grpSalAbstract.Controls.Add(Me.lblBasicSalary)
        Me.grpSalAbstract.Controls.Add(Me.lblTotalDays)
        Me.grpSalAbstract.Controls.Add(Me.lblOTDays)
        Me.grpSalAbstract.Controls.Add(Me.lblOTHours)
        Me.grpSalAbstract.Controls.Add(Me.lblAbsent)
        Me.grpSalAbstract.Controls.Add(Me.lblPresent)
        Me.grpSalAbstract.Controls.Add(Me.lblEmpName)
        Me.grpSalAbstract.Controls.Add(Me.lblEmpID)
        Me.grpSalAbstract.Location = New System.Drawing.Point(13, 42)
        Me.grpSalAbstract.Name = "grpSalAbstract"
        Me.grpSalAbstract.Size = New System.Drawing.Size(1323, 524)
        Me.grpSalAbstract.TabIndex = 0
        Me.grpSalAbstract.TabStop = False
        Me.grpSalAbstract.Text = "Salary Abstract"
        Me.grpSalAbstract.Visible = False
        '
        'txtTotalESIEmplContr
        '
        Me.txtTotalESIEmplContr.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalESIEmplContr.Enabled = False
        Me.txtTotalESIEmplContr.Location = New System.Drawing.Point(1149, 18)
        Me.txtTotalESIEmplContr.Name = "txtTotalESIEmplContr"
        Me.txtTotalESIEmplContr.Size = New System.Drawing.Size(60, 20)
        Me.txtTotalESIEmplContr.TabIndex = 40
        Me.txtTotalESIEmplContr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalSalPaid
        '
        Me.txtTotalSalPaid.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalSalPaid.Enabled = False
        Me.txtTotalSalPaid.Location = New System.Drawing.Point(1081, 18)
        Me.txtTotalSalPaid.Name = "txtTotalSalPaid"
        Me.txtTotalSalPaid.Size = New System.Drawing.Size(60, 20)
        Me.txtTotalSalPaid.TabIndex = 39
        Me.txtTotalSalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalAmt.Enabled = False
        Me.txtTotalAmt.Location = New System.Drawing.Point(1015, 18)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.Size = New System.Drawing.Size(60, 20)
        Me.txtTotalAmt.TabIndex = 38
        Me.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalProfTax
        '
        Me.txtTotalProfTax.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalProfTax.Enabled = False
        Me.txtTotalProfTax.Location = New System.Drawing.Point(959, 18)
        Me.txtTotalProfTax.Name = "txtTotalProfTax"
        Me.txtTotalProfTax.Size = New System.Drawing.Size(50, 20)
        Me.txtTotalProfTax.TabIndex = 37
        Me.txtTotalProfTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAdvDedn
        '
        Me.txtTotalAdvDedn.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalAdvDedn.Enabled = False
        Me.txtTotalAdvDedn.Location = New System.Drawing.Point(886, 18)
        Me.txtTotalAdvDedn.Name = "txtTotalAdvDedn"
        Me.txtTotalAdvDedn.Size = New System.Drawing.Size(50, 20)
        Me.txtTotalAdvDedn.TabIndex = 36
        Me.txtTotalAdvDedn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalESIDedn
        '
        Me.txtTotalESIDedn.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalESIDedn.Enabled = False
        Me.txtTotalESIDedn.Location = New System.Drawing.Point(821, 18)
        Me.txtTotalESIDedn.Name = "txtTotalESIDedn"
        Me.txtTotalESIDedn.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalESIDedn.TabIndex = 35
        Me.txtTotalESIDedn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalNetPay
        '
        Me.txtTotalNetPay.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalNetPay.Enabled = False
        Me.txtTotalNetPay.Location = New System.Drawing.Point(753, 18)
        Me.txtTotalNetPay.Name = "txtTotalNetPay"
        Me.txtTotalNetPay.Size = New System.Drawing.Size(60, 20)
        Me.txtTotalNetPay.TabIndex = 34
        Me.txtTotalNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalGrossPay
        '
        Me.txtTotalGrossPay.BackColor = System.Drawing.Color.LightBlue
        Me.txtTotalGrossPay.Enabled = False
        Me.txtTotalGrossPay.Location = New System.Drawing.Point(553, 18)
        Me.txtTotalGrossPay.Name = "txtTotalGrossPay"
        Me.txtTotalGrossPay.Size = New System.Drawing.Size(60, 20)
        Me.txtTotalGrossPay.TabIndex = 33
        Me.txtTotalGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumDaysInMonth
        '
        Me.txtNumDaysInMonth.Enabled = False
        Me.txtNumDaysInMonth.Location = New System.Drawing.Point(143, 18)
        Me.txtNumDaysInMonth.Name = "txtNumDaysInMonth"
        Me.txtNumDaysInMonth.Size = New System.Drawing.Size(36, 20)
        Me.txtNumDaysInMonth.TabIndex = 32
        '
        'lblNumDaysInMonth
        '
        Me.lblNumDaysInMonth.AutoSize = True
        Me.lblNumDaysInMonth.Location = New System.Drawing.Point(7, 21)
        Me.lblNumDaysInMonth.Name = "lblNumDaysInMonth"
        Me.lblNumDaysInMonth.Size = New System.Drawing.Size(130, 13)
        Me.lblNumDaysInMonth.TabIndex = 4
        Me.lblNumDaysInMonth.Text = "Number of Days in Month:"
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblLine.Location = New System.Drawing.Point(6, 57)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(1210, 3)
        Me.lblLine.TabIndex = 31
        '
        'lblESIEmplContr
        '
        Me.lblESIEmplContr.AutoSize = True
        Me.lblESIEmplContr.Location = New System.Drawing.Point(1146, 42)
        Me.lblESIEmplContr.Name = "lblESIEmplContr"
        Me.lblESIEmplContr.Size = New System.Drawing.Size(78, 13)
        Me.lblESIEmplContr.TabIndex = 17
        Me.lblESIEmplContr.Text = "ESI Empl Contr"
        '
        'lblSalaryPaid
        '
        Me.lblSalaryPaid.AutoSize = True
        Me.lblSalaryPaid.Location = New System.Drawing.Point(1080, 42)
        Me.lblSalaryPaid.Name = "lblSalaryPaid"
        Me.lblSalaryPaid.Size = New System.Drawing.Size(60, 13)
        Me.lblSalaryPaid.TabIndex = 16
        Me.lblSalaryPaid.Text = "Salary Paid"
        '
        'lblAmtToPay
        '
        Me.lblAmtToPay.AutoSize = True
        Me.lblAmtToPay.Location = New System.Drawing.Point(1012, 42)
        Me.lblAmtToPay.Name = "lblAmtToPay"
        Me.lblAmtToPay.Size = New System.Drawing.Size(62, 13)
        Me.lblAmtToPay.TabIndex = 15
        Me.lblAmtToPay.Text = "Amt To Pay"
        '
        'lblProfTax
        '
        Me.lblProfTax.AutoSize = True
        Me.lblProfTax.Location = New System.Drawing.Point(956, 42)
        Me.lblProfTax.Name = "lblProfTax"
        Me.lblProfTax.Size = New System.Drawing.Size(50, 13)
        Me.lblProfTax.TabIndex = 14
        Me.lblProfTax.Text = "Prof. Tax"
        '
        'lblAdvDedn
        '
        Me.lblAdvDedn.AutoSize = True
        Me.lblAdvDedn.Location = New System.Drawing.Point(883, 42)
        Me.lblAdvDedn.Name = "lblAdvDedn"
        Me.lblAdvDedn.Size = New System.Drawing.Size(61, 13)
        Me.lblAdvDedn.TabIndex = 13
        Me.lblAdvDedn.Text = "Adv. Dedn."
        '
        'lblESIDedn
        '
        Me.lblESIDedn.AutoSize = True
        Me.lblESIDedn.Location = New System.Drawing.Point(821, 42)
        Me.lblESIDedn.Name = "lblESIDedn"
        Me.lblESIDedn.Size = New System.Drawing.Size(56, 13)
        Me.lblESIDedn.TabIndex = 12
        Me.lblESIDedn.Text = "ESI Dedn."
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(750, 42)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(45, 13)
        Me.lblNetPay.TabIndex = 11
        Me.lblNetPay.Text = "Net Pay"
        '
        'lblNSBF
        '
        Me.lblNSBF.AutoSize = True
        Me.lblNSBF.Location = New System.Drawing.Point(689, 42)
        Me.lblNSBF.Name = "lblNSBF"
        Me.lblNSBF.Size = New System.Drawing.Size(46, 13)
        Me.lblNSBF.TabIndex = 10
        Me.lblNSBF.Text = "NS / BF"
        '
        'lblAttdBonus
        '
        Me.lblAttdBonus.AutoSize = True
        Me.lblAttdBonus.Location = New System.Drawing.Point(624, 42)
        Me.lblAttdBonus.Name = "lblAttdBonus"
        Me.lblAttdBonus.Size = New System.Drawing.Size(59, 13)
        Me.lblAttdBonus.TabIndex = 9
        Me.lblAttdBonus.Text = "Attd Bonus"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(550, 42)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(55, 13)
        Me.lblGrossPay.TabIndex = 8
        Me.lblGrossPay.Text = "Gross Pay"
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Location = New System.Drawing.Point(479, 42)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(65, 13)
        Me.lblBasicSalary.TabIndex = 7
        Me.lblBasicSalary.Text = "Basic Salary"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(415, 42)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalDays.TabIndex = 6
        Me.lblTotalDays.Text = "Total Days"
        '
        'lblOTDays
        '
        Me.lblOTDays.AutoSize = True
        Me.lblOTDays.Location = New System.Drawing.Point(360, 42)
        Me.lblOTDays.Name = "lblOTDays"
        Me.lblOTDays.Size = New System.Drawing.Size(49, 13)
        Me.lblOTDays.TabIndex = 5
        Me.lblOTDays.Text = "OT Days"
        '
        'lblOTHours
        '
        Me.lblOTHours.AutoSize = True
        Me.lblOTHours.Location = New System.Drawing.Point(301, 42)
        Me.lblOTHours.Name = "lblOTHours"
        Me.lblOTHours.Size = New System.Drawing.Size(53, 13)
        Me.lblOTHours.TabIndex = 4
        Me.lblOTHours.Text = "OT Hours"
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.Location = New System.Drawing.Point(255, 42)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(40, 13)
        Me.lblAbsent.TabIndex = 3
        Me.lblAbsent.Text = "Absent"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(206, 42)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(43, 13)
        Me.lblPresent.TabIndex = 2
        Me.lblPresent.Text = "Present"
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(80, 42)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(84, 13)
        Me.lblEmpName.TabIndex = 1
        Me.lblEmpName.Text = "Employee Name"
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(7, 42)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmpID.TabIndex = 0
        Me.lblEmpID.Text = "Employee ID"
        '
        'lblPayrollForMonth
        '
        Me.lblPayrollForMonth.AutoSize = True
        Me.lblPayrollForMonth.Location = New System.Drawing.Point(13, 15)
        Me.lblPayrollForMonth.Name = "lblPayrollForMonth"
        Me.lblPayrollForMonth.Size = New System.Drawing.Size(89, 13)
        Me.lblPayrollForMonth.TabIndex = 1
        Me.lblPayrollForMonth.Text = "Payroll for Month:"
        '
        'cmbPayrollForMonth
        '
        Me.cmbPayrollForMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayrollForMonth.FormattingEnabled = True
        Me.cmbPayrollForMonth.Location = New System.Drawing.Point(108, 11)
        Me.cmbPayrollForMonth.Name = "cmbPayrollForMonth"
        Me.cmbPayrollForMonth.Size = New System.Drawing.Size(154, 21)
        Me.cmbPayrollForMonth.TabIndex = 2
        '
        'btnGeneratePayroll
        '
        Me.btnGeneratePayroll.Location = New System.Drawing.Point(283, 10)
        Me.btnGeneratePayroll.Name = "btnGeneratePayroll"
        Me.btnGeneratePayroll.Size = New System.Drawing.Size(109, 23)
        Me.btnGeneratePayroll.TabIndex = 3
        Me.btnGeneratePayroll.Text = "Generate Payroll"
        Me.btnGeneratePayroll.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(500, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(595, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SalaryCalculationTableAdapter
        '
        Me.SalaryCalculationTableAdapter.ClearBeforeFill = True
        '
        'EmployeeMasterTableAdapter
        '
        Me.EmployeeMasterTableAdapter.ClearBeforeFill = True
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'SalaryAdvancesTableAdapter
        '
        Me.SalaryAdvancesTableAdapter.ClearBeforeFill = True
        '
        'KIPayrollDataSet
        '
        Me.KIPayrollDataSet.DataSetName = "KIPayrollDataSet"
        Me.KIPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(411, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PayrollCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1348, 631)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGeneratePayroll)
        Me.Controls.Add(Me.cmbPayrollForMonth)
        Me.Controls.Add(Me.lblPayrollForMonth)
        Me.Controls.Add(Me.grpSalAbstract)
        Me.Name = "PayrollCalc"
        Me.ShowInTaskbar = False
        Me.Text = "Payroll Calculation"
        Me.grpSalAbstract.ResumeLayout(False)
        Me.grpSalAbstract.PerformLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSalAbstract As GroupBox
    Friend WithEvents SalaryCalculationTableAdapter As KIPayrollDataSetTableAdapters.SalaryCalculationTableAdapter
    Friend WithEvents EmployeeMasterTableAdapter As KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter
    Friend WithEvents AttendanceTableAdapter As KIPayrollDataSetTableAdapters.AttendanceTableAdapter
    Friend WithEvents SalaryAdvancesTableAdapter As KIPayrollDataSetTableAdapters.SalaryAdvancesTableAdapter
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
    Friend WithEvents lblESIEmplContr As Label
    Friend WithEvents lblSalaryPaid As Label
    Friend WithEvents lblAmtToPay As Label
    Friend WithEvents lblProfTax As Label
    Friend WithEvents lblAdvDedn As Label
    Friend WithEvents lblESIDedn As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblNSBF As Label
    Friend WithEvents lblAttdBonus As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents lblOTDays As Label
    Friend WithEvents lblOTHours As Label
    Friend WithEvents lblAbsent As Label
    Friend WithEvents lblPresent As Label
    Friend WithEvents lblEmpName As Label
    Friend WithEvents lblEmpID As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents lblPayrollForMonth As Label
    Friend WithEvents cmbPayrollForMonth As ComboBox
    Friend WithEvents btnGeneratePayroll As Button
    Friend WithEvents txtNumDaysInMonth As TextBox
    Friend WithEvents lblNumDaysInMonth As Label
    Friend WithEvents txtTotalESIEmplContr As TextBox
    Friend WithEvents txtTotalSalPaid As TextBox
    Friend WithEvents txtTotalAmt As TextBox
    Friend WithEvents txtTotalProfTax As TextBox
    Friend WithEvents txtTotalAdvDedn As TextBox
    Friend WithEvents txtTotalESIDedn As TextBox
    Friend WithEvents txtTotalNetPay As TextBox
    Friend WithEvents txtTotalGrossPay As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClose As Button
End Class
