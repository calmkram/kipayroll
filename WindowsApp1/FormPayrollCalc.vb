Public Class PayrollCalc
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub PayrollCalc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AppMainWindow.DisablePrintMenuItem()
    End Sub

    Private Sub PayrollCalc_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'KIPayrollDataSet.EmployeeMaster' table. You can move, or remove it, as needed.
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.Attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryAdvances' table. You can move, or remove it, as needed.
        Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryCalculation' table. You can move, or remove it, as needed.
        Me.SalaryCalculationTableAdapter.Fill(Me.KIPayrollDataSet.SalaryCalculation)

        'Dynamically create all the text boxes to display salary calculations for each active employee this month
        Dim iEmpIndex As Integer, iYLocation As Integer
        Dim iEmpIDXLocation As Integer, iEmpNameXLocation As Integer, iPresentXLocation As Integer, iAbsentXLocation As Integer
        Dim txtEmpIDs(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtEmpNames(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        Dim txtPayMonth(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtPresent(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtAbsent(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtOTHours(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtOTDays(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtTotalDays(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtNumDaysInMonth(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtBasicSalary(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtGrossPay(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtAttdBonus(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtNSBFAllow(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtNetPay(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtESIDedn(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtSalAdvDedn(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtProfTax(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtSalaryToPay(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox, txtSalaryPaid(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox
        Dim txtESIEmployerContrib(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count) As TextBox

        iEmpIDXLocation = lblEmpID.Location.X + 3
        iEmpNameXLocation = lblEmpName.Location.X + 3
        iPresentXLocation = lblPresent.Location.X + 3
        iAbsentXLocation = lblAbsent.Location.X + 3

        iYLocation = lblLine.Location.Y + 10
        For iEmpIndex = 0 To Me.KIPayrollDataSet.EmployeeMaster.Rows.Count - 1
            txtEmpIDs(iEmpIndex) = New TextBox()
            txtEmpIDs(iEmpIndex).Enabled = False
            txtEmpIDs(iEmpIndex).Size = New Size(50, 20)
            txtEmpIDs(iEmpIndex).Location = New Point(iEmpIDXLocation, iYLocation)
            txtEmpIDs(iEmpIndex).Text = Me.KIPayrollDataSet.EmployeeMaster.Rows(iEmpIndex)("EmpID").ToString

            txtEmpNames(iEmpIndex) = New TextBox()
            txtEmpNames(iEmpIndex).Enabled = False
            txtEmpNames(iEmpIndex).Size = New Size(110, 20)
            txtEmpNames(iEmpIndex).Location = New Point(iEmpNameXLocation, iYLocation)
            txtEmpNames(iEmpIndex).Text = Me.KIPayrollDataSet.EmployeeMaster.Rows(iEmpIndex)("EmpName").ToString

            txtPresent(iEmpIndex) = New TextBox()
            txtPresent(iEmpIndex).Enabled = False
            txtPresent(iEmpIndex).Size = New Size(30, 20)
            txtPresent(iEmpIndex).Location = New Point(iPresentXLocation, iYLocation)
            'txtPresent(iEmpIndex).Text = Me.KIPayrollDataSet.EmployeeMaster.Rows(iEmpIndex)("Present").ToString

            txtAbsent(iEmpIndex) = New TextBox()
            txtAbsent(iEmpIndex).Enabled = False
            txtAbsent(iEmpIndex).Size = New Size(30, 20)
            txtAbsent(iEmpIndex).Location = New Point(iAbsentXLocation, iYLocation)
            'txtAbsent(iEmpIndex).Text = Me.KIPayrollDataSet.EmployeeMaster.Rows(iEmpIndex)("Absent").ToString

            grpSalAbstract.Controls.Add(txtEmpIDs(iEmpIndex))
            grpSalAbstract.Controls.Add(txtEmpNames(iEmpIndex))
            grpSalAbstract.Controls.Add(txtPresent(iEmpIndex))
            grpSalAbstract.Controls.Add(txtAbsent(iEmpIndex))

            iYLocation = iYLocation + 25
        Next
    End Sub
End Class