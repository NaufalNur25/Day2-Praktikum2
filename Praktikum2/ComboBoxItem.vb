Public Class ComboBoxItem
    Public Property DisplayText As String
    Public Property Id As Integer

    Public Sub New(displayText As String, id As Integer)
        Me.DisplayText = displayText
        Me.Id = id
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayText
    End Function
End Class