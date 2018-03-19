Imports SetAppInstallMode.MyDllModule.SetAppMode

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testObj As SetAppInstallMode.MyDllModule.SetAppMode

        testObj = New SetAppInstallMode.MyDllModule.SetAppMode
        TextBox1.Text = testObj.GetMode("C:\Users\karth\source\repos\KrithikaIndPayroll\WindowsApp1\bin\Release\KIPayroll.exe").ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim testObj As SetAppInstallMode.MyDllModule.SetAppMode

        testObj = New SetAppInstallMode.MyDllModule.SetAppMode
        If testObj.SetMode(CInt(TextBox2.Text), "C:\Users\karth\source\repos\KrithikaIndPayroll\WindowsApp1\bin\Release\KIPayroll.exe") Then
            Me.Text = "Successfully set mode and saved config file"
        End If
    End Sub
End Class
