<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalaryAdvances
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstbxEmpList = New System.Windows.Forms.ListBox()
        Me.lblSelectEmp = New System.Windows.Forms.Label()
        Me.grpbxAddSalAdvInfo = New System.Windows.Forms.GroupBox()
        Me.txtPendAdvDue = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPaybackAmt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPaybackDuration = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdvanceAmt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdvanceReason = New System.Windows.Forms.TextBox()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.btnAddSalAdvance = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpbxViewSalAdvInfo = New System.Windows.Forms.GroupBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbSalAdvListForEmp = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.KIPayrollDataSet = New WindowsApp1.KIPayrollDataSet()
        Me.SalaryAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryAdvancesTableAdapter = New WindowsApp1.KIPayrollDataSetTableAdapters.SalaryAdvancesTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.KIPayrollDataSetTableAdapters.TableAdapterManager()
        Me.RetrieveEmpNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetrieveEmpNameTableAdapter = New WindowsApp1.KIPayrollDataSetTableAdapters.RetrieveEmpNameTableAdapter()
        Me.grpbxAddSalAdvInfo.SuspendLayout()
        Me.grpbxViewSalAdvInfo.SuspendLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetrieveEmpNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstbxEmpList
        '
        Me.lstbxEmpList.FormattingEnabled = True
        Me.lstbxEmpList.Location = New System.Drawing.Point(16, 42)
        Me.lstbxEmpList.MaximumSize = New System.Drawing.Size(150, 205)
        Me.lstbxEmpList.Name = "lstbxEmpList"
        Me.lstbxEmpList.Size = New System.Drawing.Size(145, 199)
        Me.lstbxEmpList.TabIndex = 0
        '
        'lblSelectEmp
        '
        Me.lblSelectEmp.AutoSize = True
        Me.lblSelectEmp.Location = New System.Drawing.Point(13, 13)
        Me.lblSelectEmp.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblSelectEmp.Name = "lblSelectEmp"
        Me.lblSelectEmp.Size = New System.Drawing.Size(150, 26)
        Me.lblSelectEmp.TabIndex = 1
        Me.lblSelectEmp.Text = "Select Employee to View Outstanding Salary Advances:"
        '
        'grpbxAddSalAdvInfo
        '
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtPendAdvDue)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.Label8)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtPaybackAmt)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.Label7)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.cmbPaybackDuration)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.Label6)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtAdvanceAmt)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.Label5)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.Label4)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtAdvanceReason)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblEmpName)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtEmpName)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblEmpID)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtEmpID)
        Me.grpbxAddSalAdvInfo.Location = New System.Drawing.Point(190, 13)
        Me.grpbxAddSalAdvInfo.Name = "grpbxAddSalAdvInfo"
        Me.grpbxAddSalAdvInfo.Size = New System.Drawing.Size(464, 232)
        Me.grpbxAddSalAdvInfo.TabIndex = 2
        Me.grpbxAddSalAdvInfo.TabStop = False
        Me.grpbxAddSalAdvInfo.Text = "Salary Advance Information:"
        Me.grpbxAddSalAdvInfo.Visible = False
        '
        'txtPendAdvDue
        '
        Me.txtPendAdvDue.Location = New System.Drawing.Point(171, 198)
        Me.txtPendAdvDue.Name = "txtPendAdvDue"
        Me.txtPendAdvDue.Size = New System.Drawing.Size(77, 20)
        Me.txtPendAdvDue.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total Advance Due:"
        '
        'txtPaybackAmt
        '
        Me.txtPaybackAmt.Location = New System.Drawing.Point(171, 163)
        Me.txtPaybackAmt.Name = "txtPaybackAmt"
        Me.txtPaybackAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtPaybackAmt.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Payback Amount per Month:"
        '
        'cmbPaybackDuration
        '
        Me.cmbPaybackDuration.FormattingEnabled = True
        Me.cmbPaybackDuration.Location = New System.Drawing.Point(171, 129)
        Me.cmbPaybackDuration.Name = "cmbPaybackDuration"
        Me.cmbPaybackDuration.Size = New System.Drawing.Size(77, 21)
        Me.cmbPaybackDuration.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Payback Duration:"
        '
        'txtAdvanceAmt
        '
        Me.txtAdvanceAmt.Location = New System.Drawing.Point(171, 95)
        Me.txtAdvanceAmt.Name = "txtAdvanceAmt"
        Me.txtAdvanceAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtAdvanceAmt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Advance Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Advance Reason:"
        '
        'txtAdvanceReason
        '
        Me.txtAdvanceReason.Location = New System.Drawing.Point(171, 61)
        Me.txtAdvanceReason.Name = "txtAdvanceReason"
        Me.txtAdvanceReason.Size = New System.Drawing.Size(275, 20)
        Me.txtAdvanceReason.TabIndex = 4
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(215, 31)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(87, 13)
        Me.lblEmpName.TabIndex = 3
        Me.lblEmpName.Text = "Employee Name:"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(308, 27)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(138, 20)
        Me.txtEmpName.TabIndex = 2
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(18, 31)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(70, 13)
        Me.lblEmpID.TabIndex = 1
        Me.lblEmpID.Text = "Employee ID:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(94, 27)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(76, 20)
        Me.txtEmpID.TabIndex = 0
        '
        'btnAddSalAdvance
        '
        Me.btnAddSalAdvance.Location = New System.Drawing.Point(99, 266)
        Me.btnAddSalAdvance.Name = "btnAddSalAdvance"
        Me.btnAddSalAdvance.Size = New System.Drawing.Size(141, 23)
        Me.btnAddSalAdvance.TabIndex = 3
        Me.btnAddSalAdvance.Text = "Add New Salary Advance"
        Me.btnAddSalAdvance.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(519, 265)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpbxViewSalAdvInfo
        '
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblLine)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label13)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.cmbSalAdvListForEmp)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.TextBox1)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label1)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.TextBox2)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label2)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.ComboBox1)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label3)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.TextBox3)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label9)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label10)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.TextBox4)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label11)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.TextBox5)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.Label12)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.TextBox6)
        Me.grpbxViewSalAdvInfo.Location = New System.Drawing.Point(190, 308)
        Me.grpbxViewSalAdvInfo.Name = "grpbxViewSalAdvInfo"
        Me.grpbxViewSalAdvInfo.Size = New System.Drawing.Size(464, 271)
        Me.grpbxViewSalAdvInfo.TabIndex = 6
        Me.grpbxViewSalAdvInfo.TabStop = False
        Me.grpbxViewSalAdvInfo.Text = "Salary Advance Information:"
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblLine.Location = New System.Drawing.Point(8, 55)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(450, 3)
        Me.lblLine.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 23)
        Me.Label13.MaximumSize = New System.Drawing.Size(150, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 26)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Select Salary Advance Info to View:"
        '
        'cmbSalAdvListForEmp
        '
        Me.cmbSalAdvListForEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSalAdvListForEmp.FormattingEnabled = True
        Me.cmbSalAdvListForEmp.Location = New System.Drawing.Point(160, 23)
        Me.cmbSalAdvListForEmp.Name = "cmbSalAdvListForEmp"
        Me.cmbSalAdvListForEmp.Size = New System.Drawing.Size(253, 21)
        Me.cmbSalAdvListForEmp.TabIndex = 28
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(171, 239)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(77, 20)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Total Advance Due:"
        Me.Label1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(171, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(77, 20)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Payback Amount per Month:"
        Me.Label2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(171, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(77, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Payback Duration:"
        Me.Label3.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(171, 136)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(77, 20)
        Me.TextBox3.TabIndex = 21
        Me.TextBox3.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Advance Amount:"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Advance Reason:"
        Me.Label10.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(171, 102)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(275, 20)
        Me.TextBox4.TabIndex = 18
        Me.TextBox4.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Employee Name:"
        Me.Label11.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(308, 68)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(138, 20)
        Me.TextBox5.TabIndex = 16
        Me.TextBox5.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Employee ID:"
        Me.Label12.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(94, 68)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(76, 20)
        Me.TextBox6.TabIndex = 14
        Me.TextBox6.Visible = False
        '
        'KIPayrollDataSet
        '
        Me.KIPayrollDataSet.DataSetName = "KIPayrollDataSet"
        Me.KIPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalaryAdvancesBindingSource
        '
        Me.SalaryAdvancesBindingSource.DataMember = "SalaryAdvances"
        Me.SalaryAdvancesBindingSource.DataSource = Me.KIPayrollDataSet
        '
        'SalaryAdvancesTableAdapter
        '
        Me.SalaryAdvancesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpInfoArchiveTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeMasterTableAdapter = Nothing
        Me.TableAdapterManager.SalaryAdvancesTableAdapter = Me.SalaryAdvancesTableAdapter
        Me.TableAdapterManager.SalaryCalculationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.KIPayrollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RetrieveEmpNameBindingSource
        '
        Me.RetrieveEmpNameBindingSource.DataSource = Me.KIPayrollDataSet
        Me.RetrieveEmpNameBindingSource.Position = 0
        '
        'RetrieveEmpNameTableAdapter
        '
        Me.RetrieveEmpNameTableAdapter.ClearBeforeFill = True
        '
        'SalaryAdvances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 677)
        Me.Controls.Add(Me.grpbxViewSalAdvInfo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAddSalAdvance)
        Me.Controls.Add(Me.grpbxAddSalAdvInfo)
        Me.Controls.Add(Me.lblSelectEmp)
        Me.Controls.Add(Me.lstbxEmpList)
        Me.Name = "SalaryAdvances"
        Me.Text = "Manage Salary Advances"
        Me.grpbxAddSalAdvInfo.ResumeLayout(False)
        Me.grpbxAddSalAdvInfo.PerformLayout()
        Me.grpbxViewSalAdvInfo.ResumeLayout(False)
        Me.grpbxViewSalAdvInfo.PerformLayout()
        CType(Me.KIPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetrieveEmpNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstbxEmpList As ListBox
    Friend WithEvents lblSelectEmp As Label
    Friend WithEvents KIPayrollDataSet As KIPayrollDataSet
    Friend WithEvents SalaryAdvancesBindingSource As BindingSource
    Friend WithEvents SalaryAdvancesTableAdapter As KIPayrollDataSetTableAdapters.SalaryAdvancesTableAdapter
    Friend WithEvents TableAdapterManager As KIPayrollDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RetrieveEmpNameBindingSource As BindingSource
    Friend WithEvents RetrieveEmpNameTableAdapter As KIPayrollDataSetTableAdapters.RetrieveEmpNameTableAdapter
    Friend WithEvents grpbxAddSalAdvInfo As GroupBox
    Friend WithEvents txtPaybackAmt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPaybackDuration As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdvanceAmt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdvanceReason As TextBox
    Friend WithEvents lblEmpName As Label
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents lblEmpID As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents btnAddSalAdvance As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtPendAdvDue As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grpbxViewSalAdvInfo As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbSalAdvListForEmp As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblLine As Label
End Class
