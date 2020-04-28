Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmProducts

    Sub clear()
        txtdesc.Text = ""
        txtcategory.Text = ""
        txtprice.Text = ""
        CheckBox1.CheckState = CheckState.Checked
        Status = "Available"
        ' picImage.Image = Image.FromFile(opf.FileName)
        txtdesc.Focus()
    End Sub

    Sub LoadCategory()

        connect.Open()
        command = New MySqlCommand("select * from tblcategory order by Category", connect)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(command)
        da.Fill(ds, "category")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("category").ToString)
        Next
        txtcategory.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtcategory.AutoCompleteCustomSource = col
        txtcategory.AutoCompleteMode = AutoCompleteMode.Suggest
        command = Nothing
        connect.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub frmProducts_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtdesc.Focus()
        txtdesc.SelectAll()
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AcceptButton = btnsave

        connect.Open()
        Dim arrImage() As Byte
        command = connect.CreateCommand
        command = New MySqlCommand("Select * from tblproducts where description='" & txtdesc.Text & "' and Category='" & txtcategory.Text & "'", connect)
        reader = command.ExecuteReader
        With reader
            While reader.Read
                txtprice.Text = reader.Item("Price")
                arrImage = reader.Item("myImage")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                picImage.Image = Image.FromStream(mstream)
            End While
        End With
        reader.Close()
        Status = "Available"
        ImageIsNull = "NoImage"
        query = "Select category from tblcategory"
        command = New MySqlCommand(query, connect)
        Dim dt As New DataTable
        Dim adapter As New MySqlDataAdapter(command)
        Dim acsc As New AutoCompleteStringCollection
        adapter.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            acsc.Add(dt.Rows(i)("category").ToString())
        Next
        txtcategory.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtcategory.AutoCompleteCustomSource = acsc
        txtcategory.AutoCompleteMode = AutoCompleteMode.Suggest

        connect.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "All Files | *.*| Image File (*.jpeg, *.bmp, *.png) | *.jpg, *.bmp' *.png"

        If opf.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            picImage.Image = Image.FromFile(opf.FileName)
            ImageIsNull = opf.FileName
            txtdesc.Focus()
        End If
    End Sub

    Private Sub txtdesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdesc.GotFocus
        txtdesc.BackColor = Color.LightBlue
    End Sub

    Private Sub txtdesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdesc.Leave
        txtdesc.BackColor = Color.White
    End Sub

    Private Sub txtprice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprice.GotFocus
        txtprice.BackColor = Color.LightBlue
    End Sub

    Private Sub txtprice_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprice.Leave
        On Error Resume Next
        txtprice.Text = Decimal.Parse(txtprice.Text, 2).ToString("f2")

        txtprice.BackColor = Color.White
    End Sub

    Private Sub txtcategory_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcategory.GotFocus
        txtcategory.BackColor = Color.LightBlue
    End Sub

    Private Sub txtcategory_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcategory.Leave
        txtcategory.BackColor = Color.White
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox2.CheckState = CheckState.Unchecked
            CheckBox2.Checked = False
            Status = "Available"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox1.CheckState = CheckState.Unchecked
            CheckBox1.Checked = False
            Status = "Not Available"
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click


        connect.Close()

        Try
            Dim mstream As New System.IO.MemoryStream
            picImage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer
            mstream.Close()
            connect.Open()
            command = New MySqlCommand("Insert into tblproducts(Description, Category, Price, Status, myImage)values(@1,@2,@3,@4,@5)", connect)
            With command.Parameters
                .AddWithValue("@1", txtdesc.Text)
                .AddWithValue("@2", txtcategory.Text)
                .AddWithValue("@3", txtprice.Text)
                .AddWithValue("@4", Status)
                .AddWithValue("@5", arrImage)
            End With
            command.ExecuteNonQuery()
            connect.Close()

            MsgBox("Record has been successfully add!", vbInformation)
            ManageProducts.ProductRecords()
            clear()
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)


        End Try

    End Sub

    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case Else
                MsgBox("Please Enter Numbers Only", MsgBoxStyle.Critical, "Error Occur")
                e.Handled = True
                txtprice.Focus()
        End Select
    End Sub
End Class