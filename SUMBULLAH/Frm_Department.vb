Public Class Frm_Department

    Dim deptt_id

    Private Sub loadAllManagers()

        Dim query As String = "Select manager_id, manager_name From Manager order by manager_name"
        Dim dtEmp As DataTable = getDataTable(query)

        cmboxManagers.DataSource = dtEmp
        cmboxManagers.DisplayMember = "manager_name"
        cmboxManagers.ValueMember = "manager_id"

        If cmboxManagers.Items.Count > 0 Then
            cmboxManagers.SelectedIndex = 0
        End If

    End Sub

    Function emptyFields()

        If txtName.Text = "" OrElse txtPhone.Text = "" OrElse txtStrength.Text = "" Then

            Return True

        End If

        Return False

    End Function

    Sub formClear()

        txtName.Clear()
        txtPhone.Clear()
        txtStrength.Clear()

    End Sub

    Private Function autoId() As Integer ' generating auto employee id for a new employee

        Dim query = "Select IsNull(Max(department_id+1),0) department_id From Department"
        Dim dr As SqlClient.SqlDataReader
        dr = getDataReader(query)
        dr.Read()
        deptt_id = dr("department_id")
        dr.Close()

        Return deptt_id

    End Function

    Private Sub add()

        If emptyFields() = True Then

            MsgBox("Must Enter In All Fields ", MsgBoxStyle.Information)

            Return

        Else

            dgvDeptt.Rows.Add()
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttID").Value = txtID.Text
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttName").Value = txtName.Text
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttPhone").Value = txtPhone.Text
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttStrength").Value = txtStrength.Text
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttManID").Value = cmboxManagers.SelectedValue
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttManName").Value = cmboxManagers.Text
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue

        End If

        formClear()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            add()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub edit()

        If dgvDeptt.SelectedRows.Count = 0 Then

            Return

        End If

        If btnEdit.Text = "Edit" Then

            txtID.Text = dgvDeptt.SelectedRows(0).Cells("DepttID").Value
            txtName.Text = dgvDeptt.SelectedRows(0).Cells("DepttName").Value
            txtPhone.Text = dgvDeptt.SelectedRows(0).Cells("DepttPhone").Value
            txtStrength.Text = dgvDeptt.SelectedRows(0).Cells("DepttStrength").Value
            cmboxManagers.SelectedValue = dgvDeptt.SelectedRows(0).Cells("DepttManID").Value
            cmboxManagers.Text = dgvDeptt.SelectedRows(0).Cells("DepttManName").Value
            dgvDeptt.Enabled = False
            btnEdit.Text = "Update"

        Else

            dgvDeptt.SelectedRows(0).Cells("DepttID").Value = txtID.Text
            dgvDeptt.SelectedRows(0).Cells("DepttName").Value = txtName.Text
            dgvDeptt.SelectedRows(0).Cells("DepttPhone").Value = txtPhone.Text
            dgvDeptt.SelectedRows(0).Cells("DepttStrength").Value = txtStrength.Text
            dgvDeptt.SelectedRows(0).Cells("DepttManID").Value = cmboxManagers.SelectedValue
            dgvDeptt.SelectedRows(0).Cells("DepttManName").Value = cmboxManagers.Text
            dgvDeptt.Enabled = True
            btnEdit.Text = "Edit"


        End If

        dgvDeptt.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Blue

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            edit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub remove()

        If dgvDeptt.SelectedRows.Count = 0 Then

            Return

        End If

        dgvDeptt.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Red

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            remove()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub apply()

        Dim query As String = String.Empty

        For Each row As DataGridViewRow In dgvDeptt.Rows

            If row.Cells("FromDB").Value = True Then

                If row.DefaultCellStyle.ForeColor = Color.Black Then

                    Continue For

                ElseIf row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Update Department set department_name = '" & row.Cells("DepttName").Value & "',strength = '" & row.Cells("DepttStrength").Value & "',phone_number = '" & row.Cells("DepttPhone").Value & "',manager_id = '" & row.Cells("DepttManID").Value & "' Where department_id = '" & row.Cells("DepttID").Value & "'"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    query = "Delete From Department Where department_id = " & row.Cells("DepttID").Value

                End If


            Else

                If row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Insert Into Department (department_name,strength,phone_number,manager_id) Values ('" & row.Cells("DepttName").Value & "','" & row.Cells("DepttStrength").Value & "','" & row.Cells("DepttPhone").Value & "','" & row.Cells("DepttManID").Value & "')"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    dgvDeptt.Rows.Remove(row)

                    Continue For

                End If

            End If

            executeQuery(query)

        Next

        reload()

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Try
            apply()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            apply()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub reload()

        Dim query As String
        query = "Select	D.*, M.manager_name, M.manager_id"
        query = query + " From	Department D "
        query = query + " Inner Join Manager M On D.manager_id = M.manager_id"

        dgvDeptt.Rows.Clear()

        Dim dt As DataTable = getDataTable(query)

        For Each row As DataRow In dt.Rows

            dgvDeptt.Rows.Add()
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttID").Value = row("department_id")
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttName").Value = row("department_name")
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttStrength").Value = row("strength")
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttPhone").Value = row("phone_number")
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttManID").Value = row("manager_id")
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("DepttManName").Value = row("manager_name")
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).Cells("FromDB").Value = True
            dgvDeptt.Rows(dgvDeptt.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black

        Next

        txtID.Text = autoId()

    End Sub

    Private Sub Frm_Department_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadAllManagers()
            'txtID.Text = autoId()
            reload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then   'Ristricting Deptt name To Input Only Characters
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting TxtPhone To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub

    Private Sub txtStrength_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStrength.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting strength To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub

    Private Sub cmboxManagers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmboxManagers.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub txtPhone_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPhone.TextChanged

    End Sub
End Class