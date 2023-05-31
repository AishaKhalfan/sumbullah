<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Search
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpDeptt = New CloudToolkitN6.CloudGroup()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmboxDeptt = New System.Windows.Forms.ComboBox()
        Me.grpSalary = New CloudToolkitN6.CloudGroup()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.dgvSalary = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpJob = New CloudToolkitN6.CloudGroup()
        Me.dgvEmployeeJob = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmboxTitle = New System.Windows.Forms.ComboBox()
        Me.grpDeptt.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalary.SuspendLayout()
        CType(Me.dgvSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.grpJob.SuspendLayout()
        CType(Me.dgvEmployeeJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDeptt
        '
        Me.grpDeptt.AnimationEnabled = True
        Me.grpDeptt.AnimationSpeed = 4
        Me.grpDeptt.BackColor = System.Drawing.Color.Transparent
        Me.grpDeptt.BorderColor = System.Drawing.Color.DarkGray
        Me.grpDeptt.BorderWidth = 1.0!
        Me.grpDeptt.Controls.Add(Me.dgvEmployee)
        Me.grpDeptt.Controls.Add(Me.Label7)
        Me.grpDeptt.Controls.Add(Me.cmboxDeptt)
        Me.grpDeptt.FillColor1 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grpDeptt.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grpDeptt.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grpDeptt.FillColor2_2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grpDeptt.FontColorMouseOn = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpDeptt.FontColorNormal = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.grpDeptt.HeaderText = "                       Search Employee By Department"
        Me.grpDeptt.Icon = Nothing
        Me.grpDeptt.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.grpDeptt.IconPadding = 5
        Me.grpDeptt.ImageHeader = False
        Me.grpDeptt.IsOpen = False
        Me.grpDeptt.Location = New System.Drawing.Point(12, 47)
        Me.grpDeptt.MaximumHeight = 250
        Me.grpDeptt.Name = "grpDeptt"
        Me.grpDeptt.PanelColor = System.Drawing.Color.Transparent
        Me.grpDeptt.Size = New System.Drawing.Size(491, 27)
        Me.grpDeptt.TabIndex = 0
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Location = New System.Drawing.Point(12, 81)
        Me.dgvEmployee.MultiSelect = False
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployee.Size = New System.Drawing.Size(468, 150)
        Me.dgvEmployee.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(72, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Department"
        '
        'cmboxDeptt
        '
        Me.cmboxDeptt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxDeptt.FormattingEnabled = True
        Me.cmboxDeptt.Location = New System.Drawing.Point(184, 46)
        Me.cmboxDeptt.Name = "cmboxDeptt"
        Me.cmboxDeptt.Size = New System.Drawing.Size(176, 23)
        Me.cmboxDeptt.TabIndex = 21
        Me.cmboxDeptt.Text = "Select - Department"
        '
        'grpSalary
        '
        Me.grpSalary.AnimationEnabled = True
        Me.grpSalary.AnimationSpeed = 4
        Me.grpSalary.BackColor = System.Drawing.Color.Transparent
        Me.grpSalary.BorderColor = System.Drawing.Color.DarkGray
        Me.grpSalary.BorderWidth = 1.0!
        Me.grpSalary.Controls.Add(Me.btnSubmit)
        Me.grpSalary.Controls.Add(Me.Label3)
        Me.grpSalary.Controls.Add(Me.Label2)
        Me.grpSalary.Controls.Add(Me.txtEnd)
        Me.grpSalary.Controls.Add(Me.txtStart)
        Me.grpSalary.Controls.Add(Me.dgvSalary)
        Me.grpSalary.FillColor1 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grpSalary.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grpSalary.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grpSalary.FillColor2_2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grpSalary.FontColorMouseOn = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpSalary.FontColorNormal = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.grpSalary.HeaderText = "                            Search Employee By Salary"
        Me.grpSalary.Icon = Nothing
        Me.grpSalary.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.grpSalary.IconPadding = 5
        Me.grpSalary.ImageHeader = False
        Me.grpSalary.IsOpen = False
        Me.grpSalary.Location = New System.Drawing.Point(12, 302)
        Me.grpSalary.MaximumHeight = 250
        Me.grpSalary.Name = "grpSalary"
        Me.grpSalary.PanelColor = System.Drawing.Color.Transparent
        Me.grpSalary.Size = New System.Drawing.Size(491, 27)
        Me.grpSalary.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(363, 36)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 46)
        Me.btnSubmit.TabIndex = 35
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(69, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "End Range"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(69, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Start Range"
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(181, 62)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(176, 20)
        Me.txtEnd.TabIndex = 32
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(181, 36)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(176, 20)
        Me.txtStart.TabIndex = 31
        '
        'dgvSalary
        '
        Me.dgvSalary.AllowUserToAddRows = False
        Me.dgvSalary.AllowUserToDeleteRows = False
        Me.dgvSalary.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalary.Location = New System.Drawing.Point(12, 94)
        Me.dgvSalary.MultiSelect = False
        Me.dgvSalary.Name = "dgvSalary"
        Me.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalary.Size = New System.Drawing.Size(468, 137)
        Me.dgvSalary.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(202, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 39)
        Me.Panel2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(0, 809)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 19)
        Me.Panel1.TabIndex = 15
        '
        'grpJob
        '
        Me.grpJob.AnimationEnabled = True
        Me.grpJob.AnimationSpeed = 4
        Me.grpJob.BackColor = System.Drawing.Color.Transparent
        Me.grpJob.BorderColor = System.Drawing.Color.DarkGray
        Me.grpJob.BorderWidth = 1.0!
        Me.grpJob.Controls.Add(Me.dgvEmployeeJob)
        Me.grpJob.Controls.Add(Me.Label4)
        Me.grpJob.Controls.Add(Me.cmboxTitle)
        Me.grpJob.FillColor1 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grpJob.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grpJob.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grpJob.FillColor2_2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grpJob.FontColorMouseOn = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpJob.FontColorNormal = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.grpJob.HeaderText = "                       Search Employee By Job Title"
        Me.grpJob.Icon = Nothing
        Me.grpJob.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.grpJob.IconPadding = 5
        Me.grpJob.ImageHeader = False
        Me.grpJob.IsOpen = False
        Me.grpJob.Location = New System.Drawing.Point(12, 556)
        Me.grpJob.MaximumHeight = 250
        Me.grpJob.Name = "grpJob"
        Me.grpJob.PanelColor = System.Drawing.Color.Transparent
        Me.grpJob.Size = New System.Drawing.Size(491, 27)
        Me.grpJob.TabIndex = 16
        '
        'dgvEmployeeJob
        '
        Me.dgvEmployeeJob.AllowUserToAddRows = False
        Me.dgvEmployeeJob.AllowUserToDeleteRows = False
        Me.dgvEmployeeJob.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvEmployeeJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeJob.Location = New System.Drawing.Point(12, 80)
        Me.dgvEmployeeJob.MultiSelect = False
        Me.dgvEmployeeJob.Name = "dgvEmployeeJob"
        Me.dgvEmployeeJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeJob.Size = New System.Drawing.Size(468, 150)
        Me.dgvEmployeeJob.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(72, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Job Title"
        '
        'cmboxTitle
        '
        Me.cmboxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxTitle.FormattingEnabled = True
        Me.cmboxTitle.Location = New System.Drawing.Point(184, 46)
        Me.cmboxTitle.Name = "cmboxTitle"
        Me.cmboxTitle.Size = New System.Drawing.Size(176, 23)
        Me.cmboxTitle.TabIndex = 21
        Me.cmboxTitle.Text = "Select - Job Title"
        '
        'Frm_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(514, 750)
        Me.Controls.Add(Me.grpJob)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grpSalary)
        Me.Controls.Add(Me.grpDeptt)
        Me.MaximizeBox = False
        Me.Name = "Frm_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.grpDeptt.ResumeLayout(False)
        Me.grpDeptt.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalary.ResumeLayout(False)
        Me.grpSalary.PerformLayout()
        CType(Me.dgvSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.grpJob.ResumeLayout(False)
        Me.grpJob.PerformLayout()
        CType(Me.dgvEmployeeJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDeptt As CloudToolkitN6.CloudGroup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmboxDeptt As System.Windows.Forms.ComboBox
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents grpSalary As CloudToolkitN6.CloudGroup
    Friend WithEvents dgvSalary As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents grpJob As CloudToolkitN6.CloudGroup
    Friend WithEvents dgvEmployeeJob As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmboxTitle As System.Windows.Forms.ComboBox
End Class
