﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsContainer
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
        Me.rptSalaryAbstract = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalaryAbstractQueryTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.SalaryAbstractQueryTableAdapter()
        Me.KIPayrollDataSet = New KIPayroll.KIPayrollDataSet()
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.cmbPayrollForMonth = New System.Windows.Forms.ComboBox()
        Me.lblPayrollForMonth = New System.Windows.Forms.Label()
        Me.rptSalarySlip = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalarySlipQueryTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.SalarySlipQueryTableAdapter()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptSalaryAbstract
        '
        Me.rptSalaryAbstract.LocalReport.ReportEmbeddedResource = "KIPayroll.ReportSalaryAbstract.rdlc"
        Me.rptSalaryAbstract.Location = New System.Drawing.Point(12, 118)
        Me.rptSalaryAbstract.Name = "rptSalaryAbstract"
        Me.rptSalaryAbstract.ServerReport.BearerToken = Nothing
        Me.rptSalaryAbstract.Size = New System.Drawing.Size(241, 452)
        Me.rptSalaryAbstract.TabIndex = 0
        '
        'SalaryAbstractQueryTableAdapter
        '
        Me.SalaryAbstractQueryTableAdapter.ClearBeforeFill = True
        '
        'KIPayrollDataSet
        '
        Me.KIPayrollDataSet.DataSetName = "KIPayrollDataSet"
        Me.KIPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnShowReport
        '
        Me.btnShowReport.Location = New System.Drawing.Point(51, 46)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(157, 23)
        Me.btnShowReport.TabIndex = 6
        Me.btnShowReport.Text = "Show Salary Abstract Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'cmbPayrollForMonth
        '
        Me.cmbPayrollForMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayrollForMonth.FormattingEnabled = True
        Me.cmbPayrollForMonth.Location = New System.Drawing.Point(111, 12)
        Me.cmbPayrollForMonth.Name = "cmbPayrollForMonth"
        Me.cmbPayrollForMonth.Size = New System.Drawing.Size(142, 21)
        Me.cmbPayrollForMonth.TabIndex = 5
        '
        'lblPayrollForMonth
        '
        Me.lblPayrollForMonth.AutoSize = True
        Me.lblPayrollForMonth.Location = New System.Drawing.Point(16, 16)
        Me.lblPayrollForMonth.Name = "lblPayrollForMonth"
        Me.lblPayrollForMonth.Size = New System.Drawing.Size(89, 13)
        Me.lblPayrollForMonth.TabIndex = 4
        Me.lblPayrollForMonth.Text = "Payroll for Month:"
        '
        'rptSalarySlip
        '
        Me.rptSalarySlip.LocalReport.ReportEmbeddedResource = "KIPayroll.ReportSalarySlip.rdlc"
        Me.rptSalarySlip.Location = New System.Drawing.Point(340, 118)
        Me.rptSalarySlip.Name = "rptSalarySlip"
        Me.rptSalarySlip.ServerReport.BearerToken = Nothing
        Me.rptSalarySlip.Size = New System.Drawing.Size(396, 407)
        Me.rptSalarySlip.TabIndex = 9
        '
        'SalarySlipQueryTableAdapter
        '
        Me.SalarySlipQueryTableAdapter.ClearBeforeFill = True
        '
        'ReportsContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 82)
        Me.Controls.Add(Me.rptSalarySlip)
        Me.Controls.Add(Me.btnShowReport)
        Me.Controls.Add(Me.cmbPayrollForMonth)
        Me.Controls.Add(Me.lblPayrollForMonth)
        Me.Controls.Add(Me.rptSalaryAbstract)
        Me.Name = "ReportsContainer"
        Me.Text = "Reports"
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptSalaryAbstract As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalaryAbstractQueryTableAdapter As KIPayrollDataSetTableAdapters.SalaryAbstractQueryTableAdapter
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
    Friend WithEvents btnShowReport As Button
    Friend WithEvents cmbPayrollForMonth As ComboBox
    Friend WithEvents lblPayrollForMonth As Label
    Friend WithEvents rptSalarySlip As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalarySlipQueryTableAdapter As KIPayrollDataSetTableAdapters.SalarySlipQueryTableAdapter
End Class
