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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPaybackAmt = New System.Windows.Forms.MaskedTextBox()
        Me.txtAdvanceAmt = New System.Windows.Forms.MaskedTextBox()
        Me.cmbEmpName = New System.Windows.Forms.ComboBox()
        Me.txtAdvStatus = New System.Windows.Forms.TextBox()
        Me.lblAdvStatus = New System.Windows.Forms.Label()
        Me.lblPaybackAmt = New System.Windows.Forms.Label()
        Me.cmbPaybackDuration = New System.Windows.Forms.ComboBox()
        Me.lblPaybackDur = New System.Windows.Forms.Label()
        Me.lblAdvAmt = New System.Windows.Forms.Label()
        Me.lblAdvReason = New System.Windows.Forms.Label()
        Me.txtAdvanceReason = New System.Windows.Forms.TextBox()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.btnAddSalAdvance = New System.Windows.Forms.Button()
        Me.btnViewSalAdvInfo = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpbxViewSalAdvInfo = New System.Windows.Forms.GroupBox()
        Me.btnCancelView = New System.Windows.Forms.Button()
        Me.txtViewAdvStatus = New System.Windows.Forms.TextBox()
        Me.lblViewAdvStatus = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblSelectSalAdvToView = New System.Windows.Forms.Label()
        Me.cmbSalAdvListForEmp = New System.Windows.Forms.ComboBox()
        Me.txtViewAdvDue = New System.Windows.Forms.TextBox()
        Me.lblViewAdvDue = New System.Windows.Forms.Label()
        Me.txtViewPaybackAmt = New System.Windows.Forms.TextBox()
        Me.lblViewPaybackAmt = New System.Windows.Forms.Label()
        Me.cmbViewPaybackDur = New System.Windows.Forms.ComboBox()
        Me.lblViewPaybackDur = New System.Windows.Forms.Label()
        Me.txtViewAdvAmt = New System.Windows.Forms.TextBox()
        Me.lblViewAdvAmt = New System.Windows.Forms.Label()
        Me.lblViewAdvReason = New System.Windows.Forms.Label()
        Me.txtViewAdvReason = New System.Windows.Forms.TextBox()
        Me.lblViewEmpName = New System.Windows.Forms.Label()
        Me.txtViewEmpName = New System.Windows.Forms.TextBox()
        Me.lblViewEmpID = New System.Windows.Forms.Label()
        Me.txtViewEmpID = New System.Windows.Forms.TextBox()
        Me.KIPayrollDataSet = New KIPayroll.KIPayrollDataSet()
        Me.SalaryAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryAdvancesTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.SalaryAdvancesTableAdapter()
        Me.TableAdapterManager = New KIPayroll.KIPayrollDataSetTableAdapters.TableAdapterManager()
        Me.RetrieveEmpNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetrieveEmpNameTableAdapter = New KIPayroll.KIPayrollDataSetTableAdapters.RetrieveEmpNameTableAdapter()
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
        Me.lstbxEmpList.MaximumSize = New System.Drawing.Size(150, 225)
        Me.lstbxEmpList.Name = "lstbxEmpList"
        Me.lstbxEmpList.Size = New System.Drawing.Size(145, 212)
        Me.lstbxEmpList.TabIndex = 0
        '
        'lblSelectEmp
        '
        Me.lblSelectEmp.AutoSize = True
        Me.lblSelectEmp.Location = New System.Drawing.Point(13, 13)
        Me.lblSelectEmp.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblSelectEmp.Name = "lblSelectEmp"
        Me.lblSelectEmp.Size = New System.Drawing.Size(159, 26)
        Me.lblSelectEmp.TabIndex = 1
        Me.lblSelectEmp.Text = "Select Employee to View Salary Advances Issued:"
        '
        'grpbxAddSalAdvInfo
        '
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.btnCancel)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.btnSave)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtPaybackAmt)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtAdvanceAmt)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.cmbEmpName)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtAdvStatus)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblAdvStatus)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblPaybackAmt)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.cmbPaybackDuration)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblPaybackDur)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblAdvAmt)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblAdvReason)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.txtAdvanceReason)
        Me.grpbxAddSalAdvInfo.Controls.Add(Me.lblEmpName)
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(369, 195)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(369, 164)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPaybackAmt
        '
        Me.txtPaybackAmt.Enabled = False
        Me.txtPaybackAmt.Location = New System.Drawing.Point(171, 164)
        Me.txtPaybackAmt.Name = "txtPaybackAmt"
        Me.txtPaybackAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtPaybackAmt.TabIndex = 38
        '
        'txtAdvanceAmt
        '
        Me.txtAdvanceAmt.Location = New System.Drawing.Point(171, 96)
        Me.txtAdvanceAmt.Name = "txtAdvanceAmt"
        Me.txtAdvanceAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtAdvanceAmt.TabIndex = 37
        '
        'cmbEmpName
        '
        Me.cmbEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpName.FormattingEnabled = True
        Me.cmbEmpName.Location = New System.Drawing.Point(308, 28)
        Me.cmbEmpName.Name = "cmbEmpName"
        Me.cmbEmpName.Size = New System.Drawing.Size(136, 21)
        Me.cmbEmpName.TabIndex = 36
        '
        'txtAdvStatus
        '
        Me.txtAdvStatus.Enabled = False
        Me.txtAdvStatus.Location = New System.Drawing.Point(171, 195)
        Me.txtAdvStatus.Name = "txtAdvStatus"
        Me.txtAdvStatus.Size = New System.Drawing.Size(77, 20)
        Me.txtAdvStatus.TabIndex = 35
        '
        'lblAdvStatus
        '
        Me.lblAdvStatus.AutoSize = True
        Me.lblAdvStatus.Location = New System.Drawing.Point(18, 199)
        Me.lblAdvStatus.Name = "lblAdvStatus"
        Me.lblAdvStatus.Size = New System.Drawing.Size(86, 13)
        Me.lblAdvStatus.TabIndex = 34
        Me.lblAdvStatus.Text = "Advance Status:"
        '
        'lblPaybackAmt
        '
        Me.lblPaybackAmt.AutoSize = True
        Me.lblPaybackAmt.Location = New System.Drawing.Point(18, 167)
        Me.lblPaybackAmt.Name = "lblPaybackAmt"
        Me.lblPaybackAmt.Size = New System.Drawing.Size(142, 13)
        Me.lblPaybackAmt.TabIndex = 10
        Me.lblPaybackAmt.Text = "Payback Amount per Month:"
        '
        'cmbPaybackDuration
        '
        Me.cmbPaybackDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaybackDuration.FormattingEnabled = True
        Me.cmbPaybackDuration.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.cmbPaybackDuration.Location = New System.Drawing.Point(171, 129)
        Me.cmbPaybackDuration.Name = "cmbPaybackDuration"
        Me.cmbPaybackDuration.Size = New System.Drawing.Size(77, 21)
        Me.cmbPaybackDuration.TabIndex = 9
        '
        'lblPaybackDur
        '
        Me.lblPaybackDur.AutoSize = True
        Me.lblPaybackDur.Location = New System.Drawing.Point(18, 133)
        Me.lblPaybackDur.Name = "lblPaybackDur"
        Me.lblPaybackDur.Size = New System.Drawing.Size(95, 13)
        Me.lblPaybackDur.TabIndex = 8
        Me.lblPaybackDur.Text = "Payback Duration:"
        '
        'lblAdvAmt
        '
        Me.lblAdvAmt.AutoSize = True
        Me.lblAdvAmt.Location = New System.Drawing.Point(18, 99)
        Me.lblAdvAmt.Name = "lblAdvAmt"
        Me.lblAdvAmt.Size = New System.Drawing.Size(92, 13)
        Me.lblAdvAmt.TabIndex = 6
        Me.lblAdvAmt.Text = "Advance Amount:"
        '
        'lblAdvReason
        '
        Me.lblAdvReason.AutoSize = True
        Me.lblAdvReason.Location = New System.Drawing.Point(18, 65)
        Me.lblAdvReason.Name = "lblAdvReason"
        Me.lblAdvReason.Size = New System.Drawing.Size(93, 13)
        Me.lblAdvReason.TabIndex = 5
        Me.lblAdvReason.Text = "Advance Reason:"
        '
        'txtAdvanceReason
        '
        Me.txtAdvanceReason.Location = New System.Drawing.Point(171, 61)
        Me.txtAdvanceReason.Name = "txtAdvanceReason"
        Me.txtAdvanceReason.Size = New System.Drawing.Size(273, 20)
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
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(94, 28)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(76, 20)
        Me.txtEmpID.TabIndex = 0
        '
        'btnAddSalAdvance
        '
        Me.btnAddSalAdvance.Location = New System.Drawing.Point(85, 271)
        Me.btnAddSalAdvance.Name = "btnAddSalAdvance"
        Me.btnAddSalAdvance.Size = New System.Drawing.Size(155, 23)
        Me.btnAddSalAdvance.TabIndex = 3
        Me.btnAddSalAdvance.Text = "Issue New Salary Advance"
        Me.btnAddSalAdvance.UseVisualStyleBackColor = True
        '
        'btnViewSalAdvInfo
        '
        Me.btnViewSalAdvInfo.Enabled = False
        Me.btnViewSalAdvInfo.Location = New System.Drawing.Point(302, 271)
        Me.btnViewSalAdvInfo.Name = "btnViewSalAdvInfo"
        Me.btnViewSalAdvInfo.Size = New System.Drawing.Size(154, 23)
        Me.btnViewSalAdvInfo.TabIndex = 4
        Me.btnViewSalAdvInfo.Text = "View Salary Advance Info"
        Me.btnViewSalAdvInfo.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(518, 270)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpbxViewSalAdvInfo
        '
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.btnCancelView)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.txtViewAdvStatus)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewAdvStatus)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblLine)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblSelectSalAdvToView)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.cmbSalAdvListForEmp)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.txtViewAdvDue)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewAdvDue)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.txtViewPaybackAmt)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewPaybackAmt)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.cmbViewPaybackDur)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewPaybackDur)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.txtViewAdvAmt)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewAdvAmt)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewAdvReason)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.txtViewAdvReason)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewEmpName)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.txtViewEmpName)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.lblViewEmpID)
        Me.grpbxViewSalAdvInfo.Controls.Add(Me.txtViewEmpID)
        Me.grpbxViewSalAdvInfo.Location = New System.Drawing.Point(190, 308)
        Me.grpbxViewSalAdvInfo.Name = "grpbxViewSalAdvInfo"
        Me.grpbxViewSalAdvInfo.Size = New System.Drawing.Size(464, 254)
        Me.grpbxViewSalAdvInfo.TabIndex = 6
        Me.grpbxViewSalAdvInfo.TabStop = False
        Me.grpbxViewSalAdvInfo.Text = "Salary Advance Information:"
        '
        'btnCancelView
        '
        Me.btnCancelView.Location = New System.Drawing.Point(362, 215)
        Me.btnCancelView.Name = "btnCancelView"
        Me.btnCancelView.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelView.TabIndex = 35
        Me.btnCancelView.Text = "Cancel View"
        Me.btnCancelView.UseVisualStyleBackColor = True
        '
        'txtViewAdvStatus
        '
        Me.txtViewAdvStatus.Location = New System.Drawing.Point(361, 134)
        Me.txtViewAdvStatus.Name = "txtViewAdvStatus"
        Me.txtViewAdvStatus.Size = New System.Drawing.Size(83, 20)
        Me.txtViewAdvStatus.TabIndex = 33
        Me.txtViewAdvStatus.Visible = False
        '
        'lblViewAdvStatus
        '
        Me.lblViewAdvStatus.AutoSize = True
        Me.lblViewAdvStatus.Location = New System.Drawing.Point(251, 138)
        Me.lblViewAdvStatus.Name = "lblViewAdvStatus"
        Me.lblViewAdvStatus.Size = New System.Drawing.Size(86, 13)
        Me.lblViewAdvStatus.TabIndex = 32
        Me.lblViewAdvStatus.Text = "Advance Status:"
        Me.lblViewAdvStatus.Visible = False
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
        'lblSelectSalAdvToView
        '
        Me.lblSelectSalAdvToView.AutoSize = True
        Me.lblSelectSalAdvToView.Location = New System.Drawing.Point(6, 23)
        Me.lblSelectSalAdvToView.MaximumSize = New System.Drawing.Size(150, 0)
        Me.lblSelectSalAdvToView.Name = "lblSelectSalAdvToView"
        Me.lblSelectSalAdvToView.Size = New System.Drawing.Size(148, 26)
        Me.lblSelectSalAdvToView.TabIndex = 29
        Me.lblSelectSalAdvToView.Text = "Select Salary Advance Info to View:"
        '
        'cmbSalAdvListForEmp
        '
        Me.cmbSalAdvListForEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSalAdvListForEmp.FormattingEnabled = True
        Me.cmbSalAdvListForEmp.Location = New System.Drawing.Point(160, 23)
        Me.cmbSalAdvListForEmp.Name = "cmbSalAdvListForEmp"
        Me.cmbSalAdvListForEmp.Size = New System.Drawing.Size(284, 21)
        Me.cmbSalAdvListForEmp.TabIndex = 28
        '
        'txtViewAdvDue
        '
        Me.txtViewAdvDue.Location = New System.Drawing.Point(152, 223)
        Me.txtViewAdvDue.Name = "txtViewAdvDue"
        Me.txtViewAdvDue.Size = New System.Drawing.Size(77, 20)
        Me.txtViewAdvDue.TabIndex = 27
        Me.txtViewAdvDue.Visible = False
        '
        'lblViewAdvDue
        '
        Me.lblViewAdvDue.AutoSize = True
        Me.lblViewAdvDue.Location = New System.Drawing.Point(6, 226)
        Me.lblViewAdvDue.Name = "lblViewAdvDue"
        Me.lblViewAdvDue.Size = New System.Drawing.Size(103, 13)
        Me.lblViewAdvDue.TabIndex = 26
        Me.lblViewAdvDue.Text = "Total Advance Due:"
        Me.lblViewAdvDue.Visible = False
        '
        'txtViewPaybackAmt
        '
        Me.txtViewPaybackAmt.Location = New System.Drawing.Point(152, 193)
        Me.txtViewPaybackAmt.Name = "txtViewPaybackAmt"
        Me.txtViewPaybackAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtViewPaybackAmt.TabIndex = 25
        Me.txtViewPaybackAmt.Visible = False
        '
        'lblViewPaybackAmt
        '
        Me.lblViewPaybackAmt.AutoSize = True
        Me.lblViewPaybackAmt.Location = New System.Drawing.Point(6, 197)
        Me.lblViewPaybackAmt.Name = "lblViewPaybackAmt"
        Me.lblViewPaybackAmt.Size = New System.Drawing.Size(142, 13)
        Me.lblViewPaybackAmt.TabIndex = 24
        Me.lblViewPaybackAmt.Text = "Payback Amount per Month:"
        Me.lblViewPaybackAmt.Visible = False
        '
        'cmbViewPaybackDur
        '
        Me.cmbViewPaybackDur.FormattingEnabled = True
        Me.cmbViewPaybackDur.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.cmbViewPaybackDur.Location = New System.Drawing.Point(152, 162)
        Me.cmbViewPaybackDur.Name = "cmbViewPaybackDur"
        Me.cmbViewPaybackDur.Size = New System.Drawing.Size(77, 21)
        Me.cmbViewPaybackDur.TabIndex = 23
        Me.cmbViewPaybackDur.Visible = False
        '
        'lblViewPaybackDur
        '
        Me.lblViewPaybackDur.AutoSize = True
        Me.lblViewPaybackDur.Location = New System.Drawing.Point(6, 166)
        Me.lblViewPaybackDur.Name = "lblViewPaybackDur"
        Me.lblViewPaybackDur.Size = New System.Drawing.Size(95, 13)
        Me.lblViewPaybackDur.TabIndex = 22
        Me.lblViewPaybackDur.Text = "Payback Duration:"
        Me.lblViewPaybackDur.Visible = False
        '
        'txtViewAdvAmt
        '
        Me.txtViewAdvAmt.Location = New System.Drawing.Point(152, 133)
        Me.txtViewAdvAmt.Name = "txtViewAdvAmt"
        Me.txtViewAdvAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtViewAdvAmt.TabIndex = 21
        Me.txtViewAdvAmt.Visible = False
        '
        'lblViewAdvAmt
        '
        Me.lblViewAdvAmt.AutoSize = True
        Me.lblViewAdvAmt.Location = New System.Drawing.Point(6, 137)
        Me.lblViewAdvAmt.Name = "lblViewAdvAmt"
        Me.lblViewAdvAmt.Size = New System.Drawing.Size(92, 13)
        Me.lblViewAdvAmt.TabIndex = 20
        Me.lblViewAdvAmt.Text = "Advance Amount:"
        Me.lblViewAdvAmt.Visible = False
        '
        'lblViewAdvReason
        '
        Me.lblViewAdvReason.AutoSize = True
        Me.lblViewAdvReason.Location = New System.Drawing.Point(6, 106)
        Me.lblViewAdvReason.Name = "lblViewAdvReason"
        Me.lblViewAdvReason.Size = New System.Drawing.Size(93, 13)
        Me.lblViewAdvReason.TabIndex = 19
        Me.lblViewAdvReason.Text = "Advance Reason:"
        Me.lblViewAdvReason.Visible = False
        '
        'txtViewAdvReason
        '
        Me.txtViewAdvReason.Location = New System.Drawing.Point(152, 103)
        Me.txtViewAdvReason.Name = "txtViewAdvReason"
        Me.txtViewAdvReason.Size = New System.Drawing.Size(293, 20)
        Me.txtViewAdvReason.TabIndex = 18
        Me.txtViewAdvReason.Visible = False
        '
        'lblViewEmpName
        '
        Me.lblViewEmpName.AutoSize = True
        Me.lblViewEmpName.Location = New System.Drawing.Point(215, 72)
        Me.lblViewEmpName.Name = "lblViewEmpName"
        Me.lblViewEmpName.Size = New System.Drawing.Size(87, 13)
        Me.lblViewEmpName.TabIndex = 17
        Me.lblViewEmpName.Text = "Employee Name:"
        Me.lblViewEmpName.Visible = False
        '
        'txtViewEmpName
        '
        Me.txtViewEmpName.Location = New System.Drawing.Point(308, 68)
        Me.txtViewEmpName.Name = "txtViewEmpName"
        Me.txtViewEmpName.Size = New System.Drawing.Size(136, 20)
        Me.txtViewEmpName.TabIndex = 16
        Me.txtViewEmpName.Visible = False
        '
        'lblViewEmpID
        '
        Me.lblViewEmpID.AutoSize = True
        Me.lblViewEmpID.Location = New System.Drawing.Point(6, 72)
        Me.lblViewEmpID.Name = "lblViewEmpID"
        Me.lblViewEmpID.Size = New System.Drawing.Size(70, 13)
        Me.lblViewEmpID.TabIndex = 15
        Me.lblViewEmpID.Text = "Employee ID:"
        Me.lblViewEmpID.Visible = False
        '
        'txtViewEmpID
        '
        Me.txtViewEmpID.Location = New System.Drawing.Point(94, 68)
        Me.txtViewEmpID.Name = "txtViewEmpID"
        Me.txtViewEmpID.Size = New System.Drawing.Size(76, 20)
        Me.txtViewEmpID.TabIndex = 14
        Me.txtViewEmpID.Visible = False
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
        Me.TableAdapterManager.UpdateOrder = KIPayroll.KIPayrollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.ClientSize = New System.Drawing.Size(690, 573)
        Me.Controls.Add(Me.grpbxViewSalAdvInfo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewSalAdvInfo)
        Me.Controls.Add(Me.btnAddSalAdvance)
        Me.Controls.Add(Me.grpbxAddSalAdvInfo)
        Me.Controls.Add(Me.lblSelectEmp)
        Me.Controls.Add(Me.lstbxEmpList)
        Me.Name = "SalaryAdvances"
        Me.ShowInTaskbar = False
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
    Friend WithEvents lblPaybackAmt As Label
    Friend WithEvents cmbPaybackDuration As ComboBox
    Friend WithEvents lblPaybackDur As Label
    Friend WithEvents lblAdvAmt As Label
    Friend WithEvents lblAdvReason As Label
    Friend WithEvents txtAdvanceReason As TextBox
    Friend WithEvents lblEmpName As Label
    Friend WithEvents lblEmpID As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents btnAddSalAdvance As Button
    Friend WithEvents btnViewSalAdvInfo As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents grpbxViewSalAdvInfo As GroupBox
    Friend WithEvents lblSelectSalAdvToView As Label
    Friend WithEvents cmbSalAdvListForEmp As ComboBox
    Friend WithEvents txtViewAdvDue As TextBox
    Friend WithEvents lblViewAdvDue As Label
    Friend WithEvents txtViewPaybackAmt As TextBox
    Friend WithEvents lblViewPaybackAmt As Label
    Friend WithEvents cmbViewPaybackDur As ComboBox
    Friend WithEvents lblViewPaybackDur As Label
    Friend WithEvents txtViewAdvAmt As TextBox
    Friend WithEvents lblViewAdvAmt As Label
    Friend WithEvents lblViewAdvReason As Label
    Friend WithEvents txtViewAdvReason As TextBox
    Friend WithEvents lblViewEmpName As Label
    Friend WithEvents txtViewEmpName As TextBox
    Friend WithEvents lblViewEmpID As Label
    Friend WithEvents txtViewEmpID As TextBox
    Friend WithEvents lblLine As Label
    Friend WithEvents txtViewAdvStatus As TextBox
    Friend WithEvents lblViewAdvStatus As Label
    Friend WithEvents txtAdvStatus As TextBox
    Friend WithEvents lblAdvStatus As Label
    Friend WithEvents cmbEmpName As ComboBox
    Friend WithEvents txtPaybackAmt As MaskedTextBox
    Friend WithEvents txtAdvanceAmt As MaskedTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancelView As Button
End Class
