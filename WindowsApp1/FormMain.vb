Imports System.ComponentModel

Public Class AppMainWindow
    Public p_sConnectionString As String

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        Attendance.MdiParent = AppMainWindow.ActiveForm
        Attendance.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        AskExitQuestion()
    End Sub

    Private Sub EmployeeMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeMasterToolStripMenuItem.Click
        EmpMaster.MdiParent = AppMainWindow.ActiveForm
        EmpMaster.Show()
    End Sub

    Private Sub SalaryAdvancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryAdvancesToolStripMenuItem.Click
        SalaryAdvances.MdiParent = AppMainWindow.ActiveForm
        SalaryAdvances.Show()
    End Sub

    Private Sub AppMainWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
        p_sConnectionString = My.Settings.KIPayrollConnectionString

        DisablePrintMenuItems()
    End Sub

    Private Sub AppMainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' add code to copy database from the Debug or Release folders back into the main project folder
    End Sub

    Public Function DisablePrintMenuItems()
        PrintSalaryAbstractToolStripMenuItem.Enabled = False
        PrintSalarySlipsToolStripMenuItem.Enabled = False
        DisablePrintMenuItems = True
    End Function

    Public Function EnablePrintMenuItems()
        PrintSalaryAbstractToolStripMenuItem.Enabled = True
        PrintSalarySlipsToolStripMenuItem.Enabled = True
        EnablePrintMenuItems = True
    End Function

    Private Sub GeneratePayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratePayrollToolStripMenuItem.Click
        PayrollCalc.MdiParent = AppMainWindow.ActiveForm
        PayrollCalc.Show()
    End Sub

    Private Sub AppMainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            AskExitQuestion()
        End If
    End Sub

    Public Function AskExitQuestion()
        Dim msgResult As Byte

        msgResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgResult = DialogResult.Yes Then
            Application.Exit()
        End If
        AskExitQuestion = True
    End Function
End Class
