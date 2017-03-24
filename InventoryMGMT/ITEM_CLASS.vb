Public Class ITEM_CLASS

    Public item_number As String
    Public price As Double
    Public stock As Integer

    Public Sub New(ByVal item_number As String, ByVal price As Double, ByVal stock As Integer)
        Me.item_number = item_number
        Me.price = price
        Me.stock = stock
    End Sub

    'overrides .tostring for this class only
    Public Overrides Function ToString() As String
        Dim item_string As String = ("item number = " & item_number & " | price = " & price & " | stock = " & stock)

        Return item_string
    End Function


End Class
