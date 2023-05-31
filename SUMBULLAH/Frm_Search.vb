Public Class Frm_Search

    Private Sub fillCmboxDepartment() ' for getting deparment names from database

        Dim query As String = "Select department_id, department_name From Department order by department_name"
        Dim dtDeptt As DataTable = getDataTable(query)

        cmboxDeptt.DataSource = dtDeptt
        cmboxDeptt.DisplayMember = "department_name"
        cmboxDeptt.ValueMember = "department_id"

        If cmboxDeptt.Items.Count > 0 Then
            cmboxDeptt.SelectedIndex = 0
        End If

    End Sub

    Private Sub fillCmBoxJobTitles()

        Dim query As String = "Select job_id, job_title From Employee_Job_Info order by job_title"
        Dim dtEmp As DataTable = getDataTable(query)

        cmboxTitle.DataSource = dtEmp
        cmboxTitle.DisplayMember = "job_title"
        cmboxTitle.ValueMember = "job_id"

        If cmboxTitle.Items.Count > 0 Then
            cmboxTitle.SelectedIndex = 0
        End If

    End Sub

    Private Sub Frm_Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.DoubleBuffered = True
            Me.Invalidate()
            fillCmboxDepartment()
            fillCmBoxJobTitles()
            cmboxDeptt.Text = "Select - Department"

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub cmboxDeptt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxDeptt.SelectedIndexChanged

        Try

            Dim query = "Select E.* "
            query = query & " From Employee E"
            query = query & " Inner Join Department D on E.department_id = D.department_id"
            query = query & " Where department_name = '" & cmboxDeptt.Text & "'"
            dgvEmployee.DataSource = getDataTable(query)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub cmboxTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxTitle.SelectedIndexChanged

        Try

            Dim query = "Select E.employee_id, E.EmpName, J.start_date , J.end_date, D.department_name"
            query = query & " From Employee_Job_History J"
            query = query & " Inner Join Employee E on E.employee_id = J.employee_id "
            query = query & " Inner Join Department D on D.department_id = J.department_id"
            query = query & " Inner Join Employee_Job_Info Ji on Ji.job_id = J.job_id"
            query = query & " Where Ji.job_title = '" & cmboxTitle.Text & "'"
            dgvEmployeeJob.DataSource = getDataTable(query)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Try

            Dim query = "Select E.employee_id, E.EmpName, E.salary, D.department_name"
            query = query & " From Employee E"
            query = query & " Inner Join Department D on D.department_id = E.department_id"
            query = query & " Where E.salary > " & Convert.ToInt32(txtStart.Text) & " And E.salary < " & Convert.ToInt32(txtEnd.Text) & ""
            dgvSalary.DataSource = getDataTable(query)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub grpDeptt_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles grpDeptt.Paint

    End Sub
End Class