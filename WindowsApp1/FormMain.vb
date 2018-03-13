Imports System.ComponentModel

Public Class AppMainWindow
    Friend p_myAppSettings As AppSettings
    Public Const conAdminMode As String = "Admin Mode"
    Public Const conUserMode As String = "User Mode"

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        If p_myAppSettings.GetAppMode() = conAdminMode Or p_myAppSettings.GetAppMode() = conUserMode Then
            Attendance.MdiParent = AppMainWindow.ActiveForm
            Attendance.Show()
        Else
            MessageBox.Show("This option is not available in this mode!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        AskExitQuestion()
    End Sub

    Private Sub EmployeeMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeMasterToolStripMenuItem.Click
        If p_myAppSettings.GetAppMode() = conAdminMode Then
            EmpMaster.MdiParent = AppMainWindow.ActiveForm
            EmpMaster.Show()
        Else
            MessageBox.Show("This option is not available in this mode!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SalaryAdvancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryAdvancesToolStripMenuItem.Click
        If p_myAppSettings.GetAppMode() = conAdminMode Then
            SalaryAdvances.MdiParent = AppMainWindow.ActiveForm
            SalaryAdvances.Show()
        Else
            MessageBox.Show("This option is not available in this mode!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AppMainWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load data into the 'KIPayrollDataSet.SalaryCalculation' table
        Me.SalaryCalculationTableAdapter.Fill(Me.KIPayrollDataSet.SalaryCalculation)

        'Loading the Global Application Settings
        p_myAppSettings.SetConnectionString(My.Settings.KIPayrollConnectionString)
        p_myAppSettings.SetAppMode(My.Settings.AppMode)

        Me.DateTimeStatusLabel.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt")
        Me.DateTimeStatusLabel.BorderStyle = BorderStyle.Fixed3D
        Me.DateTimeStatusLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
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
        If p_myAppSettings.GetAppMode() = conAdminMode Then
            PayrollCalc.MdiParent = AppMainWindow.ActiveForm
            PayrollCalc.Show()
        Else
            MessageBox.Show("This option is not available in this mode!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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

    Private Sub PrintSalaryAbstractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSalaryAbstractToolStripMenuItem.Click
        If p_myAppSettings.GetAppMode() = conAdminMode Then
            If Application.OpenForms().OfType(Of PayrollCalc).Any Then
                If PayrollCalc.IsPayrollMonthSelected() Then
                    Dim sPayrollForMonth As String, dtPayrollForMonth As DateTime

                    sPayrollForMonth = PayrollCalc.GetPayrollForMonth()
                    dtPayrollForMonth = DateTime.Parse(sPayrollForMonth)

                    ReportsContainer.MdiParent = AppMainWindow.ActiveForm
                    ReportsContainer.SetPayrollFormStatus(True)
                    ReportsContainer.SetLoadSalaryAbstractReport(True)
                    ReportsContainer.SetReportName("Salary Abstract for " & dtPayrollForMonth.ToString("MMMM yyyy"))
                    ReportsContainer.Show()
                Else
                    ReportsContainer.MdiParent = AppMainWindow.ActiveForm
                    ReportsContainer.SetPayrollFormStatus(False)
                    ReportsContainer.SetLoadSalaryAbstractReport(True)
                    ReportsContainer.Show()
                End If
            Else
                ReportsContainer.MdiParent = AppMainWindow.ActiveForm
                ReportsContainer.SetPayrollFormStatus(False)
                ReportsContainer.SetLoadSalaryAbstractReport(True)
                ReportsContainer.Show()
            End If
        Else
            MessageBox.Show("This option is not available in this mode!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog(AppMainWindow.ActiveForm)
    End Sub

    Private Sub DTTimer_Tick(sender As Object, e As EventArgs) Handles DTTimer.Tick
        Me.DateTimeStatusLabel.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt")
    End Sub

    Private Sub PrintSalarySlipsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSalarySlipsToolStripMenuItem.Click
        If p_myAppSettings.GetAppMode() = conAdminMode Then
            If Application.OpenForms().OfType(Of PayrollCalc).Any Then
                If PayrollCalc.IsPayrollMonthSelected() Then
                    Dim dtPayrollForMonth As DateTime

                    dtPayrollForMonth = DateTime.Parse(PayrollCalc.GetPayrollForMonth())

                    ReportsContainer.MdiParent = AppMainWindow.ActiveForm
                    ReportsContainer.SetPayrollFormStatus(True)
                    ReportsContainer.SetLoadSalarySlipReport(True)
                    ReportsContainer.SetReportName("Salary Abstract for " & dtPayrollForMonth.ToString("MMMM yyyy"))
                    ReportsContainer.Show()
                Else
                    ReportsContainer.MdiParent = AppMainWindow.ActiveForm
                    ReportsContainer.SetPayrollFormStatus(False)
                    ReportsContainer.SetLoadSalarySlipReport(True)
                    ReportsContainer.Show()
                End If
            Else
                ReportsContainer.MdiParent = AppMainWindow.ActiveForm
                ReportsContainer.SetPayrollFormStatus(False)
                ReportsContainer.SetLoadSalarySlipReport(True)
                ReportsContainer.Show()
            End If
        Else
            MessageBox.Show("This option is not available in this mode!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
