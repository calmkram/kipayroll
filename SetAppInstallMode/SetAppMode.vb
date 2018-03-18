Imports System.Configuration
Imports System.Runtime.InteropServices

Namespace MyDllModule
    Public Class SetAppMode
        Private Const CON_APPSETTINGS As String = "applicationSettings"
        Private Const CON_MYAPPSETTINGS As String = ".My.MySettings"

        Public Function SetMode(ByVal iInputValue As Integer) As Boolean
            Dim bReturnResult As Boolean = False
            Dim sConfig As String, cAppConfig As System.Configuration.Configuration

            'sConfig = System.Reflection.Assembly.GetExecutingAssembly().Location
            sConfig = "C:\Users\karth\source\repos\KrithikaIndPayroll\WindowsApp1\bin\Release\KIPayroll.exe"
            cAppConfig = ConfigurationManager.OpenExeConfiguration(sConfig)

            Dim secGroup As ConfigurationSectionGroup
            secGroup = cAppConfig.SectionGroups(CON_APPSETTINGS)
            Dim applicationSec As ClientSettingsSection
            applicationSec = CType(secGroup.Sections("KIPayroll" & CON_MYAPPSETTINGS), ClientSettingsSection)
            Dim applicationSettingCol As SettingElementCollection
            applicationSettingCol = applicationSec.Settings

            For Each element As SettingElement In applicationSettingCol
                If element.Name = "AppMode" Then
                    element.Value.ValueXml.InnerText = iInputValue
                    bReturnResult = True
                End If
            Next
            If bReturnResult = True Then
                applicationSec.SectionInformation.ForceSave = True
                cAppConfig.Save(ConfigurationSaveMode.Full)
            End If

            SetMode = bReturnResult
        End Function

        Public Function GetMode() As Integer
            Dim iAppModeValue As Integer = -1
            Dim sConfig As String, cAppConfig As System.Configuration.Configuration

            sConfig = "C:\Users\karth\source\repos\KrithikaIndPayroll\WindowsApp1\bin\Release\KIPayroll.exe"
            cAppConfig = ConfigurationManager.OpenExeConfiguration(sConfig)

            Dim secGroup As ConfigurationSectionGroup
            secGroup = cAppConfig.SectionGroups(CON_APPSETTINGS)
            Dim applicationSec As ClientSettingsSection
            applicationSec = CType(secGroup.Sections("KIPayroll" & CON_MYAPPSETTINGS), ClientSettingsSection)
            Dim applicationSettingCol As SettingElementCollection
            applicationSettingCol = applicationSec.Settings

            For Each element As SettingElement In applicationSettingCol
                If element.Name = "AppMode" Then
                    iAppModeValue = CInt(element.Value.ValueXml.InnerText)
                    Debug.Print("The value for " & element.Name & " is " & element.Value.ValueXml.InnerText)
                End If
            Next

            GetMode = iAppModeValue
        End Function
    End Class
End Namespace
