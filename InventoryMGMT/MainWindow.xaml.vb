Class MainWindow 
    Dim items As New ITEMS

    Private Sub search_bttn_tran_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles search_bttn_tran.Click
        Dim item_numbers As List(Of String) = items.item_number
        Dim prices As List(Of Double) = items.price
        Dim in_stock As List(Of Integer) = items.stock


        listbox_item_tran.Items.Clear()
        listbox_price_tran.Items.Clear()
        listbox_stock_tran.Items.Clear()

        For x = 0 To item_numbers.Count - 1


            'If items.item_number.Contains(search_txtbox_tran.Text) Then
            If items.item_number(x) = search_txtbox_tran.Text Then

                listbox_item_tran.Items.Add(item_numbers(x))
                listbox_price_tran.Items.Add(prices(x))
                listbox_stock_tran.Items.Add(in_stock(x))


            End If

            listbox_item_tran.Items.Refresh()
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


        For x = 0 To item_numbers.Count - 1
            listbox_item_inv.Items.Add(item_numbers(x))
            listbox_price_inv.Items.Add(prices(x))
            listbox_stock_inv.Items.Add(in_stock(x))
        Next


    End Sub
    
    Private Sub search_bttn_inv_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles search_bttn_inv.Click
        Dim item_numbers As List(Of String) = items.item_number
        Dim prices As List(Of Double) = items.price
        Dim in_stock As List(Of Integer) = items.stock



        'search inv page to highlight .contains
        For x = 0 To item_numbers.Count - 1
            If items.item_number.Contains(search_txtbox_inv.Text) Then

                listbox_item_inv.Items.Add(item_numbers(x))
                listbox_price_inv.Items.Add(prices(x))
                listbox_stock_inv.Items.Add(in_stock(x))
            End If
        Next
    End Sub
End Class
