<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppMainWindow
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EmpInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryAdvancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneratePayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSalaryAbstractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSalarySlipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusBarLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTimeStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.KIPayrollDataSet = New KIPayroll.KIPayrollDataSet()
        Me.SalaryCalculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryCalculationTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.SalaryCalculationTableAdapter()
        Me.DTTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryCalculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpInfoToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "mnuStrip"
        '
        'EmpInfoToolStripMenuItem
        '
        Me.EmpInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttendanceToolStripMenuItem, Me.EmployeeMasterToolStripMenuItem, Me.SalaryAdvancesToolStripMenuItem})
        Me.EmpInfoToolStripMenuItem.Name = "EmpInfoToolStripMenuItem"
        Me.EmpInfoToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.EmpInfoToolStripMenuItem.Text = "Employee &Information"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AttendanceToolStripMenuItem.Text = "&Attendance"
        '
        'EmployeeMasterToolStripMenuItem
        '
        Me.EmployeeMasterToolStripMenuItem.Name = "EmployeeMasterToolStripMenuItem"
        Me.EmployeeMasterToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EmployeeMasterToolStripMenuItem.Text = "&Employee Master"
        '
        'SalaryAdvancesToolStripMenuItem
        '
        Me.SalaryAdvancesToolStripMenuItem.Name = "SalaryAdvancesToolStripMenuItem"
        Me.SalaryAdvancesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SalaryAdvancesToolStripMenuItem.Text = "&Salary Advances"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneratePayrollToolStripMenuItem, Me.PrintSalaryAbstractToolStripMenuItem, Me.PrintSalarySlipsToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PayrollToolStripMenuItem.Text = "P&ayroll"
        '
        'GeneratePayrollToolStripMenuItem
        '
        Me.GeneratePayrollToolStripMenuItem.Name = "GeneratePayrollToolStripMenuItem"
        Me.GeneratePayrollToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GeneratePayrollToolStripMenuItem.Text = "&Generate Payroll"
        '
        'PrintSalaryAbstractToolStripMenuItem
        '
        Me.PrintSalaryAbstractToolStripMenuItem.Name = "PrintSalaryAbstractToolStripMenuItem"
        Me.PrintSalaryAbstractToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintSalaryAbstractToolStripMenuItem.Text = "Print Salary &Abstract"
        '
        'PrintSalarySlipsToolStripMenuItem
        '
        Me.PrintSalarySlipsToolStripMenuItem.Name = "PrintSalarySlipsToolStripMenuItem"
        Me.PrintSalarySlipsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintSalarySlipsToolStripMenuItem.Text = "Print Salary &Slips"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarLabel1, Me.DateTimeStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 590)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1063, 22)
        Me.StatusStrip.Stretch = False
        Me.StatusStrip.TabIndex = 2
        '
        'StatusBarLabel1
        '
        Me.StatusBarLabel1.AutoSize = False
        Me.StatusBarLabel1.Name = "StatusBarLabel1"
        Me.StatusBarLabel1.Size = New System.Drawing.Size(850, 17)
        Me.StatusBarLabel1.Text = "Welcome to the Krithika Industries Payroll Application!"
        Me.StatusBarLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimeStatusLabel
        '
        Me.DateTimeStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DateTimeStatusLabel.Name = "DateTimeStatusLabel"
        Me.DateTimeStatusLabel.Size = New System.Drawing.Size(0, 17)
        Me.DateTimeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'KIPayrollDataSet
        '
        Me.KIPayrollDataSet.DataSetName = "KIPayrollDataSet"
        Me.KIPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalaryCalculationBindingSource
        '
        Me.SalaryCalculationBindingSource.DataMember = "SalaryCalculation"
        Me.SalaryCalculationBindingSource.DataSource = Me.KIPayrollDataSet
        '
        'SalaryCalculationTableAdapter
        '
        Me.SalaryCalculationTableAdapter.ClearBeforeFill = True
        '
        'DTTimer
        '
        Me.DTTimer.Enabled = True
        Me.DTTimer.Interval = 1000
        '
        'AppMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 612)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "AppMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krithika Industries Payroll Application"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryCalculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents EmpInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryAdvancesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents StatusBarLabel1 As ToolStripStatusLabel
    Friend WithEvents GeneratePayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSalaryAbstractToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSalarySlipsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryCalculationBindingSource As BindingSource
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
    Friend WithEvents SalaryCalculationTableAdapter As KIPayrollDataSetTableAdapters.SalaryCalculationTableAdapter
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimeStatusLabel As ToolStripStatusLabel
    Friend WithEvents DTTimer As Timer
End Class
