﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryAdvancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusBarLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpInfoToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mnuStrip"
        '
        'EmpInfoToolStripMenuItem
        '
        Me.EmpInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeMasterToolStripMenuItem, Me.SalaryAdvancesToolStripMenuItem, Me.AttendanceToolStripMenuItem})
        Me.EmpInfoToolStripMenuItem.Name = "EmpInfoToolStripMenuItem"
        Me.EmpInfoToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.EmpInfoToolStripMenuItem.Text = "Employee &Information"
        '
        'EmployeeMasterToolStripMenuItem
        '
        Me.EmployeeMasterToolStripMenuItem.Name = "EmployeeMasterToolStripMenuItem"
        Me.EmployeeMasterToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EmployeeMasterToolStripMenuItem.Text = "Employee Master"
        '
        'SalaryAdvancesToolStripMenuItem
        '
        Me.SalaryAdvancesToolStripMenuItem.Name = "SalaryAdvancesToolStripMenuItem"
        Me.SalaryAdvancesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SalaryAdvancesToolStripMenuItem.Text = "Salary Advances"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.PayrollToolStripMenuItem.Text = "&Generate Payroll"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Enabled = False
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 590)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1063, 22)
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 2
        '
        'StatusBarLabel1
        '
        Me.StatusBarLabel1.Name = "StatusBarLabel1"
        Me.StatusBarLabel1.Size = New System.Drawing.Size(291, 17)
        Me.StatusBarLabel1.Text = "Welcome to the Krithika Industries Payroll Application"
        '
        'AppMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 612)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AppMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krithika Industries - Payroll Application"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryAdvancesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusBarLabel1 As ToolStripStatusLabel
End Class