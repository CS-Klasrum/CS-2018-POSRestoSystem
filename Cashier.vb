Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Cashier

    Private Sub Cashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connect.Close()

        Timer1.Enabled = True
        Call ShowCategory()
        Call ShowTables()
        Call ColoredTotalBill()
        Call ShowImage()
        myInvoiceNo = maxInvoiceNo()
        myInvoiceNo = myInvoiceNo.ToString.PadLeft(4, "0"c)
        lblcounter.Text = "COUNTER " & Counter
        lblinvoice.Text = YearandMonth_No & "." & Day_No & "" & Counter & "." & myInvoiceNo

    End Sub

    Sub DuplicateHistory()
        connect.Open()
        query = "Select * from history_sale where TableNo='" & lbltable.Text & "' and Description='" & Description & "' and InvoiceNo='" & lblinvoice.Text & "' order by Description ASC"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        While reader.Read
            myID = reader("ID")
            myQty = reader("Qty")
        End While
        command.Dispose()
        reader.Close()
        connect.Close()
    End Sub

    Sub ColoredTotalBill()
        For Each item As ListViewItem In lvtable.Items
            If (item.SubItems(1).Text) = "0.00" Then
                item.BackColor = Color.White
                item.ForeColor = Color.Black
            Else
                item.BackColor = Color.SkyBlue
                item.ForeColor = Color.DarkSlateGray
            End If
        Next
    End Sub

    Sub GrandTotal()
        Dim GT As Decimal
        For Each item As ListViewItem In lvdiningcart.Items
            GT += CDec(item.SubItems(3).Text)
        Next
        lblgrandtotal.Text = " " & Decimal.Round(GT, 2).ToString("#,##0.00")
        CommaGrandTotal = Decimal.Round(GT, 2).ToString("#,##0.00")
        NoCommaGrandTotal = Decimal.Round(GT, 2).ToString("f2")
    End Sub

    Sub ShowTotalbill()
        connect.Open()
        query = "Select * from tbltable where TableNo='" & lbltable.Text & "'"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        While reader.Read
            TB = reader("TotalBill")
        End While
        command.Dispose()
        reader.Close()
        connect.Close()
    End Sub

    Sub ShowDiningCart()
        connect.Close()

        connect.Open()
        lvdiningcart.Items.Clear()
        query = "Select * from history_sale where TableNo='" & lbltable.Text & "' and not Remarks='SOLD' order by ID ASC"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        While reader.Read
            With lvdiningcart.Items.Add(reader("Description"))
                .SubItems.Add(reader("Price"))
                .SubItems.Add(reader("Qty"))
                .SubItems.Add(reader("Subtotal"))
                .SubItems.Add(reader("ID"))
                .SubItems.Add(reader("InvoiceNo"))
                lblinvoice.Text = reader("InvoiceNo")
            End With
        End While
        command.Dispose()
        reader.Close()
        connect.Close()
    End Sub

    Sub ShowImage()
        connect.Open()
        lvsamgyup.Items.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        lvsamgyup.LargeImageList = imglist
        lvsamgyup.LargeImageList.ImageSize = New System.Drawing.Size(125, 125)
        query = "Select * from tblproducts where Status='Available' order by Description ASC"
        Dim dt_images As New DataTable
        command.Connection = connect
        command.CommandText = query

        adapter = New MySqlDataAdapter
        adapter.SelectCommand = command
        adapter.Fill(dt_images)

        For Each dr As DataRow In dt_images.Rows
            Dim img_buffer = CType(dr("myImage"), Byte())
            Dim img_stream As New MemoryStream(img_buffer, True)
            img_stream.Write(img_buffer, 0, img_buffer.Length)
            imglist.Images.Add(dr("ID").ToString, New Bitmap(img_stream))
            img_stream.Close()

            Dim LVI As New ListViewItem
            LVI.ToolTipText = dr("Category").ToString
            LVI.Text = dr("Description").ToString & vbCrLf & dr("Price").ToString
            LVI.Name = dr("Description").ToString
            LVI.ImageKey = dr("ID").ToString
            lvsamgyup.Items.Add(LVI)
            lvsamgyup.Focus()

        Next
        For i As Integer = 0 To lvsamgyup.Items.Count - 1
            If i Mod 2 Then
                lvsamgyup.Items(i).BackColor = Color.SkyBlue
                lvsamgyup.Items(i).ForeColor = Color.DarkSlateGray
            Else
                lvsamgyup.Items(i).BackColor = Color.LightBlue
                lvsamgyup.Items(i).ForeColor = Color.DarkSlateGray
            End If
        Next
        connect.Close()

    End Sub

    Sub Search(ByVal searchProduct As String)
        connect.Open()
        lvsamgyup.Items.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        lvsamgyup.LargeImageList = imglist
        lvsamgyup.LargeImageList.ImageSize = New System.Drawing.Size(125, 125)
        query = "Select * from tblproducts where Description like '" & searchProduct & "%' and Status='Available' order by Description ASC"

        Dim dt_images As New DataTable
        command.Connection = connect
        command.CommandText = query

        adapter = New MySqlDataAdapter
        adapter.SelectCommand = command
        adapter.Fill(dt_images)

        For Each dr As DataRow In dt_images.Rows
            Dim img_buffer = CType(dr("myImage"), Byte())
            Dim img_stream As New MemoryStream(img_buffer, True)
            img_stream.Write(img_buffer, 0, img_buffer.Length)
            imglist.Images.Add(dr("ID").ToString(), New Bitmap(img_stream))
            img_stream.Close()

            Dim LVI As New ListViewItem
            LVI.ToolTipText = dr("Category").ToString
            LVI.Text = dr("Description").ToString & vbCrLf & dr("Price").ToString
            LVI.Name = dr("Description").ToString
            LVI.ImageKey = dr("ID").ToString
            lvsamgyup.Items.Add(LVI)

        Next
        For i As Integer = 0 To lvsamgyup.Items.Count - 1
            If i Mod 2 Then
                lvsamgyup.Items(i).BackColor = Color.SkyBlue
                lvsamgyup.Items(i).ForeColor = Color.DarkSlateGray
            Else
                lvsamgyup.Items(i).BackColor = Color.LightBlue
                lvsamgyup.Items(i).ForeColor = Color.DarkSlateGray
            End If
        Next
        connect.Close()
    End Sub

    Sub ShowTables()
        connect.Open()
        lvtable.Items.Clear()
        query = "Select * from tbltable order by TableNo ASC"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        While reader.Read
            With lvtable.Items.Add(reader("TableNo"))
                .subitems.add(reader("TotalBill"))
            End With
        End While
        command.Dispose()
        reader.Close()
        connect.Close()
    End Sub

    Sub ShowCategory()
        connect.Open()
        lvcategory.Items.Clear()
        query = "Select * from tblcategory order by Category ASC"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        While reader.Read
            With lvcategory.Items.Add(reader("Category"))

            End With
        End While
        command.Dispose()
        reader.Close()
        connect.Close()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBox("Are you sure you want to Exit Appication?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Application.Exit()
        Else
            txtsearch.Focus()
        End If
    End Sub

    Private Sub btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = Format(DateTime.Now, "hh:mm:ss tt")
        lbldateandday.Text = myDate.ToString("MMMM dd, yyyy") & " | " & myDate.ToString("dddd")

    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click

        If MsgBox("Are you sure you want to Logout?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Me.Dispose()
            Form1.Show()
        Else
            txtsearch.Focus()
        End If
    End Sub

    Private Sub lvtable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvtable.SelectedIndexChanged
        btnvoid.Enabled = False
        With lvtable.FocusedItem
            lbltable.Text = .SubItems(0).Text
            myTableNo = .SubItems(0).Text
            myTotalBill = .SubItems(1).Text
        End With
        lbltable.Text = myTableNo
        If Not TotalBill = "0.00" Then
            Call ShowDiningCart()
            Call GrandTotal()
        Else
            lvdiningcart.Items.Clear()
            lblgrandtotal.Text = "0.00"
            btncash.Enabled = False
            Price = Nothing
            Subtotal = Nothing
        End If
    End Sub

    Private Sub btnpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpass.Click
        txtsearch.Focus()
        With frmChangePass
            .ShowDialog()
        End With
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = "" Then
            Call ShowImage()
        Else
            Search(txtsearch.Text)
        End If
    End Sub

    Private Sub lvcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvcategory.SelectedIndexChanged

        With lvcategory.FocusedItem
            myCategory = .SubItems(0).Text
        End With
        btnvoid.Enabled = False
        btnqty.Enabled = False

        If myCategory = "All Products" Then
            Call ShowImage()
        Else

            lvsamgyup.Items.Clear()
            Dim imglist As New ImageList
            imglist.ColorDepth = ColorDepth.Depth32Bit
            lvsamgyup.LargeImageList = imglist
            lvsamgyup.LargeImageList.ImageSize = New System.Drawing.Size(125, 125)
            query = "Select * from tblproducts where Status='Available' and Category='" & myCategory & "' order by Description ASC"

            Dim dt_images As New DataTable
            command.Connection = connect
            command.CommandText = query

            adapter = New MySqlDataAdapter
            adapter.SelectCommand = command
            adapter.Fill(dt_images)

            For Each dr As DataRow In dt_images.Rows
                Dim img_buffer = CType(dr("myImage"), Byte())
                Dim img_stream As New MemoryStream(img_buffer, True)
                img_stream.Write(img_buffer, 0, img_buffer.Length)
                imglist.Images.Add(dr("ID").ToString(), New Bitmap(img_stream))
                img_stream.Close()

                Dim LVI As New ListViewItem
                LVI.ToolTipText = dr("Category").ToString
                LVI.Text = dr("Description").ToString & vbCrLf & dr("Price").ToString
                LVI.Name = dr("Description").ToString
                LVI.ImageKey = dr("ID").ToString
                lvsamgyup.Items.Add(LVI)
                lvsamgyup.Focus()

            Next
            For i As Integer = 0 To lvsamgyup.Items.Count - 1
                If i Mod 2 Then
                    lvsamgyup.Items(i).BackColor = Color.SkyBlue
                    lvsamgyup.Items(i).ForeColor = Color.DarkSlateGray
                Else
                    lvsamgyup.Items(i).BackColor = Color.LightBlue
                    lvsamgyup.Items(i).ForeColor = Color.DarkSlateGray
                End If
            Next
            connect.Close()
        End If
    End Sub

    Private Sub lvsamgyup_MouseClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvsamgyup.MouseClick
        If lbltable.Text = "" Then
            MsgBox("Please, Select the Table No. First", MsgBoxStyle.Exclamation, "Select Table")
            lvtable.Focus()
        Else
            Call ShowTotalbill()
            Dim Qty As String = "1"
            Subtotal = Val(Price) * Val(Qty)
            TotalBill = Val(TB) + Val(Price)
            connect.Open()
            query = "Insert history_sale(InvoiceNo,TableNo,Description,Price,Qty,Subtotal)values(@i,@t,@d,@p,@q,@s)"
            command = New MySqlCommand(query, connect)
            With command.Parameters
                .AddWithValue("@i", lblinvoice.Text)
                .AddWithValue("@t", lbltable.Text)
                .AddWithValue("@d", Description)
                .AddWithValue("@p", Price)
                .AddWithValue("@q", Qty)
                .AddWithValue("@s", Subtotal)
                '.AddWithValue("@df", DateFull)
            End With
            command.ExecuteNonQuery()
            command.Dispose()
            query = "Update tbltable set TotalBill='" & TotalBill & "' where TableNo='" & lbltable.Text & "'"
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            command.Dispose()
            Call ShowDiningCart()
            Call ShowTables()
            Call ColoredTotalBill()
            Call GrandTotal()
            For Each item As ListViewItem In lvdiningcart.Items
                If (item.Text = Description) Then
                    item.BackColor = Color.DodgerBlue
                End If
            Next
            lvdiningcart.Focus()
            connect.Close()
        End If
    End Sub

    Private Sub lvsamgyup_ItemSelectionChanged_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvsamgyup.ItemSelectionChanged
        connect.Open()
        query = "Select * from tblproducts where Description='" & e.Item.Name & "'"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        While reader.Read
            Description = reader("Description")
            Price = reader("Price")
        End While
        command.Dispose()
        reader.Close()
        connect.Close()
    End Sub

    Private Sub lvsamgyup_DrawItem_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawListViewItemEventArgs) Handles lvsamgyup.DrawItem
        e.DrawDefault = True
        e.Graphics.DrawRectangle(Pens.Black, e.Bounds.X + 7, e.Bounds.Y + 1, e.Bounds.Width - 15, e.Bounds.Height + 2)
        If e.ItemIndex Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.DarkOrange, e.Bounds.X + 8, e.Bounds.Y + 2, e.Bounds.Width - 16, e.Bounds.Height + 1)
        Else
            e.Graphics.FillRectangle(Brushes.SaddleBrown, e.Bounds.X + 8, e.Bounds.Y + 2, e.Bounds.Width - 16, e.Bounds.Height + 1)
        End If
        e.Item.Selected = False
    End Sub

    Private Sub Cashier_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        btnvoid.Enabled = False
        btnqty.Enabled = False
        lvsamgyup.Items.Clear()
        lblgrandtotal.Text = "0.00"
    End Sub

    
    Private Sub lvsamgyup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvsamgyup.SelectedIndexChanged
        With lvsamgyup.FocusedItem
            myPrice = .SubItems(0).Text
            mySubTotal = .SubItems(0).Text
            myID = .SubItems(0).Text
        End With
        btnvoid.Enabled = True
        btnqty.Enabled = True
        btndiscount.Enabled = True
    End Sub

    Private Sub btnvoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvoid.Click
        btnvoid.Enabled = False
        btnqty.Enabled = False
        btndiscount.Enabled = False
        With frmVoid
            .txtuser.Text = ""
            .txtpass.Text = ""
            .txtuser.BackColor = Color.LightBlue
            .txtpass.BackColor = Color.White
            .ShowDialog()
        End With
    End Sub

    Private Sub btnqty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnqty.Click
        btnqty.Enabled = False
        btnvoid.Enabled = False
        btndiscount.Enabled = False
        With frmchangeQty
            .txtchange.Text = ""
            .ShowDialog()
        End With
    End Sub
End Class