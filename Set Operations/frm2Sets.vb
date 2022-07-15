Public Class frm2Sets

    Private Sub frm2Sets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        default_color()
        lblTitle.Text = " "
    End Sub
    Public Sub default_color()
        txtVennA.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232)) 'gray
        txtVenn2.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232)) 'gray
        txtVennB.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232)) 'gray
    End Sub


    'SetA name
    Private Sub txtSet1name_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSet1name.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblSetAname.Text = txtSet1name.Text
            If txtSet1name.Text = "" Then
                lblSetAname.Text = "A"
            End If
        
            e.SuppressKeyPress = True
            e.Handled = True
        Else
        End If
    End Sub

    'SetB name
    Private Sub txtSet2name_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSet2name.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblSetBname.Text = txtSet2name.Text
            If txtSet2name.Text = "" Then
                lblSetBname.Text = "B"
            End If
            e.SuppressKeyPress = True
            e.Handled = True
        Else

        End If
    End Sub

    'SetA add keydown
    Private Sub txtSet1_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtSet1.KeyDown
        If e.KeyCode = Keys.Enter Then
            addElement(txtSet1, ListBox1)
            e.SuppressKeyPress = True
            e.Handled = True
        Else

        End If
    End Sub

    'Set B add keydown
    Private Sub txtSet2_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtSet2.KeyDown
        If e.KeyCode = Keys.Enter Then
            addElement(txtSet2, ListBox2)
            e.SuppressKeyPress = True
            e.Handled = True
        Else

        End If
    End Sub

    'btnAddSet2
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        addElement(txtSet2, ListBox2)
    End Sub

    'btnAddSet1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        addElement(txtSet1, ListBox1)
    End Sub


    'btnRemoveSet1
    Private Sub ListBox1_DoubleClick1(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        removeElement(ListBox1)
    End Sub

    'btnRemoveSet2
    Private Sub ListBox2_DoubleClick1(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        removeElement(ListBox2)
    End Sub


    Public Sub loadVenn()
       
            txtVenn2.Clear()
            txtVennA.Clear()
            txtVennB.Clear()

            If ComboBox2.SelectedIndex = -1 Then
                MessageBox.Show("Please select set operation", "No Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If ComboBox2.Text = "Union" Then
                    PictureBox1.Image = My.Resources._2setunion
                    txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192)) 'pink
                    txtVenn2.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192)) 'pink
                    txtVennB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192)) 'pink
                lblTitle.Text = lblSetAname.Text + " ∪ " + lblSetBname.Text

                ElseIf ComboBox2.Text = "Intersection" Then
                    PictureBox1.Image = My.Resources._2set_intersection
                    txtVennA.BackColor = Color.White
                    txtVenn2.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtVennB.BackColor = Color.White
                lblTitle.Text = lblSetAname.Text + " ∩ " + lblSetBname.Text

                ElseIf ComboBox2.Text = "Difference (A-B)" Then
                    PictureBox1.Image = My.Resources._2setdifference_a_b
                    txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtVenn2.BackColor = Color.White
                    txtVennB.BackColor = Color.White
                lblTitle.Text = lblSetAname.Text + " - " + lblSetBname.Text

                ElseIf ComboBox2.Text = "Difference (B-A)" Then
                    PictureBox1.Image = My.Resources._2setdifference_b_a
                    txtVennA.BackColor = Color.White
                    txtVenn2.BackColor = Color.White
                    txtVennB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                lblTitle.Text = lblSetBname.Text + " - " + lblSetAname.Text

                ElseIf ComboBox2.Text = "Symmetric Difference" Then
                    PictureBox1.Image = My.Resources._2set_symmetric_diffference
                    txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtVenn2.BackColor = Color.White
                    txtVennB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                lblTitle.Text = lblSetAname.Text + " △ " + lblSetBname.Text

                End If

                For Each itm In ListBox1.Items
                    If ListBox2.Items.Contains(itm) Then
                        txtVenn2.AppendText(itm.ToString() & Space(4)) 'intersection
                    ElseIf Not ListBox2.Items.Contains(itm) Then
                        txtVennA.AppendText(itm.ToString() & Space(4)) 'set A
                    End If
                Next


                For Each itm In ListBox2.Items
                    If ListBox1.Items.Contains(itm) Then
                    ElseIf Not ListBox1.Items.Contains(itm) Then
                        txtVennB.AppendText(itm.ToString() & Space(4)) 'set B
                    End If

                Next
            End If


       


    End Sub

  
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = -1 Then
        Else
            loadVenn()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result = MessageBox.Show("Are you sure you want clear all?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtVenn2.Clear()
            txtVennA.Clear()
            txtVennB.Clear()
            PictureBox1.Image = Nothing
            ComboBox2.SelectedIndex = -1
            default_color()
            lblSetAname.Text = "A"
            lblSetBname.Text = "B"
            txtSet1name.Clear()
            txtSet2name.Clear()
            lblTitle.Text = " "

            While ListBox1.Items.Count > 0
                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
            End While
            While ListBox2.Items.Count > 0
                ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)
            End While
        Else
        End If
    End Sub

   

    Private Sub btnLoadVenn_Click(sender As Object, e As EventArgs) Handles btnLoadVenn.Click
        loadVenn()
    End Sub

End Class