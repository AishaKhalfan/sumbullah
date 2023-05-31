Public Class Frm_PerformanceAll

    Dim flag As Integer = 0
    Dim monthName As String = String.Empty

    Private Function monthPerformance(ByRef monthName As String) As DataTable

        Dim query = "Select E.employee_id , E.full_name , " & monthName
        query = query & " From Employee_Performance_Table Ept"
        query = query & " Inner Join Employee E On E.employee_id = Ept.employee_id"
        query = query & " Inner Join Performance P On P.performance_id = Ept.performance_id"

        Return getDataTable(query)

    End Function

    Private Sub cmboxMonths_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxMonths.SelectedIndexChanged

        If cmboxMonths.Text.Equals("January") Then

            dgvPerformance.DataSource = monthPerformance("perf_january")

        ElseIf cmboxMonths.Text.Equals("Feburary") Then

            dgvPerformance.DataSource = monthPerformance("perf_feburary")

        ElseIf cmboxMonths.Text.Equals("March") Then

            dgvPerformance.DataSource = monthPerformance("perf_march")

        ElseIf cmboxMonths.Text.Equals("April") Then

            dgvPerformance.DataSource = monthPerformance("perf_april")

        ElseIf cmboxMonths.Text.Equals("May") Then

            dgvPerformance.DataSource = monthPerformance("perf_may")

        ElseIf cmboxMonths.Text.Equals("June") Then

            dgvPerformance.DataSource = monthPerformance("perf_june")

        ElseIf cmboxMonths.Text.Equals("July") Then

            dgvPerformance.DataSource = monthPerformance("perf_july")

        ElseIf cmboxMonths.Text.Equals("August") Then

            dgvPerformance.DataSource = monthPerformance("perf_august")

        ElseIf cmboxMonths.Text.Equals("September") Then

            dgvPerformance.DataSource = monthPerformance("perf_september")

        ElseIf cmboxMonths.Text.Equals("October") Then

            dgvPerformance.DataSource = monthPerformance("perf_october")

        ElseIf cmboxMonths.Text.Equals("November") Then

            dgvPerformance.DataSource = monthPerformance("perf_november")

        ElseIf cmboxMonths.Text.Equals("December") Then

            dgvPerformance.DataSource = monthPerformance("perf_december")

        End If

    End Sub

    Private Sub Frm_PerformanceAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Size = New Size(605, 582)
        Me.lblPerf.Location = New Point(123, 6)

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If flag = 0 Then
            Me.btnUpdate.Text = "<< Update Performance"
            Me.Size = New Size(1068, 582)
            Me.lblPerf.Location = New Point(382, 6)
            flag = 1
        ElseIf flag = 1 Then
            Me.btnUpdate.Text = "Update Performance >>"
            Me.Size = New Size(605, 582)
            Me.lblPerf.Location = New Point(123, 6)
            flag = 0
        End If

    End Sub

    Private Function employeePerformance(ByVal employeeID As Integer, ByVal monthName As String) As DataTable

        Dim query = "Select E.employee_id , E.full_name, P.performance_id, P." & monthName
        query = query & " From Employee_Performance_Table Ept"
        query = query & " Inner Join Employee E on E.employee_id = Ept.employee_id"
        query = query & " Inner Join Performance P on P.performance_id = Ept.performance_id"
        query = query & " Where E.employee_id ='" & employeeID & "'"

        Return getDataTable(query)

    End Function

    Private Sub cmboxMonths2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxMonths2.SelectedIndexChanged

        If cmboxMonths2.Text.Equals("January") Then

            monthName = "perf_january"

        ElseIf cmboxMonths2.Text.Equals("Feburary") Then

            monthName = "perf_feburary"

        ElseIf cmboxMonths2.Text.Equals("March") Then

            monthName = "perf_march"

        ElseIf cmboxMonths2.Text.Equals("April") Then

            monthName = "perf_april"

        ElseIf cmboxMonths2.Text.Equals("May") Then

            monthName = "perf_may"

        ElseIf cmboxMonths2.Text.Equals("June") Then

            monthName = "perf_june"

        ElseIf cmboxMonths2.Text.Equals("July") Then

            monthName = "perf_july"

        ElseIf cmboxMonths2.Text.Equals("August") Then

            monthName = "perf_august"

        ElseIf cmboxMonths2.Text.Equals("September") Then

            monthName = "perf_september"

        ElseIf cmboxMonths2.Text.Equals("October") Then

            monthName = "perf_october"

        ElseIf cmboxMonths2.Text.Equals("November") Then

            monthName = "perf_november"

        ElseIf cmboxMonths2.Text.Equals("December") Then

            monthName = "perf_december"

        End If

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Try

            Dim dt As DataTable = employeePerformance(Convert.ToInt32(txtID.Text), monthName)

            For Each row As DataRow In dt.Rows

                dgvEmployee.Rows.Add()
                dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("PerfID").Value = row("performance_id")
                dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpID").Value = row("employee_id")
                dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("EmpName").Value = row("full_name")
                dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("PerfMonth").Value = row(monthName)
                dgvEmployee.Rows(dgvEmployee.RowCount - 1).Cells("FromDB").Value = True
                dgvEmployee.Rows(dgvEmployee.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black

            Next

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        
        Try

            Dim query = "Update Performance set " & monthName & " = " & dgvEmployee.SelectedRows(0).Cells("PerfMonth").Value & " Where performance_id = " & dgvEmployee.SelectedRows(0).Cells("PerfID").Value & ""
            executeQuery(query)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

End Class