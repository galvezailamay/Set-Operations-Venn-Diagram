Module Module1
    Public Sub addElement(txtbox As Object, lstbox As Object)
        If txtbox.Text = "" Then
            MessageBox.Show("Empty field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtbox.Text = " " Then
            MessageBox.Show("You can't add this value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not lstbox.Items.Contains(txtbox.Text) Then
            lstbox.Items.Add(txtbox.Text)
            txtbox.Clear()
        Else
            MessageBox.Show("You can't add duplicate element", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbox.Clear()
        End If
    End Sub

    Public Sub removeElement(lstbox)
        If Not lstbox.SelectedIndex = -1 Then
            Dim result = MessageBox.Show("Are you sure you want to remove this element?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                lstbox.Items.Remove(lstbox.SelectedItem)
            Else
            End If
        Else
        End If
    End Sub

End Module
