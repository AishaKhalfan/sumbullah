Imports System.Data.SqlClient

Public Class Frm_Login

    Dim emp_id As Integer = 0

    Private Sub formClear()
        txtUserID.Clear()
        txtPass.Clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmboxLoginType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxLoginType.SelectedIndexChanged

        If cmboxLoginType.Text.Equals("Employee") Then

            lblName.Text = "Employee ID"

            lblPass.Visible = False
            txtPass.Visible = False



            lblLogin.Location = New Point(49, 130)
            cmboxLoginType.Location = New Point(157, 129)

        ElseIf cmboxLoginType.Text.Equals("Admin") Then

            lblName.Text = "Admin Name"
            lblLogin.Location = New Point(49, 166)
            cmboxLoginType.Location = New Point(159, 166)

            lblPass.Visible = True
            txtPass.Visible = True

        End If

    End Sub

    Public Function verifyEmployeeId() As Integer

        Dim query = "Select employee_id From Employee Where employee_id = '" & Convert.ToInt32(txtUserID.Text) & "'"
        Dim dr As SqlDataReader = getDataReader(query)
        dr.Read()
        emp_id = dr("employee_id")
        dr.Close()

        Return emp_id

    End Function

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Try

            If cmboxLoginType.Text.Equals("Employee") AndAlso Convert.ToInt32(txtUserID.Text) = verifyEmployeeId() Then

                disableRights(Frm_Main.btnAdmin, Frm_Main.btnDeptt, Frm_Main.btnSearch, Frm_Main.btnEmployee, Frm_Main.MenuStrip)
                Frm_Employee_Performance.emp_id = Convert.ToInt32(txtUserID.Text)
                'enableRights(Frm_Employee_Performance.emp_id = Convert.ToInt32)(txtUserID.Text, Frm_Main.btnDeptt, Frm_Main.btnSearch, Frm_Main.MenuStrip)

                Frm_Main.flag = 0
                Frm_Main.flag3 = 0
                Frm_Main.Show()
                ' Frm_Main.btnLogout.Visible = True
                formClear()

            ElseIf cmboxLoginType.Text.Equals("Admin") AndAlso txtUserID.Text.Equals("aisha") AndAlso txtPass.Text.Equals("khalfan") Then

                enableRights(Frm_Main.btnAdmin, Frm_Main.btnDeptt, Frm_Main.btnSearch, Frm_Main.btnEmployee, Frm_Main.MenuStrip)
                Frm_Main.Show()
                Frm_Main.flag = 1
                Frm_Main.flag3 = 1
                Frm_Main.btnLogout.Visible = True
                Frm_Main.btnAdmin.Enabled = False
                formClear()
            Else

                MsgBox("Must Enter A Valid Login Details")

            End If

        Catch ex As Exception

            If cmboxLoginType.Text.Equals("Employee") Then

                MsgBox("Must Enter A Valid Employee ID")

            End If

        End Try

    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    
    Private Sub Frm_Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class