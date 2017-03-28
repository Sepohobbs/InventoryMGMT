Class MainWindow 
    Dim items_list As New List(Of ITEM_CLASS)
    Dim search_list As New List(Of ITEM_CLASS)
    Dim purchase_list As New List(Of ITEM_CLASS)

    Dim temp_stock As New List(Of Integer)

    Private Sub search_bttn_tran_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles search_bttn_tran.Click
        Dim found_index As Integer = search(search_txtbox_tran.Text, items_list)

        If found_index <> -1 Then
            search_list.Clear()

            search_list.Add(items_list(found_index))
            listbox_tran.ItemsSource = search_list
            listbox_tran.Items.Refresh()

        Else
            listbox_tran.Items.Add("Not found")
        End If

    End Sub


    Public Function search(ByVal item_number As String, ByVal list As List(Of ITEM_CLASS))

        For x As Integer = 0 To list.Count - 1
            If item_number = list(x).item_number Then
                Return x

            End If
        Next
        'once a function returns it doesnt continue down the function (if it returns X it wont make it to -1)
        Return -1

    End Function


    Public Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        Dim current_item1 As New ITEM_CLASS("1111", 12.99, 4)
        items_list.Add(current_item1)

        Dim current_item2 As New ITEM_CLASS("2222", 3.99, 20)
        items_list.Add(current_item2)

        Dim current_item3 As New ITEM_CLASS("1122", 5.99, 10)
        items_list.Add(current_item3)

        Dim current_item4 As New ITEM_CLASS("2233", 3.5, 11)
        items_list.Add(current_item4)

        Dim current_item5 As New ITEM_CLASS("1234", 4.25, 22)
        items_list.Add(current_item5)

        listbox_inv.ItemsSource = items_list

    End Sub


    Private Sub add_bttn_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles add_bttn.Click
        Dim total_price_current As Double = 0

        purchase_list.Add(search_list(0))
        listbox_purchase.ItemsSource = purchase_list
        listbox_purchase.Items.Refresh()

        For current_item_index = 0 To purchase_list.Count - 1
            total_price_current += purchase_list(current_item_index).price

        Next

        'adds a temp stock to keep from going negative
        temp_stock.Add(purchase_list(purchase_list.Count - 1).stock)

        label_price_currect.Content = total_price_current

    End Sub

   
    Private Sub search_txtbox_inv_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.TextChangedEventArgs) Handles search_txtbox_inv.TextChanged
        Dim search_results As New List(Of ITEM_CLASS)

        For x As Integer = 0 To items_list.Count - 1
            If items_list(x).item_number.StartsWith(search_txtbox_inv.Text) Then
                search_results.Add(items_list(x))

            End If

        Next
        listbox_inv.ItemsSource = search_results
        listbox_inv.Items.Refresh()
    End Sub

    Private Sub purchase_bttn_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles purchase_bttn.Click
        Dim total_price_final As Double = 0


        For current_item_index = 0 To purchase_list.Count - 1
            total_price_final += purchase_list(current_item_index).price
        Next


        For current_item_index = 0 To purchase_list.Count - 1
            purchase_list(current_item_index).stock = purchase_list(current_item_index).stock - 1

        Next
        listbox_inv.Items.Refresh()

        MessageBox.Show(total_price_final)

    End Sub
End Class
