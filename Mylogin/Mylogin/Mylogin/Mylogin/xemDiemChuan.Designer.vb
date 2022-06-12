<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xemDiemChuan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nganhGV = New System.Windows.Forms.DataGridView()
        Me.filter = New System.Windows.Forms.ComboBox()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.nganhGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.nganhGV)
        Me.Panel1.Controls.Add(Me.filter)
        Me.Panel1.Controls.Add(Me.searchTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(870, 492)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tìm kiếm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(691, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lọc:"
        '
        'nganhGV
        '
        Me.nganhGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.nganhGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nganhGV.Location = New System.Drawing.Point(0, 76)
        Me.nganhGV.Name = "nganhGV"
        Me.nganhGV.Size = New System.Drawing.Size(870, 416)
        Me.nganhGV.TabIndex = 3
        '
        'filter
        '
        Me.filter.FormattingEnabled = True
        Me.filter.Items.AddRange(New Object() {"Năm", "Ngành"})
        Me.filter.Location = New System.Drawing.Point(737, 34)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(121, 21)
        Me.filter.TabIndex = 2
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(91, 35)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(183, 20)
        Me.searchTextBox.TabIndex = 0
        '
        'xemDiemChuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 492)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "xemDiemChuan"
        Me.Text = "XEM ĐIỂM CHUẨN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nganhGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nganhGV As DataGridView
    Friend WithEvents filter As ComboBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
