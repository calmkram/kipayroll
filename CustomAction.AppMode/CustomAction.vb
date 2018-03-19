Imports System.Configuration
Imports System.Runtime.InteropServices

' CustomActions public class that encapsulates the ConfigureAppInstallMode function as part of the CA DLL used by the Installer application.
Public Class CustomActions

    Private Const CONST_APPSETTINGS As String = "applicationSettings"
    Private Const CONST_MYAPPSETTINGS As String = "KIPayroll.My.MySettings"
    Private Const CONST_APPMODESETTING As String = "AppMode"
    Private Const CONST_APPMODE_PARAMETER As String = "APPMODE"
    Private Const CONST_APPFILEPATH_PARAMETER As String = "APPFILEPATH"

    <CustomAction()>
    Public Shared Function ConfigureAppInstallMode(ByVal session As Session) As ActionResult
        Dim bReturnResult As Boolean = False, cAppConfig As Configuration, sAppFilePath As String = ""
        Dim secGroup As ConfigurationSectionGroup, applicationSec As ClientSettingsSection, applicationSettingCol As SettingElementCollection
        Dim myCustomData As CustomActionData, sAppInstMode As String

        Try
            session.Log("Begin ConfigureAppInstallMode")

            ' Retrieving the passed parameters from the Payroll Installer MSI
            myCustomData = session.CustomActionData
            sAppInstMode = myCustomData.Item(CONST_APPMODE_PARAMETER).ToString
            sAppFilePath = myCustomData.Item(CONST_APPFILEPATH_PARAMETER).ToString

            session.Log("Value for AppInstallMode is {0}", sAppInstMode)
            session.Log("Value for AppFilePath is {0}", sAppFilePath)

            ' Retrieving the AppMode setting from the Configuration file
            cAppConfig = ConfigurationManager.OpenExeConfiguration(sAppFilePath)
            secGroup = cAppConfig.SectionGroups(CONST_APPSETTINGS)
            applicationSec = CType(secGroup.Sections(CONST_MYAPPSETTINGS), ClientSettingsSection)
            applicationSettingCol = applicationSec.Settings

            For Each element As SettingElement In applicationSettingCol
                If element.Name = CONST_APPMODESETTING Then
                    session.Log("The default/old value for {0} is {1}", element.Name, element.Value.ValueXml.InnerText)
                    ' Setting the AppMode setting to the passed AppInstallMode parameter from the installer
                    element.Value.ValueXml.InnerText = CInt(sAppInstMode)
                    bReturnResult = True
                    session.Log("The new value for {0} is {1}", element.Name, CInt(sAppInstMode))
                End If
            Next
            If bReturnResult = True Then
                ' Saving the changes back to the Configuration file
                applicationSec.SectionInformation.ForceSave = True
                cAppConfig.Save(ConfigurationSaveMode.Full)
                session.Log("Successfully saved the App Install Mode information in the Configuration file!")
            End If

            session.Log("End ConfigureAppInstallMode")
        Catch ex As Exception
            session.Log("ERROR in custom action ConfigureAppInstallMode {0}", ex.ToString)
            Return ActionResult.Failure
        End Try

        Return ActionResult.Success
    End Function

End Class
