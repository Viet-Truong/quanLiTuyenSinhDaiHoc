<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class account
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
        Me.GroupBoxInfo = New System.Windows.Forms.GroupBox()
        Me.nu = New System.Windows.Forms.RadioButton()
        Me.nam = New System.Windows.Forms.RadioButton()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sdt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.quequan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmnd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.GroupBoxInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxInfo
        '
        Me.GroupBoxInfo.Controls.Add(Me.nu)
        Me.GroupBoxInfo.Controls.Add(Me.nam)
        Me.GroupBoxInfo.Controls.Add(Me.dob)
        Me.GroupBoxInfo.Controls.Add(Me.email)
        Me.GroupBoxInfo.Controls.Add(Me.Label8)
        Me.GroupBoxInfo.Controls.Add(Me.sdt)
        Me.GroupBoxInfo.Controls.Add(Me.Label7)
        Me.GroupBoxInfo.Controls.Add(Me.quequan)
        Me.GroupBoxInfo.Controls.Add(Me.Label6)
        Me.GroupBoxInfo.Controls.Add(Me.Label5)
        Me.GroupBoxInfo.Controls.Add(Me.Label4)
        Me.GroupBoxInfo.Controls.Add(Me.cmnd)
        Me.GroupBoxInfo.Controls.Add(Me.Label3)
        Me.GroupBoxInfo.Controls.Add(Me.ten)
        Me.GroupBoxInfo.Controls.Add(Me.Label2)
        Me.GroupBoxInfo.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxInfo.Name = "GroupBoxInfo"
        Me.GroupBoxInfo.Size = New System.Drawing.Size(564, 468)
        Me.GroupBoxInfo.TabIndex = 0
        Me.GroupBoxInfo.TabStop = False
        Me.GroupBoxInfo.Text = "Thông tin cá nhân"
        '
        'nu
        '
        Me.nu.AutoSize = True
        Me.nu.Location = New System.Drawing.Point(219, 117)
        Me.nu.Name = "nu"
        Me.nu.Size = New System.Drawing.Size(39, 17)
        Me.nu.TabIndex = 47
        Me.nu.TabStop = True
        Me.nu.Text = "Nữ"
        Me.nu.UseVisualStyleBackColor = True
        '
        'nam
        '
        Me.nam.AutoSize = True
        Me.nam.Location = New System.Drawing.Point(124, 117)
        Me.nam.Name = "nam"
        Me.nam.Size = New System.Drawing.Size(47, 17)
        Me.nam.TabIndex = 46
        Me.nam.TabStop = True
        Me.nam.Text = "Nam"
        Me.nam.UseVisualStyleBackColor = True
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(124, 237)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(200, 20)
        Me.dob.TabIndex = 45
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(124, 70)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(134, 20)
        Me.email.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Email:"
        '
        'sdt
        '
        Me.sdt.Location = New System.Drawing.Point(124, 196)
        Me.sdt.Name = "sdt"
        Me.sdt.Size = New System.Drawing.Size(134, 20)
        Me.sdt.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Số điện thoại:"
        '
        'quequan
        '
        Me.quequan.Location = New System.Drawing.Point(124, 153)
        Me.quequan.Name = "quequan"
        Me.quequan.Size = New System.Drawing.Size(134, 20)
        Me.quequan.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Quê quán:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Giới tính:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Ngày sinh:"
        '
        'cmnd
        '
        Me.cmnd.Location = New System.Drawing.Point(124, 272)
        Me.cmnd.Name = "cmnd"
        Me.cmnd.Size = New System.Drawing.Size(134, 20)
        Me.cmnd.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "CMND / CCCD:"
        '
        'ten
        '
        Me.ten.Location = New System.Drawing.Point(124, 34)
        Me.ten.Name = "ten"
        Me.ten.Size = New System.Drawing.Size(134, 20)
        Me.ten.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Họ và tên:"
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(631, 36)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(99, 51)
        Me.updateBtn.TabIndex = 1
        Me.updateBtn.Text = "CHỈNH SỬA"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(634, 136)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(95, 43)
        Me.saveBtn.TabIndex = 2
        Me.saveBtn.Text = "Lưu"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 492)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.GroupBoxInfo)
        Me.Name = "account"
        Me.Text = "TÀI KHOẢN"
        Me.GroupBoxInfo.ResumeLayout(False)
        Me.GroupBoxInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxInfo As GroupBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents sdt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents quequan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmnd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents nu As RadioButton
    Friend WithEvents nam As RadioButton
    Friend WithEvents updateBtn As Button
    Friend WithEvents saveBtn As Button
End Class
