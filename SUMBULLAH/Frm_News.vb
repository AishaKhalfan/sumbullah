Public Class Frm_News

    Dim news_id = 0

    Sub formClear()

        txtTitle.Clear()
        txtDesc.Clear()

    End Sub

    Private Function autoId() As Integer ' generating auto news id 

        Dim query = "Select IsNull(Max(news_id+1),0) news_id From News"
        Dim dr As SqlClient.SqlDataReader
        dr = getDataReader(query)
        dr.Read()
        news_id = dr("news_id")
        dr.Close()

        Return news_id

    End Function

    Private Sub add()

        dgvNews.Rows.Add()
        dgvNews.Rows(dgvNews.RowCount - 1).Cells("NewsID").Value = txtID.Text
        dgvNews.Rows(dgvNews.RowCount - 1).Cells("NewsTitle").Value = txtTitle.Text
        dgvNews.Rows(dgvNews.RowCount - 1).Cells("NewsDesc").Value = txtDesc.Text
        dgvNews.Rows(dgvNews.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue

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

        If dgvNews.SelectedRows.Count = 0 Then

            Return

        End If

        If btnEdit.Text = "Edit" Then

            txtID.Text = dgvNews.SelectedRows(0).Cells("NewsID").Value
            txtTitle.Text = dgvNews.SelectedRows(0).Cells("NewsTitle").Value
            txtDesc.Text = dgvNews.SelectedRows(0).Cells("NewsDesc").Value
            dgvNews.Enabled = False
            btnEdit.Text = "Update"

        Else

            dgvNews.SelectedRows(0).Cells("NewsID").Value = txtID.Text
            dgvNews.SelectedRows(0).Cells("NewsTitle").Value = txtTitle.Text
            dgvNews.SelectedRows(0).Cells("NewsDesc").Value = txtDesc.Text
            dgvNews.Enabled = True
            btnEdit.Text = "Edit"


        End If

        dgvNews.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Blue

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            edit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub remove()

        If dgvNews.SelectedRows.Count = 0 Then

            Return

        End If

        dgvNews.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Red

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

        For Each row As DataGridViewRow In dgvNews.Rows

            If row.Cells("FromDB").Value = True Then

                If row.DefaultCellStyle.ForeColor = Color.Black Then

                    Continue For

                ElseIf row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Update News set news_title = '" & row.Cells("NewsTitle").Value & "',news_description = '" & row.Cells("NewsDesc").Value & "' Where news_id = '" & row.Cells("NewsID").Value & "'"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    query = "Delete From News Where news_id = " & row.Cells("NewsID").Value

                End If


            Else

                If row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Insert Into News (news_title,news_description) Values ('" & row.Cells("NewsTitle").Value & "','" & row.Cells("NewsDesc").Value & "')"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    dgvNews.Rows.Remove(row)

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
        query = "Select	* From News"
        
        dgvNews.Rows.Clear()

        Dim dt As DataTable = getDataTable(query)

        For Each row As DataRow In dt.Rows

            dgvNews.Rows.Add()
            dgvNews.Rows(dgvNews.RowCount - 1).Cells("NewsID").Value = row("news_id")
            dgvNews.Rows(dgvNews.RowCount - 1).Cells("NewsTitle").Value = row("news_title")
            dgvNews.Rows(dgvNews.RowCount - 1).Cells("NewsDesc").Value = row("news_description")
            dgvNews.Rows(dgvNews.RowCount - 1).Cells("FromDB").Value = True
            dgvNews.Rows(dgvNews.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black

        Next

        txtID.Text = autoId()

    End Sub

    Private Sub Frm_News_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class