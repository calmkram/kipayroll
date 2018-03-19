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
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryAdvances' table. You can move, or remove it, as needed.
            Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
            Me.RetrieveEmpNameTableAdapter.Fill(Me.KIPayrollDataSet.RetrieveEmpName)
            Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)

            LoadEmployeesListInListBox()
            Me.Size = New Size(706, 342)

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub EmpList_Click(sender As Object, e As EventArgs) Handles lstbxEmpList.Click
        Dim sEmpID As String = "", sEmpName As String = "", sTemp As String = "", rDisplayRows() As KIPayrollDataSet.SalaryAdvancesRow
        Dim sSalAdvListForEmp As String = ""
        Dim structSalAdvList() As SalAdvList

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

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

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            Me.Close()
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub AddSalAdvance_Click(sender As Object, e As EventArgs) Handles btnAddSalAdvance.Click
        Dim iIndex As Integer = 0

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

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

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub SalAdvListForEmp_TextChanged(sender As Object, e As EventArgs) Handles cmbSalAdvListForEmp.TextChanged
        Dim sSalAdvSelected As String, sSalAdvID As String, rDisplayRow As KIPayrollDataSet.SalaryAdvancesRow

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

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

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub EmpName_TextChanged(sender As Object, e As EventArgs) Handles cmbEmpName.TextChanged
        Dim iEmpNameIndex As Integer

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            If cmbEmpName.SelectedIndex > -1 Then
                iEmpNameIndex = cmbEmpName.SelectedIndex
                txtEmpID.Text = p_sEmpIDArray(iEmpNameIndex)
            End If

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim rowSelectedEmp As DataRow, dTotalOutstandingBalance As Double = 0

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

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
                My.Application.Log.WriteException(ex, TraceEventType.Error, "Failed in SalaryAdvances Insert")
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

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub PaybackDuration_TextChanged(sender As Object, e As EventArgs) Handles cmbPaybackDuration.TextChanged
        Dim iPaybackDuration As Integer = 0, dPaybackAmtPerMth As Double = 0, dAdvanceAmt As Double = 0
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            If cmbPaybackDuration.SelectedIndex > -1 Then
                iPaybackDuration = CInt(cmbPaybackDuration.SelectedItem.ToString)
                dAdvanceAmt = CDbl(txtAdvanceAmt.Text)
                dPaybackAmtPerMth = dAdvanceAmt / iPaybackDuration
                txtPaybackAmt.Text = dPaybackAmtPerMth.ToString
            End If

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

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

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub ViewSalAdvInfo_Click(sender As Object, e As EventArgs) Handles btnViewSalAdvInfo.Click
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            LoadEmployeesListInListBox()

            lblSelectEmp.Visible = True
            lstbxEmpList.Visible = True

            grpbxAddSalAdvInfo.Visible = False
            grpbxViewSalAdvInfo.Visible = True

            btnAddSalAdvance.Enabled = True
            btnViewSalAdvInfo.Enabled = False

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub CancelView_Click(sender As Object, e As EventArgs) Handles btnCancelView.Click
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            lblSelectEmp.Visible = False
            lstbxEmpList.Visible = False
            grpbxViewSalAdvInfo.Visible = False
            btnViewSalAdvInfo.Enabled = True

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub LoadEmployeesListInListBox()
        Dim sEmpItem As String = ""
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            lstbxEmpList.Items.Clear()
            Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Sort = "EmpID ASC"
            For iIndex = 0 To Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Count - 1
                sEmpItem = Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Item(iIndex)("EmpID").ToString & " - " &
                                Me.KIPayrollDataSet.RetrieveEmpName.DefaultView.Item(iIndex)("EmpName").ToString
                lstbxEmpList.Items.Add(sEmpItem)
            Next

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub EmpList_KeyDown(sender As Object, e As KeyEventArgs) Handles lstbxEmpList.KeyDown
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            If e.KeyCode = Keys.Enter Then
                EmpList_Click(sender, e)
            End If

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub SortSalAdvList(ByRef value() As SalAdvList)
        Dim oTemp As Object, iIndex As Integer = 0, jIndex As Integer = 0

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            For iIndex = LBound(value) To UBound(value)
                For jIndex = iIndex + 1 To UBound(value)
                    If value(iIndex).iID > value(jIndex).iID Then
                        oTemp = value(iIndex)
                        value(iIndex) = value(jIndex)
                        value(jIndex) = oTemp
                    End If
                Next
            Next

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub
End Class
