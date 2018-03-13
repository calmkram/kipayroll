Public Class Attendance
    Private p_bDisableFormClose As Boolean
    Private p_txtEmpID As DataGridViewTextBoxColumn, p_cmbEmpName As DataGridViewComboBoxColumn, p_dtpAttdDate As CalendarColumn
    Private p_dtpStartTime As CalendarColumn, p_dtpEndTime As CalendarColumn, p_txtRegHours As DataGridViewTextBoxColumn, p_txtOTHours As DataGridViewTextBoxColumn
    Private p_txtTotalHours As DataGridViewTextBoxColumn, p_sEmpName As String, p_dtMonth As DateTime

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtblAttendance As DataTable, dtMonth As DateTime, dtPrevMonth As DateTime, dtblEmpMast As DataTable, sEmpName As String = "", sPrevEmpName As String = ""

        p_bDisableFormClose = False

        'Loading data into the required Dataset tables.
        Me.AttendanceQueryTableAdapter.Fill(Me.KIPayrollDataSet.AttendanceQuery)
        Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)
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

        dgvRecordAttendance.Columns.Clear()

        p_txtEmpID = New DataGridViewTextBoxColumn()
        p_txtEmpID.DataPropertyName = "EmpID"
        p_txtEmpID.HeaderText = "Emp ID"
        p_txtEmpID.Width = 50
        p_txtEmpID.ReadOnly = True
        dgvRecordAttendance.Columns.Add(p_txtEmpID)

        p_cmbEmpName = New DataGridViewComboBoxColumn()
        p_cmbEmpName.DataPropertyName = "EmpName"
        p_cmbEmpName.HeaderText = "Employee Name"
        p_cmbEmpName.Width = 100
        dgvRecordAttendance.Columns.Add(p_cmbEmpName)
        For iIndex = 0 To Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Count - 1
            p_cmbEmpName.Items.Add(Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpName").ToString)
        Next

        p_dtpAttdDate = New CalendarColumn()
        p_dtpAttdDate.DataPropertyName = "Attendance Date"
        p_dtpAttdDate.HeaderText = "Attendance Date"
        p_dtpAttdDate.DateTimeFormat = "dd-MMM-yyyy"
        p_dtpAttdDate.Width = 75
        dgvRecordAttendance.Columns.Add(p_dtpAttdDate)

        p_dtpStartTime = New CalendarColumn()
        p_dtpStartTime.DataPropertyName = "Start Time"
        p_dtpStartTime.HeaderText = "Start Time"
        p_dtpStartTime.DateTimeFormat = "hh:mm tt"
        p_dtpStartTime.ShowUpDown = True
        p_dtpStartTime.Width = 75
        dgvRecordAttendance.Columns.Add(p_dtpStartTime)

        p_dtpEndTime = New CalendarColumn()
        p_dtpEndTime.DataPropertyName = "End Time"
        p_dtpEndTime.HeaderText = "End Time"
        p_dtpEndTime.DateTimeFormat = "hh:mm tt"
        p_dtpEndTime.ShowUpDown = True
        p_dtpEndTime.Width = 75
        dgvRecordAttendance.Columns.Add(p_dtpEndTime)

        p_txtRegHours = New DataGridViewTextBoxColumn()
        p_txtRegHours.DataPropertyName = "Regular Hours"
        p_txtRegHours.HeaderText = "Regular Hours"
        p_txtRegHours.Width = 50
        p_txtRegHours.ReadOnly = True
        dgvRecordAttendance.Columns.Add(p_txtRegHours)

        p_txtOTHours = New DataGridViewTextBoxColumn()
        p_txtOTHours.DataPropertyName = "OT Hours"
        p_txtOTHours.HeaderText = "OT Hours"
        p_txtOTHours.Width = 50
        p_txtOTHours.ReadOnly = True
        dgvRecordAttendance.Columns.Add(p_txtOTHours)

        p_txtTotalHours = New DataGridViewTextBoxColumn()
        p_txtTotalHours.DataPropertyName = "Total Hours"
        p_txtTotalHours.HeaderText = "Total Hours"
        p_txtTotalHours.Width = 50
        p_txtTotalHours.ReadOnly = True
        dgvRecordAttendance.Columns.Add(p_txtTotalHours)

        btnSave.Visible = False
        btnCancel.Visible = False
        dgvRecordAttendance.Enabled = False
        btnRecordAttd.Enabled = True
        btnViewAttdRecords.Enabled = True
        btnClose.Enabled = True
    End Sub

    Private Sub btnRecordAttd_Click(sender As Object, e As EventArgs) Handles btnRecordAttd.Click
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
    End Sub

    Private Sub Attendance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing And p_bDisableFormClose = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnViewAttdRecords_Click(sender As Object, e As EventArgs) Handles btnViewAttdRecords.Click
        Dim dtblAttendance As DataTable, dtMonth As DateTime, dtPrevMonth As DateTime, dtblEmpMast As DataTable
        Dim sEmpName As String, sPrevEmpName As String = ""

        grpAddAttdRecords.Visible = False

        dgvViewAttdRecords.DataSource = Nothing
        dgvViewAttdRecords.Rows.Clear()

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
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        p_bDisableFormClose = False
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sEmpID As String, sEmpName As String, dtAttdDate As DateTime, dtStartTime As DateTime, dtEndTime As DateTime, dtToday As DateTime
        Dim dTotalHrs As Double, dOvertimeHrs As Double, dRegHrs As Double, dtblAttdCopy As DataTable, bInsertSuccess As Boolean

        Try
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
        Catch ex As Exception
            AppMainWindow.AppStatusBarLabel.Text = "An error has occurred with processing the new attendance records! Please refer to the error message displayed."
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try

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
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvRecordAttendance.Rows.Clear()
        dgvRecordAttendance.Enabled = False
        btnSave.Visible = False
        btnCancel.Visible = False
        btnRecordAttd.Enabled = True
        btnViewAttdRecords.Enabled = True
        btnClose.Enabled = True
        p_bDisableFormClose = False
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs)
        Dim cmbEmpName As ComboBox = CType(sender, ComboBox)
        Dim sEmpName As String, sEmpID As String

        If dgvRecordAttendance.CurrentCell.ColumnIndex = 1 Then
            sEmpName = cmbEmpName.SelectedItem.ToString
            For iIndex = 0 To Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Count - 1
                If sEmpName = Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpName").ToString Then
                    sEmpID = Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpID").ToString
                    dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex - 1).Value = sEmpID
                End If
            Next
        End If
    End Sub

    Private Sub DateTimePicker_Leave(ByVal sender As Object, ByVal e As EventArgs)
        Dim dtpEndTime As DateTimePicker = CType(sender, DateTimePicker)
        Dim dtStartTime As DateTime, dtEndTime As DateTime
        Dim tsRegHours As TimeSpan = New TimeSpan(8, 0, 0), tsTotalHours As TimeSpan, tsOTHours As TimeSpan

        If dgvRecordAttendance.CurrentCell.ColumnIndex = 4 Then
            dtStartTime = DateTime.Parse(dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex - 1).Value)
            dtEndTime = DateTime.Parse(dtpEndTime.Value.ToString)
            tsTotalHours = dtEndTime - dtStartTime
            tsOTHours = tsTotalHours - tsRegHours

            dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex + 1).Value = tsRegHours.TotalHours.ToString("N2")
            dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex + 2).Value = tsOTHours.TotalHours.ToString("N2")
            dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex + 3).Value = tsTotalHours.TotalHours.ToString("N2")
        End If
    End Sub

    Private Sub dgvRecordAttendance_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvRecordAttendance.EditingControlShowing
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
    End Sub

    Private Sub cmbViewMonth_TextChanged(sender As Object, e As EventArgs) Handles cmbViewMonth.TextChanged
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
    End Sub

    Private Sub LoadAttendanceRecordsInView(dtMonth As DateTime, sEmpName As String)
        Try
            If sEmpName = "" And dtMonth.Date = Today.Date Then
                MsgBox("No Month or Employee selected! Please select either the month only or month and employee to view attendance records.")
            ElseIf dtMonth.Date > #01/01/1900# And sEmpName IsNot "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "EmpName = '" & sEmpName & "' AND (AttdDate>=#" & DateSerial(dtMonth.Year, dtMonth.Month, 1) &
                                                                        "# AND AttdDate<=#" & DateSerial(dtMonth.Year, dtMonth.Month + 1, 0) & "#)"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
            ElseIf dtMonth.Date > #01/01/1900# And sEmpName = "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "(AttdDate>=#" & DateSerial(dtMonth.Year, dtMonth.Month, 1) &
                                                                        "# AND AttdDate<=#" & DateSerial(dtMonth.Year, dtMonth.Month + 1, 0) & "#)"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
            ElseIf sEmpName = "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "(AttdDate>=#" & DateSerial(dtMonth.Year, dtMonth.Month, 1) &
                                                                        "# AND AttdDate<=#" & DateSerial(dtMonth.Year, dtMonth.Month + 1, 0) & "#)"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
            ElseIf dtMonth.Date = #01/01/1900# And sEmpName IsNot "" Then
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "EmpName = '" & sEmpName & "'"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
            End If
            If Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Count > 0 Then
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
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try
    End Sub

    Private Sub cmbEmpName_TextChanged(sender As Object, e As EventArgs) Handles cmbEmpName.TextChanged
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
    End Sub

    Private Sub btnClearSelections_Click(sender As Object, e As EventArgs) Handles btnClearSelections.Click
        cmbViewMonth.SelectedIndex = -1
        cmbEmpName.SelectedIndex = -1
        If dgvViewAttdRecords.Rows.Count > 0 Then
            dgvViewAttdRecords.DataSource = Nothing
            dgvViewAttdRecords.Rows.Clear()
        End If
    End Sub
End Class