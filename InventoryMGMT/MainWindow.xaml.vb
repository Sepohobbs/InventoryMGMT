Class MainWindow 
    Dim add_items_class As New ADD_ITEMS


    'Maybe just put it all in main.....


    'Dim item_number_list As New List(Of String)
    'Dim price_list As New List(Of Double)
    'Dim stock_list As New List(Of Integer)

    'Public Sub add_item(ByVal item_number As String, ByVal price As Double, ByVal stock As Integer)
    '    item_number_list.Add(item_number)
    '    price_list.Add(price)
    '    stock_list.Add(stock)

    'End Sub

    'classes are broken. i cant get them to work. Try just doing ti all in main i guess........

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click

        ADD_ITEMS.add_item(1111, 9.99, 3)


        Dim test = item_number_list

        'this stuff is too crazy.....
    End Sub

End Class
