Public Class Frm_Admin_Login

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If txtUserName.Text.Equals("aisha") AndAlso txtPassword.Text.Equals("khalfan") Then
            Frm_Main.btnLogout.Visible = True
            Frm_Main.flag2 = 1
            Me.Close()
        Else
            MsgBox("Must Enter A Valid Login Details")
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress

        If (Asc(e.KeyChar) = 13) Then
            btnOk_Click(sender, e)
        End If

    End Sub

    Private Sub txtUserName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class
