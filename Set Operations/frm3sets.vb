Public Class frm3sets

    Private Sub frm3sets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        default_color()
        lblTitle.Text = " "

    End Sub
    Public Sub default_color()
        txtVennA.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232))
        txtVennB.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232))
        txtVennC.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232))
        txtAB.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232))
        txtAC.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232))
        txtABC.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232))
        txtBC.BackColor = ColorTranslator.FromOle(RGB(227, 229, 232))
    End Sub

    Private Sub txtSet1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSet1.KeyDown
        If e.KeyCode = Keys.Enter Then
            addElement(txtSet1, ListBox1)
            e.SuppressKeyPress = True
            e.Handled = True
        Else

        End If
    End Sub
    Private Sub txtSet2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSet2.KeyDown
        If e.KeyCode = Keys.Enter Then
            addElement(txtSet2, ListBox2)
            e.SuppressKeyPress = True
            e.Handled = True
        Else

        End If
    End Sub
    Private Sub txtSet3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSet3.KeyDown
        If e.KeyCode = Keys.Enter Then
            addElement(txtSet3, ListBox3)
            e.SuppressKeyPress = True
            e.Handled = True
        Else

        End If
    End Sub


    Private Sub btnAddA_Click(sender As Object, e As EventArgs) Handles btnAddA.Click
        addElement(txtSet1, ListBox1)
    End Sub


    Private Sub btnAddB_Click(sender As Object, e As EventArgs) Handles btnAddB.Click
        addElement(txtSet2, ListBox2)
    End Sub


    Private Sub btnAddC_Click(sender As Object, e As EventArgs) Handles btnAddC.Click
        addElement(txtSet3, ListBox3)
    End Sub


    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        removeElement(ListBox1)
    End Sub


    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        removeElement(ListBox2)
    End Sub


    Private Sub ListBox3_DoubleClick(sender As Object, e As EventArgs) Handles ListBox3.DoubleClick
        removeElement(ListBox3)
    End Sub


    Private Sub btnLoadVenn_Click(sender As Object, e As EventArgs) Handles btnLoadVenn.Click
        loadVennS3()
    End Sub

    'setAname
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

    'setBname
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

    'setCname
    Private Sub txtset3name_KeyDown(sender As Object, e As KeyEventArgs) Handles txtset3name.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblSetCname.Text = txtset3name.Text
            If txtset3name.Text = "" Then
                lblSetCname.Text = "C"
            End If
            e.SuppressKeyPress = True
            e.Handled = True
        Else

        End If
    End Sub

    Public Sub loadVennS3()


            txtVennA.Clear()
            txtVennB.Clear()
            txtVennC.Clear()
            txtAB.Clear()
            txtBC.Clear()
            txtAC.Clear()
            txtABC.Clear()

            If ComboBox3.SelectedIndex = -1 Then
                MessageBox.Show("Please select set operation", "No Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If ComboBox3.SelectedIndex = 0 Then
                    PictureBox1.Image = My.Resources._3set_union
                    txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtAB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtVennB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtAC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtABC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtBC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtVennC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                lblTitle.Text = lblSetAname.Text + " ∪ " + lblSetBname.Text + " ∪ " + lblSetCname.Text

                ElseIf ComboBox3.SelectedIndex = 1 Then
                    PictureBox1.Image = My.Resources._3set_intersection
                    txtVennA.BackColor = Color.White
                    txtAB.BackColor = Color.White
                    txtVennB.BackColor = Color.White
                    txtAC.BackColor = Color.White
                    txtABC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                    txtBC.BackColor = Color.White
                    txtVennC.BackColor = Color.White
                lblTitle.Text = lblSetAname.Text + " ∩ " + lblSetBname.Text + " ∩ " + lblSetCname.Text


            ElseIf ComboBox3.SelectedIndex = 2 Then
                PictureBox1.Image = My.Resources._3seta_b_c
                txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtAB.BackColor = Color.White
                txtVennB.BackColor = Color.White
                txtAC.BackColor = Color.White
                txtABC.BackColor = Color.White
                txtBC.BackColor = Color.White
                txtVennC.BackColor = Color.White
                lblTitle.Text = "(" + lblSetAname.Text + " - " + lblSetBname.Text + ")" + " - " + lblSetCname.Text

            ElseIf ComboBox3.SelectedIndex = 3 Then
                PictureBox1.Image = My.Resources._3set_symmetric_difference
                txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtAB.BackColor = Color.White
                txtVennB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtAC.BackColor = Color.White
                txtABC.BackColor = Color.White
                txtBC.BackColor = Color.White
                txtVennC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                lblTitle.Text = lblSetAname.Text + " △ " + lblSetBname.Text + " △ " + lblSetCname.Text

            ElseIf ComboBox3.SelectedIndex = 4 Then
                PictureBox1.Image = My.Resources.a_symm__b_inter_c_
                txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtAB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennB.BackColor = Color.White
                txtAC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtABC.BackColor = Color.White
                txtBC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennC.BackColor = Color.White
                lblTitle.Text = lblSetAname.Text + " △ (" + lblSetBname.Text + " ∩ " + lblSetCname.Text + ")"

            ElseIf ComboBox3.SelectedIndex = 5 Then
                PictureBox1.Image = My.Resources.A_I_B_U_C
                txtVennA.BackColor = Color.White
                txtAB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennB.BackColor = Color.White
                txtAC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtABC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtBC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                lblTitle.Text = lblSetAname.Text + " ∩ " + lblSetBname.Text + " ∪ " + lblSetCname.Text

            ElseIf ComboBox3.SelectedIndex = 6 Then
                PictureBox1.Image = My.Resources.A_I__B_U_C_
                txtVennA.BackColor = Color.White
                txtAB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennB.BackColor = Color.White
                txtAC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtABC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtBC.BackColor = Color.White
                txtVennC.BackColor = Color.White
                lblTitle.Text = lblSetAname.Text + " ∩ (" + lblSetBname.Text + " ∪ " + lblSetCname.Text + ")"

            ElseIf ComboBox3.SelectedIndex = 7 Then
                PictureBox1.Image = My.Resources.A_U__b_I_c_
                txtVennA.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtAB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennB.BackColor = Color.White
                txtAC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtABC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtBC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennC.BackColor = Color.White
                lblTitle.Text = lblSetAname.Text + " ∪ (" + lblSetBname.Text + " ∩ " + lblSetCname.Text + ")"


            ElseIf ComboBox3.SelectedIndex = 8 Then
                PictureBox1.Image = My.Resources._c_U_a_U_b
                txtVennA.BackColor = Color.White
                txtAB.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennB.BackColor = Color.White
                txtAC.BackColor = Color.White
                txtABC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtBC.BackColor = ColorTranslator.FromOle(RGB(255, 192, 192))
                txtVennC.BackColor = Color.White
                lblTitle.Text = "(" + lblSetCname.Text + " ∪ " + lblSetAname.Text + ") ∩ " + lblSetBname.Text
                End If

                'compare L1 items in (L2items and L3items)
                For Each itm In ListBox1.Items
                    If ListBox2.Items.Contains(itm) And ListBox3.Items.Contains(itm) Then
                        txtABC.AppendText(itm.ToString() & Space(4))        'intersection of A and B and C

                    ElseIf (Not ListBox2.Items.Contains(itm)) And ListBox3.Items.Contains(itm) Then
                        txtAC.AppendText(itm.ToString() & Space(4))          'set A and C

                    ElseIf (Not ListBox2.Items.Contains(itm)) And (Not ListBox3.Items.Contains(itm)) Then
                        txtVennA.AppendText(itm.ToString() & Space(4))       'set A

                    ElseIf (Not ListBox3.Items.Contains(itm)) And (ListBox2.Items.Contains(itm)) Then
                        txtAB.AppendText(itm.ToString() & Space(4))          'set A and B

                    End If
                Next



                'compare L2 items in (L1items and L3items)
                For Each itm In ListBox2.Items
                    If (Not ListBox1.Items.Contains(itm)) And (Not ListBox3.Items.Contains(itm)) Then
                        txtVennB.AppendText(itm.ToString() & Space(4))  'set B

                    ElseIf ListBox3.Items.Contains(itm) And (Not ListBox1.Items.Contains(itm)) Then
                        txtBC.AppendText(itm.ToString() & Space(4)) 'set B and C
                    End If
                Next

                For Each itm In ListBox3.Items
                    If (Not ListBox1.Items.Contains(itm)) And (Not ListBox2.Items.Contains(itm)) Then
                        txtVennC.AppendText(itm.ToString() & Space(4)) 'set C
                    End If
                Next
            End If



       


    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result = MessageBox.Show("Are you sure you want clear all?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtVennA.Clear()
            txtVennB.Clear()
            txtVennC.Clear()
            txtAB.Clear()
            txtBC.Clear()
            txtAC.Clear()
            txtABC.Clear()
            lblTitle.Text = " "

            PictureBox1.Image = Nothing
            ComboBox3.SelectedIndex = -1
            default_color()
            lblSetAname.Text = "A"
            lblSetBname.Text = "B"
            lblSetCname.Text = "C"

            txtSet1name.Clear()
            txtSet2name.Clear()
            txtset3name.Clear()

            While ListBox1.Items.Count > 0
                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
            End While
            While ListBox2.Items.Count > 0
                ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)
            End While
            While ListBox3.Items.Count > 0
                ListBox3.Items.RemoveAt(ListBox3.Items.Count - 1)
            End While
        Else
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = -1 Then
        Else
            loadVennS3()

        End If

    End Sub



End Class