<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptSalaryAbstract
        '
        Me.rptSalaryAbstract.LocalReport.ReportEmbeddedResource = "KIPayroll.ReportSalaryAbstract.rdlc"
        Me.rptSalaryAbstract.Location = New System.Drawing.Point(12, 12)
        Me.rptSalaryAbstract.Name = "rptSalaryAbstract"
        Me.rptSalaryAbstract.Size = New System.Drawing.Size(1132, 558)
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
        'ReportsContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 582)
        Me.Controls.Add(Me.rptSalaryAbstract)
        Me.Name = "ReportsContainer"
        Me.Text = "Reports"
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rptSalaryAbstract As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalaryAbstractQueryTableAdapter As KIPayrollDataSetTableAdapters.SalaryAbstractQueryTableAdapter
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
End Class
