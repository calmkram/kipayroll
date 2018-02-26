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
        Me.SalaryCalculationTableAdapter = New WindowsApp1.KIPayrollDataSetTableAdapters.SalaryCalculationTableAdapter()
        Me.EmployeeMasterTableAdapter = New WindowsApp1.KIPayrollDataSetTableAdapters.EmployeeMasterTableAdapter()
        Me.AttendanceTableAdapter = New WindowsApp1.KIPayrollDataSetTableAdapters.AttendanceTableAdapter()
        Me.SalaryAdvancesTableAdapter = New WindowsApp1.KIPayrollDataSetTableAdapters.SalaryAdvancesTableAdapter()
        Me.KIPayrollDataSet = New WindowsApp1.KIPayrollDataSet()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.lblAbsent = New System.Windows.Forms.Label()
        Me.lblOTHours = New System.Windows.Forms.Label()
        Me.lblOTDays = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblAttdBonus = New System.Windows.Forms.Label()
        Me.lblNSBF = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblESIDedn = New System.Windows.Forms.Label()
        Me.lblAdvDedn = New System.Windows.Forms.Label()
        Me.lblProfTax = New System.Windows.Forms.Label()
        Me.lblAmtToPay = New System.Windows.Forms.Label()
        Me.lblSalaryPaid = New System.Windows.Forms.Label()
        Me.lblESIEmplContr = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.grpSalAbstract.SuspendLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSalAbstract
        '
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
        Me.grpSalAbstract.Location = New System.Drawing.Point(13, 13)
        Me.grpSalAbstract.Name = "grpSalAbstract"
        Me.grpSalAbstract.Size = New System.Drawing.Size(1193, 553)
        Me.grpSalAbstract.TabIndex = 0
        Me.grpSalAbstract.TabStop = False
        Me.grpSalAbstract.Text = "Salary Abstract"
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
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(7, 20)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmpID.TabIndex = 0
        Me.lblEmpID.Text = "Employee ID"
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(80, 20)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(84, 13)
        Me.lblEmpName.TabIndex = 1
        Me.lblEmpName.Text = "Employee Name"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(206, 20)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(43, 13)
        Me.lblPresent.TabIndex = 2
        Me.lblPresent.Text = "Present"
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.Location = New System.Drawing.Point(255, 20)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(40, 13)
        Me.lblAbsent.TabIndex = 3
        Me.lblAbsent.Text = "Absent"
        '
        'lblOTHours
        '
        Me.lblOTHours.AutoSize = True
        Me.lblOTHours.Location = New System.Drawing.Point(301, 20)
        Me.lblOTHours.Name = "lblOTHours"
        Me.lblOTHours.Size = New System.Drawing.Size(53, 13)
        Me.lblOTHours.TabIndex = 4
        Me.lblOTHours.Text = "OT Hours"
        '
        'lblOTDays
        '
        Me.lblOTDays.AutoSize = True
        Me.lblOTDays.Location = New System.Drawing.Point(360, 20)
        Me.lblOTDays.Name = "lblOTDays"
        Me.lblOTDays.Size = New System.Drawing.Size(49, 13)
        Me.lblOTDays.TabIndex = 5
        Me.lblOTDays.Text = "OT Days"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(415, 20)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalDays.TabIndex = 6
        Me.lblTotalDays.Text = "Total Days"
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Location = New System.Drawing.Point(479, 20)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(65, 13)
        Me.lblBasicSalary.TabIndex = 7
        Me.lblBasicSalary.Text = "Basic Salary"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(550, 20)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(55, 13)
        Me.lblGrossPay.TabIndex = 8
        Me.lblGrossPay.Text = "Gross Pay"
        '
        'lblAttdBonus
        '
        Me.lblAttdBonus.AutoSize = True
        Me.lblAttdBonus.Location = New System.Drawing.Point(611, 20)
        Me.lblAttdBonus.Name = "lblAttdBonus"
        Me.lblAttdBonus.Size = New System.Drawing.Size(59, 13)
        Me.lblAttdBonus.TabIndex = 9
        Me.lblAttdBonus.Text = "Attd Bonus"
        '
        'lblNSBF
        '
        Me.lblNSBF.AutoSize = True
        Me.lblNSBF.Location = New System.Drawing.Point(676, 20)
        Me.lblNSBF.Name = "lblNSBF"
        Me.lblNSBF.Size = New System.Drawing.Size(46, 13)
        Me.lblNSBF.TabIndex = 10
        Me.lblNSBF.Text = "NS / BF"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(728, 20)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(45, 13)
        Me.lblNetPay.TabIndex = 11
        Me.lblNetPay.Text = "Net Pay"
        '
        'lblESIDedn
        '
        Me.lblESIDedn.AutoSize = True
        Me.lblESIDedn.Location = New System.Drawing.Point(779, 20)
        Me.lblESIDedn.Name = "lblESIDedn"
        Me.lblESIDedn.Size = New System.Drawing.Size(56, 13)
        Me.lblESIDedn.TabIndex = 12
        Me.lblESIDedn.Text = "ESI Dedn."
        '
        'lblAdvDedn
        '
        Me.lblAdvDedn.AutoSize = True
        Me.lblAdvDedn.Location = New System.Drawing.Point(841, 20)
        Me.lblAdvDedn.Name = "lblAdvDedn"
        Me.lblAdvDedn.Size = New System.Drawing.Size(61, 13)
        Me.lblAdvDedn.TabIndex = 13
        Me.lblAdvDedn.Text = "Adv. Dedn."
        '
        'lblProfTax
        '
        Me.lblProfTax.AutoSize = True
        Me.lblProfTax.Location = New System.Drawing.Point(908, 20)
        Me.lblProfTax.Name = "lblProfTax"
        Me.lblProfTax.Size = New System.Drawing.Size(50, 13)
        Me.lblProfTax.TabIndex = 14
        Me.lblProfTax.Text = "Prof. Tax"
        '
        'lblAmtToPay
        '
        Me.lblAmtToPay.AutoSize = True
        Me.lblAmtToPay.Location = New System.Drawing.Point(964, 20)
        Me.lblAmtToPay.Name = "lblAmtToPay"
        Me.lblAmtToPay.Size = New System.Drawing.Size(62, 13)
        Me.lblAmtToPay.TabIndex = 15
        Me.lblAmtToPay.Text = "Amt To Pay"
        '
        'lblSalaryPaid
        '
        Me.lblSalaryPaid.AutoSize = True
        Me.lblSalaryPaid.Location = New System.Drawing.Point(1032, 20)
        Me.lblSalaryPaid.Name = "lblSalaryPaid"
        Me.lblSalaryPaid.Size = New System.Drawing.Size(60, 13)
        Me.lblSalaryPaid.TabIndex = 16
        Me.lblSalaryPaid.Text = "Salary Paid"
        '
        'lblESIEmplContr
        '
        Me.lblESIEmplContr.AutoSize = True
        Me.lblESIEmplContr.Location = New System.Drawing.Point(1098, 20)
        Me.lblESIEmplContr.Name = "lblESIEmplContr"
        Me.lblESIEmplContr.Size = New System.Drawing.Size(78, 13)
        Me.lblESIEmplContr.TabIndex = 17
        Me.lblESIEmplContr.Text = "ESI Empl Contr"
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblLine.Location = New System.Drawing.Point(6, 35)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(1170, 3)
        Me.lblLine.TabIndex = 31
        '
        'PayrollCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1218, 631)
        Me.Controls.Add(Me.grpSalAbstract)
        Me.Name = "PayrollCalc"
        Me.ShowInTaskbar = False
        Me.Text = "Payroll Calculation"
        Me.grpSalAbstract.ResumeLayout(False)
        Me.grpSalAbstract.PerformLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
