Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class CustomActions

    Private Const CONST_APPSETTINGS As String = "applicationSettings"
    Private Const CONST_MYAPPSETTINGS As String = "KIPayroll.My.MySettings"
    Private Const CONST_APPMODESETTING As String = "AppMode"

    <CustomAction()>
    Public Shared Function ConfigureAppInstallMode(ByVal session As Session) As ActionResult
        Dim bReturnResult As Boolean = False, cAppConfig As Configuration, sAppFilePath As String = ""
        Dim secGroup As ConfigurationSectionGroup, applicationSec As ClientSettingsSection, applicationSettingCol As SettingElementCollection

        Try
            session.Log("Begin ConfigureAppInstallMode")

            session.Log("Value for AppInstaMode is {0}", session("APPINSTMODE"))

            ' Retrieve App Config from the application's app.config file
            session.Log("Value for AppFilePath is {0}", session("APPFILEPATH"))
            MsgBox("Value for AppFilePath is " & session("APPFILEPATH"))
            sAppFilePath = session("APPFILEPATH")
            cAppConfig = ConfigurationManager.OpenExeConfiguration(sAppFilePath)
            secGroup = cAppConfig.SectionGroups(CONST_APPSETTINGS)
            applicationSec = CType(secGroup.Sections(CONST_MYAPPSETTINGS), ClientSettingsSection)
            applicationSettingCol = applicationSec.Settings

            For Each element As SettingElement In applicationSettingCol
                If element.Name = CONST_APPMODESETTING Then
                    element.Value.ValueXml.InnerText = CInt(session("APPINSTMODE"))
                    bReturnResult = True
                    Debug.Print("The new value for " & element.Name & " is " & CInt(session("APPINSTMODE")))
                End If
            Next
            If bReturnResult = True Then
                applicationSec.SectionInformation.ForceSave = True
                cAppConfig.Save(ConfigurationSaveMode.Full)
            End If

            session.Log("End ConfigureAppInstallMode")
        Catch ex As Exception
            session.Log("ERROR in custom action ConfigureAppInstallMode {0}", ex.ToString)
            Return ActionResult.Failure
        End Try

        Return ActionResult.Success
    End Function

End Class
