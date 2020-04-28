Public Class Admin

    Private Sub btnMProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMProduct.Click
        With ManageProducts
            .TopLevel = False
            Panel3.Controls.Add(ManageProducts)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnproducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproducts.Click
        With ManageTable
            .TopLevel = False
            Panel3.Controls.Add(ManageTable)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With ManageCategory
            .TopLevel = False
            Panel3.Controls.Add(ManageCategory)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuser.Click
        With ManageUsers
            .TopLevel = False
            Panel3.Controls.Add(ManageUsers)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = Format(DateTime.Now, "hh:mm:ss tt")
        lbldateandday.Text = myDate.ToString("MMMM dd, yyyy") & " | " & myDate.ToString("dddd")

    End Sub

    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBox("Are you sure you want to Exit Appication?", _
             vbYesNo + vbQuestion, _
             "Confirmation") = vbYes Then
            Application.Exit()
       
        End If
    End Sub

    Private Sub btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to Logout?", _
             vbYesNo + vbQuestion, _
             "Confirmation") = vbYes Then
            Me.Dispose()
            Form1.Show()
        End If
    End Sub
End Class