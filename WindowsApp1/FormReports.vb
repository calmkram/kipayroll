Imports Microsoft.Reporting.WinForms

Public Class ReportsContainer
    Private p_sReportName As String

    Private Sub ReportsContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rdsConsolidatedSalaryAbstractDataset As ReportDataSource

        Me.SalaryAbstractQueryTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAbstractQuery)

        Me.rptSalaryAbstract.Dock = DockStyle.Fill

        Dim parRepName As New ReportParameter("parReportName", p_sReportName)
        Me.rptSalaryAbstract.LocalReport.SetParameters(parRepName)

        rdsConsolidatedSalaryAbstractDataset = New ReportDataSource("ConsolidatedSalaryAbstractDataset", Me.KIPayrollDataSet.SalaryAbstractQuery.CopyToDataTable)
        Me.rptSalaryAbstract.LocalReport.DataSources.Clear()
        Me.rptSalaryAbstract.LocalReport.DataSources.Add(rdsConsolidatedSalaryAbstractDataset)

        Dim myPgSettings As New Printing.PageSettings() With {
                    .Landscape = True,
                    .Margins = New Printing.Margins(6, 3, 8, 8)}
        Me.rptSalaryAbstract.SetPageSettings(myPgSettings)
        Me.rptSalaryAbstract.RefreshReport()
    End Sub

    Public Function GetReportName() As String
        GetReportName = p_sReportName
    End Function

    Public Function SetReportName(sInput As String) As Boolean
        If sInput IsNot "" Then
            p_sReportName = sInput
        End If
        SetReportName = True
    End Function
End Class