Public Class Attendance
    Private p_bDisableFormClose As Boolean
    Private p_txtEmpID As DataGridViewTextBoxColumn, p_cmbEmpName As DataGridViewComboBoxColumn, p_dtpAttdDate As CalendarColumn
    Private p_dtpStartTime As CalendarColumn, p_dtpEndTime As CalendarColumn, p_txtRegHours As DataGridViewTextBoxColumn, p_txtOTHours As DataGridViewTextBoxColumn
    Private p_txtTotalHours As DataGridViewTextBoxColumn

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtblAttendance As DataTable, dtMonth As DateTime, dtPrevMonth As DateTime
        p_bDisableFormClose = False

        'TODO: This line of code loads data into the 'KIPayrollDataSet.AttendanceQuery' table. You can move, or remove it, as needed.
        Me.AttendanceQueryTableAdapter.Fill(Me.KIPayrollDataSet.AttendanceQuery)
        Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)
        Me.KIPayrollDataSet.EmployeeMaster.DefaultView.RowFilter = "EmpStatus = 'Active'"

        lblSelectMonth.Visible = False ' Original Location - 13, 13
        cmbViewMonth.Visible = False ' Original Location - 92, 10
        grpAddAttdRecords.Location = New Point(16, 13)
        ' Location for grpViewAttdRecords - 16, 37

        dtblAttendance = Me.KIPayrollDataSet.AttendanceQuery.DefaultView.ToTable(True, "AttdDate")
        cmbViewMonth.Items.Clear()
        For iIndex = 0 To dtblAttendance.Rows.Count - 1
            dtMonth = DateTime.Parse(dtblAttendance.Rows(iIndex)("AttdDate").ToString)
            If Not dtPrevMonth.ToString("MMM-yyyy") = dtMonth.ToString("MMM-yyyy") Then
                cmbViewMonth.Items.Add(dtMonth.ToString("MMMM yyyy"))
                dtPrevMonth = dtMonth
            End If
        Next

        dgvRecordAttendance.Columns.Clear()

        p_txtEmpID = New DataGridViewTextBoxColumn()
        p_txtEmpID.DataPropertyName = "EmpID"
        p_txtEmpID.HeaderText = "Employee ID"
        p_txtEmpID.Width = 50
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
        p_dtpAttdDate.DataPropertyName = "AttdDate"
        p_dtpAttdDate.HeaderText = "Attendance Date"
        p_dtpAttdDate.DateTimeFormat = "dd-MMM-yyyy"
        p_dtpAttdDate.Width = 75
        dgvRecordAttendance.Columns.Add(p_dtpAttdDate)

        p_dtpStartTime = New CalendarColumn()
        p_dtpStartTime.DataPropertyName = "StartTime"
        p_dtpStartTime.HeaderText = "Start Time"
        p_dtpStartTime.DateTimeFormat = "hh:mm tt"
        p_dtpStartTime.ShowUpDown = True
        p_dtpStartTime.Width = 75
        dgvRecordAttendance.Columns.Add(p_dtpStartTime)

        p_dtpEndTime = New CalendarColumn()
        p_dtpEndTime.DataPropertyName = "EndTime"
        p_dtpEndTime.HeaderText = "End Time"
        p_dtpEndTime.DateTimeFormat = "hh:mm tt"
        p_dtpEndTime.ShowUpDown = True
        p_dtpEndTime.Width = 75
        dgvRecordAttendance.Columns.Add(p_dtpEndTime)

        p_txtRegHours = New DataGridViewTextBoxColumn()
        p_txtRegHours.DataPropertyName = "RegHours"
        p_txtRegHours.HeaderText = "Regular Hours"
        p_txtRegHours.Width = 50
        dgvRecordAttendance.Columns.Add(p_txtRegHours)

        p_txtOTHours = New DataGridViewTextBoxColumn()
        p_txtOTHours.DataPropertyName = "OTHours"
        p_txtOTHours.HeaderText = "Overtime Hours"
        p_txtOTHours.Width = 50
        dgvRecordAttendance.Columns.Add(p_txtOTHours)

        p_txtTotalHours = New DataGridViewTextBoxColumn()
        p_txtTotalHours.DataPropertyName = "TotalHours"
        p_txtTotalHours.HeaderText = "Total Hours"
        p_txtTotalHours.Width = 50
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
        grpViewAttdRecords.Visible = False
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
        Dim dtblAttendance As DataTable, dtMonth As DateTime, dtPrevMonth As DateTime

        grpAddAttdRecords.Visible = False

        dtblAttendance = Me.KIPayrollDataSet.Attendance.DefaultView.ToTable(True, "AttdDate")
        cmbViewMonth.Items.Clear()
        For iIndex = 0 To dtblAttendance.Rows.Count - 1
            dtMonth = DateTime.Parse(dtblAttendance.Rows(iIndex)("AttdDate").ToString)
            If Not dtPrevMonth.ToString("MMM-yyyy") = dtMonth.ToString("MMM-yyyy") Then
                cmbViewMonth.Items.Add(dtMonth.ToString("MMMM yyyy"))
                dtPrevMonth = dtMonth
            End If
        Next

        lblSelectMonth.Visible = True ' Original Location - 13, 13
        cmbViewMonth.Visible = True ' Original Location - 92, 10
        grpViewAttdRecords.Location = New Point(16, 37)

        grpViewAttdRecords.Visible = True
        btnRecordAttd.Enabled = False
        'btnClose.Enabled = False
        'p_bDisableFormClose = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        p_bDisableFormClose = False
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sEmpID As String, sEmpName As String, dtAttdDate As DateTime, dtStartTime As DateTime, dtEndTime As DateTime
        Dim dTotalHrs As Double, dOvertimeHrs As Double, dRegHrs As Double, dtblAttdCopy As DataTable, bInsertSuccess As Boolean

        Try
            For iIndex = 0 To dgvRecordAttendance.Rows.Count - 2
                sEmpID = dgvRecordAttendance.Rows(iIndex).Cells(0).Value
                sEmpName = dgvRecordAttendance.Rows(iIndex).Cells(1).Value
                dtAttdDate = dgvRecordAttendance.Rows(iIndex).Cells(2).Value
                dtStartTime = dgvRecordAttendance.Rows(iIndex).Cells(3).Value
                dtEndTime = dgvRecordAttendance.Rows(iIndex).Cells(4).Value
                dRegHrs = dgvRecordAttendance.Rows(iIndex).Cells(5).Value
                dOvertimeHrs = dgvRecordAttendance.Rows(iIndex).Cells(6).Value
                dTotalHrs = dgvRecordAttendance.Rows(iIndex).Cells(7).Value

                dtblAttdCopy = Me.KIPayrollDataSet.Attendance.CopyToDataTable()
                dtblAttdCopy.DefaultView.RowFilter = "EmpID = '" & sEmpID & "' AND AttdDate = #" & dtAttdDate.Date.ToString("dd-MMM-yyyy") & "#"
                If Not dtblAttdCopy.DefaultView.Count > 0 Then
                    Me.AttendanceTableAdapter.Insert(sEmpID, dtAttdDate.Date.ToString("dd-MMM-yyyy"), dtStartTime, dtEndTime, dTotalHrs, dOvertimeHrs)
                    Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
                    bInsertSuccess = True
                Else
                    MsgBox("Attendance record for " & sEmpID & ":" & sEmpName & " for " & dtAttdDate.Date.ToString("dd-MMM-yyyy") & " already exists!")
                    bInsertSuccess = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try

        If bInsertSuccess = True Then
            dgvRecordAttendance.Enabled = False
            btnSave.Visible = False
            btnCancel.Visible = False
            btnViewAttdRecords.Enabled = True
            btnRecordAttd.Enabled = True
            btnClose.Enabled = True
            p_bDisableFormClose = False
        Else
            dgvRecordAttendance.Select()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvRecordAttendance.Enabled = False
        btnSave.Visible = False
        btnCancel.Visible = False
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
        Dim dtSelectedMonth As DateTime

        Try
            If cmbViewMonth.SelectedIndex > -1 Then
                dtSelectedMonth = DateTime.Parse(cmbViewMonth.SelectedItem.ToString)
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.RowFilter = "(AttdDate>=#" & DateSerial(dtSelectedMonth.Year, dtSelectedMonth.Month, 1) & "# AND AttdDate<=#" & DateSerial(dtSelectedMonth.Year, dtSelectedMonth.Month + 1, 0) & "#)"
                Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Sort = "EmpID ASC, AttdDate ASC"
                If Me.KIPayrollDataSet.AttendanceQuery.DefaultView.Count > 0 Then
                    dgvViewAttdRecords.DataSource = Me.KIPayrollDataSet.AttendanceQuery.DefaultView
                    dgvViewAttdRecords.Columns("ID").Visible = False
                    dgvViewAttdRecords.Columns("EmpID").Width = 50
                    dgvViewAttdRecords.Columns("EmpName").Width = 100
                    dgvViewAttdRecords.Columns("AttdDate").Width = 75
                    dgvViewAttdRecords.Columns("StartTime").Width = 75
                    dgvViewAttdRecords.Columns("StartTime").DefaultCellStyle.Format = "hh:mm tt"
                    dgvViewAttdRecords.Columns("EndTime").Width = 75
                    dgvViewAttdRecords.Columns("EndTime").DefaultCellStyle.Format = "hh:mm tt"
                    dgvViewAttdRecords.Columns("TotalHours").Width = 50
                    dgvViewAttdRecords.Columns("OvertimeHours").Width = 50
                    dgvViewAttdRecords.Refresh()
                End If
                btnRecordAttd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try
    End Sub
End Class