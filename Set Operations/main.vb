Public Class main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 
        With frm2Sets
            .TopLevel = False
            pnlPaneltoBack.Controls.Add(frm2Sets)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub LblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub



    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SidePanel.Height = button1.Height
        SidePanel.Top = button1.Top
        With frm2Sets
            .TopLevel = False
            pnlPaneltoBack.Controls.Add(frm2Sets)
            .BringToFront()
            .Show()

        End With

    End Sub
  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SidePanel.Height = Button2.Height
        SidePanel.Top = Button2.Top

        With frm3sets
            .TopLevel = False
            pnlPaneltoBack.Controls.Add(frm3sets)
            .BringToFront()
            .Show()
        End With

    End Sub



End Class
