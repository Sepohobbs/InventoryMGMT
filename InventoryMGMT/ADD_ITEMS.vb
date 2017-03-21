Public Class ADD_ITEMS

    Shared item_number_list As New List(Of String)
    Shared price_list As New List(Of Double)
    Shared stock_list As New List(Of Integer)

    Public Shared Sub add_item(ByVal item_number As String, ByVal price As Double, ByVal stock As Integer)
        item_number_list.Add(item_number)
        price_list.Add(price)
        stock_list.Add(stock)

    End Sub

End Class
