Public Class PayrollCalc
    Private iPrevEmpCount As Integer, iPayrollGenerated As Integer
    Private iEmpIndex As Integer, iYLocation As Integer, iSalPaidXLocation As Integer, iESIEmplContrXLocation As Integer
    Private iEmpIDXLocation As Integer, iEmpNameXLocation As Integer, iPresentXLocation As Integer, iAbsentXLocation As Integer
    Private iOTHrsXLocation As Integer, iOTDaysXLocation As Integer, iTotalDaysXLocation As Integer, iBasicSalaryXLocation As Integer
    Private iGrossPayXLocation As Integer, iAttdBonusXLocation As Integer, iNSBFXLocation As Integer, iNetPayXLocation As Integer
    Private iESIDednXLocation As Integer, iSalAdvDednXLocation As Integer, iProfTaxXLocation As Integer, iSalToPayXLocation As Integer
    Private txtEmpIDs() As TextBox, txtEmpNames() As TextBox, txtPresent() As TextBox, txtAbsent() As TextBox, txtOTHours() As TextBox
    Private txtOTDays() As TextBox, txtTotalDays() As TextBox, txtESIEmployerContrib() As TextBox, txtBasicSalary() As TextBox
    Private txtGrossPay() As TextBox, txtAttdBonus() As TextBox, txtNSBFAllow() As TextBox, txtNetPay() As TextBox, txtESIDedn() As TextBox
    Private txtSalAdvDedn() As TextBox, txtProfTax() As TextBox, txtSalaryToPay() As TextBox, txtSalaryPaid() As TextBox
    Private dsFiltered As DataSet, oSumOTHours As Object, sQuery As String, dataAdapter As New OleDb.OleDbDataAdapter, dsAttd As New DataSet
    Private iNSAllowance As Integer = 0, iBFAllowance As Integer = 0, dTotalSalAdvForEmp As Double = 0
    Private dTotalGrossPay As Double = 0, dTotalNetPay As Double = 0, dTotalESIDedn As Double = 0, dTotalAdvDedn As Double = 0, dTotalProfTax As Double = 0
    Private dTotalAmtToPay As Double = 0, dTotalSalaryPaid As Double = 0, dTotalESIEmplContr As Double = 0
    Private dtPayrollForMonth As DateTime, iTotalNumSalAdvances As Integer = 0, iSalAdvanceCount As Integer = 0
    Private Structure EmpSalAdvances
        Public iID As Integer
        Public sEmpID As String
        Public dAdvanceAmount As Double
        Public dAdvanceAmountPerMonth As Double
        Public iAdvancePaybackMonths As Integer
        Public iAdvancePaybackRemainingMonths As Integer
        Public sCurrentPaybackStatus As String
        Public sNewPaybackStatus As String
    End Structure
    Private structEmpSalAdvances() As EmpSalAdvances

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If iPayrollGenerated > 0 Then
            RemoveAndDisposeControls()
        End If
        grpSalAbstract.Visible = False
        btnSave.Visible = False
        btnCancel.Visible = False
        btnGeneratePayroll.Enabled = True
        btnClose.Enabled = True
        Me.ControlBox = True
        AppMainWindow.ControlBox = True
        AppMainWindow.EnablePrintMenuItems()
        AppMainWindow.ExitToolStripMenuItem.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PayrollCalc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AppMainWindow.DisablePrintMenuItems()
        AppMainWindow.StatusBarLabel1.ForeColor = Color.Black
        AppMainWindow.StatusBarLabel1.Text = "Welcome to the Krithika Industries Payroll Application!"
    End Sub

    Private Sub PayrollCalc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtPrevMonth As DateTime, dtCurrMonth As DateTime, dtNextMonth As DateTime

        iPayrollGenerated = 0

        'TODO: This line of code loads data into the 'KIPayrollDataSet.EmployeeMaster' table. You can move, or remove it, as needed.
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.Attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryAdvances' table. You can move, or remove it, as needed.
        Me.SalaryAdvancesTableAdapter.Fill(Me.KIPayrollDataSet.SalaryAdvances)
        'TODO: This line of code loads data into the 'KIPayrollDataSet.SalaryCalculation' table. You can move, or remove it, as needed.
        Me.SalaryCalculationTableAdapter.Fill(Me.KIPayrollDataSet.SalaryCalculation)

        cmbPayrollForMonth.Items.Clear()
        dtPrevMonth = New DateTime(Now().Year, Now().Month() - 1, 1)
        cmbPayrollForMonth.Items.Add(dtPrevMonth.ToString("MMMM yyyy"))
        dtCurrMonth = New DateTime(Now().Year, Now().Month(), 1)
        cmbPayrollForMonth.Items.Add(dtCurrMonth.ToString("MMMM yyyy"))
        dtNextMonth = New DateTime(Now().Year, Now().Month() + 1, 1)
        cmbPayrollForMonth.Items.Add(dtNextMonth.ToString("MMMM yyyy"))

        btnSave.Visible = False
        btnCancel.Visible = False
    End Sub

    Private Sub btnGeneratePayroll_Click(sender As Object, e As EventArgs) Handles btnGeneratePayroll.Click
        'Dynamically create all the text boxes to display salary calculations for each active employee this month
        Dim dvEmpMaster As DataView, dvEmpRow As DataRowView, dvSalAdvances() As DataView, dvSalAdvRow As DataRowView
        Dim dtCurrentSelection As DateTime, dtPrevSelection As DateTime
        Dim sRowFilterCriteria As String, dtFirstDay As Date, dtLastDay As Date

        dtCurrentSelection = DateTime.Parse(cmbPayrollForMonth.SelectedItem.ToString)
        dtPrevSelection = dtPayrollForMonth
        dtPayrollForMonth = DateTime.Parse(cmbPayrollForMonth.SelectedItem.ToString)
        Me.KIPayrollDataSet.SalaryCalculation.DefaultView.RowFilter = "PayMonth = '" & dtPayrollForMonth.ToString("MMM-yyyy") & "'"

        If dtCurrentSelection.Date = dtPrevSelection.Date Then
            MsgBox("Payroll for this month has just been generated - " & dtPayrollForMonth.ToString("MMM-yyyy") & "! Please exit this form or generate payroll for a different month.")
            Console.WriteLine("Payroll for this month has just been generated - " & dtPayrollForMonth.ToString("MMM-yyyy") & "! Please exit this form or generate payroll for a different month.")
            Exit Sub
        End If

        'If this form was already loaded and Generate Payroll button is being clicked again, 
        ' remove & Dispose() of the TextBox controls before creating another set for a different month
        RemoveAndDisposeControls()
        iPrevEmpCount = 0

        ' Creating an array of TextBoxes for the Payroll
        ReDim txtEmpIDs(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtEmpNames(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtPresent(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtAbsent(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtOTHours(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtOTDays(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtTotalDays(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtBasicSalary(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtGrossPay(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtAttdBonus(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtNSBFAllow(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtNetPay(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtESIDedn(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtSalAdvDedn(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtProfTax(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtSalaryToPay(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtSalaryPaid(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)
        ReDim txtESIEmployerContrib(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)

        iEmpIDXLocation = lblEmpID.Location.X + 3
        iEmpNameXLocation = lblEmpName.Location.X + 3
        iPresentXLocation = lblPresent.Location.X + 3
        iAbsentXLocation = lblAbsent.Location.X + 3
        iOTHrsXLocation = lblOTHours.Location.X + 3
        iOTDaysXLocation = lblOTDays.Location.X + 3
        iTotalDaysXLocation = lblTotalDays.Location.X + 3
        iBasicSalaryXLocation = lblBasicSalary.Location.X + 3
        iGrossPayXLocation = lblGrossPay.Location.X + 3
        iAttdBonusXLocation = lblAttdBonus.Location.X + 3
        iNSBFXLocation = lblNSBF.Location.X + 3
        iNetPayXLocation = lblNetPay.Location.X + 3
        iESIDednXLocation = lblESIDedn.Location.X + 3
        iSalAdvDednXLocation = lblAdvDedn.Location.X + 3
        iProfTaxXLocation = lblProfTax.Location.X + 3
        iSalToPayXLocation = lblAmtToPay.Location.X + 3
        iSalPaidXLocation = lblSalaryPaid.Location.X + 3
        iESIEmplContrXLocation = lblESIEmplContr.Location.X + 3
        iYLocation = lblLine.Location.Y + 10

        'Saving the selected Payroll Month and Year information
        dtPayrollForMonth = DateTime.Parse(cmbPayrollForMonth.SelectedItem.ToString)

        'Creating a DataView of the Employee Master table filtered for 'Active' employees only
        dvEmpMaster = New DataView(Me.KIPayrollDataSet.EmployeeMaster, "EmpStatus = 'Active'", "", DataViewRowState.CurrentRows)
        'Creating a filtered DataSet copy of the main KIPayrollDataSet
        dsFiltered = Me.KIPayrollDataSet.Copy
        'Filtering the Salary Advances table to retrieve only "Issued" or "In Progress" advances that should be included in
        'the payroll calculations
        dsFiltered.Tables("SalaryAdvances").DefaultView.RowFilter = "AdvPaybackStatus NOT LIKE 'Completed'"

        iTotalNumSalAdvances = dvEmpMaster.Count * dsFiltered.Tables("SalaryAdvances").DefaultView.Count
        ReDim structEmpSalAdvances(iTotalNumSalAdvances)

        For iEmpIndex = 0 To dvEmpMaster.Count - 1
            ReDim dvSalAdvances(dvEmpMaster.Count)

            dvEmpRow = dvEmpMaster.Item(iEmpIndex)
            dvSalAdvances(iEmpIndex) = New DataView(Me.KIPayrollDataSet.SalaryAdvances, "EmpID = '" & dvEmpRow.Item("EmpID").ToString & "' AND AdvPaybackStatus NOT LIKE 'Completed'", "", DataViewRowState.CurrentRows)

            txtEmpIDs(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(50, 20),
                                        .Location = New Point(iEmpIDXLocation, iYLocation)}
            txtEmpIDs(iEmpIndex).Text = dvEmpRow.Item("EmpID").ToString

            txtEmpNames(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(110, 20),
                                        .Location = New Point(iEmpNameXLocation, iYLocation)}
            txtEmpNames(iEmpIndex).Text = dvEmpRow.Item("EmpName").ToString

            txtPresent(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(30, 20),
                                        .Location = New Point(iPresentXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            dtFirstDay = DateSerial(dtPayrollForMonth.Year, dtPayrollForMonth.Month, 1)
            dtLastDay = DateSerial(dtPayrollForMonth.Year, dtPayrollForMonth.Month + 1, 0)
            sRowFilterCriteria = String.Format("EmpID LIKE '{0}' AND (AttdDate >= '{1}' AND AttdDate <= '{2}')", txtEmpIDs(iEmpIndex).Text, dtFirstDay.ToShortDateString(), dtLastDay.ToShortDateString())
            dsFiltered.Tables("Attendance").DefaultView.RowFilter = sRowFilterCriteria
            txtPresent(iEmpIndex).Text = dsFiltered.Tables("Attendance").DefaultView.Count

            txtAbsent(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(30, 20),
                                        .Location = New Point(iAbsentXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            txtAbsent(iEmpIndex).Text = CInt(txtNumDaysInMonth.Text) - CInt(txtPresent(iEmpIndex).Text)

            txtOTHours(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(35, 20),
                                        .Location = New Point(iOTHrsXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            sRowFilterCriteria = String.Format("EmpID = '{0}' AND (AttdDate >= '{1}' AND AttdDate <= '{2}')", txtEmpIDs(iEmpIndex).Text, dtFirstDay.ToShortDateString(), dtLastDay.ToShortDateString())
            oSumOTHours = dsFiltered.Tables("Attendance").Compute("SUM(OvertimeHours)", sRowFilterCriteria)
            If oSumOTHours IsNot Nothing Then
                If oSumOTHours.ToString = "" Then
                    txtOTHours(iEmpIndex).Text = "0"
                Else
                    txtOTHours(iEmpIndex).Text = oSumOTHours.ToString
                End If
            Else
                txtOTHours(iEmpIndex).Text = "0"
            End If

            txtOTDays(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(35, 20),
                                        .Location = New Point(iOTDaysXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            txtOTDays(iEmpIndex).Text = Math.Round((((CDbl(txtOTHours(iEmpIndex).Text)) * 1.5) / 8), 2, MidpointRounding.AwayFromZero)

            txtTotalDays(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(35, 20),
                                        .Location = New Point(iTotalDaysXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            txtTotalDays(iEmpIndex).Text = (CInt(txtPresent(iEmpIndex).Text) + CDbl(txtOTDays(iEmpIndex).Text))

            txtBasicSalary(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(60, 20),
                                        .Location = New Point(iBasicSalaryXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            txtBasicSalary(iEmpIndex).Text = FormatCurrency(dvEmpRow.Item("BasicSalary").ToString)

            txtGrossPay(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(60, 20),
                                        .Location = New Point(iGrossPayXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            txtGrossPay(iEmpIndex).Text = FormatCurrency(Math.Round((txtTotalDays(iEmpIndex).Text * CDbl(txtBasicSalary(iEmpIndex).Text)) / txtNumDaysInMonth.Text, 2, MidpointRounding.AwayFromZero))
            dTotalGrossPay += CDbl(txtGrossPay(iEmpIndex).Text)

            txtAttdBonus(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(50, 20),
                                        .Location = New Point(iAttdBonusXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            If CDbl(txtNumDaysInMonth.Text) = CDbl(txtPresent(iEmpIndex).Text) Then
                txtAttdBonus(iEmpIndex).Text = FormatCurrency(100)
            Else
                txtAttdBonus(iEmpIndex).Text = FormatCurrency(0)
            End If

            txtNSBFAllow(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(60, 20),
                                        .Location = New Point(iNSBFXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            ' execute query to filter and retrieve matching records for breakfast & night shift allowances
            Try
                Using myConnection As New OleDb.OleDbConnection(AppMainWindow.p_sConnectionString)
                    myConnection.Open()

                    sQuery = "SELECT * FROM ATTENDANCE WHERE TimeValue(StartTime) < #08:00:00 AM# AND EmpID=@EmpID AND (AttdDate >= @FirstDay AND AttdDate <= @LastDay)"

                    Using dbCommand As OleDb.OleDbCommand = New OleDb.OleDbCommand(sQuery, myConnection)
                        dbCommand.Parameters.AddWithValue("@EmpID", txtEmpIDs(iEmpIndex).Text)
                        dbCommand.Parameters.AddWithValue("@FirstDay", DateSerial(dtPayrollForMonth.Year, dtPayrollForMonth.Month, 1))
                        dbCommand.Parameters.AddWithValue("@LastDay", DateSerial(dtPayrollForMonth.Year, dtPayrollForMonth.Month + 1, 0))

                        dataAdapter.SelectCommand = dbCommand
                        dataAdapter.Fill(dsAttd, "Attendance")
                        iBFAllowance = dsAttd.Tables("Attendance").Rows.Count
                    End Using

                    sQuery = "SELECT * FROM ATTENDANCE WHERE TimeValue(EndTime) > #07:00:00 PM# AND EmpID=@EmpID AND (AttdDate >= @FirstDay AND AttdDate <= @LastDay)"

                    Using dbCommand As OleDb.OleDbCommand = New OleDb.OleDbCommand(sQuery, myConnection)
                        dbCommand.Parameters.AddWithValue("@EmpID", txtEmpIDs(iEmpIndex).Text)
                        dbCommand.Parameters.AddWithValue("@FirstDay", DateSerial(dtPayrollForMonth.Year, dtPayrollForMonth.Month, 1))
                        dbCommand.Parameters.AddWithValue("@LastDay", DateSerial(dtPayrollForMonth.Year, dtPayrollForMonth.Month + 1, 0))

                        dataAdapter.SelectCommand = dbCommand
                        dataAdapter.Fill(dsAttd, "Attendance")
                        iNSAllowance = dsAttd.Tables("Attendance").Rows.Count
                    End Using
                End Using
            Catch localException As Exception
                MsgBox(localException.ToString)
            End Try
            txtNSBFAllow(iEmpIndex).Text = FormatCurrency((iNSAllowance + iBFAllowance) * 100)

            txtNetPay(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(60, 20),
                                        .Location = New Point(iNetPayXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            Dim dNetPay As Double = 0
            dNetPay = CDbl(txtGrossPay(iEmpIndex).Text) + CDbl(txtAttdBonus(iEmpIndex).Text) + CDbl(txtNSBFAllow(iEmpIndex).Text)
            txtNetPay(iEmpIndex).Text = FormatCurrency(dNetPay)
            dTotalNetPay += dNetPay

            txtESIDedn(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(50, 20),
                                        .Location = New Point(iESIDednXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            Dim dESIDedn As Double = 0
            If (CDbl(txtNetPay(iEmpIndex).Text) > 0) And (CDbl(txtNetPay(iEmpIndex).Text) < 15000) Then
                dESIDedn = -(Me.Ceiling(dNetPay * 0.0175))
            Else
                dESIDedn = 0
            End If
            txtESIDedn(iEmpIndex).Text = FormatCurrency(dESIDedn)
            dTotalESIDedn += dESIDedn

            txtSalAdvDedn(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(50, 20),
                                        .Location = New Point(iSalAdvDednXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            dTotalSalAdvForEmp = 0
            For Each dvSalAdvRow In dvSalAdvances(iEmpIndex)
                dTotalSalAdvForEmp += -(CDbl(dvSalAdvRow.Item("AdvPaybackAmtPerMth").ToString))
                structEmpSalAdvances(iSalAdvanceCount).iID = dvSalAdvRow.Item("ID")
                structEmpSalAdvances(iSalAdvanceCount).sEmpID = dvEmpRow.Item("EmpID").ToString
                structEmpSalAdvances(iSalAdvanceCount).dAdvanceAmount = dvSalAdvRow.Item("AdvAmount")
                structEmpSalAdvances(iSalAdvanceCount).dAdvanceAmountPerMonth = dvSalAdvRow.Item("AdvPaybackAmtPerMth")
                structEmpSalAdvances(iSalAdvanceCount).iAdvancePaybackMonths = dvSalAdvRow.Item("AdvPaybackMonths")
                structEmpSalAdvances(iSalAdvanceCount).iAdvancePaybackRemainingMonths = dvSalAdvRow.Item("AdvPaybkRemMonths") - 1
                structEmpSalAdvances(iSalAdvanceCount).sCurrentPaybackStatus = dvSalAdvRow.Item("AdvPaybackStatus")
                If structEmpSalAdvances(iSalAdvanceCount).sCurrentPaybackStatus = "Issued" Then
                    structEmpSalAdvances(iSalAdvanceCount).sNewPaybackStatus = "In Progress"
                End If
                If structEmpSalAdvances(iSalAdvanceCount).iAdvancePaybackRemainingMonths <= 0 Then
                    structEmpSalAdvances(iSalAdvanceCount).sNewPaybackStatus = "Completed"
                End If
                iSalAdvanceCount += 1
            Next
            If dNetPay <= 0 Then
                dTotalSalAdvForEmp = 0
            End If
            txtSalAdvDedn(iEmpIndex).Text = FormatCurrency(dTotalSalAdvForEmp)
            dTotalAdvDedn += dTotalSalAdvForEmp

            txtProfTax(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(50, 20),
                                        .Location = New Point(iProfTaxXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            Dim dProfTax As Double = 0
            If (CDbl(txtNetPay(iEmpIndex).Text) > 9999) And (CDbl(txtNetPay(iEmpIndex).Text) < 15000) Then
                dProfTax = -(150)
            ElseIf (CDbl(txtNetPay(iEmpIndex).Text) > 14999) Then
                dProfTax = -(200)
            Else
                dProfTax = 0
            End If
            txtProfTax(iEmpIndex).Text = FormatCurrency(dProfTax)
            dTotalProfTax += dProfTax

            txtSalaryToPay(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(60, 20),
                                        .Location = New Point(iSalToPayXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            Dim dSalToPay As Double = 0
            dSalToPay = (CDbl(txtNetPay(iEmpIndex).Text) + CDbl(txtESIDedn(iEmpIndex).Text) + CDbl(txtSalAdvDedn(iEmpIndex).Text) + CDbl(txtProfTax(iEmpIndex).Text))
            dSalToPay = Math.Round(dSalToPay, 0, MidpointRounding.AwayFromZero)
            txtSalaryToPay(iEmpIndex).Text = FormatCurrency(dSalToPay)
            dTotalAmtToPay += dSalToPay

            txtSalaryPaid(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(60, 20),
                                        .Location = New Point(iSalPaidXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            txtSalaryPaid(iEmpIndex).Text = FormatCurrency(Me.Ceiling(dSalToPay, 10))
            dTotalSalaryPaid += Me.Ceiling(dSalToPay, 10)

            txtESIEmployerContrib(iEmpIndex) = New TextBox() With {
                                        .Enabled = False,
                                        .Size = New Size(60, 20),
                                        .Location = New Point(iESIEmplContrXLocation, iYLocation),
                                        .TextAlign = HorizontalAlignment.Right}
            Dim dESIEmplContr As Double = 0
            dESIEmplContr = -(Me.Ceiling(dNetPay * 0.0475, 1))
            If dNetPay <= 0 Then
                txtESIEmployerContrib(iEmpIndex).Text = FormatCurrency(0)
            Else
                txtESIEmployerContrib(iEmpIndex).Text = FormatCurrency(dESIEmplContr)
            End If
            dTotalESIEmplContr += dESIEmplContr

            grpSalAbstract.Controls.Add(txtEmpIDs(iEmpIndex))
            grpSalAbstract.Controls.Add(txtEmpNames(iEmpIndex))
            grpSalAbstract.Controls.Add(txtPresent(iEmpIndex))
            grpSalAbstract.Controls.Add(txtAbsent(iEmpIndex))
            grpSalAbstract.Controls.Add(txtOTHours(iEmpIndex))
            grpSalAbstract.Controls.Add(txtOTDays(iEmpIndex))
            grpSalAbstract.Controls.Add(txtTotalDays(iEmpIndex))
            grpSalAbstract.Controls.Add(txtBasicSalary(iEmpIndex))
            grpSalAbstract.Controls.Add(txtGrossPay(iEmpIndex))
            grpSalAbstract.Controls.Add(txtAttdBonus(iEmpIndex))
            grpSalAbstract.Controls.Add(txtNSBFAllow(iEmpIndex))
            grpSalAbstract.Controls.Add(txtNetPay(iEmpIndex))
            grpSalAbstract.Controls.Add(txtESIDedn(iEmpIndex))
            grpSalAbstract.Controls.Add(txtSalAdvDedn(iEmpIndex))
            grpSalAbstract.Controls.Add(txtProfTax(iEmpIndex))
            grpSalAbstract.Controls.Add(txtSalaryToPay(iEmpIndex))
            grpSalAbstract.Controls.Add(txtSalaryPaid(iEmpIndex))
            grpSalAbstract.Controls.Add(txtESIEmployerContrib(iEmpIndex))

            iYLocation = iYLocation + 25
        Next
        txtTotalGrossPay.Text = FormatCurrency(dTotalGrossPay)
        txtTotalNetPay.Text = FormatCurrency(dTotalNetPay)
        txtTotalESIDedn.Text = FormatCurrency(dTotalESIDedn)
        txtTotalAdvDedn.Text = FormatCurrency(dTotalAdvDedn)
        txtTotalProfTax.Text = FormatCurrency(dTotalProfTax)
        txtTotalAmt.Text = FormatCurrency(dTotalAmtToPay)
        txtTotalSalPaid.Text = FormatCurrency(dTotalSalaryPaid)
        txtTotalESIEmplContr.Text = FormatCurrency(dTotalESIEmplContr)

        If dTotalSalaryPaid <= 0 Then
            AppMainWindow.StatusBarLabel1.Text = "No payroll data available to generate payroll for this month - " & dtPayrollForMonth.ToString("MMM-yyyy") & "!"
            AppMainWindow.StatusBarLabel1.ForeColor = Color.Red
            btnSave.Visible = False
            btnCancel.Visible = False
            btnGeneratePayroll.Enabled = True
            btnClose.Enabled = True
            Me.ControlBox = True
            AppMainWindow.DisablePrintMenuItems()
            AppMainWindow.ControlBox = True
            AppMainWindow.ExitToolStripMenuItem.Enabled = True
        Else
            btnSave.Visible = True
            btnCancel.Visible = True
            btnGeneratePayroll.Enabled = False
            btnClose.Enabled = False
            Me.ControlBox = False
            AppMainWindow.EnablePrintMenuItems()
            AppMainWindow.ControlBox = False
            AppMainWindow.ExitToolStripMenuItem.Enabled = False
        End If

        iPayrollGenerated += 1
        iPrevEmpCount = dvEmpMaster.Count
        grpSalAbstract.Visible = True
    End Sub

    Private Sub cmbPayrollForMonth_TextChanged(sender As Object, e As EventArgs) Handles cmbPayrollForMonth.TextChanged
        Dim sMonthAndYear As String, iNumDaysInMonth As Integer, dtMonth As DateTime

        If cmbPayrollForMonth.SelectedIndex >= 0 Then
            sMonthAndYear = cmbPayrollForMonth.SelectedItem.ToString
            dtMonth = DateTime.Parse(sMonthAndYear)
            iNumDaysInMonth = DateTime.DaysInMonth(dtMonth.Year, dtMonth.Month)
            txtNumDaysInMonth.Text = iNumDaysInMonth
        End If
    End Sub

    Public Function Ceiling(ByVal dInputValue As Double, Optional ByVal dFactor As Double = 1) As Double
        Ceiling = (Int(dInputValue / dFactor) - (dInputValue / dFactor - Int(dInputValue / dFactor) > 0)) * dFactor
    End Function

    Public Function Floor(ByVal dInputValue As Double, Optional ByVal dFactor As Double = 1) As Double
        Floor = (Int(dInputValue / dFactor) - (dInputValue / dFactor - Int(dInputValue / dFactor) > 0)) * dFactor
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dtPayrollMonth As DateTime, iIndex As Integer = 0, sEmpMasterID As String

        dtPayrollMonth = DateTime.Parse(cmbPayrollForMonth.SelectedItem.ToString)
        Me.KIPayrollDataSet.SalaryCalculation.DefaultView.RowFilter = "PayMonth = '" & dtPayrollMonth.ToString("MMM-yyyy") & "'"
        Me.KIPayrollDataSet.EmployeeMaster.DefaultView.RowFilter = "EmpStatus = 'Active'"

        If Me.KIPayrollDataSet.SalaryCalculation.DefaultView.Count > 0 Then
            MsgBox("Payroll calculations for " & dtPayrollForMonth.ToString("MMM-yyyy") & " already exist in the database! Select a different month for the payroll run.")
            Console.WriteLine("Payroll calculations for " & dtPayrollForMonth.ToString("MMM-yyyy") & " already exist in the database! Select a different month for the payroll run.")
            Exit Sub
        Else
            For iEmpIndex = 0 To Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Count - 1
                'Insert payroll record for each employee into the SalaryCalculation table
                Try
                    sEmpMasterID = Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iEmpIndex)("EmpID").ToString

                    Me.SalaryCalculationTableAdapter.Insert(txtEmpIDs(iEmpIndex).Text, dtPayrollMonth.ToString("MMM-yyyy"), txtPresent(iEmpIndex).Text,
                                                        txtAbsent(iEmpIndex).Text, txtOTHours(iEmpIndex).Text, txtOTDays(iEmpIndex).Text,
                                                        txtTotalDays(iEmpIndex).Text, txtNumDaysInMonth.Text, txtGrossPay(iEmpIndex).Text,
                                                        txtAttdBonus(iEmpIndex).Text, txtNSBFAllow(iEmpIndex).Text, txtNetPay(iEmpIndex).Text,
                                                        txtESIDedn(iEmpIndex).Text, txtSalAdvDedn(iEmpIndex).Text, txtProfTax(iEmpIndex).Text,
                                                        txtSalaryToPay(iEmpIndex).Text, txtSalaryPaid(iEmpIndex).Text, txtESIEmployerContrib(iEmpIndex).Text)
                Catch ex As Exception
                    Console.WriteLine("Insert failed in Salary Calculation Insert due to: " & ex.Message)
                    Exit Sub
                End Try

                'If payroll record for each employee is successfully inserted, then check and update Salary Advance records to "In Progress" or "Completed"
                'and also calculate the total outstanding salary advance for each employee after the current month's deductions
                Dim dOutstandingSalAdv As Double = 0, drSalAdvRow As KIPayrollDataSet.SalaryAdvancesRow

                Try
                    For iIndex = 0 To iSalAdvanceCount
                        If structEmpSalAdvances(iIndex).sEmpID = txtEmpIDs(iEmpIndex).Text Then
                            drSalAdvRow = Me.KIPayrollDataSet.SalaryAdvances.FindByID(structEmpSalAdvances(iIndex).iID)
                            If drSalAdvRow.EmpID = structEmpSalAdvances(iIndex).sEmpID Then
                                drSalAdvRow.AdvPaybkRemMonths = structEmpSalAdvances(iIndex).iAdvancePaybackRemainingMonths
                                If structEmpSalAdvances(iIndex).sNewPaybackStatus IsNot "" Then
                                    drSalAdvRow.AdvPaybackStatus = structEmpSalAdvances(iIndex).sNewPaybackStatus
                                Else
                                    drSalAdvRow.AdvPaybackStatus = structEmpSalAdvances(iIndex).sCurrentPaybackStatus
                                End If
                                Me.SalaryAdvancesTableAdapter.Update(Me.KIPayrollDataSet.SalaryAdvances)
                                Me.KIPayrollDataSet.AcceptChanges()
                            End If
                        End If
                    Next
                Catch ex As Exception
                    Console.WriteLine("Insert failed in Salary Advances Update due to: " & ex.Message)
                    Exit Sub
                End Try

                Try
                    For Each drSalAdvRow In Me.KIPayrollDataSet.SalaryAdvances
                        If (drSalAdvRow.EmpID = sEmpMasterID) And
                        (drSalAdvRow.AdvPaybackStatus = "Issued" Or drSalAdvRow.AdvPaybackStatus = "In Progress") Then
                            dOutstandingSalAdv += (drSalAdvRow.AdvPaybackAmtPerMth * drSalAdvRow.AdvPaybkRemMonths)
                        End If
                    Next
                    Dim drEmpRow As KIPayrollDataSet.EmployeeMasterRow
                    drEmpRow = Me.KIPayrollDataSet.EmployeeMaster.FindByEmpID(sEmpMasterID)
                    drEmpRow.PendingAdvBalance = dOutstandingSalAdv
                    Me.EmployeeMasterTableAdapter.Update(Me.KIPayrollDataSet.EmployeeMaster)
                    Me.KIPayrollDataSet.AcceptChanges()
                    Console.WriteLine("Emp ID: " & sEmpMasterID & " has " & FormatCurrency(dOutstandingSalAdv) & " in Salary Advances outstanding!")
                Catch ex As Exception
                    Console.WriteLine("Insert failed in Employee Master Update due to: " & ex.Message)
                    Exit Sub
                End Try
            Next
        End If

        'Dispense with the dynamically created TextBoxes, as necessary
        RemoveAndDisposeControls()

        btnSave.Enabled = False
        btnCancel.Enabled = False
        grpSalAbstract.Visible = False
        btnGeneratePayroll.Enabled = True
        btnClose.Enabled = True
        Me.ControlBox = True
        AppMainWindow.ControlBox = True
        AppMainWindow.ExitToolStripMenuItem.Enabled = True
    End Sub

    Private Sub RemoveAndDisposeControls()
        If iPrevEmpCount > 0 Then
            For iIndex = 0 To iPrevEmpCount
                ' Remove & dispose off the dynamically created controls once the payroll run record has been saved to the database
                If txtEmpIDs(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtEmpIDs(iIndex))
                    txtEmpIDs(iIndex).Dispose()
                End If
                If txtEmpNames(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtEmpNames(iIndex))
                    txtEmpNames(iIndex).Dispose()
                End If
                If txtPresent(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtPresent(iIndex))
                    txtPresent(iIndex).Dispose()
                End If
                If txtAbsent(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtAbsent(iIndex))
                    txtAbsent(iIndex).Dispose()
                End If
                If txtOTHours(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtOTHours(iIndex))
                    txtOTHours(iIndex).Dispose()
                End If
                If txtOTDays(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtOTDays(iIndex))
                    txtOTDays(iIndex).Dispose()
                End If
                If txtTotalDays(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtTotalDays(iIndex))
                    txtTotalDays(iIndex).Dispose()
                End If
                If txtGrossPay(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtGrossPay(iIndex))
                    txtGrossPay(iIndex).Dispose()
                End If
                If txtAttdBonus(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtAttdBonus(iIndex))
                    txtAttdBonus(iIndex).Dispose()
                End If
                If txtNSBFAllow(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtNSBFAllow(iIndex))
                    txtNSBFAllow(iIndex).Dispose()
                End If
                If txtNetPay(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtNetPay(iIndex))
                    txtNetPay(iIndex).Dispose()
                End If
                If txtESIDedn(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtESIDedn(iIndex))
                    txtESIDedn(iIndex).Dispose()
                End If
                If txtSalAdvDedn(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtSalAdvDedn(iIndex))
                    txtSalAdvDedn(iIndex).Dispose()
                End If
                If txtProfTax(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtProfTax(iIndex))
                    txtProfTax(iIndex).Dispose()
                End If
                If txtSalaryToPay(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtSalaryToPay(iIndex))
                    txtSalaryToPay(iIndex).Dispose()
                End If
                If txtSalaryPaid(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtSalaryPaid(iIndex))
                    txtSalaryPaid(iIndex).Dispose()
                End If
                If txtESIEmployerContrib(iIndex) IsNot Nothing Then
                    Me.grpSalAbstract.Controls.Remove(txtESIEmployerContrib(iIndex))
                    txtESIEmployerContrib(iIndex).Dispose()
                End If
            Next
        End If
    End Sub

    Public Function GetPayrollForMonth() As String
        GetPayrollForMonth = cmbPayrollForMonth.SelectedItem.ToString
    End Function

    Public Function IsPayrollMonthSelected() As Boolean
        If cmbPayrollForMonth.SelectedIndex <= 0 Then
            IsPayrollMonthSelected = False
        ElseIf cmbPayrollForMonth.SelectedIndex > 0 Then
            IsPayrollMonthSelected = True
        Else
            IsPayrollMonthSelected = False
        End If
    End Function
End Class