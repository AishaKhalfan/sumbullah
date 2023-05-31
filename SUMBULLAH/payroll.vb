Public Class payroll

  
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.ImageLocation = "D:\COMP SCIENCE\SEMESTER 8\Payroll Management System\Payroll Management System\Resources\alma8.png"
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        PictureBox1.ImageLocation = "D:\COMP SCIENCE\SEMESTER 8\Payroll Management System\Payroll Management System\Resources\bar-chart.gif"
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub payroll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Developed By Aisha Khalifan"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'dept.Show()
        Frm_Department.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Frm_Payslip.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Frm_Search.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Frm_ViewAll.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If MsgBox("Make sure that no other application is running....", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Frm_Database_Backup.Show()
            Me.Visible = False
        ElseIf MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Frm_Restore.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Frm_About.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If MsgBox("Are you sure you want to exit this application?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Visible = False
            ' Frm_Main.Show()
        ElseIf MsgBoxResult.No Then
            Exit Sub

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Frm_Main.Show()

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class