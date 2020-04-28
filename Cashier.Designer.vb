<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnvoid = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnpass = New System.Windows.Forms.Button()
        Me.btnyearly = New System.Windows.Forms.Button()
        Me.btndaily = New System.Windows.Forms.Button()
        Me.btnmonthly = New System.Windows.Forms.Button()
        Me.btncashier = New System.Windows.Forms.Button()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.btninvoice = New System.Windows.Forms.Button()
        Me.btnqty = New System.Windows.Forms.Button()
        Me.btnbill = New System.Windows.Forms.Button()
        Me.btndiscount = New System.Windows.Forms.Button()
        Me.btncash = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcounter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltable = New System.Windows.Forms.Label()
        Me.lblinvoice = New System.Windows.Forms.Label()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnminimized = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lvtable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcategory = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnx = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbldateandday = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lvdiningcart = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvsamgyup = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.btnvoid)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnpass)
        Me.Panel1.Controls.Add(Me.btnyearly)
        Me.Panel1.Controls.Add(Me.btndaily)
        Me.Panel1.Controls.Add(Me.btnmonthly)
        Me.Panel1.Controls.Add(Me.btncashier)
        Me.Panel1.Controls.Add(Me.btnchange)
        Me.Panel1.Controls.Add(Me.btninvoice)
        Me.Panel1.Controls.Add(Me.btnqty)
        Me.Panel1.Controls.Add(Me.btnbill)
        Me.Panel1.Controls.Add(Me.btndiscount)
        Me.Panel1.Controls.Add(Me.btncash)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 672)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1365, 77)
        Me.Panel1.TabIndex = 0
        '
        'btnvoid
        '
        Me.btnvoid.BackColor = System.Drawing.Color.Transparent
        Me.btnvoid.Enabled = False
        Me.btnvoid.FlatAppearance.BorderSize = 0
        Me.btnvoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvoid.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvoid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnvoid.Location = New System.Drawing.Point(1218, 16)
        Me.btnvoid.Name = "btnvoid"
        Me.btnvoid.Size = New System.Drawing.Size(100, 58)
        Me.btnvoid.TabIndex = 16
        Me.btnvoid.Text = "Void Items"
        Me.btnvoid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnvoid.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnlogout.Location = New System.Drawing.Point(1116, 17)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(100, 58)
        Me.btnlogout.TabIndex = 15
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnpass
        '
        Me.btnpass.BackColor = System.Drawing.Color.Transparent
        Me.btnpass.FlatAppearance.BorderSize = 0
        Me.btnpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpass.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpass.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnpass.Location = New System.Drawing.Point(1015, 17)
        Me.btnpass.Name = "btnpass"
        Me.btnpass.Size = New System.Drawing.Size(100, 58)
        Me.btnpass.TabIndex = 14
        Me.btnpass.Text = "Change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.btnpass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpass.UseVisualStyleBackColor = False
        '
        'btnyearly
        '
        Me.btnyearly.BackColor = System.Drawing.Color.Transparent
        Me.btnyearly.FlatAppearance.BorderSize = 0
        Me.btnyearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyearly.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyearly.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnyearly.Location = New System.Drawing.Point(914, 17)
        Me.btnyearly.Name = "btnyearly"
        Me.btnyearly.Size = New System.Drawing.Size(100, 58)
        Me.btnyearly.TabIndex = 13
        Me.btnyearly.Text = "Re-Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yearly Sales"
        Me.btnyearly.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnyearly.UseVisualStyleBackColor = False
        '
        'btndaily
        '
        Me.btndaily.BackColor = System.Drawing.Color.Transparent
        Me.btndaily.FlatAppearance.BorderSize = 0
        Me.btndaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndaily.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndaily.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btndaily.Location = New System.Drawing.Point(711, 16)
        Me.btndaily.Name = "btndaily"
        Me.btndaily.Size = New System.Drawing.Size(100, 58)
        Me.btndaily.TabIndex = 12
        Me.btndaily.Text = "Re-Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Daily Sales"
        Me.btndaily.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndaily.UseVisualStyleBackColor = False
        '
        'btnmonthly
        '
        Me.btnmonthly.BackColor = System.Drawing.Color.Transparent
        Me.btnmonthly.FlatAppearance.BorderSize = 0
        Me.btnmonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmonthly.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmonthly.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnmonthly.Location = New System.Drawing.Point(812, 16)
        Me.btnmonthly.Name = "btnmonthly"
        Me.btnmonthly.Size = New System.Drawing.Size(100, 58)
        Me.btnmonthly.TabIndex = 11
        Me.btnmonthly.Text = "Re-Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monthly"
        Me.btnmonthly.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmonthly.UseVisualStyleBackColor = False
        '
        'btncashier
        '
        Me.btncashier.BackColor = System.Drawing.Color.Transparent
        Me.btncashier.FlatAppearance.BorderSize = 0
        Me.btncashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncashier.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncashier.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btncashier.Location = New System.Drawing.Point(610, 16)
        Me.btncashier.Name = "btncashier"
        Me.btncashier.Size = New System.Drawing.Size(100, 58)
        Me.btncashier.TabIndex = 10
        Me.btncashier.Text = "Cashier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turnovers"
        Me.btncashier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncashier.UseVisualStyleBackColor = False
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.Color.Transparent
        Me.btnchange.FlatAppearance.BorderSize = 0
        Me.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchange.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnchange.Location = New System.Drawing.Point(509, 16)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(100, 58)
        Me.btnchange.TabIndex = 9
        Me.btnchange.Text = "Change " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status"
        Me.btnchange.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnchange.UseVisualStyleBackColor = False
        '
        'btninvoice
        '
        Me.btninvoice.BackColor = System.Drawing.Color.Transparent
        Me.btninvoice.FlatAppearance.BorderSize = 0
        Me.btninvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninvoice.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvoice.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btninvoice.Location = New System.Drawing.Point(408, 16)
        Me.btninvoice.Name = "btninvoice"
        Me.btninvoice.Size = New System.Drawing.Size(100, 58)
        Me.btninvoice.TabIndex = 8
        Me.btninvoice.Text = "Re-Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Invoice No."
        Me.btninvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btninvoice.UseVisualStyleBackColor = False
        '
        'btnqty
        '
        Me.btnqty.BackColor = System.Drawing.Color.Transparent
        Me.btnqty.FlatAppearance.BorderSize = 0
        Me.btnqty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnqty.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnqty.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnqty.Location = New System.Drawing.Point(306, 16)
        Me.btnqty.Name = "btnqty"
        Me.btnqty.Size = New System.Drawing.Size(100, 58)
        Me.btnqty.TabIndex = 7
        Me.btnqty.Text = "Change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quantity"
        Me.btnqty.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnqty.UseVisualStyleBackColor = False
        '
        'btnbill
        '
        Me.btnbill.BackColor = System.Drawing.Color.Transparent
        Me.btnbill.FlatAppearance.BorderSize = 0
        Me.btnbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbill.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbill.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnbill.Location = New System.Drawing.Point(205, 16)
        Me.btnbill.Name = "btnbill"
        Me.btnbill.Size = New System.Drawing.Size(100, 58)
        Me.btnbill.TabIndex = 6
        Me.btnbill.Text = "Temporary" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bill"
        Me.btnbill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbill.UseVisualStyleBackColor = False
        '
        'btndiscount
        '
        Me.btndiscount.BackColor = System.Drawing.Color.Transparent
        Me.btndiscount.FlatAppearance.BorderSize = 0
        Me.btndiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndiscount.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndiscount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btndiscount.Location = New System.Drawing.Point(104, 16)
        Me.btndiscount.Name = "btndiscount"
        Me.btndiscount.Size = New System.Drawing.Size(100, 58)
        Me.btndiscount.TabIndex = 5
        Me.btndiscount.Text = "Item" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discount"
        Me.btndiscount.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndiscount.UseVisualStyleBackColor = False
        '
        'btncash
        '
        Me.btncash.BackColor = System.Drawing.Color.Transparent
        Me.btncash.FlatAppearance.BorderSize = 0
        Me.btncash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncash.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncash.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btncash.Location = New System.Drawing.Point(3, 16)
        Me.btncash.Name = "btncash"
        Me.btncash.Size = New System.Drawing.Size(100, 58)
        Me.btncash.TabIndex = 1
        Me.btncash.Text = "Cash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tender"
        Me.btncash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncash.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblcounter)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbltable)
        Me.Panel2.Controls.Add(Me.lblinvoice)
        Me.Panel2.Controls.Add(Me.lblgrandtotal)
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnminimized)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1365, 151)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.finals.My.Resources.Resources.Copy_of_oktoberfest_flyers_bar_flyers___Made_with_PosterMyWall___Copy
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(8, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(286, 106)
        Me.Panel4.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(1175, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Table  No:"
        '
        'lblcounter
        '
        Me.lblcounter.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblcounter.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcounter.ForeColor = System.Drawing.Color.White
        Me.lblcounter.Location = New System.Drawing.Point(7, 118)
        Me.lblcounter.Name = "lblcounter"
        Me.lblcounter.Size = New System.Drawing.Size(287, 24)
        Me.lblcounter.TabIndex = 125
        Me.lblcounter.Text = "COUNTER"
        Me.lblcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(1009, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Invoice No:"
        '
        'lbltable
        '
        Me.lbltable.AutoSize = True
        Me.lbltable.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltable.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbltable.Location = New System.Drawing.Point(1250, 123)
        Me.lbltable.Name = "lbltable"
        Me.lbltable.Size = New System.Drawing.Size(0, 17)
        Me.lbltable.TabIndex = 137
        '
        'lblinvoice
        '
        Me.lblinvoice.AutoSize = True
        Me.lblinvoice.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvoice.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblinvoice.Location = New System.Drawing.Point(1095, 122)
        Me.lblinvoice.Name = "lblinvoice"
        Me.lblinvoice.Size = New System.Drawing.Size(0, 17)
        Me.lblinvoice.TabIndex = 136
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.BackColor = System.Drawing.Color.LightBlue
        Me.lblgrandtotal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblgrandtotal.Font = New System.Drawing.Font("Gadugi", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrandtotal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblgrandtotal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblgrandtotal.Location = New System.Drawing.Point(1073, 39)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(132, 64)
        Me.lblgrandtotal.TabIndex = 135
        Me.lblgrandtotal.Text = "0.00"
        Me.lblgrandtotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.BackgroundImage = Global.finals.My.Resources.Resources.x_button
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnexit.FlatAppearance.BorderSize = 0
        Me.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnexit.Location = New System.Drawing.Point(1339, 3)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(22, 22)
        Me.btnexit.TabIndex = 134
        Me.btnexit.TabStop = False
        Me.btnexit.Tag = ""
        Me.ToolTip1.SetToolTip(Me.btnexit, "Minimized")
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnminimized
        '
        Me.btnminimized.BackColor = System.Drawing.Color.Transparent
        Me.btnminimized.BackgroundImage = Global.finals.My.Resources.Resources.minimize
        Me.btnminimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimized.FlatAppearance.BorderSize = 0
        Me.btnminimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnminimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnminimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimized.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimized.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnminimized.Location = New System.Drawing.Point(1311, 4)
        Me.btnminimized.Name = "btnminimized"
        Me.btnminimized.Size = New System.Drawing.Size(22, 22)
        Me.btnminimized.TabIndex = 133
        Me.btnminimized.TabStop = False
        Me.btnminimized.Tag = ""
        Me.ToolTip1.SetToolTip(Me.btnminimized, "Minimized")
        Me.btnminimized.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(1002, 157)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(361, 29)
        Me.Panel6.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(79, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 24)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Costumer Dining Cart"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvtable
        '
        Me.lvtable.BackColor = System.Drawing.SystemColors.Window
        Me.lvtable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvtable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvtable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvtable.FullRowSelect = True
        Me.lvtable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvtable.Location = New System.Drawing.Point(0, 172)
        Me.lvtable.Name = "lvtable"
        Me.lvtable.Size = New System.Drawing.Size(176, 444)
        Me.lvtable.TabIndex = 128
        Me.lvtable.UseCompatibleStateImageBehavior = False
        Me.lvtable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tables"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Total Bill"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 92
        '
        'lvcategory
        '
        Me.lvcategory.BackColor = System.Drawing.SystemColors.Window
        Me.lvcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvcategory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.lvcategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvcategory.FullRowSelect = True
        Me.lvcategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvcategory.Location = New System.Drawing.Point(177, 172)
        Me.lvcategory.Name = "lvcategory"
        Me.lvcategory.Size = New System.Drawing.Size(110, 444)
        Me.lvcategory.TabIndex = 129
        Me.lvcategory.UseCompatibleStateImageBehavior = False
        Me.lvcategory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.Width = 110
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'btnx
        '
        Me.btnx.BackColor = System.Drawing.Color.Transparent
        Me.btnx.BackgroundImage = Global.finals.My.Resources.Resources.x_button
        Me.btnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnx.FlatAppearance.BorderSize = 0
        Me.btnx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnx.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnx.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnx.Location = New System.Drawing.Point(1339, 4)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(22, 22)
        Me.btnx.TabIndex = 132
        Me.btnx.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnx, "(Press END to exit application)0")
        Me.btnx.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'lbldateandday
        '
        Me.lbldateandday.BackColor = System.Drawing.Color.Transparent
        Me.lbldateandday.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateandday.ForeColor = System.Drawing.Color.Black
        Me.lbldateandday.Location = New System.Drawing.Point(38, 667)
        Me.lbldateandday.Name = "lbldateandday"
        Me.lbldateandday.Size = New System.Drawing.Size(213, 24)
        Me.lbldateandday.TabIndex = 134
        Me.lbldateandday.Text = ";lkjhgfds"
        Me.lbldateandday.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Red
        Me.lbltime.Location = New System.Drawing.Point(3, 632)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(284, 28)
        Me.lbltime.TabIndex = 133
        Me.lbltime.Text = "mnbvcx"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsearch.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtsearch.Location = New System.Drawing.Point(434, 38)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(270, 18)
        Me.txtsearch.TabIndex = 135
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.txtsearch)
        Me.Panel8.Location = New System.Drawing.Point(289, 157)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(710, 62)
        Me.Panel8.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(431, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Search"
        '
        'lvdiningcart
        '
        Me.lvdiningcart.BackColor = System.Drawing.SystemColors.Window
        Me.lvdiningcart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvdiningcart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvdiningcart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvdiningcart.FullRowSelect = True
        Me.lvdiningcart.Location = New System.Drawing.Point(1002, 184)
        Me.lvdiningcart.Name = "lvdiningcart"
        Me.lvdiningcart.Size = New System.Drawing.Size(361, 507)
        Me.lvdiningcart.TabIndex = 136
        Me.lvdiningcart.UseCompatibleStateImageBehavior = False
        Me.lvdiningcart.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 174
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 72
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Qty"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 55
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Subtotal"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvsamgyup
        '
        Me.lvsamgyup.BackColor = System.Drawing.SystemColors.Window
        Me.lvsamgyup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvsamgyup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.lvsamgyup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvsamgyup.FullRowSelect = True
        Me.lvsamgyup.Location = New System.Drawing.Point(289, 219)
        Me.lvsamgyup.Name = "lvsamgyup"
        Me.lvsamgyup.Size = New System.Drawing.Size(710, 472)
        Me.lvsamgyup.TabIndex = 137
        Me.lvsamgyup.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = ""
        Me.ColumnHeader8.Width = 110
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(177, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 140
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 15)
        Me.Label5.TabIndex = 141
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1365, 749)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvsamgyup)
        Me.Controls.Add(Me.lvdiningcart)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.lbldateandday)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lvcategory)
        Me.Controls.Add(Me.lvtable)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncash As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblcounter As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lvtable As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcategory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnminimized As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnvoid As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnpass As System.Windows.Forms.Button
    Friend WithEvents btnyearly As System.Windows.Forms.Button
    Friend WithEvents btndaily As System.Windows.Forms.Button
    Friend WithEvents btnmonthly As System.Windows.Forms.Button
    Friend WithEvents btncashier As System.Windows.Forms.Button
    Friend WithEvents btnchange As System.Windows.Forms.Button
    Friend WithEvents btninvoice As System.Windows.Forms.Button
    Friend WithEvents btnqty As System.Windows.Forms.Button
    Friend WithEvents btnbill As System.Windows.Forms.Button
    Friend WithEvents btndiscount As System.Windows.Forms.Button
    Friend WithEvents btnx As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lbldateandday As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltable As System.Windows.Forms.Label
    Friend WithEvents lblinvoice As System.Windows.Forms.Label
    Friend WithEvents lblgrandtotal As System.Windows.Forms.Label
    Friend WithEvents lvdiningcart As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvsamgyup As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
