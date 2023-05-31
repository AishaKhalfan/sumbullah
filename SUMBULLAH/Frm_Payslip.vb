Public Class Frm_Payslip
    Dim pay As New dbase("Search")
    Dim dept As New dbase("Department")
    Dim dr() As DataRow
    Dim e As Integer

    Private Sub Frm_Payslip_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load, MyBase.Enter
        Emp_IDTextBox.DataBindings.Add("text", pay.dt, "employee_id")
        EmpNameTextBox.DataBindings.Add("text", pay.dt, "EmpName")
        DepartmentTextBox.DataBindings.Add("text", pay.dt, "Department")
        AddressTextBox.DataBindings.Add("text", pay.dt, "Address")
        BasicSalTextBox.DataBindings.Add("text", pay.dt, "BasicSal")
        LeaveTextBox.DataBindings.Add("text", pay.dt, "Leave")
        DATextBox.DataBindings.Add("text", pay.dt, "DA")
        TATextBox.DataBindings.Add("text", pay.dt, "TA")
        TextBox1.DataBindings.Add("text", pay.dt, "Date_Of_Join")
        HRATextBox.DataBindings.Add("text", pay.dt, "HRA")
        PFTextBox.DataBindings.Add("text", pay.dt, "PF")
        ITAXTextBox.DataBindings.Add("text", pay.dt, "ITAX")
        COMMTextBox.DataBindings.Add("text", pay.dt, "COMM")
        Net_SalaryTextBox.DataBindings.Add("text", pay.dt, "Net_Salary")
        ComboBox1.DataSource = dept.dt
        ComboBox1.DisplayMember = "Department"
        'Label2.Text = Now
        Me.Width = "665"
        Me.Height = "740"
        'Dim a As String
        'a = Val(TextBox1.Text) / 30    '##Calculate one day salary##'

        'TextBox9.Text = (Val(TextBox1.Text) - (Val(TextBox2.Text) * Val(a))) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) - Val(TextBox6.Text) - Val(TextBox7.Text) + Val(TextBox8.Text)


    End Sub

    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button2.Enabled = True
        Me.BindingContext(pay.dt).AddNew()
        DepartmentTextBox.Visible = False
        DepartmentTextBox.Text = ComboBox1.Text
        Emp_IDTextBox.Focus()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim a, b, c, d, h As String
        a = Val(BasicSalTextBox.Text) / 30    '##Calculate one day salary##'
        b = (Val(BasicSalTextBox.Text) - (Val(LeaveTextBox.Text) * Val(a)))  '##Calculate one leave salary##'
        c = (Val(DATextBox.Text) + Val(TATextBox.Text) + Val(HRATextBox.Text))
        d = (Val(b) * Val(PFTextBox.Text)) / 100
        h = (Val(b) * Val(ITAXTextBox.Text)) / 100       '(Val(b) + Val(c) + Val(d)) + Val(BasicSalTextBox.Text)

        Net_SalaryTextBox.Text = (Val(b) - Val(d) - Val(h) + Val(c) + Val(COMMTextBox.Text))

        'Net_SalaryTextBox.Text = (Val(BasicSalTextBox.Text) - (Val(LeaveTextBox.Text) * Val(a))) + Val(DATextBox.Text) + Val(HRATextBox.Text) + Val(TATextBox.Text) - Val(PFTextBox.Text) - Val(ITAXTextBox.Text) + Val(COMMTextBox.Text)
        '*****************************************************************************************
        Button2.Enabled = False
        On Error GoTo er
        'TextBox6.Text = 0
        Me.BindingContext(pay.dt).EndCurrentEdit()
        pay.save()
        DepartmentTextBox.Visible = True
        'TextBox6.Visible = True
        Exit Sub
er:
        MsgBox(Err.Description)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'Me.ValidateChildren()
        'Me.Emp_detailTableAdapter.Update(Me.Payroll1DataSet.emp_detail)
        Me.BindingContext(pay.dt).RemoveAt(Me.BindingContext(pay.dt).Position)
        Button2.PerformClick()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.BindingContext(pay.dt).CancelCurrentEdit()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Visible = False
            Frm_Main.Show()
            pay.con.Close()
            dept.con.Close()
        ElseIf MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.BindingContext(pay.dt).Position = 0
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.BindingContext(pay.dt).Position -= 1
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Me.BindingContext(pay.dt).Position += 1
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Me.BindingContext(pay.dt).Position = Me.BindingContext(pay.dt).Count - 1
    End Sub


    Private Sub Date_Of_JoinDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Date_Of_JoinDateTimePicker.ValueChanged
        Dim i As String
        i = Format(Me.Date_Of_JoinDateTimePicker.Value, "dd-MMM-yy")
        Me.TextBox1.Text = i
    End Sub
End Class