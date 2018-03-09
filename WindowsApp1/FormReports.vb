Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms

Public Class ReportsContainer
    Private p_sReportName As String, p_bPayrollFormOpen As Boolean, p_bSalaryAbstract As Boolean, p_bSalarySlip As Boolean
    Private p_dtblSalarySlip As DataTable

    Private Sub ReportsContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SalaryAbstractQueryTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAbstractQuery)
        Me.SalarySlipQueryTableAdapter.Fill(Me.KIPayrollDataSet.SalarySlipQuery)

        If p_bSalaryAbstract = True Then
            If p_bPayrollFormOpen = True Then
                'ReportViewer Control Location & Size Settings - Location = 12, 12; Size = 1132, 558
                'ReportsContainer Form Size = 1177, 621
                Me.lblPayrollForMonth.Visible = False
                Me.cmbPayrollForMonth.Visible = False
                Me.btnShowReport.Visible = False

                Me.Size = New Size(1177, 621)
                Me.rptSalaryAbstract.Size = New Size(1132, 558)
                Me.rptSalaryAbstract.Location = New Point(12, 12)
                Me.rptSalaryAbstract.Dock = DockStyle.Fill

                Me.SetSalAbstractReportViewerDataset()
                Me.SetReportParameters(rptSalaryAbstract)
                Me.SetReportPageSettings(rptSalaryAbstract)
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
                Me.btnShowReport.Visible = True
                Me.rptSalaryAbstract.Visible = False
                Me.rptSalarySlip.Visible = False

                Me.btnShowReport.Text = "Show Salary Abstract Report"
                Me.btnShowReport.Location = New Point(46, 49)
                Me.Size = New Size(306, 119)
            End If
            Me.rptSalaryAbstract.RefreshReport()
        ElseIf p_bSalarySlip = True Then
            If p_bPayrollFormOpen = True Then
                Me.lblPayrollForMonth.Visible = False
                Me.cmbPayrollForMonth.Visible = False
                Me.btnShowReport.Visible = False

                Me.Size = New Size(1177, 621)
                Me.rptSalarySlip.Size = New Size(1132, 558)
                Me.rptSalarySlip.Location = New Point(12, 12)
                Me.rptSalarySlip.Dock = DockStyle.Fill

                Me.SetSalSlipReportViewerDataset(cmbPayrollForMonth.SelectedItem.ToString("MMM-yyyy"))
                Me.SetReportParameters(rptSalarySlip)
                Me.SetReportPageSettings(rptSalarySlip)
                Me.rptSalarySlip.Visible = True
            Else
                Dim dtMonth As DateTime, iIndex As Integer

                Me.cmbPayrollForMonth.Items.Clear()
                For iIndex = 0 To Me.KIPayrollDataSet.SalarySlipQuery.Rows.Count - 1
                    If Not dtMonth.CompareTo(DateTime.Parse(Me.KIPayrollDataSet.SalarySlipQuery.Rows(iIndex)("PayMonth").ToString())) = 0 Then
                        dtMonth = DateTime.Parse(Me.KIPayrollDataSet.SalarySlipQuery.Rows(iIndex)("PayMonth").ToString())
                        Me.cmbPayrollForMonth.Items.Add(dtMonth.ToString("MMMM yyyy"))
                    End If
                Next
                Me.lblPayrollForMonth.Visible = True
                Me.cmbPayrollForMonth.Visible = True
                Me.rptSalaryAbstract.Visible = False
                Me.rptSalarySlip.Visible = False
                Me.btnShowReport.Visible = True

                Me.btnShowReport.Text = "Show Salary Slips"
                Me.Size = New Size(306, 119)
            End If
            Me.rptSalarySlip.RefreshReport()
        End If
    End Sub

    Private Sub SetReportPageSettings(rptViewer As ReportViewer)
        Dim myPgSettings As New Printing.PageSettings() With {
                    .Landscape = True,
                    .Margins = New Printing.Margins(6, 3, 8, 8)}
        rptViewer.SetPageSettings(myPgSettings)
    End Sub

    Private Sub SetReportParameters(rptViewer As ReportViewer)
        Dim parRepName As ReportParameter, parPayMonth As ReportParameter, parNumDaysInMonth As ReportParameter

        parRepName = New ReportParameter("parReportName", p_sReportName)
        rptViewer.LocalReport.SetParameters(parRepName)
        If p_bSalarySlip = True Then
            parPayMonth = New ReportParameter("parPayMonth", DateTime.Parse(cmbPayrollForMonth.SelectedItem.ToString).ToString("MMM-yyyy"))
            parNumDaysInMonth = New ReportParameter("parNumDaysInMonth", p_dtblSalarySlip.Rows(0)("NumDaysInMonth").ToString)
            rptViewer.LocalReport.SetParameters(parPayMonth)
            rptViewer.LocalReport.SetParameters(parNumDaysInMonth)
        End If
    End Sub

    Private Sub SetSalAbstractReportViewerDataset()
        Dim rdsConsolidatedSalaryAbstractDataset As ReportDataSource

        rdsConsolidatedSalaryAbstractDataset = New ReportDataSource("ConsolidatedSalaryAbstractDataset", Me.KIPayrollDataSet.SalaryAbstractQuery.CopyToDataTable)
        Me.rptSalaryAbstract.LocalReport.DataSources.Clear()
        Me.rptSalaryAbstract.LocalReport.DataSources.Add(rdsConsolidatedSalaryAbstractDataset)
    End Sub

    Private Sub SetSalSlipReportViewerDataset(sInputPayMonth As String)
        Dim rdsSalarySlipDataset As ReportDataSource

        p_dtblSalarySlip = Me.KIPayrollDataSet.SalarySlipQuery.CopyToDataTable()
        p_dtblSalarySlip.DefaultView.RowFilter = "PayMonth='" & sInputPayMonth & "'"

        rdsSalarySlipDataset = New ReportDataSource("EmpSalarySlipDataset", p_dtblSalarySlip.DefaultView)
        Me.rptSalarySlip.LocalReport.DataSources.Clear()
        Me.rptSalarySlip.LocalReport.DataSources.Add(rdsSalarySlipDataset)
    End Sub

    Private Sub btnShowReport_Click(sender As Object, e As EventArgs) Handles btnShowReport.Click
        Dim dtPayrollForMonth As DateTime

        If p_bSalaryAbstract = True Then
            Me.btnShowReport.Visible = False
            Me.btnShowReport.Text = "Show Salary Abstract Report"
            Me.lblPayrollForMonth.Visible = False
            Me.cmbPayrollForMonth.Visible = False

            Me.rptSalaryAbstract.Location = New Point(12, 12)
            Me.rptSalaryAbstract.Size = New Size(1132, 558)
            Me.rptSalaryAbstract.Dock = DockStyle.Fill

            dtPayrollForMonth = DateTime.Parse(Me.cmbPayrollForMonth.SelectedItem.ToString)
            Me.SetReportName("Salary Abstract for " & dtPayrollForMonth.ToString("MMMM yyyy"))
            Me.SetSalAbstractReportViewerDataset()
            Me.SetReportParameters(rptSalaryAbstract)
            Me.SetReportPageSettings(rptSalaryAbstract)

            Me.Size = New Size(1177, 621)
            Me.rptSalarySlip.Visible = False
            Me.rptSalaryAbstract.Visible = True
            Me.rptSalaryAbstract.RefreshReport()
        ElseIf p_bSalarySlip = True Then
            Me.btnShowReport.Visible = False
            Me.lblPayrollForMonth.Visible = False
            Me.cmbPayrollForMonth.Visible = False

            Me.rptSalarySlip.Location = New Point(12, 12)
            Me.rptSalarySlip.Size = New Size(1132, 558)
            Me.rptSalarySlip.Dock = DockStyle.Fill

            dtPayrollForMonth = DateTime.Parse(Me.cmbPayrollForMonth.SelectedItem.ToString)
            Me.SetReportName("Salary Slip for " & dtPayrollForMonth.ToString("MMMM yyyy"))
            Me.SetSalSlipReportViewerDataset(dtPayrollForMonth.ToString("MMM-yyyy"))
            Me.SetReportParameters(rptSalarySlip)
            Me.SetReportPageSettings(rptSalarySlip)

            Me.Size = New Size(1177, 621)
            Me.rptSalaryAbstract.Visible = False
            Me.rptSalarySlip.Visible = True
            Me.rptSalarySlip.RefreshReport()
        End If
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

    Public Function SetLoadSalaryAbstractReport(bInput As Boolean) As Boolean
        p_bSalaryAbstract = bInput
        SetLoadSalaryAbstractReport = True
    End Function

    Public Function SetLoadSalarySlipReport(bInput As Boolean) As Boolean
        p_bSalarySlip = bInput
        SetLoadSalarySlipReport = True
    End Function
End Class