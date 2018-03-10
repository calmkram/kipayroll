﻿Public Class Attendance
    Private p_bDisableFormClose As Boolean
    Private p_txtEmpID As DataGridViewTextBoxColumn, p_cmbEmpName As DataGridViewComboBoxColumn, p_dtpAttdDate As CalendarColumn
    Private p_dtpStartTime As CalendarColumn, p_dtpEndTime As CalendarColumn, p_txtRegHours As DataGridViewTextBoxColumn, p_txtOTHours As DataGridViewTextBoxColumn
    Private p_txtTotalHours As DataGridViewTextBoxColumn

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles Me.Load
        p_bDisableFormClose = False

        Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)
        Me.KIPayrollDataSet.EmployeeMaster.DefaultView.RowFilter = "EmpStatus = 'Active'"

        lblSelectMonth.Visible = False ' Original Location - 13, 13
        cmbViewMonth.Visible = False ' Original Location - 92, 10
        grpAddAttdRecords.Location = New Point(16, 13)
        ' Location for grpViewAttdRecords - 16, 37

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
        dgvRecordAttendance.Enabled = True
        btnSave.Visible = True
        btnCancel.Visible = True
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
        grpAddAttdRecords.Visible = False
        btnRecordAttd.Enabled = False
        btnClose.Enabled = False
        p_bDisableFormClose = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        p_bDisableFormClose = False
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dgvRecordAttendance.Enabled = False
        btnSave.Visible = False
        btnCancel.Visible = False
        btnViewAttdRecords.Enabled = True
        btnClose.Enabled = True
        p_bDisableFormClose = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvRecordAttendance.Enabled = False
        btnSave.Visible = False
        btnCancel.Visible = False
        btnViewAttdRecords.Enabled = True
        btnClose.Enabled = True
        p_bDisableFormClose = False
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmbEmpName As ComboBox = CType(sender, ComboBox)
        Dim sEmpName As String, sEmpID As String

        sEmpName = cmbEmpName.SelectedItem.ToString
        For iIndex = 0 To Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Count - 1
            If sEmpName = Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpName").ToString Then
                sEmpID = Me.KIPayrollDataSet.EmployeeMaster.DefaultView.Item(iIndex)("EmpID").ToString
                dgvRecordAttendance.CurrentRow.Cells(dgvRecordAttendance.CurrentCell.ColumnIndex - 1).Value = sEmpID
            End If
        Next
    End Sub

    Private Sub dgvRecordAttendance_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvRecordAttendance.EditingControlShowing
        If dgvRecordAttendance.CurrentCell.ColumnIndex = 1 Then
            Dim cmbEmpName As ComboBox = CType(e.Control, ComboBox)
            If (cmbEmpName IsNot Nothing) Then
                RemoveHandler cmbEmpName.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                AddHandler cmbEmpName.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub
End Class