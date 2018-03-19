Public Class Attendance
    Private p_bDisableFormClose As Boolean
    Private p_txtEmpID As DataGridViewTextBoxColumn, p_cmbEmpName As DataGridViewComboBoxColumn, p_dtpAttdDate As CalendarColumn
    Private p_dtpStartTime As CalendarColumn, p_dtpEndTime As CalendarColumn, p_txtRegHours As DataGridViewTextBoxColumn, p_txtOTHours As DataGridViewTextBoxColumn
    Private p_txtTotalHours As DataGridViewTextBoxColumn, p_sEmpName As String, p_dtMonth As DateTime

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtblAttendance As DataTable, dtMonth As DateTime, dtPrevMonth As DateTime, dtblEmpMast As DataTable, sEmpName As String = "", sPrevEmpName As String = ""

        'Loading data into the required Dataset tables.
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            p_bDisableFormClose = False

            Me.AttendanceQueryTableAdapter.Fill(Me.KIPayrollDataSet.AttendanceQuery)
            Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
            Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)
            My.Application.Log.WriteEntry("Loaded the required Table Adapters")

            'Filtering the Employee Master table to only 'Active' employees
            Me.KIPayrollDataSet.EmployeeMaster.DefaultView.RowFilter = "EmpStatus = 'Active'"

            lblSelectMonth.Visible = False ' Original Location - 13, 13
            cmbViewMonth.Visible = False ' Original Location - 92, 10
            lblEmpName.Visible = False
            cmbEmpName.Visible = False
            btnClearSelections.Visible = False
            grpAddAttdRecords.Location = New Point(16, 13)

            dgvRecordAttendance.EditMode = DataGridViewEditMode.EditOnEnter
            dgvViewAttdRecords.EditMode = DataGridViewEditMode.EditOnEnter
            dgvViewAttdRecords.ReadOnly = True
            ' Location for grpViewAttdRecords - 16, 37

            My.Application.Log.WriteEntry("Loading valid months in the dropdown list for the View Attendance Records function")
            'Finding valid months for which attendance records exist and adding those months to the dropdown list
            dtblAttendance = Me.KIPayrollDataSet.AttendanceQuery.DefaultView.ToTable(True, "AttdDate")
            dtblAttendance.DefaultView.Sort = "AttdDate ASC"
            cmbViewMonth.Items.Clear()
            For iIndex = 0 To dtblAttendance.DefaultView.Count - 1
                dtMonth = DateTime.Parse(dtblAttendance.DefaultView.Item(iIndex)("AttdDate").ToString)
                If Not dtPrevMonth.ToString("MMM-yyyy") = dtMonth.ToString("MMM-yyyy") Then
                    cmbViewMonth.Items.Add(dtMonth.ToString("MMMM yyyy"))
                    dtPrevMonth = dtMonth
                End If
            Next

            My.Application.Log.WriteEntry("Loading valid employees who have attendance records to the dropdown list for the View Attendance Records function")
            'Finding active employees who have attendance records and adding those employees to the dropdown list
            dtblEmpMast = Me.KIPayrollDataSet.AttendanceQuery.DefaultView.ToTable(True, "EmpName")
            cmbEmpName.Items.Clear()
            For iIndex = 0 To dtblEmpMast.DefaultView.Count - 1
                sEmpName = dtblEmpMast.Rows(iIndex)("EmpName").ToString
                If Not sPrevEmpName = sEmpName Then
                    cmbEmpName.Items.Add(sEmpName)
                    sPrevEmpName = sEmpName
                End If
            Next

            My.Application.Log.WriteEntry("Setting up the Record Attendance datagridview")
            dgvRecordAttendance.Columns.Clear()

            p_txtEmpID = New DataGridViewTextBoxColumn() With {
                                .DataPropertyName = "EmpID",
                                .HeaderText = "Emp ID",
                                .Width = 50,
                                .ReadOnly = True}
            dgvRecordAttendance.Columns.Add(p_txtEmpID)

            p_cmbEmpName = New DataGridViewComboBoxColumn() With {
                                .DataPropertyName = "EmpName",
                                .HeaderText = "Employee Name",
                                .Width = 100}
            dgvRecordAttendance.Columns.Add(p_cmbEmpName)
            For iIndex = 0 To Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Count - 1
                p_cmbEmpName.Items.Add(Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpName").ToString)
            Next

            p_dtpAttdDate = New CalendarColumn() With {
                                .DataPropertyName = "Attendance Date",
                                .HeaderText = "Attendance Date",
                                .DateTimeFormat = "dd-MMM-yyyy",
                                .Width = 75}
            dgvRecordAttendance.Columns.Add(p_dtpAttdDate)

            p_dtpStartTime = New CalendarColumn() With {
                                .DataPropertyName = "Start Time",
                                .HeaderText = "Start Time",
                                .DateTimeFormat = "hh:mm tt",
                                .ShowUpDown = True,
                                .Width = 75}
            dgvRecordAttendance.Columns.Add(p_dtpStartTime)

            p_dtpEndTime = New CalendarColumn() With {
                                .DataPropertyName = "End Time",
                                .HeaderText = "End Time",
                                .DateTimeFormat = "hh:mm tt",
                                .ShowUpDown = True,
                                .Width = 75}
            dgvRecordAttendance.Columns.Add(p_dtpEndTime)

            p_txtRegHours = New DataGridViewTextBoxColumn() With {
                                .DataPropertyName = "Regular Hours",
                                .HeaderText = "Regular Hours",
                                .Width = 50,
                                .ReadOnly = True}
            dgvRecordAttendance.Columns.Add(p_txtRegHours)

            p_txtOTHours = New DataGridViewTextBoxColumn() With {
                                .DataPropertyName = "OT Hours",
                                .HeaderText = "OT Hours",
                                .Width = 50,
                                .ReadOnly = True}
            dgvRecordAttendance.Columns.Add(p_txtOTHours)

            p_txtTotalHours = New DataGridViewTextBoxColumn() With {
                                .DataPropertyName = "Total Hours",
                                .HeaderText = "Total Hours",
                                .Width = 50,
                                .ReadOnly = True}
            dgvRecordAttendance.Columns.Add(p_txtTotalHours)

            My.Application.Log.WriteEntry("Setting up appropriate buttons and datagridviews")
            btnSave.Visible = False
            btnCancel.Visible = False
            dgvRecordAttendance.Enabled = False
            btnRecordAttd.Enabled = True
            btnViewAttdRecords.Enabled = True
            btnClose.Enabled = True
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub RecordAttd_Click(sender As Object, e As EventArgs) Handles btnRecordAttd.Click
        My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
        lblSelectMonth.Visible = False
        cmbViewMonth.Visible = False
        lblEmpName.Visible = False
        cmbEmpName.Visible = False
        btnClearSelections.Visible = False
        grpViewAttdRecords.Visible = False
        dgvViewAttdRecords.DataSource = Nothing
        grpAddAttdRecords.Visible = True
        dgvRecordAttendance.Enabled = True
        btnSave.Visible = True
        btnCancel.Visible = True
        btnRecordAttd.Enabled = False
        btnViewAttdRecords.Enabled = False
        btnClose.Enabled = False
        p_bDisableFormClose = True
        My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
    End Sub

    Private Sub Attendance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
        If e.CloseReason = CloseReason.UserClosing And p_bDisableFormClose = True Then
            e.Cancel = True
        End If
        My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
    End Sub

    Private Sub ViewAttdRecords_Click(sender As Object, e As EventArgs) Handles btnViewAttdRecords.Click
        Dim dtblAttendance As DataTable, dtMonth As DateTime, dtPrevMonth As DateTime, dtblEmpMast As DataTable
        Dim sEmpName As String, sPrevEmpName As String = ""

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)

            grpAddAttdRecords.Visible = False
            dgvViewAttdRecords.DataSource = Nothing
            dgvViewAttdRecords.Rows.Clear()

            My.Application.Log.WriteEntry("Filtering by distinct AttdDate's and adding relevant months to the View Attendance Records Month dropdown list")
            Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = ""
            dtblAttendance = Me.KIPayrollDataSet.AttendanceQuery.DefaultView.ToTable(True, "AttdDate")
            dtblAttendance.DefaultView.Sort = "AttdDate ASC"
            cmbViewMonth.Items.Clear()
            For iIndex = 0 To dtblAttendance.DefaultView.Count - 1
                dtMonth = DateTime.Parse(dtblAttendance.DefaultView.Item(iIndex)("AttdDate").ToString)
                If (Not dtPrevMonth.ToString("MMM-yyyy") = dtMonth.ToString("MMM-yyyy")) Then
                    cmbViewMonth.Items.Add(dtMonth.ToString("MMMM yyyy"))
                    dtPrevMonth = dtMonth
                End If
            Next

            'Finding active employees who have attendance records and adding those employees to the dropdown list
            My.Application.Log.WriteEntry("Filtering by distinct employee name's and adding employee name's to the View Attendance Records Employee dropdown list")
            dtblEmpMast = Me.KIPayrollDataSet.AttendanceQuery.DefaultView.ToTable(True, "EmpName")
            cmbEmpName.Items.Clear()
            For iIndex = 0 To dtblEmpMast.DefaultView.Count - 1
                sEmpName = dtblEmpMast.Rows(iIndex)("EmpName").ToString
                If Not sPrevEmpName = sEmpName Then
                    cmbEmpName.Items.Add(sEmpName)
                    sPrevEmpName = sEmpName
                End If
            Next

            lblSelectMonth.Visible = True ' Original Location - 13, 13
            cmbViewMonth.Visible = True ' Original Location - 92, 10
            lblEmpName.Visible = True
            cmbEmpName.Visible = True
            btnClearSelections.Visible = True
            btnClearSelections.Enabled = False
            grpViewAttdRecords.Location = New Point(16, 37)

            grpViewAttdRecords.Visible = True
            btnRecordAttd.Enabled = False

            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            p_bDisableFormClose = False
            Me.Close()
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sEmpID As String, sEmpName As String, dtAttdDate As DateTime, dtStartTime As DateTime, dtEndTime As DateTime, dtToday As DateTime
        Dim dTotalHrs As Double, dOvertimeHrs As Double, dRegHrs As Double, dtblAttdCopy As DataTable, bInsertSuccess As Boolean

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            Using (New MyHourGlass())
                dtToday = DateTime.Today
                For iIndex = 0 To dgvRecordAttendance.Rows.Count - 2
                    sEmpID = dgvRecordAttendance.Rows(iIndex).Cells(0).Value
                    sEmpName = dgvRecordAttendance.Rows(iIndex).Cells(1).Value
                    dtAttdDate = dgvRecordAttendance.Rows(iIndex).Cells(2).Value
                    dtStartTime = dgvRecordAttendance.Rows(iIndex).Cells(3).Value
                    dtEndTime = dgvRecordAttendance.Rows(iIndex).Cells(4).Value
                    dRegHrs = dgvRecordAttendance.Rows(iIndex).Cells(5).Value
                    dOvertimeHrs = dgvRecordAttendance.Rows(iIndex).Cells(6).Value
                    dTotalHrs = dgvRecordAttendance.Rows(iIndex).Cells(7).Value

                    If dtAttdDate.Date > dtToday.Date Then
                        MessageBox.Show("Attendance record for future dates cannot be entered!", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        AppMainWindow.AppStatusBarLabel.Text = "Attendance record for future dates cannot be entered!"
                        bInsertSuccess = False
                    Else
                        dtblAttdCopy = Me.KIPayrollDataSet.Attendance.CopyToDataTable()
                        dtblAttdCopy.DefaultView.RowFilter = "EmpID = '" & sEmpID & "' AND AttdDate = #" & dtAttdDate.Date.ToString("dd-MMM-yyyy") & "#"
                        If Not dtblAttdCopy.DefaultView.Count > 0 Then
                            Me.AttendanceTableAdapter.Insert(sEmpID, dtAttdDate.Date.ToString("dd-MMM-yyyy"), dtStartTime, dtEndTime, dTotalHrs, dOvertimeHrs)
                            Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
                            Me.AttendanceQueryTableAdapter.Fill(Me.KIPayrollDataSet.AttendanceQuery)
                            bInsertSuccess = True
                        Else
                            MessageBox.Show("Attendance record for " & sEmpID & ":" & sEmpName & " for " & dtAttdDate.Date.ToString("dd-MMM-yyyy") & " already exists!", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            AppMainWindow.AppStatusBarLabel.Text = "Attendance record for " & sEmpID & ":" & sEmpName & " for " & dtAttdDate.Date.ToString("dd-MMM-yyyy") & " already exists!"
                            bInsertSuccess = False
                        End If
                    End If
                Next
            End Using

            If bInsertSuccess = True Then
                dgvRecordAttendance.Enabled = False
                dgvRecordAttendance.Rows.Clear()
                btnSave.Visible = False
                btnCancel.Visible = False
                btnRecordAttd.Enabled = True
                btnViewAttdRecords.Enabled = True
                btnClose.Enabled = True
                p_bDisableFormClose = False
            Else
                dgvRecordAttendance.Select()
            End If
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            AppMainWindow.AppStatusBarLabel.Text = "An error has occurred with processing the new attendance records! Please refer to the error message in the application log."
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            dgvRecordAttendance.Rows.Clear()
            dgvRecordAttendance.Enabled = False
            btnSave.Visible = False
            btnCancel.Visible = False
            btnRecordAttd.Enabled = True
            btnViewAttdRecords.Enabled = True
            btnClose.Enabled = True
            p_bDisableFormClose = False
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs)
        Dim cmbEmpName As ComboBox = CType(sender, ComboBox)
        Dim sEmpName As String, sEmpID As String

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            If dgvRecordAttendance.CurrentCell.ColumnIndex = 1 Then
                sEmpName = cmbEmpName.SelectedItem.ToString
                For iIndex = 0 To Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Count - 1
                    If sEmpName = Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpName").ToString Then
                        sEmpID = Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpID").ToString
                        dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex - 1).Value = sEmpID
                    End If
                Next
            End If
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub DateTimePicker_Leave(ByVal sender As Object, ByVal e As EventArgs)
        Dim dtpEndTime As DateTimePicker = CType(sender, DateTimePicker)
        Dim dtStartTime As DateTime, dtEndTime As DateTime
        Dim tsRegHours As TimeSpan = New TimeSpan(8, 0, 0), tsTotalHours As TimeSpan, tsOTHours As TimeSpan

        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            If dgvRecordAttendance.CurrentCell.ColumnIndex = 4 Then
                dtStartTime = DateTime.Parse(dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex - 1).Value)
                dtEndTime = DateTime.Parse(dtpEndTime.Value.ToString)
                tsTotalHours = dtEndTime - dtStartTime
                tsOTHours = tsTotalHours - tsRegHours

                dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex + 1).Value = tsRegHours.TotalHours.ToString("N2")
                dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex + 2).Value = tsOTHours.TotalHours.ToString("N2")
                dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex + 3).Value = tsTotalHours.TotalHours.ToString("N2")
            End If
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub RecordAttendance_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvRecordAttendance.EditingControlShowing
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            If dgvRecordAttendance.CurrentCell.ColumnIndex = 1 Then
                Dim cmbEmpName As ComboBox = CType(e.Control, ComboBox)
                If (cmbEmpName IsNot Nothing) Then
                    RemoveHandler cmbEmpName.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                    AddHandler cmbEmpName.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
                End If
            ElseIf dgvRecordAttendance.CurrentCell.ColumnIndex = 4 Then
                Dim dtpEndTime As DateTimePicker = CType(e.Control, DateTimePicker)
                If (dtpEndTime IsNot Nothing) Then
                    RemoveHandler dtpEndTime.Leave, New EventHandler(AddressOf DateTimePicker_Leave)
                    'RemoveHandler dtpEndTime.ValueChanged, New EventHandler(AddressOf DateTimePicker_ValueChanged)

                    AddHandler dtpEndTime.Leave, New EventHandler(AddressOf DateTimePicker_Leave)
                    'AddHandler dtpEndTime.ValueChanged, New EventHandler(AddressOf DateTimePicker_ValueChanged)
                End If
            End If
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub ViewMonth_TextChanged(sender As Object, e As EventArgs) Handles cmbViewMonth.TextChanged
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            If cmbViewMonth.SelectedIndex > -1 And cmbEmpName.SelectedIndex > -1 Then
                LoadAttendanceRecordsInView(DateTime.Parse(cmbViewMonth.SelectedItem.ToString), cmbEmpName.SelectedItem.ToString)
            ElseIf cmbViewMonth.SelectedIndex > -1 And cmbEmpName.SelectedIndex = -1 Then
                LoadAttendanceRecordsInView(DateTime.Parse(cmbViewMonth.SelectedItem.ToString), "")
            ElseIf cmbViewMonth.SelectedIndex = -1 And cmbEmpName.SelectedIndex > -1 Then
                LoadAttendanceRecordsInView(DateSerial(1900, 1, 1), cmbEmpName.SelectedItem.ToString)
            Else
                'no month or employee selected, do nothing
            End If
            If cmbViewMonth.SelectedIndex > -1 Then
                btnClearSelections.Enabled = True
            ElseIf cmbViewMonth.SelectedIndex = -1 Then
                btnClearSelections.Enabled = False
            End If
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub LoadAttendanceRecordsInView(dtMonth As DateTime, sEmpName As String)
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            If sEmpName = "" And dtMonth.Date = Today.Date Then
                Dim sMessage As String
                sMessage = "No Month or Employee selected! Please select either the month only or month and employee to view attendance records."
                MsgBox(sMessage)
                My.Application.Log.WriteEntry(sMessage)
            ElseIf dtMonth.Date > #01/01/1900# And sEmpName IsNot "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "EmpName = '" & sEmpName & "' AND (AttdDate>=#" & DateSerial(dtMonth.Year, dtMonth.Month, 1) &
                                                                        "# AND AttdDate<=#" & DateSerial(dtMonth.Year, dtMonth.Month + 1, 0) & "#)"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
                My.Application.Log.WriteEntry("Filtered on EmpName and AttdDate and sorted by EmpID and AttdDate")
            ElseIf dtMonth.Date > #01/01/1900# And sEmpName = "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "(AttdDate>=#" & DateSerial(dtMonth.Year, dtMonth.Month, 1) &
                                                                        "# AND AttdDate<=#" & DateSerial(dtMonth.Year, dtMonth.Month + 1, 0) & "#)"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
                My.Application.Log.WriteEntry("Filtered on AttdDate and sorted by EmpID and AttdDate")
            ElseIf sEmpName = "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "(AttdDate>=#" & DateSerial(dtMonth.Year, dtMonth.Month, 1) &
                                                                        "# AND AttdDate<=#" & DateSerial(dtMonth.Year, dtMonth.Month + 1, 0) & "#)"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
                My.Application.Log.WriteEntry("Filtered on AttdDate and sorted by EmpID and AttdDate")
            ElseIf dtMonth.Date = #01/01/1900# And sEmpName IsNot "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "EmpName = '" & sEmpName & "'"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
                My.Application.Log.WriteEntry("Filtered on EmpName and sorted by EmpID and AttdDate")
            End If
            If Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Count > 0 Then
                My.Application.Log.WriteEntry("Setting dgvViewAttdRecords datasource")
                dgvViewAttdRecords.DataSource = Me.KIPayrollDataSet.AttendanceQuery.DefaultView
                dgvViewAttdRecords.Columns("ID").Visible = False
                dgvViewAttdRecords.Columns("EmpID").Width = 50
                dgvViewAttdRecords.Columns("EmpID").HeaderText = "Emp ID"
                dgvViewAttdRecords.Columns("EmpName").Width = 100
                dgvViewAttdRecords.Columns("EmpName").HeaderText = "Emp Name"
                dgvViewAttdRecords.Columns("AttdDate").Width = 75
                dgvViewAttdRecords.Columns("AttdDate").HeaderText = "Attendance Date"
                dgvViewAttdRecords.Columns("StartTime").Width = 75
                dgvViewAttdRecords.Columns("StartTime").HeaderText = "Start Time"
                dgvViewAttdRecords.Columns("StartTime").DefaultCellStyle.Format = "hh:mm tt"
                dgvViewAttdRecords.Columns("EndTime").Width = 75
                dgvViewAttdRecords.Columns("EndTime").HeaderText = "End Time"
                dgvViewAttdRecords.Columns("EndTime").DefaultCellStyle.Format = "hh:mm tt"
                dgvViewAttdRecords.Columns("TotalHours").Width = 75
                dgvViewAttdRecords.Columns("TotalHours").HeaderText = "Total Hours"
                dgvViewAttdRecords.Columns("OvertimeHours").Width = 75
                dgvViewAttdRecords.Columns("OvertimeHours").HeaderText = "OT Hours"
                dgvViewAttdRecords.Refresh()
            End If
            btnRecordAttd.Enabled = True
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub EmpName_TextChanged(sender As Object, e As EventArgs) Handles cmbEmpName.TextChanged
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            If cmbViewMonth.SelectedIndex > -1 And cmbEmpName.SelectedIndex > -1 Then
                LoadAttendanceRecordsInView(DateTime.Parse(cmbViewMonth.SelectedItem.ToString), cmbEmpName.SelectedItem.ToString)
            ElseIf cmbViewMonth.SelectedIndex > -1 And cmbEmpName.SelectedIndex = -1 Then
                LoadAttendanceRecordsInView(DateTime.Parse(cmbViewMonth.SelectedItem.ToString), "")
            ElseIf cmbViewMonth.SelectedIndex = -1 And cmbEmpName.SelectedIndex > -1 Then
                LoadAttendanceRecordsInView(DateSerial(1900, 1, 1), cmbEmpName.SelectedItem.ToString)
            Else
                'no month or employee selected, do nothing
            End If
            If cmbEmpName.SelectedIndex > -1 Then
                btnClearSelections.Enabled = True
            ElseIf cmbEmpName.SelectedIndex = -1 Then
                btnClearSelections.Enabled = False
            End If
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub

    Private Sub ClearSelections_Click(sender As Object, e As EventArgs) Handles btnClearSelections.Click
        Try
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name)
            cmbViewMonth.SelectedIndex = -1
            cmbEmpName.SelectedIndex = -1
            If dgvViewAttdRecords.Rows.Count > 0 Then
                dgvViewAttdRecords.DataSource = Nothing
                dgvViewAttdRecords.Rows.Clear()
            End If
            My.Application.Log.WriteEntry(System.Reflection.MethodBase.GetCurrentMethod().Name & " END")
        Catch exLocal As Exception
            My.Application.Log.WriteException(exLocal)
        End Try
    End Sub
End Class