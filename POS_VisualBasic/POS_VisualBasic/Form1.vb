'Any event handlers for buttons that don't have any functionality are simply for ui layout 
Public Class Form1

    'This function uses a for loop to go through the index of items in the transaction table
    'and calculate the sums/costs of all the items
    Private Function Transaction() As Double
        Dim index As Integer = 0
        Dim itm_total As Double = 0
        'for loop iterates from first indexed item in transaction table to the last indexed item
        For index = 0 To TransactionTable.Rows.Count - 1
            'adds value of item onto the total specified by the current index and item cost
            'Convert is used to convert the string form of the item value to a double
            itm_total = itm_total + Convert.ToDouble(TransactionTable.Rows(index).Cells(2).Value)
        Next index
        Return itm_total

    End Function

    'This function calculates the tax amount of the items, calculates transaction total(not-adjusted by tax or subtotal)
    'calculates transaction total after adjusted for tax(Total)
    'ToString() for dollar and cent format
    Sub Calc_FinalTotals()
        Dim CaliforniaTax As Double
        Dim TaxAdjustment As Double
        CaliforniaTax = 7.2 / 100.0

        If TransactionTable.Rows.Count > 0 Then
            TaxAdjustment = ((Transaction() * CaliforniaTax))
            TransactionSubTotal.Text = Transaction().ToString("0.00")
            MandatoryStoreTax.Text = ((Transaction() * CaliforniaTax)).ToString("0.00")
            TransactionTotal.Text = TaxAdjustment + Transaction().ToString("0.00")
        End If
    End Sub

    'This function performs a sub procedure but does not return any value
    'Specifically is meant to calculate the correct amount of change to a customer after a transaction is 
    'successfully completed
    Sub Calc_FinalChangeAmount()
        Dim CaliforniaTax As Double
        Dim TaxAdjustment As Double
        Dim CashAmount As Double
        CaliforniaTax = 7.2 / 100.0
        If TransactionTable.Rows.Count > 0 Then
            'val returns the value within the String Cash Amount and converts it into a double to be stored
            CashAmount = Val(CustomerCashAmount.Text)
            TaxAdjustment = ((Transaction() * CaliforniaTax)) + Transaction()
            CustomerChange.Text = (CashAmount - TaxAdjustment).ToString("0.00")
        End If
    End Sub
    Private Sub TransactionTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionTable.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentMethod.SelectedIndexChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    'This function is for the resetting of the entire system which includes mainly the transaction in progress
    'and any attributes/buttons that coincide with the transaction
    'This is also known as an event handler for providing functionality when the reset transaction button is clicked
    'Everything here is set to an empty string to signify a reset
    Private Sub ResetTransaction_Click(sender As Object, e As EventArgs) Handles ResetTransaction.Click
        MandatoryStoreTax.Text = ""
        CustomerCashAmount.Text = ""
        TransactionSubTotal.Text = ""
        PaymentMethod.Text = ""
        TransactionTotal.Text = ""
        CustomerChange.Text = ""
        'clears the collection 
        TransactionTable.Rows.Clear()
        'redraws the controls/child controls
        TransactionTable.Refresh()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    'event handler for allowing keypad buttons to be databinded to the customer cash amount
    Private Sub Keypad_Click(sender As Object, e As EventArgs) Handles keypadDecimal.Click, keypad0.Click, keypad1.Click, keypad2.Click, keypad3.Click, keypad4.Click, keypad5.Click, keypad6.Click, keypad7.Click, keypad8.Click, keypad9.Click

        'declares the all of the keypad buttons as type button
        Dim keypadButton As Button = sender

        'if the customer cash amount is currently 0 then the customer cash amount will equal the next keypad button value selected
        If (CustomerCashAmount.Text = "0") Then

            CustomerCashAmount.Text = ""

            CustomerCashAmount.Text = keypadButton.Text

            'if the keypad button selected containing "." is selected then check if the customer cash amount does not contain "."
            'already and if it doesn't contain "." then add on the "." to the customer cash amount
        ElseIf (keypadButton.Text = ".") Then
            If (Not CustomerCashAmount.Text.Contains(".")) Then
                CustomerCashAmount.Text = CustomerCashAmount.Text + keypadButton.Text
            End If
        Else
            'if the customer cash amount has any other value besides "0" and "."
            'then add on the next keypad value selected to the current cash amount
            CustomerCashAmount.Text = CustomerCashAmount.Text + keypadButton.Text
        End If
    End Sub

    'Combobox allows for selection of payment methods for any transaction 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaymentMethod.Items.Add("Credit")
        PaymentMethod.Items.Add("Cash")
        PaymentMethod.Items.Add("Debit")
    End Sub

    'This event handler allows for the keypad clear button to clear customer cash amount, payment method and customer change
    'This is used for when a mistake in keypad inputs occurs on the user end
    Private Sub keypadClear_Click(sender As Object, e As EventArgs) Handles keypadClear.Click
        CustomerCashAmount.Text = ""
        PaymentMethod.Text = ""
        CustomerChange.Text = ""
    End Sub

    'Event handler for allowing payment to be confirmed based on customer cash amount entered and proceeds to calculate
    'the final change amount for the customer
    'Else if the payment method is not cash then nothing occurs
    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles Payment.Click

        If (PaymentMethod.Text = "Cash") Then
            Calc_FinalChangeAmount()
        Else
            CustomerCashAmount.Text = ""
            CustomerChange.Text = ""
        End If
    End Sub

    'Event handler iterates through selected item rows of type DataGridViewRow in the transaction table
    'and removes the selected rows and calculates new transaction totals
    Private Sub RemoveItem_Click(sender As Object, e As EventArgs) Handles RemoveItem.Click
        For Each itemIndex As DataGridViewRow In TransactionTable.SelectedRows
            TransactionTable.Rows.Remove(itemIndex)
        Next
        Calc_FinalTotals()
    End Sub


    Private printLayout As Bitmap 'bitmap here is used for working with images such as print previews and printing setup
    Private Sub Print_Click(sender As Object, e As EventArgs) Handles PrintReceipt.Click
        'printLayout is used to store pixel data on the width and height of the transaction table for creating the print preview
        'and initializing the new instance of Bitmap
        printLayout = New Bitmap(Me.TransactionTable.Width, Me.TransactionTable.Height)
        TransactionTable.DrawToBitmap(printLayout, New Rectangle(0, 0, Me.TransactionTable.Width, Me.TransactionTable.Height))
        'sets the document that we are going to preview in this case it's the document containing the transaction table
        PrintSetup.Document = Invoice
        'when the document we want to print is being previewed the PrintPreviewControl.Zoom helps to adjust zoom level of the document
        PrintSetup.PrintPreviewControl.Zoom = 1.5
        'The print preview is in the form of a dialog box
        PrintSetup.ShowDialog()
    End Sub

    'Event handler for when BEERANDNACHOS are clicked. Iterates through all the transaction rows with BEER AND NACHOS
    'to increment item quantity and item value for the totals
    Private Sub BEERANDNACHOS_Click(sender As Object, e As EventArgs) Handles BEERANDNACHOS.Click
        Dim ItemVal As Double = 7.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "BEER AND NACHOS" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("BEER AND NACHOS", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lblTax_Click(sender As Object, e As EventArgs) Handles MandatoryStoreTax.Click

    End Sub

    'Event handler for updating the all the totals and for preventing any value mismatching
    Private Sub CalcTotals_Click(sender As Object, e As EventArgs) Handles CalcTotals.Click
        For Each row As DataGridViewRow In TransactionTable.SelectedRows
            TransactionTable.Rows.Remove(row)
        Next
        Calc_FinalTotals()
    End Sub

    'Event handler for when SALADANDSAUSAGE are clicked. Iterates through all the transaction rows with SALAD AND SAUSAGE
    'to increment item quantity and item value for the totals
    Private Sub SALADANDSAUSAGE_Click(sender As Object, e As EventArgs) Handles SALADANDSAUSAGE.Click
        Dim ItemVal As Double = 6.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "SALAD AND SAUSAGE" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("SALAD AND SAUSAGE", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when TASTYMEAT are clicked. Iterates through all the transaction rows with TASTY MEAT
    'to increment item quantity and item value for the totals
    Private Sub TASTYMEAT_Click(sender As Object, e As EventArgs) Handles TASTYMEAT.Click
        Dim ItemVal As Double = 5.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "TASTY MEAT" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("TASTY MEAT", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when CINEMAFOOD are clicked. Iterates through all the transaction rows with CINEMA FOOD
    'to increment item quantity and item value for the totals
    Private Sub CINEMAFOOD_Click(sender As Object, e As EventArgs) Handles CINEMAFOOD.Click
        Dim ItemVal As Double = 7.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "CINEMA FOOD" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("CINEMA FOOD", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when TASTYTACOS are clicked. Iterates through all the transaction rows with TASTY TACOS
    'to increment item quantity and item value for the totals
    Private Sub TASTYTACOS_Click(sender As Object, e As EventArgs) Handles TASTYTACOS.Click
        Dim ItemVal As Double = 6.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "TASTY TACOS" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("TASTY TACOS", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when QUESADILLA are clicked. Iterates through all the transaction rows with QUESADILLA
    'to increment item quantity and item value for the totals
    Private Sub QUESADILLA_Click(sender As Object, e As EventArgs) Handles QUESADILLA.Click
        Dim ItemVal As Double = 3.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "QUESADILLA" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("QUESADILLA", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when ICECREAM are clicked. Iterates through all the transaction rows with ICECREAM
    'to increment item quantity and item value for the totals
    Private Sub ICECREAM_Click(sender As Object, e As EventArgs) Handles ICECREAM.Click
        Dim ItemVal As Double = 1.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "ICECREAM" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("ICECREAM", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when FALAFEL are clicked. Iterates through all the transaction rows with FALAFEL
    'to increment item quantity and item value for the totals
    Private Sub FALAFEL_Click(sender As Object, e As EventArgs) Handles FALAFEL.Click
        Dim ItemVal As Double = 4.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "FALAFEL" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("FALAFEL", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when MEXICANDISHES are clicked. Iterates through all the transaction rows with MEXICAN DISHES
    'to increment item quantity and item value for the totals
    Private Sub MEXICANDISHES_Click(sender As Object, e As EventArgs) Handles MEXICANDISHES.Click
        Dim ItemVal As Double = 3.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "MEXICAN DISHES" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("MEXICAN DISHES", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when SWEETDONUTS are clicked. Iterates through all the transaction rows with SWEET DONUTS
    'to increment item quantity and item value for the totals
    Private Sub SWEETDONUTS_Click(sender As Object, e As EventArgs) Handles SWEETDONUTS.Click
        Dim ItemVal As Double = 1.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "SWEET DONUTS" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("SWEET DONUTS", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when SANDWICH are clicked. Iterates through all the transaction rows with SANDWICH
    'to increment item quantity and item value for the totals
    Private Sub SANDWICH_Click(sender As Object, e As EventArgs) Handles SANDWICH.Click
        Dim ItemVal As Double = 5.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "SANDWICH" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("SANDWICH", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when FRESHDRINKS are clicked. Iterates through all the transaction rows with FRESH DRINKS
    'to increment item quantity and item value for the totals
    Private Sub FRESHDRINKS_Click(sender As Object, e As EventArgs) Handles FRESHDRINKS.Click
        Dim ItemVal As Double = 9.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "FRESH DRINKS" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("FRESH DRINKS", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when BURRITOS are clicked. Iterates through all the transaction rows with BURRITOS
    'to increment item quantity and item value for the totals
    Private Sub BURRITOS_Click(sender As Object, e As EventArgs) Handles BURRITOS.Click
        Dim ItemVal As Double = 8.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "BURRITOS" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("BURRITOS", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when TASTYSAUCES are clicked. Iterates through all the transaction rows with TASTY SAUCES
    'to increment item quantity and item value for the totals
    Private Sub TASTYSAUCES_Click(sender As Object, e As EventArgs) Handles TASTYSAUCES.Click
        Dim ItemVal As Double = 5.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "TASTY SAUCES" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("TASTY SAUCES", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler for when FRESHPIZZA are clicked. Iterates through all the transaction rows with FRESH PIZZA
    'to increment item quantity and item value for the totals
    Private Sub FRESHPIZZA_Click(sender As Object, e As EventArgs) Handles FRESHPIZZA.Click
        Dim ItemVal As Double = 9.0
        For Each ItemIndex As DataGridViewRow In TransactionTable.Rows
            'row.Cells(0) in the transaction table refers to item name
            If ItemIndex.Cells(0).Value = "FRESH PIZZA" Then
                'row.Cells(1) in the transaction table refers to item quantity
                ItemIndex.Cells(1).Value = Double.Parse(ItemIndex.Cells(1).Value + 1)
                'row.Cells(2) in the transaction table refers to item value
                ItemIndex.Cells(2).Value = Double.Parse(ItemIndex.Cells(1).Value) * ItemVal
                Exit Sub
            End If
        Next
        TransactionTable.Rows.Add("FRESH PIZZA", "1", ItemVal)
        Calc_FinalTotals()
    End Sub

    'Event handler used for drawing the print layout at location 30, 30 in general is used for printing the document
    Private Sub Invoice_PrintPage(sender As Object, myInvoicePage As Printing.PrintPageEventArgs) Handles Invoice.PrintPage
        myInvoicePage.Graphics.DrawImage(printLayout, 30, 30)
    End Sub
End Class
