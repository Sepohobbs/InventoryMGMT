Class MainWindow 
    Dim items As New ITEMS

    Private Sub search_bttn_tran_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles search_bttn_tran.Click
        Dim item_numbers As List(Of String) = items.item_number
        Dim prices As List(Of Double) = items.price
        Dim in_stock As List(Of Integer) = items.stock


        For Each x In items.item_number
            If items.item_number.Contains(search_txtbox_tran.Text) Then
                listbox_item_tran.Items.Add(item_numbers(x))
                listbox_price_tran.Items.Add(prices(x))
                listbox_stock_tran.Items.Add(in_stock(x))

                'trying to find a way to refresh the items shown in listbox_stock_tran
                'after i click to search they dont show but the break points lead me to believe that are being added

            End If

        Next


    End Sub


    Public Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        'Load default items
        items.item_number.Add("1111")
        items.price.Add(9.99)
        items.stock.Add(4)

        items.item_number.Add("1112")
        items.price.Add(3.49)
        items.stock.Add(20)

        items.item_number.Add("1113")
        items.price.Add(1.99)
        items.stock.Add(10)

        items.item_number.Add("1114")
        items.price.Add(20.0)
        items.stock.Add(15)

        Dim item_numbers As List(Of String) = items.item_number
        Dim prices As List(Of Double) = items.price
        Dim in_stock As List(Of Integer) = items.stock


        For x = 0 To item_numbers.Count
            listbox_item_inv.Items.Add(item_numbers(x))
            listbox_price_inv.Items.Add(prices(x))
            listbox_stock_inv.Items.Add(in_stock(x))
        Next


    End Sub
End Class
