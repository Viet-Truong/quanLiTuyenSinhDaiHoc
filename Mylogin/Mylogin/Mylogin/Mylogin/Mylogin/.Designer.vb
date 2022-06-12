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
        Me.ten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmnd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.quequan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sdt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.thm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dangKyBtn = New System.Windows.Forms.Button()
        CType(Me.dangkinguyenvongGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
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
        Me.maNganh.Location = New System.Drawing.Point(125, 32)
        Me.maNganh.Name = "maNganh"
        Me.maNganh.Size = New System.Drawing.Size(134, 20)
        Me.maNganh.TabIndex = 2
        '
        'ten
        '
        Me.ten.Location = New System.Drawing.Point(125, 77)
        Me.ten.Name = "ten"
        Me.ten.Size = New System.Drawing.Size(134, 20)
        Me.ten.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Họ và tên:"
        '
        'cmnd
        '
        Me.cmnd.Location = New System.Drawing.Point(125, 129)
        Me.cmnd.Name = "cmnd"
        Me.cmnd.Size = New System.Drawing.Size(134, 20)
        Me.cmnd.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CMND / CCCD:"
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(402, 32)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(134, 20)
        Me.dob.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ngày sinh:"
        '
        'gender
        '
        Me.gender.Location = New System.Drawing.Point(402, 80)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(134, 20)
        Me.gender.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Giới tính:"
        '
        'quequan
        '
        Me.quequan.Location = New System.Drawing.Point(402, 133)
        Me.quequan.Name = "quequan"
        Me.quequan.Size = New System.Drawing.Size(134, 20)
        Me.quequan.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quê quán:"
        '
        'sdt
        '
        Me.sdt.Location = New System.Drawing.Point(701, 28)
        Me.sdt.Name = "sdt"
        Me.sdt.Size = New System.Drawing.Size(134, 20)
        Me.sdt.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(595, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Số điện thoại:"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(701, 76)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(134, 20)
        Me.email.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(595, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email:"
        '
        'thm
        '
        Me.thm.Location = New System.Drawing.Point(701, 133)
        Me.thm.Name = "thm"
        Me.thm.Size = New System.Drawing.Size(134, 20)
        Me.thm.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(595, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tổ hợp môn:"
        '
        'dangKyBtn
        '
        Me.dangKyBtn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dangKyBtn.Location = New System.Drawing.Point(738, 188)
        Me.dangKyBtn.Name = "dangKyBtn"
        Me.dangKyBtn.Size = New System.Drawing.Size(97, 53)
        Me.dangKyBtn.TabIndex = 19
        Me.dangKyBtn.Text = "Đăng ký"
        Me.dangKyBtn.UseVisualStyleBackColor = True
        '
        'DangKiNguyenVong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 530)
        Me.Controls.Add(Me.dangKyBtn)
        Me.Controls.Add(Me.thm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sdt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.quequan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maNganh)
        Me.Controls.Add(Me.dangkinguyenvongGV)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DangKiNguyenVong"
        Me.Text = "ĐĂNG KÍ NGUYỆN VỌNG"
        CType(Me.dangkinguyenvongGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dangkinguyenvongGV As DataGridView
    Friend WithEvents maNganh As TextBox
    Friend WithEvents ten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmnd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dob As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gender As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents quequan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents sdt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents thm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dangKyBtn As Button
End Class
