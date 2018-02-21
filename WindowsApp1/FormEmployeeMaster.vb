Public Class EmpMaster
    Dim iEditState As Integer

    Private Sub lstbxCurrentEmpList_Click(sender As Object, e As EventArgs) Handles lstbxCurrentEmpList.Click
        If lstbxCurrentEmpList.Items.Count > 0 Then
            btnModEmpInfo.Enabled = True
        End If
    End Sub

    Private Sub lstbxCurrentEmpList_LostFocus(sender As Object, e As EventArgs) Handles lstbxCurrentEmpList.LostFocus
        'btnModEmpInfo.Enabled = False
    End Sub

    Private Sub btnAddEmpInfo_Click(sender As Object, e As EventArgs) Handles btnAddEmpInfo.Click
        Dim sEmpIDMax As String, iNewEmpID As Integer, iMaxEmpID As Integer, sEmpIDTemp As String, sNewEmpID As String

        iEditState = 1

        ' Retrieve current max emp id and auto calculate new emp ID
        sEmpIDMax = Me.EmployeeMasterTableAdapter.EmpIDMaxQuery()
        sEmpIDTemp = sEmpIDMax.Substring(sEmpIDMax.IndexOf("-") + 1)
        iMaxEmpID = Convert.ToInt32(sEmpIDTemp)
        iNewEmpID = iMaxEmpID + 1
        If iNewEmpID >= 0 And iNewEmpID < 10 Then
            If iNewEmpID = 0 Then
                iNewEmpID = 1
            End If
            sNewEmpID = "KI-00" & Convert.ToString(iNewEmpID)
        ElseIf iNewEmpID < 100 Then
            sNewEmpID = "KI-0" & Convert.ToString(iNewEmpID)
        ElseIf iNewEmpID > 100 Then
            sNewEmpID = "KI-" & Convert.ToString(iNewEmpID)
        Else
            Exit Sub
        End If

        Me.txtEmpID1.Text = sNewEmpID
        Me.txtEmpName.Text = ""
        Me.txtEmpAddress.Text = ""
        Me.txtCity.Text = ""
        Me.txtPincode.Text = ""
        Me.dtpDOB.ResetText()
        Me.dtpDOJ.ResetText()
        Me.txtBasicSalary.Text = ""
        Me.dtpSalaryEffDate.ResetText()
        Me.txtEmpStatus.Text = ""

        ' Enable controls for data entry
        Me.txtEmpName.Enabled = True
        Me.txtEmpAddress.Enabled = True
        Me.txtCity.Enabled = True
        Me.txtPincode.Enabled = True
        Me.dtpDOB.Enabled = True
        Me.dtpDOJ.Enabled = True
        Me.txtBasicSalary.Enabled = True
        Me.dtpSalaryEffDate.Enabled = True
        Me.txtEmpStatus.Enabled = False
        Me.btnSave.Visible = True
        Me.btnCancel.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.txtEmpName.Enabled = False
        Me.txtEmpAddress.Enabled = False
        Me.txtCity.Enabled = False
        Me.txtPincode.Enabled = False
        Me.dtpDOB.Enabled = False
        Me.dtpDOJ.Enabled = False
        Me.txtBasicSalary.Enabled = False
        Me.dtpSalaryEffDate.Enabled = False
        Me.txtEmpStatus.Enabled = False
        Me.btnSave.Visible = False
        Me.btnCancel.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.txtEmpName.Enabled = False
        Me.txtEmpAddress.Enabled = False
        Me.txtCity.Enabled = False
        Me.txtPincode.Enabled = False
        Me.dtpDOB.Enabled = False
        Me.dtpDOJ.Enabled = False
        Me.txtBasicSalary.Enabled = False
        Me.dtpSalaryEffDate.Enabled = False
        Me.txtEmpStatus.Enabled = False
        Me.btnSave.Visible = False
        Me.btnCancel.Visible = False

        If iEditState = 1 Then          ' if we are adding a new record, save changes to the recordset to add the record
            Me.EmployeeMasterTableAdapter.Insert(txtEmpID1.Text, txtEmpName.Text, txtEmpAddress.Text, txtCity.Text, txtPincode.Text, dtpDOB.Value, dtpDOJ.Value, txtBasicSalary.Text, dtpSalaryEffDate.Value, 0, txtEmpStatus.Text)
            Me.EmployeeMasterTableAdapter.Fill(KIPayrollDataSet.EmployeeMaster)
        ElseIf iEditState = 2 Then      ' if we are modifying an existing record, save changes after the edits are completed
            Me.Validate()
            Me.EmployeeMasterBindingSource.EndEdit()
            Me.EmployeeMasterTableAdapter.Update(Me.KIPayrollDataSet.EmployeeMaster)
            Me.KIPayrollDataSet.AcceptChanges()
        End If
    End Sub

    Private Sub EmpMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KIPayrollDataSet.EmployeeMaster' table. You can move, or remove it, as needed.
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)

        iEditState = 0
    End Sub

    Private Sub EmpMaster_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AppMainWindow.StatusBarLabel1.Text = "Welcome to the Krithika Industries Payroll Application!"
    End Sub

    Private Sub btnModEmpInfo_Click(sender As Object, e As EventArgs) Handles btnModEmpInfo.Click
        iEditState = 2

        Me.txtEmpName.Enabled = True
        Me.txtEmpAddress.Enabled = True
        Me.txtCity.Enabled = True
        Me.txtPincode.Enabled = True
        Me.dtpDOB.Enabled = True
        Me.dtpDOJ.Enabled = True
        Me.txtBasicSalary.Enabled = True
        Me.dtpSalaryEffDate.Enabled = True
        Me.txtEmpStatus.Enabled = True
        Me.btnSave.Visible = True
        Me.btnCancel.Visible = True
    End Sub
End Class