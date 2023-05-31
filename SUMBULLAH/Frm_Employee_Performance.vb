Public Class Frm_Employee_Performance

    Public Shared emp_id = 0    
    Dim monthName As String = String.Empty

    Private Function employeePerformance(ByVal employeeID As Integer, ByVal monthName As String) As DataTable

        Dim query = "Select E.employee_id , E.full_name, P.performance_id, P." & monthName
        query = query & " From Employee_Performance_Table Ept"
        query = query & " Inner Join Employee E on E.employee_id = Ept.employee_id"
        query = query & " Inner Join Performance P on P.performance_id = Ept.performance_id"
        query = query & " Where E.employee_id ='" & employeeID & "'"

        Return getDataTable(query)

    End Function

    Private Sub showPerfInDataGrid()

        Dim dt As DataTable = employeePerformance(emp_id, monthName)

        dgvPerformance.Rows.Clear()

        For Each row As DataRow In dt.Rows

            dgvPerformance.Rows.Add()
            dgvPerformance.Rows(dgvPerformance.RowCount - 1).Cells("PerfID").Value = row("performance_id")
            dgvPerformance.Rows(dgvPerformance.RowCount - 1).Cells("EmpID").Value = row("employee_id")
            dgvPerformance.Rows(dgvPerformance.RowCount - 1).Cells("EmpName").Value = row("full_name")
            dgvPerformance.Rows(dgvPerformance.RowCount - 1).Cells("PerfMonth").Value = row(monthName)         

        Next

    End Sub

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

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        showPerfInDataGrid()
    End Sub
End Class