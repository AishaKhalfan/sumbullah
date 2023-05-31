Public Class Frm_Employee

    Dim emp_id

    Function emptyFields()

        If txtName.Text = "" OrElse txtAge.Text = "" OrElse txtEmail.Text = "" OrElse txtAddress.Text = "" OrElse txtSalary.Text = "" Then

            Return True

        End If

        Return False

    End Function

    Sub formClear()

        txtName.Clear()
        txtAge.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtSalary.Clear()

    End Sub


    Private Sub add()

        If emptyFields() = True Then

            MsgBox("Must Enter In All Fields ", MsgBoxStyle.Information)

            Return

        Else

            dgvEmployee.Rows.Add()
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpID").Value = txtID.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpName").Value = txtName.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpAge").Value = txtAge.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpEmail").Value = txtEmail.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpPhone").Value = txtPhone.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpAddress").Value = txtAddress.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpSalary").Value = txtSalary.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpDepttID").Value = cmboxDeptt.SelectedValue
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpDeptt").Value = cmboxDeptt.Text
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue

        End If

        formClear()

    End Sub

    Private Sub edit()

        If dgvEmployee.SelectedRows.Count = 0 Then

            Return

        End If

        If btnEdit.Text = "Edit" Then

            txtID.Text = dgvEmployee.SelectedRows(0).Cells("EmpID").Value
            txtName.Text = dgvEmployee.SelectedRows(0).Cells("EmpName").Value
            txtAge.Text = dgvEmployee.SelectedRows(0).Cells("EmpAge").Value
            txtEmail.Text = dgvEmployee.SelectedRows(0).Cells("EmpEmail").Value
            txtPhone.Text = dgvEmployee.SelectedRows(0).Cells("EmpPhone").Value
            txtAddress.Text = dgvEmployee.SelectedRows(0).Cells("EmpAddress").Value
            txtSalary.Text = dgvEmployee.SelectedRows(0).Cells("EmpSalary").Value
            cmboxDeptt.SelectedValue = dgvEmployee.SelectedRows(0).Cells("EmpDepttID").Value
            cmboxDeptt.Text = dgvEmployee.SelectedRows(0).Cells("EmpDeptt").Value
            dgvEmployee.Enabled = False
            btnEdit.Text = "Update"

        Else

            dgvEmployee.SelectedRows(0).Cells("EmpID").Value = txtID.Text
            dgvEmployee.SelectedRows(0).Cells("EmpName").Value = txtName.Text
            dgvEmployee.SelectedRows(0).Cells("EmpAge").Value = txtAge.Text
            dgvEmployee.SelectedRows(0).Cells("EmpEmail").Value = txtEmail.Text
            dgvEmployee.SelectedRows(0).Cells("EmpPhone").Value = txtPhone.Text
            dgvEmployee.SelectedRows(0).Cells("EmpAddress").Value = txtAddress.Text
            dgvEmployee.SelectedRows(0).Cells("EmpSalary").Value = txtSalary.Text
            dgvEmployee.SelectedRows(0).Cells("EmpDepttID").Value = cmboxDeptt.SelectedValue
            dgvEmployee.SelectedRows(0).Cells("EmpDeptt").Value = cmboxDeptt.Text
            dgvEmployee.Enabled = True
            btnEdit.Text = "Edit"


        End If

        dgvEmployee.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Blue

    End Sub

    Private Sub remove()

        If dgvEmployee.SelectedRows.Count = 0 Then

            Return

        End If

        dgvEmployee.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Red

    End Sub

    Private Sub apply()

        Dim query As String = String.Empty

        For Each row As DataGridViewRow In dgvEmployee.Rows

            If row.Cells("FromDB").Value = True Then

                If row.DefaultCellStyle.ForeColor = Color.Black Then

                    Continue For

                ElseIf row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Update Employee set EmpName = '" & row.Cells("EmpName").Value & "',age = '" & row.Cells("EmpAge").Value & "',email = '" & row.Cells("EmpEmail").Value & "',phone_number = '" & row.Cells("EmpPhone").Value & "',address = '" & row.Cells("EmpAddress").Value & "',salary = '" & row.Cells("EmpSalary").Value & "', department_id = '" & row.Cells("EmpDepttID").Value & "' Where employee_id = '" & row.Cells("EmpID").Value & "'"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    query = "Delete From Employee Where employee_id = " & row.Cells("EmpID").Value

                End If


            Else

                If row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Insert Into Employee (EmpName,age,email,phone_number,address,salary,department_id) Values ('" & row.Cells("EmpName").Value & "','" & row.Cells("EmpAge").Value & "','" & row.Cells("EmpEmail").Value & "','" & row.Cells("EmpPhone").Value & "','" & row.Cells("EmpAddress").Value & "','" & row.Cells("EmpSalary").Value & "','" & row.Cells("EmpDepttID").Value & "')"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    dgvEmployee.Rows.Remove(row)

                    Continue For

                End If

            End If

            executeQuery(query)

        Next

        reload()

    End Sub

    Private Sub reload()

        Dim query As String
        query = "Select	E.*, D.department_name, D.department_id"
        query = query + " From	Employee E "
        query = query + " Inner Join Department D On E.department_id = D.department_id"

        dgvEmployee.Rows.Clear()

        Dim dt As DataTable = getDataTable(query)

        For Each row As DataRow In dt.Rows

            dgvEmployee.Rows.Add()
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpID").Value = row("employee_id")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpName").Value = row("EmpName")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpAge").Value = row("age")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpEmail").Value = row("email")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpPhone").Value = row("phone_number")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpAddress").Value = row("address")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpSalary").Value = row("salary")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpDepttID").Value = row("department_id")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpDeptt").Value = row("department_name")
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("FromDB").Value = True
            dgvEmployee.Rows(dgvEmployee.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black

        Next

        txtID.Text = autoId().ToString()

    End Sub

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

    Private Function autoId() As Integer ' generating auto employee id for a new employee

        Dim query = "Select IsNull(Max(employee_id+1),0) employee_id From Employee"
        Dim dr As SqlClient.SqlDataReader
        dr = getDataReader(query)
        dr.Read()
        emp_id = dr("employee_id")
        dr.Close()

        Return emp_id

    End Function

    Private Sub Frm_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fillCmboxDepartment() ' loading all department names from database to combobox department
            loadAllEmployees() ' loading all employee names from database to combobox employee for searching purpose
            loadAllJobTitles() ' loading all job titles from database to combobox job titles
            reload()
            txtID.Text = autoId().ToString()
            dateTimeEnd.MinDate = Now
            dateTimeJoin.MinDate = Now
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadAllEmployees()

        Dim query As String = "Select employee_id, EmpName From Employee order by EmpName"
        Dim dtEmp As DataTable = getDataTable(query)

        cmboxNames.DataSource = dtEmp
        cmboxNames.DisplayMember = "EmpName"
        cmboxNames.ValueMember = "employee_id"

        If cmboxNames.Items.Count > 0 Then
            cmboxNames.SelectedIndex = 0
        End If

    End Sub

    Private Sub lstboxNames_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim name = lstboxNames.SelectedItem.ToString()

        Dim query As IEnumerable(Of DataGridViewRow) = _
            From row As DataGridViewRow In dgvEmployee.Rows _
            Where row.Cells("EmpName").Value.ToString().Contains(name) _
            Select row

        For Each row As DataGridViewRow In query
            row.Selected = True
        Next

    End Sub

    Private Sub loadAllJobTitles()

        Dim query As String = "Select job_id, job_title From Employee_Job_Info order by job_title"
        Dim dtEmp As DataTable = getDataTable(query)

        cmboxTitle.DataSource = dtEmp
        cmboxTitle.DisplayMember = "job_title"
        cmboxTitle.ValueMember = "job_id"

        If cmboxTitle.Items.Count > 0 Then
            cmboxTitle.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnAddJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddJob.Click
        Try
            add()
            apply()
            Dim query = "Insert Into Employee_Job_History(employee_id,start_date,end_date,job_id,department_id) Values ('" & Convert.ToInt32(emp_id - 1) & "','" & dateTimeJoin.Value & "','" & dateTimeEnd.Value & "','" & cmboxTitle.SelectedValue & "','" & cmboxDeptt.SelectedValue & "')"
            executeQuery(query)
            MsgBox("Employee And Job Added Successfully")
            TabControl1.TabPages("Employee Details").Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            add()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            edit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnRemove_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            remove()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnApply_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Try
            apply()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            apply()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        lstboxNames.Items.Add(cmboxNames.Text)
    End Sub

    Private Sub cmboxNames_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxNames.SelectedIndexChanged

        Dim name = cmboxNames.Text

        Dim query As IEnumerable(Of DataGridViewRow) = _
            From row As DataGridViewRow In dgvEmployee.Rows _
            Where row.Cells("EmpName").Value.ToString().Contains(name) _
            Select row

        For Each row As DataGridViewRow In query
            row.Selected = True
        Next
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then   'Ristricting TxtName To Input Only Characters
            e.Handled = True
        End If
    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting age To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting TxtPhone To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub

    Private Sub txtSalary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalary.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting salary To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmboxTitle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmboxTitle.SelectedIndexChanged

    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged

    End Sub
End Class
