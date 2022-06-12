Public Class updateNV
    'khai bao bien de truy xuat DB tu lop DatabaseAccess
    Private _DBAccess As New DataAccess

    'dinh nghia thu tuc load du lieu
    Private Sub loadDataGridView()
        Dim sqlQuery As String = String.Format("Select * from nguyenvong")
        Dim dtable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.gvNguyenVong.DataSource = dtable
        With Me.gvNguyenVong.DataSource = dtable
            .Columns(0).HeaderText = "Mã ngành"
            .Columns(1).HeaderText = "Tên ngành"
            .Columns(2).HeaderText = "Tổ hợp môn"
            .Columns(3).HeaderText = "Điểm chuẩn"
            .Columns(4).HeaderText = "Năm"
            .Columns(1).Width = 340
            .Columns(2).Width = 200
        End With
    End Sub
    Private Sub xemDiemChuan_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDataGridView()
    End Sub
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        With Me.gvNguyenVong
            idNganh.Text = .Rows(.CurrentCell.RowIndex).Cells("maNganh").Value
            idNganh.Text = .Rows(.CurrentCell.RowIndex).Cells("").Value
            idNganh.Text = .Rows(.CurrentCell.RowIndex).Cells("").Value
            idNganh.Text = .Rows(.CurrentCell.RowIndex).Cells("").Value
        End With
    End Sub
    Private Function update() As Boolean
        Dim sqlQuery As String = String.Format("Update nguyenvong set maNganh = {0}, ...where cmnd = {}", idNganh.Text, toHopMon.Text, nameNganh.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(idNganh.Text) OrElse String.IsNullOrEmpty(nameNganh.Text) OrElse String.IsNullOrEmpty(toHopMon.Text)
    End Function

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If isEmpty() Then
            MsgBox("Vui long nhap day du cac thong tin")
        Else
            If update() Then
                MsgBox("Chinh sua du lieu thanh cong")
            Else
                MsgBox("Chinh sua du lieu k thanh cong")
            End If
        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim idNguyenVong As String = Me.gvNguyenVong.Rows(Me.gvNguyenVong.CurrentCell.RowIndex).Cells("").Value
        Dim sqlQuery As String = String.Format("delete nguyenvong where cmnd = {0}", idNguyenVong)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MsgBox("da xoa thanh cong")
            loadDataGridView()
        Else
            MsgBox("Loi xoa du lieu")
        End If
    End Sub
End Class