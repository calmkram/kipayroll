Imports System
Imports System.Windows.Forms

Public Class CalendarColumn
    Inherits DataGridViewColumn

    Private mFormat As String = ""
    Private mShowUpDown As Boolean = False

    <System.ComponentModel.Category("Behavior"),
    System.ComponentModel.Description("Date/Time Format"),
    System.ComponentModel.DefaultValue(GetType(String), "d")>
    Public Property DateTimeFormat() As String
        Get
            Return mFormat
        End Get
        Set(value As String)
            mFormat = value
        End Set
    End Property

    <System.ComponentModel.Category("Behavior"),
    System.ComponentModel.Description("Show UpDown Button"),
    System.ComponentModel.DefaultValue(False)>
    Public Property ShowUpDown() As String
        Get
            Return mShowUpDown
        End Get
        Set(value As String)
            mShowUpDown = value
        End Set
    End Property

    ' This is required to persist my custom property DateFormat
    Public Overrides Function Clone() As Object
        Dim TheCopy As CalendarColumn = DirectCast(MyBase.Clone(), CalendarColumn)
        TheCopy.DateTimeFormat = Me.DateTimeFormat
        TheCopy.ShowUpDown = Me.ShowUpDown
        Return TheCopy
    End Function

    Public Sub New()
        MyBase.New(New CalendarCell())
    End Sub

    Public Overrides Property CellTemplate As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            'Ensure that the cell used for the template is a CalendarCell
            If value IsNot Nothing AndAlso Not value.GetType().IsAssignableFrom(GetType(CalendarCell)) Then
                Throw New InvalidCastException("Must be a CalendarCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class CalendarCell
    Inherits DataGridViewTextBoxCell

    Public Sub New()
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object,
                                                    ByVal dataGridViewCellStyle As DataGridViewCellStyle)
        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue,
            dataGridViewCellStyle)

        Dim TheControl As CalendarEditingCtrl = CType(DataGridView.EditingControl, CalendarEditingCtrl)
        If Not Me.Value.GetType Is GetType(DateTime) Then
            Me.Value = Now
        End If

        TheControl.Value = CType(Me.Value, DateTime)
        Dim myOwner As CalendarColumn = CType(OwningColumn, CalendarColumn)
        Me.Style.Format = myOwner.DateTimeFormat
        TheControl.Format = DateTimePickerFormat.Custom
        TheControl.CustomFormat = myOwner.DateTimeFormat
        TheControl.ShowUpDown = myOwner.ShowUpDown

        ' Use the default row value when Value property is null.
        If (Me.Value Is Nothing OrElse IsDBNull(Me.Value)) Then
            TheControl.Value = CType(Me.DefaultNewRowValue, DateTime)
        Else
            TheControl.Value = CType(Me.Value, DateTime)
        End If
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Return the type of the editing control that CalendarCell uses.
            Return GetType(CalendarEditingCtrl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' Return the type of the value that CalendarCell contains.
            Return GetType(DateTime)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Changed to DBNull.Value
            Return DBNull.Value
        End Get
    End Property
End Class

Public Class CalendarEditingCtrl
    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer

    Public Sub New()
        Me.Format = DateTimePickerFormat.Custom
    End Sub

    Public Property EditingControlFormattedValue() As Object _
        Implements IDataGridViewEditingControl.EditingControlFormattedValue

        Get
            Return Me.Value.ToString(Me.CustomFormat)
        End Get

        Set(ByVal value As Object)
            If TypeOf value Is [String] Then
                Me.Value = DateTime.Parse(CStr(value))
            End If
        End Set
    End Property

    Public Function GetEditingControlFormattedValue(ByVal context As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue

        Return Me.Value.ToString(Me.CustomFormat)
    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
    End Sub

    Public Property EditingControlRowIndex() As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex

        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set
    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys,
        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey

        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return False
        End Select
    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

        ' No preparation needs to be done.
    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean _
        Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange

        Get
            Return False
        End Get
    End Property

    Public Property EditingControlDataGridView() As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView

        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As DataGridView)
            dataGridViewControl = value
        End Set
    End Property

    Public Property EditingControlValueChanged() As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged

        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set
    End Property

    Public ReadOnly Property EditingControlCursor() As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor

        Get
            Return MyBase.Cursor
        End Get
    End Property

    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)
        ' Notify the DataGridView that the contents of the cell have changed.
        valueIsChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)
    End Sub
End Class
