Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms

Public Class ReportsContainer
    Private p_sReportName As String, p_bPayrollFormOpen As Boolean

    Private Sub ReportsContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SalaryAbstractQueryTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAbstractQuery)

        If p_bPayrollFormOpen = True Then
            'ReportViewer Control Location & Size Settings - Location = 12, 12; Size = 1132, 558
            'ReportsContainer Form Size = 1177, 621
            Me.lblPayrollForMonth.Visible = False
            Me.cmbPayrollForMonth.Visible = False
            Me.btnShowSalaryAbstractReport.Visible = False

            Me.Size = New Size(1177, 621)
            Me.rptSalaryAbstract.Size = New Size(1132, 558)
            Me.rptSalaryAbstract.Location = New Point(12, 12)
            Me.rptSalaryAbstract.Dock = DockStyle.Fill

            Me.SetReportParameters()
            Me.SetReportViewerDataset()
            Me.SetReportPageSettings()
            Me.rptSalaryAbstract.Visible = True
        ElseIf p_bPayrollFormOpen = False Then
            'ReportsContainer Form Size = 306, 119
            Dim dtMonth As DateTime, dataTableSalAbstract As DataTable

            Me.cmbPayrollForMonth.Items.Clear()
            dataTableSalAbstract = Me.KIPayrollDataSet.SalaryAbstractQuery.DefaultView.ToTable(True, "PayMonth")
            For iIndex = 0 To dataTableSalAbstract.Rows.Count - 1
                dtMonth = DateTime.Parse(dataTableSalAbstract.Rows(iIndex)("PayMonth").ToString())
                Me.cmbPayrollForMonth.Items.Add(dtMonth.ToString("MMMM yyyy"))
            Next

            Me.lblPayrollForMonth.Visible = True
            Me.cmbPayrollForMonth.Visible = True
            Me.btnShowSalaryAbstractReport.Visible = True
            Me.rptSalaryAbstract.Visible = False

            Me.Size = New Size(306, 119)
        End If

        Me.rptSalaryAbstract.RefreshReport()
    End Sub

    Private Sub SetReportPageSettings()
        Dim myPgSettings As New Printing.PageSettings() With {
                    .Landscape = True,
                    .Margins = New Printing.Margins(6, 3, 8, 8)}
        Me.rptSalaryAbstract.SetPageSettings(myPgSettings)
    End Sub

    Private Sub SetReportParameters()
        Dim parRepName As New ReportParameter("parReportName", p_sReportName)
        Me.rptSalaryAbstract.LocalReport.SetParameters(parRepName)
    End Sub

    Private Sub SetReportViewerDataset()
        Dim rdsConsolidatedSalaryAbstractDataset As ReportDataSource

        rdsConsolidatedSalaryAbstractDataset = New ReportDataSource("ConsolidatedSalaryAbstractDataset", Me.KIPayrollDataSet.SalaryAbstractQuery.CopyToDataTable)
        Me.rptSalaryAbstract.LocalReport.DataSources.Clear()
        Me.rptSalaryAbstract.LocalReport.DataSources.Add(rdsConsolidatedSalaryAbstractDataset)
    End Sub

    Private Sub btnShowSalaryAbstractReport_Click(sender As Object, e As EventArgs) Handles btnShowSalaryAbstractReport.Click
        Dim dtPayrollForMonth As DateTime

        Me.btnShowSalaryAbstractReport.Visible = False
        Me.lblPayrollForMonth.Visible = False
        Me.cmbPayrollForMonth.Visible = False

        Me.rptSalaryAbstract.Location = New Point(12, 12)
        Me.rptSalaryAbstract.Size = New Size(1132, 558)
        Me.rptSalaryAbstract.Dock = DockStyle.Fill

        dtPayrollForMonth = DateTime.Parse(Me.cmbPayrollForMonth.SelectedItem.ToString)
        Me.SetReportName("Salary Abstract for " & dtPayrollForMonth.ToString("MMMM yyyy"))
        Me.SetReportParameters()
        Me.SetReportViewerDataset()
        Me.SetReportPageSettings()

        Me.Size = New Size(1177, 621)
        Me.rptSalaryAbstract.Visible = True
        Me.rptSalaryAbstract.RefreshReport()
    End Sub

    Public Function SetPayrollFormStatus(bInput As Boolean) As Boolean
        p_bPayrollFormOpen = bInput
        SetPayrollFormStatus = True
    End Function

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