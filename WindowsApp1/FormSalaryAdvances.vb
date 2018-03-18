Public Class SalaryAdvances
    Private p_sEmpIDArray() As String, p_dtblEmpMaster As KIPayrollDataSet.EmployeeMasterDataTable
    Private Structure SalAdvList
        Public iID As Integer
        Public sEmpID As String
        Public sEmpName As String
        Public dtAdvDate As DateTime
        Public dAdvAmount As Double
    End Structure

    Private Sub SalaryAdvances_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryAdvances' table. You can move, or remove it, as needed.
        Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
        Me.RetrieveEmpNameTableAdapter.Fill(Me.KIPayrollDataSet.RetrieveEmpName)
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)

        LoadEmployeesListInListBox()
        Me.Size = New Size(706, 342)
    End Sub

    Private Sub lstbxEmpList_Click(sender As Object, e As EventArgs) Handles lstbxEmpList.Click
        Dim sEmpID As String = "", sEmpName As String = "", sTemp As String = "", rDisplayRows() As KIPayrollDataSet.SalaryAdvancesRow
        Dim sSalAdvListForEmp As String = ""
        Dim structSalAdvList() As SalAdvList

        If lstbxEmpList.Items.Count > 0 And lstbxEmpList.SelectedIndex > -1 Then
            sTemp = lstbxEmpList.SelectedItem
            sEmpID = sTemp.Substring(0, sTemp.IndexOf(" -"))
            sEmpName = sTemp.Substring(sTemp.IndexOf(" - ") + 3)

            rDisplayRows = Me.KIPayrollDataSet.Tables("SalaryAdvances").Select("EmpID = '" & sEmpID & "'")

            cmbSalAdvListForEmp.Items.Clear()

            ReDim structSalAdvList(rDisplayRows.Count - 1)
            For iIndex = 0 To rDisplayRows.Count - 1
                structSalAdvList(iIndex).iID = rDisplayRows.ElementAt(iIndex).ID
                structSalAdvList(iIndex).sEmpID = rDisplayRows.ElementAt(iIndex).EmpID
                structSalAdvList(iIndex).sEmpName = sEmpName
                structSalAdvList(iIndex).dtAdvDate = Format(rDisplayRows.ElementAt(iIndex).AdvDate, "dd-MMM-yyyy")
                structSalAdvList(iIndex).dAdvAmount = rDisplayRows.ElementAt(iIndex).AdvAmount
                'sSalAdvListForEmp = row.ID & "-" & sEmpID & " - " & sEmpName & " -> " & Format(row.AdvDate, "dd-MMM-yyyy") & " - " & Format(row.AdvAmount, "c")
                'cmbSalAdvListForEmp.Items.Add(sSalAdvListForEmp)
            Next
            SortSalAdvList(structSalAdvList)

            For Each struct In structSalAdvList
                sSalAdvListForEmp = struct.iID & "-" & struct.sEmpID & "-" & struct.sEmpName & "-" & struct.dtAdvDate.ToString("dd-MMM-yyyy") & "-" & FormatCurrency(struct.dAdvAmount, 2)
                cmbSalAdvListForEmp.Items.Add(sSalAdvListForEmp)
            Next

            txtViewEmpID.Text = ""
            txtViewEmpName.Text = ""
            txtViewAdvReason.Text = ""
            txtViewAdvAmt.Text = ""
            txtViewAdvStatus.Text = ""
            txtViewPaybackAmt.Text = ""
            txtViewAdvDue.Text = ""
            cmbViewPaybackDur.SelectedIndex = -1

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
        Dim iIndex As Integer = 0

        lblSelectEmp.Visible = False
        lstbxEmpList.Visible = False

        btnAddSalAdvance.Enabled = False
        grpbxViewSalAdvInfo.Visible = False

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
        txtViewAdvAmt.Text = FormatCurrency(rDisplayRow.AdvAmount, 2)
        txtViewPaybackAmt.Text = FormatCurrency(rDisplayRow.AdvPaybackAmtPerMth, 2)
        cmbViewPaybackDur.SelectedIndex = cmbPaybackDuration.FindString(rDisplayRow.AdvPaybackMonths.ToString)
        txtViewAdvStatus.Text = rDisplayRow.AdvPaybackStatus
        txtViewAdvDue.Text = FormatCurrency(Me.KIPayrollDataSet.EmployeeMaster.FindByEmpID(rDisplayRow.EmpID).PendingAdvBalance, 2)

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
        Dim iEmpNameIndex As Integer

        If cmbEmpName.SelectedIndex > -1 Then
            iEmpNameIndex = cmbEmpName.SelectedIndex
            txtEmpID.Text = p_sEmpIDArray(iEmpNameIndex)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim rowSelectedEmp As DataRow, dTotalOutstandingBalance As Double = 0

        cmbEmpName.Enabled = False
        txtAdvanceReason.Enabled = False
        txtAdvanceAmt.Enabled = False
        cmbPaybackDuration.Enabled = False
        txtPaybackAmt.Enabled = False
        txtAdvStatus.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False

        txtAdvStatus.Text = "Issued"

        Try
            Me.SalaryAdvancesTableAdapter.Insert(txtEmpID.Text, Today(), txtAdvanceReason.Text, CDbl(txtAdvanceAmt.Text), cmbPaybackDuration.SelectedItem.ToString, CDbl(txtPaybackAmt.Text), txtAdvStatus.Text, cmbPaybackDuration.SelectedItem.ToString)
            Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
            Me.RetrieveEmpNameTableAdapter.Fill(Me.KIPayrollDataSet.RetrieveEmpName)
            AppMainWindow.AppStatusBarLabel.Text = "New Salary Advance issued and saved successfully!"
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try

        rowSelectedEmp = Me.KIPayrollDataSet.EmployeeMaster.FindByEmpID(txtEmpID.Text)
        dTotalOutstandingBalance = CDbl(rowSelectedEmp.Item("PendingAdvBalance"))
        dTotalOutstandingBalance += CDbl(txtAdvanceAmt.Text)
        rowSelectedEmp.Item("PendingAdvBalance") = dTotalOutstandingBalance
        Me.EmployeeMasterTableAdapter.Update(Me.KIPayrollDataSet.EmployeeMaster)
        Me.KIPayrollDataSet.EmployeeMaster.AcceptChanges()
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)

        btnViewSalAdvInfo.Enabled = True
        btnAddSalAdvance.Enabled = True

        txtEmpID.Text = ""
        cmbEmpName.SelectedIndex = -1
        txtAdvanceReason.Text = ""
        txtAdvanceAmt.Text = ""
        cmbPaybackDuration.SelectedIndex = -1
        txtPaybackAmt.Text = ""
        txtAdvStatus.Text = ""
    End Sub

    Private Sub cmbPaybackDuration_TextChanged(sender As Object, e As EventArgs) Handles cmbPaybackDuration.TextChanged
        Dim iPaybackDuration As Integer = 0, dPaybackAmtPerMth As Double = 0, dAdvanceAmt As Double = 0

        If cmbPaybackDuration.SelectedIndex > -1 Then
            iPaybackDuration = CInt(cmbPaybackDuration.SelectedItem.ToString)
            dAdvanceAmt = CDbl(txtAdvanceAmt.Text)
            dPaybackAmtPerMth = dAdvanceAmt / iPaybackDuration
            txtPaybackAmt.Text = dPaybackAmtPerMth.ToString
        End If
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
        LoadEmployeesListInListBox()

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

    Private Sub LoadEmployeesListInListBox()
        Dim sEmpItem As String = ""

        lstbxEmpList.Items.Clear()
        Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Sort = "EmpID ASC"
        For iIndex = 0 To Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Count - 1
            sEmpItem = Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Item(iIndex)("EmpID").ToString & " - " &
                                Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Item(iIndex)("EmpName").ToString
            lstbxEmpList.Items.Add(sEmpItem)
        Next
    End Sub

    Private Sub lstbxEmpList_KeyDown(sender As Object, e As KeyEventArgs) Handles lstbxEmpList.KeyDown
        If e.KeyCode = Keys.Enter Then
            lstbxEmpList_Click(sender, e)
        End If
    End Sub

    Private Sub SortSalAdvList(ByRef value() As SalAdvList)
        Dim oTemp As Object, iIndex As Integer = 0, jIndex As Integer = 0

        For iIndex = LBound(value) To UBound(value)
            For jIndex = iIndex + 1 To UBound(value)
                If value(iIndex).iID > value(jIndex).iID Then
                    oTemp = value(iIndex)
                    value(iIndex) = value(jIndex)
                    value(jIndex) = oTemp
                End If
            Next
        Next
    End Sub

    Private Sub txtAdvanceAmt_TextChanged(sender As Object, e As EventArgs) Handles txtAdvanceAmt.TextChanged
        MsgBox(txtAdvanceAmt.Text)
    End Sub
End Class
