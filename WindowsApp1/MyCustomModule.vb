Imports System.Runtime.InteropServices

Module MyCustomModule
    Public Structure AppSettings
        Private p_sConnectionString As String
        Private p_sAppMode As String

        Public Function SetConnectionString(sConnectString As String) As Boolean
            p_sConnectionString = sConnectString
            SetConnectionString = True
        End Function
        Public Function GetConnectionString()
            GetConnectionString = p_sConnectionString
        End Function
        Public Function SetAppMode(sValue As String) As Boolean
            p_sAppMode = sValue
            SetAppMode = True
        End Function
        Public Function GetAppMode()
            GetAppMode = p_sAppMode
        End Function
    End Structure

    <DllImport("user32")>
    Public Function SendMessage(ByVal hWnd As Integer,
                            ByVal msg As UInteger,
                            ByVal wp As Integer,
                            ByVal lp As Integer) As Integer
    End Function
End Module
