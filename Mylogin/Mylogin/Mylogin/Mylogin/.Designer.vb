<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangKiNguyenVong
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dangkinguyenvongGV = New System.Windows.Forms.DataGridView()
        Me.maNganh = New System.Windows.Forms.TextBox()
        Me.thm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dangKyBtn = New System.Windows.Forms.Button()
        Me.GroupBoxNganh = New System.Windows.Forms.GroupBox()
        Me.nameNganh = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBoxInfo = New System.Windows.Forms.GroupBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sdt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.quequan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmnd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dangkinguyenvongGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxNganh.SuspendLayout()
        Me.GroupBoxInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã ngành:"
        '
        'dangkinguyenvongGV
        '
        Me.dangkinguyenvongGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dangkinguyenvongGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dangkinguyenvongGV.Location = New System.Drawing.Point(0, 258)
        Me.dangkinguyenvongGV.Name = "dangkinguyenvongGV"
        Me.dangkinguyenvongGV.Size = New System.Drawing.Size(870, 272)
        Me.dangkinguyenvongGV.TabIndex = 1
        '
        'maNganh
        '
        Me.maNganh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maNganh.Location = New System.Drawing.Point(87, 25)
        Me.maNganh.Name = "maNganh"
        Me.maNganh.Size = New System.Drawing.Size(134, 22)
        Me.maNganh.TabIndex = 2
        '
        'thm
        '
        Me.thm.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thm.Location = New System.Drawing.Point(87, 64)
        Me.thm.Name = "thm"
        Me.thm.Size = New System.Drawing.Size(134, 22)
        Me.thm.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tổ hợp môn:"
        '
        'dangKyBtn
        '
        Me.dangKyBtn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dangKyBtn.Location = New System.Drawing.Point(424, 170)
        Me.dangKyBtn.Name = "dangKyBtn"
        Me.dangKyBtn.Size = New System.Drawing.Size(97, 53)
        Me.dangKyBtn.TabIndex = 19
        Me.dangKyBtn.Text = "Đăng ký"
        Me.dangKyBtn.UseVisualStyleBackColor = True
        '
        'GroupBoxNganh
        '
        Me.GroupBoxNganh.Controls.Add(Me.nameNganh)
        Me.GroupBoxNganh.Controls.Add(Me.Label10)
        Me.GroupBoxNganh.Controls.Add(Me.Label9)
        Me.GroupBoxNganh.Controls.Add(Me.thm)
        Me.GroupBoxNganh.Controls.Add(Me.Label1)
        Me.GroupBoxNganh.Controls.Add(Me.maNganh)
        Me.GroupBoxNganh.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxNganh.Name = "GroupBoxNganh"
        Me.GroupBoxNganh.Size = New System.Drawing.Size(296, 229)
        Me.GroupBoxNganh.TabIndex = 20
        Me.GroupBoxNganh.TabStop = False
        Me.GroupBoxNganh.Text = "Thông tin ngành"
        '
        'nameNganh
        '
        Me.nameNganh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameNganh.Location = New System.Drawing.Point(87, 107)
        Me.nameNganh.Name = "nameNganh"
        Me.nameNganh.Size = New System.Drawing.Size(134, 22)
        Me.nameNganh.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tên ngành:"
        '
        'GroupBoxInfo
        '
        Me.GroupBoxInfo.Controls.Add(Me.email)
        Me.GroupBoxInfo.Controls.Add(Me.dangKyBtn)
        Me.GroupBoxInfo.Controls.Add(Me.Label8)
        Me.GroupBoxInfo.Controls.Add(Me.sdt)
        Me.GroupBoxInfo.Controls.Add(Me.Label7)
        Me.GroupBoxInfo.Controls.Add(Me.quequan)
        Me.GroupBoxInfo.Controls.Add(Me.Label6)
        Me.GroupBoxInfo.Controls.Add(Me.gender)
        Me.GroupBoxInfo.Controls.Add(Me.Label5)
        Me.GroupBoxInfo.Controls.Add(Me.dob)
        Me.GroupBoxInfo.Controls.Add(Me.Label4)
        Me.GroupBoxInfo.Controls.Add(Me.cmnd)
        Me.GroupBoxInfo.Controls.Add(Me.Label3)
        Me.GroupBoxInfo.Controls.Add(Me.ten)
        Me.GroupBoxInfo.Controls.Add(Me.Label2)
        Me.GroupBoxInfo.Location = New System.Drawing.Point(331, 12)
        Me.GroupBoxInfo.Name = "GroupBoxInfo"
        Me.GroupBoxInfo.Size = New System.Drawing.Size(527, 229)
        Me.GroupBoxInfo.TabIndex = 21
        Me.GroupBoxInfo.TabStop = False
        Me.GroupBoxInfo.Text = "Thông tin cá nhân"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(103, 64)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(134, 22)
        Me.email.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Email:"
        '
        'sdt
        '
        Me.sdt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdt.Location = New System.Drawing.Point(362, 28)
        Me.sdt.Name = "sdt"
        Me.sdt.Size = New System.Drawing.Size(134, 22)
        Me.sdt.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Số điện thoại:"
        '
        'quequan
        '
        Me.quequan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quequan.Location = New System.Drawing.Point(103, 147)
        Me.quequan.Name = "quequan"
        Me.quequan.Size = New System.Drawing.Size(134, 22)
        Me.quequan.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Quê quán:"
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(103, 105)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(134, 22)
        Me.gender.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Giới tính:"
        '
        'dob
        '
        Me.dob.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob.Location = New System.Drawing.Point(362, 67)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(134, 22)
        Me.dob.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Ngày sinh:"
        '
        'cmnd
        '
        Me.cmnd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmnd.Location = New System.Drawing.Point(362, 104)
        Me.cmnd.Name = "cmnd"
        Me.cmnd.Size = New System.Drawing.Size(134, 22)
        Me.cmnd.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CMND / CCCD:"
        '
        'ten
        '
        Me.ten.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ten.Location = New System.Drawing.Point(103, 28)
        Me.ten.Name = "ten"
        Me.ten.Size = New System.Drawing.Size(134, 22)
        Me.ten.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Họ và tên:"
        '
        'DangKiNguyenVong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 530)
        Me.Controls.Add(Me.GroupBoxInfo)
        Me.Controls.Add(Me.GroupBoxNganh)
        Me.Controls.Add(Me.dangkinguyenvongGV)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DangKiNguyenVong"
        Me.Text = "ĐĂNG KÍ NGUYỆN VỌNG"
        CType(Me.dangkinguyenvongGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxNganh.ResumeLayout(False)
        Me.GroupBoxNganh.PerformLayout()
        Me.GroupBoxInfo.ResumeLayout(False)
        Me.GroupBoxInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dangkinguyenvongGV As DataGridView
    Friend WithEvents maNganh As TextBox
    Friend WithEvents thm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dangKyBtn As Button
    Friend WithEvents GroupBoxNganh As GroupBox
    Friend WithEvents nameNganh As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBoxInfo As GroupBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents sdt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents quequan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gender As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dob As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmnd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ten As TextBox
    Friend WithEvents Label2 As Label
End Class
