Public Class MyHourGlass
    Implements IDisposable

    Public Sub New()
        Enabled = True
    End Sub

    Public Property Enabled() As Boolean
        Get
            Return Application.UseWaitCursor
        End Get
        Set(ByVal bValue As Boolean)
            If bValue = Application.UseWaitCursor Then
                Application.UseWaitCursor = bValue
                Dim f As Form = Form.ActiveForm
                If (Not (f Is Nothing) AndAlso (Not (f.Handle = vbNull))) Then
                    SendMessage(f.Handle, &H20, f.Handle, 1)
                End If
            End If
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class