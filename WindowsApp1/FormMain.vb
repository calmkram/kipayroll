Public Class AppMainWindow
    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        Attendance.MdiParent = AppMainWindow.ActiveForm
        Attendance.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim msgResult As Byte

        msgResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgResult = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub EmployeeMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeMasterToolStripMenuItem.Click
        EmpMaster.MdiParent = AppMainWindow.ActiveForm
        EmpMaster.Show()
    End Sub

    Private Sub SalaryAdvancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryAdvancesToolStripMenuItem.Click
        SalaryAdvances.MdiParent = AppMainWindow.ActiveForm
        SalaryAdvances.Show()
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        PayrollCalc.MdiParent = AppMainWindow.ActiveForm
        PrintToolStripMenuItem.Enabled = True
        PayrollCalc.Show()
    End Sub

    Private Sub AppMainWindow_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Public Function DisablePrintMenuItem()
        PrintToolStripMenuItem.Enabled = False
        DisablePrintMenuItem = True
    End Function
End Class
