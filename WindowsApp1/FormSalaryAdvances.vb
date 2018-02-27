Public Class SalaryAdvances
    Dim p_sEmpIDArray() As String

    Private Sub SalaryAdvances_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryAdvances' table. You can move, or remove it, as needed.
        Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.RetrieveEmpName' table. You can move, or remove it, as needed.
        Me.RetrieveEmpNameTableAdapter.Fill(Me.KIPayrollDataSet.RetrieveEmpName)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.EmployeeMaster' table. You can move, or remove it, as needed.
        EmpMaster.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)

        lstbxEmpList.Items.Clear()

        For Each dataRow In Me.KIPayrollDataSet.RetrieveEmpName
            Dim sEmpItem As String

            sEmpItem = dataRow.EmpID & " - " & dataRow.EmpName
            lstbxEmpList.Items.Add(sEmpItem)
        Next

        Me.Size = New Size(706, 342)
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
            grpbxViewSalAdvInfo.Location = New Point(190, 13)
            lstbxEmpList.Size = New Size(lstbxEmpList.Size.Width, grpbxViewSalAdvInfo.Size.Height)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddSalAdvance_Click(sender As Object, e As EventArgs) Handles btnAddSalAdvance.Click
        lblSelectEmp.Visible = False
        lstbxEmpList.Visible = False

        btnAddSalAdvance.Enabled = False
        grpbxViewSalAdvInfo.Visible = False

        Dim iIndex As Integer = 0
        ReDim p_sEmpIDArray(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)

        cmbEmpName.Items.Clear()
        For Each row In Me.KIPayrollDataSet.EmployeeMaster
            p_sEmpIDArray(iIndex) = row.EmpID
            cmbEmpName.Items.Add(row.EmpName)
            iIndex = iIndex + 1
        Next

        txtAdvStatus.Text = "Issuing"

        grpbxAddSalAdvInfo.Visible = True
        grpbxAddSalAdvInfo.Location = New Point(13, 13)
        grpbxAddSalAdvInfo.Size = New Size(645, 232)
    End Sub

    Private Sub cmbSalAdvListForEmp_TextChanged(sender As Object, e As EventArgs) Handles cmbSalAdvListForEmp.TextChanged
        Dim sSalAdvSelected As String, sSalAdvID As String, rDisplayRow As KIPayrollDataSet.SalaryAdvancesRow

        sSalAdvSelected = cmbSalAdvListForEmp.Text
        sSalAdvID = sSalAdvSelected.Substring(0, sSalAdvSelected.IndexOf("-"))
        rDisplayRow = Me.KIPayrollDataSet.SalaryAdvances.FindByID(sSalAdvID)

        txtViewEmpID.Text = rDisplayRow.EmpID
        txtViewEmpName.Text = Me.KIPayrollDataSet.EmployeeMaster.FindByEmpID(rDisplayRow.EmpID).EmpName
        txtViewAdvReason.Text = rDisplayRow.AdvReason
        txtViewAdvAmt.Text = Format(rDisplayRow.AdvAmount, "c")
        txtViewPaybackAmt.Text = Format(rDisplayRow.AdvPaybackAmtPerMth, "c")
        cmbViewPaybackDur.SelectedIndex = cmbPaybackDuration.FindString(rDisplayRow.AdvPaybackMonths.ToString)
        txtViewAdvStatus.Text = rDisplayRow.AdvPaybackStatus

        lblViewEmpID.Visible = True
        txtViewEmpID.Visible = True
        lblViewEmpName.Visible = True
        txtViewEmpName.Visible = True
        lblViewAdvReason.Visible = True
        txtViewAdvReason.Visible = True
        lblViewAdvAmt.Visible = True
        txtViewAdvAmt.Visible = True
        lblViewPaybackAmt.Visible = True
        txtViewPaybackAmt.Visible = True
        lblViewPaybackDur.Visible = True
        cmbViewPaybackDur.Visible = True
        lblViewAdvStatus.Visible = True
        txtViewAdvStatus.Visible = True
        lblViewAdvDue.Visible = True
        txtViewAdvDue.Visible = True

        txtViewEmpID.Enabled = False
        txtViewEmpName.Enabled = False
        txtViewAdvReason.Enabled = False
        txtViewAdvAmt.Enabled = False
        txtViewPaybackAmt.Enabled = False
        cmbViewPaybackDur.Enabled = False
        txtViewAdvStatus.Enabled = False
        txtViewAdvDue.Enabled = False
    End Sub

    Private Sub cmbEmpName_TextChanged(sender As Object, e As EventArgs) Handles cmbEmpName.TextChanged
        Dim iEmpNameIndex As Integer, sEmpName As String

        iEmpNameIndex = cmbEmpName.SelectedIndex
        sEmpName = cmbEmpName.SelectedItem.ToString
        txtEmpID.Text = p_sEmpIDArray(iEmpNameIndex)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmbEmpName.Enabled = False
        txtAdvanceReason.Enabled = False
        txtAdvanceAmt.Enabled = False
        cmbPaybackDuration.Enabled = False
        txtPaybackAmt.Enabled = False
        txtAdvStatus.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False

        txtAdvStatus.Text = "Issued"

        Me.SalaryAdvancesTableAdapter.Insert(txtEmpID.Text, Today(), txtAdvanceReason.Text, CDbl(txtAdvanceAmt.Text), cmbPaybackDuration.SelectedItem.ToString, CDbl(txtPaybackAmt.Text), txtAdvStatus.Text, cmbPaybackDuration.SelectedItem.ToString)
        Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
        AppMainWindow.StatusBarLabel1.Text = "New Salary Advance issued and saved successfully!"

        btnViewSalAdvInfo.Enabled = True
        btnAddSalAdvance.Enabled = True
    End Sub

    Private Sub cmbPaybackDuration_TextChanged(sender As Object, e As EventArgs) Handles cmbPaybackDuration.TextChanged
        Dim iPaybackDuration As Integer, dPaybackAmtPerMth As Double

        iPaybackDuration = CInt(cmbPaybackDuration.SelectedItem.ToString)
        dPaybackAmtPerMth = CDbl(txtAdvanceAmt.Text) / iPaybackDuration
        txtPaybackAmt.Text = dPaybackAmtPerMth.ToString
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAddSalAdvance.Enabled = True
        btnViewSalAdvInfo.Enabled = True

        cmbEmpName.SelectedIndex = -1
        txtEmpID.Text = ""
        txtAdvanceReason.Text = ""
        txtAdvanceAmt.ResetText()
        cmbPaybackDuration.SelectedIndex = -1
        txtPaybackAmt.ResetText()
        txtAdvStatus.Text = ""

        grpbxAddSalAdvInfo.Visible = False
        grpbxViewSalAdvInfo.Visible = False
    End Sub

    Private Sub btnViewSalAdvInfo_Click(sender As Object, e As EventArgs) Handles btnViewSalAdvInfo.Click
        lblSelectEmp.Visible = True
        lstbxEmpList.Visible = True

        grpbxAddSalAdvInfo.Visible = False
        grpbxViewSalAdvInfo.Visible = True

        btnAddSalAdvance.Enabled = True
        btnViewSalAdvInfo.Enabled = False
    End Sub

    Private Sub btnCancelView_Click(sender As Object, e As EventArgs) Handles btnCancelView.Click
        lblSelectEmp.Visible = False
        lstbxEmpList.Visible = False
        grpbxViewSalAdvInfo.Visible = False
        btnViewSalAdvInfo.Enabled = True
    End Sub
End Class