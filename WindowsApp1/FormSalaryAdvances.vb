Public Class SalaryAdvances
    Private Sub SalaryAdvances_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryAdvances' table. You can move, or remove it, as needed.
        Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.RetrieveEmpName' table. You can move, or remove it, as needed.
        Me.RetrieveEmpNameTableAdapter.Fill(Me.KIPayrollDataSet.RetrieveEmpName)

        lstbxEmpList.Items.Clear()

        For Each dataRow In Me.KIPayrollDataSet.RetrieveEmpName
            Dim sEmpItem As String

            sEmpItem = dataRow.EmpID & " - " & dataRow.EmpName
            lstbxEmpList.Items.Add(sEmpItem)
        Next
    End Sub

    Private Sub lstbxEmpList_Click(sender As Object, e As EventArgs) Handles lstbxEmpList.Click
        Dim sEmpID As String, sEmpName As String, sTemp As String, rDisplayRows() As KIPayrollDataSet.SalaryAdvancesRow
        Dim sSalAdvListForEmp As String

        If lstbxEmpList.Items.Count > 0 Then
            sTemp = lstbxEmpList.SelectedItem
            sEmpID = sTemp.Substring(0, sTemp.IndexOf(" -"))
            sEmpName = sTemp.Substring(sTemp.IndexOf(" - ") + 3)

            rDisplayRows = Me.KIPayrollDataSet.Tables("SalaryAdvances").Select("EmpID = '" & sEmpID & "'")

            cmbSalAdvListForEmp.Items.Clear()

            For Each row In rDisplayRows
                sSalAdvListForEmp = row.ID & "-" & sEmpID & " - " & sEmpName & " -> " & Format(row.AdvDate, "dd-MMM-yyyy") & " - " & Format(row.AdvAmount, "c")
                cmbSalAdvListForEmp.Items.Add(sSalAdvListForEmp)
            Next

            grpbxAddSalAdvInfo.Visible = False
            grpbxViewSalAdvInfo.Visible = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class