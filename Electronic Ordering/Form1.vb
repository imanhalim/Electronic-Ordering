Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'These program statements run when the form loads
        'devName value from constant
        Dim devName As String
        Label5.Text = "Developed by " + devName
        PictureBox1.Image = System.Drawing.Image.FromFile _
 ("C:\Users\Dell\Downloads\Electronic Ordering\Electronic Ordering\Electronic Ordering\resources\resources\pc-icon.png")
        'Add items to a list box like this:
        ListBox1.Items.Add("Extra hard disk")
        ListBox1.Items.Add("Printer")
        ListBox1.Items.Add("Satellite dish")
        'Combo boxes are also filled with the Add method:
        ComboBox1.Items.Add("MYR")
        ComboBox1.Items.Add("Check")
        ComboBox1.Items.Add("English Pounds")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'If the CheckState property for a check box is 1, it has a mark in it
        If CheckBox1.CheckState = 1 Then
            PictureBox4.Image = System.Drawing.Image.FromFile _
 ("C:\Users\Dell\Downloads\Electronic Ordering\Electronic Ordering\Electronic Ordering\resources\resources\ansering-machine.jpg")
            PictureBox4.Visible = True
        Else
            'If there is no mark, hide the image
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'If the CheckState property for a check box is 1, it has a mark in it
        If CheckBox2.CheckState = 1 Then
            PictureBox5.Image = System.Drawing.Image.FromFile _
 ("C:\Users\Dell\Downloads\Electronic Ordering\Electronic Ordering\Electronic Ordering\resources\resources\calculator.jpg")
            PictureBox5.Visible = True
        Else
            'If there is no mark, hide the image
            PictureBox5.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'If the CheckState property for a check box is 1, it has a mark in it
        If CheckBox3.CheckState = 1 Then
            PictureBox6.Image = System.Drawing.Image.FromFile _
            ("C:\Users\Dell\Downloads\Electronic Ordering\Electronic Ordering\Electronic Ordering\resources\resources\copy-machine.jpg")
            PictureBox6.Visible = True
        Else
            'If there is no mark, hide the image
            PictureBox6.Visible = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'The item you picked (0-2) is held in the SelectedIndex property
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox2.Image = System.Drawing.Image.FromFile _
                ("C:\Users\Dell\Downloads\Electronic Ordering\Electronic Ordering\Electronic Ordering\resources\resources\harddisk.jpg")
            Case 1
                PictureBox2.Image = System.Drawing.Image.FromFile _
                ("C:\Users\Dell\Downloads\Electronic Ordering\Electronic Ordering\Electronic Ordering\resources\resources\printer.jpg")
            Case 2
                PictureBox2.Image = System.Drawing.Image.FromFile _
                ("C:\Users\Dell\Downloads\Electronic Ordering\Electronic Ordering\Electronic Ordering\resources\resources\sate_dish.jpg")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
