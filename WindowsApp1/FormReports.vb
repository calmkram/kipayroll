Imports Microsoft.Reporting.WinForms

Public Class ReportsContainer
    Private p_sReportName As String

    Private Sub ReportsContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rdsConsolidatedSalaryAbstractDataset As ReportDataSource

        Me.SalaryAbstractQueryTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAbstractQuery)

        Dim parRepName As New ReportParameter("parReportName", p_sReportName)

        Me.rptSalaryAbstract.Dock = DockStyle.Fill
        Me.rptSalaryAbstract.LocalReport.SetParameters(parRepName)
        rdsConsolidatedSalaryAbstractDataset = New ReportDataSource("ConsolidatedSalaryAbstractDataset", Me.KIPayrollDataSet.SalaryAbstractQuery.CopyToDataTable)
        Me.rptSalaryAbstract.LocalReport.DataSources.Clear()
        Me.rptSalaryAbstract.LocalReport.DataSources.Add(rdsConsolidatedSalaryAbstractDataset)
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