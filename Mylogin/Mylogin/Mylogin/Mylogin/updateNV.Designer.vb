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
        Me.cccd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.gvNguyenVong, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(56, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã ngành:"
        '
        'idNganh
        '
        Me.idNganh.Location = New System.Drawing.Point(129, 27)
        Me.idNganh.Name = "idNganh"
        Me.idNganh.Size = New System.Drawing.Size(119, 20)
        Me.idNganh.TabIndex = 2
        '
        'nameNganh
        '
        Me.nameNganh.Location = New System.Drawing.Point(129, 83)
        Me.nameNganh.Name = "nameNganh"
        Me.nameNganh.Size = New System.Drawing.Size(119, 20)
        Me.nameNganh.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên ngành:"
        '
        'toHopMon
        '
        Me.toHopMon.Location = New System.Drawing.Point(129, 142)
        Me.toHopMon.Name = "toHopMon"
        Me.toHopMon.Size = New System.Drawing.Size(119, 20)
        Me.toHopMon.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tổ hợp môn:"
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(389, 27)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(94, 25)
        Me.updateBtn.TabIndex = 7
        Me.updateBtn.Text = "Chỉnh sửa"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(390, 80)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(93, 23)
        Me.saveBtn.TabIndex = 8
        Me.saveBtn.Text = "Lưu"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(389, 132)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(92, 30)
        Me.deleteBtn.TabIndex = 9
        Me.deleteBtn.Text = "Xoá"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'cccd
        '
        Me.cccd.Location = New System.Drawing.Point(129, 197)
        Me.cccd.Name = "cccd"
        Me.cccd.Size = New System.Drawing.Size(119, 20)
        Me.cccd.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CCCD:"
        '
        'updateNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 492)
        Me.Controls.Add(Me.cccd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.toHopMon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nameNganh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idNganh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gvNguyenVong)
        Me.Name = "updateNV"
        Me.Text = "CHỈNH SỬA NGUYỆN VỌNG"
        CType(Me.gvNguyenVong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cccd As TextBox
    Friend WithEvents Label4 As Label
End Class
