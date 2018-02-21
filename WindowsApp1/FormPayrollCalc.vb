Public Class PayrollCalc
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub PayrollCalc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AppMainWindow.DisablePrintMenuItem()
    End Sub
End Class