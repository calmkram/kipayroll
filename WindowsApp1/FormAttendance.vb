Public Class Attendance
    Dim p_sEmpIDArray() As String, p_bInvalidAttdRecord As Boolean, p_iEditState As Integer

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim iIndex As Integer = 0, dtStartTime As DateTime, dtEndTime As DateTime, drvEmpRow As DataRowView

        p_bInvalidAttdRecord = False
        p_iEditState = 0

        Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)
        Me.EmployeeMasterTableAdapter.Fill(Me.KIPayrollDataSet.EmployeeMaster)

        ReDim p_sEmpIDArray(Me.KIPayrollDataSet.EmployeeMaster.Rows.Count)

        cmbEmpName.Items.Clear()
        Me.KIPayrollDataSet.EmployeeMaster.DefaultView.RowFilter = "EmpStatus = 'Active'"
        For Each drvEmpRow In Me.KIPayrollDataSet.EmployeeMaster.DefaultView
            p_sEmpIDArray(iIndex) = drvEmpRow.Item("EmpID").ToString
            cmbEmpName.Items.Add(drvEmpRow.Item("EmpName").ToString)
            iIndex = iIndex + 1
        Next

        dtStartTime = New DateTime(Today().Year, Today().Month, Today().Day, 8, 0, 0)
        dtEndTime = New DateTime(Today().Year, Today().Month, Today().Day, 16, 0, 0)
        dtpStartTime.Value = dtStartTime
        dtpEndTime.Value = dtEndTime
    End Sub

    Private Sub cmbEmpName_TextChanged(sender As Object, e As EventArgs) Handles cmbEmpName.TextChanged
        Dim iEmpIDIndex As Integer = 0

        If p_iEditState > 0 Then
            dtpAttdDate.Enabled = True
            dtpStartTime.Enabled = True
            dtpEndTime.Enabled = True

            If Not cmbEmpName.SelectedIndex = -1 Then
                iEmpIDIndex = cmbEmpName.SelectedIndex
                txtEmpID.Text = p_sEmpIDArray(iEmpIDIndex)

                If p_iEditState = 1 Then
                    btnAddNewAttdRec.Enabled = False
                    btnSave.Enabled = True
                    btnCancel.Enabled = True
                ElseIf p_iEditState = 2 Then
                    Dim sQuery As String, dataAdapter As New OleDb.OleDbDataAdapter, dataGridDataSet As New DataSet

                    Try
                        Using myConnection As New OleDb.OleDbConnection(AppMainWindow.p_sConnectionString)
                            myConnection.Open()

                            sQuery = "SELECT * FROM ATTENDANCE WHERE EmpID=@EmpID AND (AttdDate>=@CurrentMthFirstDate AND AttdDate<=@CurrentMthLastDate)"

                            Using dbCommand As OleDb.OleDbCommand = New OleDb.OleDbCommand(sQuery, myConnection)
                                Dim dtFirstDate As DateTime, dtLastDate As DateTime

                                dtFirstDate = DateSerial(Today.Year, Today.Month, 1)
                                dtLastDate = DateSerial(Today.Year, Today.Month + 1, 0)
                                dbCommand.Parameters.AddWithValue("@EmpID", txtEmpID.Text)
                                dbCommand.Parameters.AddWithValue("@CurrentMthFirstDate", dtFirstDate.ToShortDateString)
                                dbCommand.Parameters.AddWithValue("@CurrentMthLastDate", dtLastDate.ToShortDateString)

                                dataAdapter.SelectCommand = dbCommand
                                dataAdapter.Fill(dataGridDataSet)
                                dgvViewAttdRecords.DataSource = dataGridDataSet.Tables(0)
                                dgvViewAttdRecords.DefaultCellStyle.SelectionForeColor = Color.Navy
                                dgvViewAttdRecords.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
                                dgvViewAttdRecords.Columns(0).Visible = False
                                dgvViewAttdRecords.Columns(3).DefaultCellStyle.Format = "hh:mm tt" 'setting the format to Time only for the Start Time field
                                dgvViewAttdRecords.Columns(4).DefaultCellStyle.Format = "hh:mm tt" 'setting the format to Time only for the End Time field
                                If dataGridDataSet.Tables(0).Rows.Count <= 0 Then
                                    AppMainWindow.StatusBarLabel1.Text = "No attendance records available for " & cmbEmpName.SelectedItem.ToString & "!"
                                Else
                                    AppMainWindow.StatusBarLabel1.Text = "Attendance records displayed above for " & cmbEmpName.SelectedItem.ToString & "!"
                                End If
                            End Using
                        End Using
                    Catch localException As Exception
                        MsgBox(localException.ToString)
                    End Try

                    grpViewAttdRecords.Visible = True
                    btnAddNewAttdRec.Enabled = True
                    btnViewAttdRecords.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btnAddNewAttdRec_Click(sender As Object, e As EventArgs) Handles btnAddNewAttdRec.Click
        p_iEditState = 1
        cmbEmpName.Enabled = True

        grpViewAttdRecords.Visible = False
        grpAddAttdRecord.Visible = True
        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnAddNewAttdRec.Enabled = False
        btnViewAttdRecords.Enabled = False

        txtEmpID.Text = ""
        cmbEmpName.SelectedIndex = -1
        cmbEmpName.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If p_bInvalidAttdRecord = False Then

            dtpStartTime.Value = CDate(Format(dtpAttdDate.Value, "dd-MMM-yyyy")) & " " & CDate(Format(dtpStartTime.Value, "hh:mm tt"))
            dtpEndTime.Value = CDate(Format(dtpAttdDate.Value, "dd-MMM-yyyy")) & " " & CDate(Format(dtpEndTime.Value, "hh:mm tt"))

            Me.AttendanceTableAdapter.Insert(txtEmpID.Text, dtpAttdDate.Value.ToShortDateString, dtpStartTime.Value, dtpEndTime.Value, txtTotalHrs.Text, txtOvertimeHrs.Text)
            Me.AttendanceTableAdapter.Fill(Me.KIPayrollDataSet.Attendance)

            txtEmpID.Text = ""
            cmbEmpName.SelectedIndex = -1
            p_iEditState = 0
            dtpAttdDate.ResetText()
            dtpStartTime.ResetText()
            dtpEndTime.ResetText()
            dtpStartTime.Value = New DateTime(Today().Year, Today().Month, Today().Day, 8, 0, 0)
            dtpEndTime.Value = New DateTime(Today().Year, Today().Month, Today().Day, 16, 0, 0)
            txtRegularHrs.Text = ""
            txtOvertimeHrs.Text = ""
            txtTotalHrs.Text = ""

            cmbEmpName.Enabled = False
            dtpAttdDate.Enabled = False
            dtpStartTime.Enabled = False
            dtpEndTime.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnAddNewAttdRec.Enabled = True
            btnViewAttdRecords.Enabled = True
        ElseIf p_bInvalidAttdRecord = True Then
            MessageBox.Show("The attendance record for " & Format(dtpAttdDate.Value, "dd-MMM-yyyy") & " already exists for " & cmbEmpName.SelectedItem.ToString & "! Please record attendance for another day for this employee.", "Record Daily Attendance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpAttdDate.ResetText()
            dtpAttdDate.Select()
        End If
    End Sub

    Private Sub dtpEndTime_TextChanged(sender As Object, e As EventArgs) Handles dtpEndTime.TextChanged
        Dim tsRegularHours As TimeSpan = New TimeSpan(8, 0, 0), tsOvertimeHours As TimeSpan, tsTotalHours As TimeSpan
        Dim dtAttdDate As DateTime, dtStartTime As DateTime, dtEndTime As DateTime

        dtAttdDate = dtpAttdDate.Value
        dtStartTime = dtpStartTime.Value
        dtEndTime = dtpEndTime.Value

        tsTotalHours = dtEndTime - dtStartTime
        tsOvertimeHours = tsTotalHours - tsRegularHours

        txtRegularHrs.Text = tsRegularHours.TotalHours.ToString("N2")
        txtOvertimeHrs.Text = tsOvertimeHours.TotalHours.ToString("N2")
        txtTotalHrs.Text = tsTotalHours.TotalHours.ToString("N2")
    End Sub

    Private Sub btnViewAttdRecords_Click(sender As Object, e As EventArgs) Handles btnViewAttdRecords.Click
        p_iEditState = 2
        grpAddAttdRecord.Visible = False
        grpViewAttdRecords.Visible = False

        cmbEmpName.Enabled = True
        cmbEmpName.Select()

        AppMainWindow.StatusBarLabel1.Text = "Select an Employee above to view their attendance records for the current month"
    End Sub

    Private Sub dtpAttdDate_TextChanged(sender As Object, e As EventArgs) Handles dtpAttdDate.TextChanged
        Dim sQuery As String

        Try
            Using myConnection As New OleDb.OleDbConnection(AppMainWindow.p_sConnectionString)
                myConnection.Open()

                sQuery = "SELECT * FROM ATTENDANCE WHERE EmpID=@EmpID AND AttdDate=@AttdDate"

                Using dbCommand As OleDb.OleDbCommand = New OleDb.OleDbCommand(sQuery, myConnection)
                    dbCommand.Parameters.AddWithValue("@EmpID", txtEmpID.Text)
                    dbCommand.Parameters.AddWithValue("@AttdDate", dtpAttdDate.Value.ToShortDateString)

                    Using dataReader As OleDb.OleDbDataReader = dbCommand.ExecuteReader
                        If dataReader.HasRows Then
                            If dataReader.Read() Then
                                If dataReader("EmpID").ToString = txtEmpID.Text And Format(dataReader("AttdDate").ToString, "dd-MMM-yyyy") = Format(dtpAttdDate.Value.ToShortDateString, "dd-MMM-yyyy") Then
                                    p_bInvalidAttdRecord = True
                                Else
                                    p_bInvalidAttdRecord = False
                                End If
                            End If
                        Else
                            p_bInvalidAttdRecord = False
                        End If
                    End Using
                End Using
            End Using
        Catch localException As Exception
            MsgBox(localException.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cmbEmpName.Enabled = False
        grpAddAttdRecord.Visible = False
        grpViewAttdRecords.Visible = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAddNewAttdRec.Enabled = True
        btnViewAttdRecords.Enabled = True

        txtEmpID.Text = ""
        cmbEmpName.SelectedIndex = -1
        p_iEditState = 0
        dtpAttdDate.ResetText()
        dtpStartTime.ResetText()
        dtpEndTime.ResetText()
        dtpStartTime.Value = New DateTime(Today().Year, Today().Month, Today().Day, 8, 0, 0)
        dtpEndTime.Value = New DateTime(Today().Year, Today().Month, Today().Day, 16, 0, 0)
        txtRegularHrs.Text = ""
        txtOvertimeHrs.Text = ""
        txtTotalHrs.Text = ""
    End Sub
End Class