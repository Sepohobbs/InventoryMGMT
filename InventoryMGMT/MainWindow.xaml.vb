Class MainWindow 
    Dim items_class As New ITEMS
    Dim item_class As New ITEM_CLASS


    Private Sub search_bttn_tran_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles search_bttn_tran.Click

        Dim items_list As New List(Of ITEM_CLASS)

        'kind of works. Doesnt show in lstbox but items_list(0).item_number is grabbibg the right number 
        listbox_item_tran.Items.Add(items_list(0).item_number)
        listbox_item_tran.Items.Refresh()

        'Dim item_numbers As List(Of String) = items_class.item_number
        'Dim prices As List(Of Double) = items_class.price
        'Dim in_stock As List(Of Integer) = items_class.stock


        'listbox_item_tran.Items.Clear()
        'listbox_price_tran.Items.Clear()
        'listbox_stock_tran.Items.Clear()

        'For x = 0 To item_numbers.Count - 1


        '    'If items.item_number.Contains(search_txtbox_tran.Text) Then
        '    If items_class.item_number(x) = search_txtbox_tran.Text Then

        '        listbox_item_tran.Items.Add(item_numbers(x))
        '        listbox_price_tran.Items.Add(prices(x))
        '        listbox_stock_tran.Items.Add(in_stock(x))


        '    End If

        '    listbox_item_tran.Items.Refresh()
        'Next

    End Sub


    Public Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        Dim items_list As New List(Of ITEM_CLASS)

        'MUCH BETTER THAN BEFORE!
        'CAN NOW STORE MULTIPLE LISTS IN ONE VAR!!


        'listbox_item_tran.Items.Add(item_class.item_number(0))
        ' somehting like this for adding to txt box
        'everything is a mess right now but this is whats important!!

        Dim current_item As New ITEM_CLASS


        For x = 0 To 1
            current_item.item_number = "1111"
            current_item.price = 12.99
            current_item.stock = 4

            items_list.Add(current_item)

            current_item.item_number = "1112"
            current_item.price = 3.49
            current_item.stock = 20

            items_list.Add(current_item)


        Next

        

        ''Load default items
        'items_class.item_number.Add("1111")
        'items_class.price.Add(9.99)
        'items_class.stock.Add(4)

        'items_class.item_number.Add("1112")
        'items_class.price.Add(3.49)
        'items_class.stock.Add(20)

        'items_class.item_number.Add("1113")
        'items_class.price.Add(1.99)
        'items_class.stock.Add(10)

        'items_class.item_number.Add("1114")
        'items_class.price.Add(20.0)
        'items_class.stock.Add(15)

        'Dim item_numbers As List(Of String) = items_class.item_number
        'Dim prices As List(Of Double) = items_class.price
        'Dim in_stock As List(Of Integer) = items_class.stock


        'For x = 0 To item_numbers.Count - 1
        '    listbox_item_inv.Items.Add(item_numbers(x))
        '    listbox_price_inv.Items.Add(prices(x))
        '    listbox_stock_inv.Items.Add(in_stock(x))
        'Next


    End Sub

    Private Sub search_bttn_inv_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles search_bttn_inv.Click
        'Dim item_numbers As List(Of String) = items_class.item_number
        'Dim prices As List(Of Double) = items_class.price
        'Dim in_stock As List(Of Integer) = items_class.stock


        'does not work yet
        'search inv page to highlight .contains
        '    For x = 0 To item_numbers.Count - 1
        '        If items_class.item_number.Contains(search_txtbox_inv.Text) Then

        '            listbox_item_inv.Items.Add(item_numbers(x))
        '            listbox_price_inv.Items.Add(prices(x))
        '            listbox_stock_inv.Items.Add(in_stock(x))
        '        End If
        '    Next
    End Sub


End Class
