<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateNV
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
        Me.gvNguyenVong = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idNganh = New System.Windows.Forms.TextBox()
        Me.nameNganh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.toHopMon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmnd = New System.Windows.Forms.TextBox()
        Me.ten = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.gvNguyenVong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvNguyenVong
        '
        Me.gvNguyenVong.AllowUserToAddRows = False
        Me.gvNguyenVong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvNguyenVong.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvNguyenVong.Location = New System.Drawing.Point(0, 274)
        Me.gvNguyenVong.MultiSelect = False
        Me.gvNguyenVong.Name = "gvNguyenVong"
        Me.gvNguyenVong.ReadOnly = True
        Me.gvNguyenVong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvNguyenVong.Size = New System.Drawing.Size(870, 218)
        Me.gvNguyenVong.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã ngành:"
        '
        'idNganh
        '
        Me.idNganh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idNganh.Location = New System.Drawing.Point(82, 44)
        Me.idNganh.Name = "idNganh"
        Me.idNganh.Size = New System.Drawing.Size(119, 22)
        Me.idNganh.TabIndex = 2
        '
        'nameNganh
        '
        Me.nameNganh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameNganh.Location = New System.Drawing.Point(82, 100)
        Me.nameNganh.Name = "nameNganh"
        Me.nameNganh.Size = New System.Drawing.Size(119, 22)
        Me.nameNganh.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên ngành:"
        '
        'toHopMon
        '
        Me.toHopMon.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toHopMon.Location = New System.Drawing.Point(82, 159)
        Me.toHopMon.Name = "toHopMon"
        Me.toHopMon.Size = New System.Drawing.Size(119, 22)
        Me.toHopMon.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tổ hợp môn:"
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(662, 150)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(82, 25)
        Me.updateBtn.TabIndex = 7
        Me.updateBtn.Text = "Chỉnh sửa"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(662, 91)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(82, 25)
        Me.saveBtn.TabIndex = 8
        Me.saveBtn.Text = "Lưu"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(662, 35)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(82, 25)
        Me.deleteBtn.TabIndex = 9
        Me.deleteBtn.Text = "Xoá"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.idNganh)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nameNganh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.toHopMon)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 252)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin ngành"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmnd)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ten)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 242)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin cá nhân"
        '
        'cmnd
        '
        Me.cmnd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmnd.Location = New System.Drawing.Point(117, 89)
        Me.cmnd.Name = "cmnd"
        Me.cmnd.Size = New System.Drawing.Size(134, 22)
        Me.cmnd.TabIndex = 34
        '
        'ten
        '
        Me.ten.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ten.Location = New System.Drawing.Point(117, 34)
        Me.ten.Name = "ten"
        Me.ten.Size = New System.Drawing.Size(134, 22)
        Me.ten.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Họ và tên:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "CMND / CCCD:"
        '
        'updateNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 492)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.gvNguyenVong)
        Me.Name = "updateNV"
        Me.Text = "CHỈNH SỬA NGUYỆN VỌNG"
        CType(Me.gvNguyenVong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gvNguyenVong As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents idNganh As TextBox
    Friend WithEvents nameNganh As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents toHopMon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmnd As TextBox
    Friend WithEvents ten As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
