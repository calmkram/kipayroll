Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim sApplicationTitle As String, sApplicationDescription As String
        If My.Application.Info.Title <> "" Then
            sApplicationTitle = My.Application.Info.Title
        Else
            sApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", sApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        If My.Settings.AppMode = 1 Then
            Me.LabelAppMode.Text = "Admin Mode"
        ElseIf My.Settings.AppMode = 2 Then
            Me.LabelAppMode.Text = "User Mode"
        End If
        sApplicationDescription = My.Application.Info.Description & vbCrLf & vbCrLf & "Application Log stored at: " & vbCrLf & My.Application.Log.DefaultFileLogWriter.FullLogFileName
        Me.TextBoxDescription.Text = sApplicationDescription
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class
