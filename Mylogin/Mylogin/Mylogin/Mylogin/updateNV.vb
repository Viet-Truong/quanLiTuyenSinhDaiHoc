Public Class updateNV
    'khai bao bien de truy xuat DB tu lop DatabaseAccess
    Private _DBAccess As New DataAccess
    'dinh nghia thu tuc load du lieu
    Private Sub loadDataGridView()
        Dim sqlQuery As String = String.Format("Select idNganh, tenNganh, nameUser, cmnd, nam, tohopmon from nguyenvong")
        Dim dtable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.gvNguyenVong.DataSource = dtable
        With Me.gvNguyenVong
            .Columns(0).HeaderText = "Mã ngành"
            .Columns(1).HeaderText = "Tên ngành"
            .Columns(2).HeaderText = "Tên"
            .Columns(3).HeaderText = "CCCD"
            .Columns(4).HeaderText = "Năm"
            .Columns(5).HeaderText = "Tổ hợp môn"
            .Columns(0).Width = 130
            .Columns(1).Width = 200
            .Columns(2).Width = 200
            .Columns(3).Width = 110
            .Columns(4).Width = 100
            .Columns(5).Width = 100
        End With
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        With Me.gvNguyenVong
            idNganh.Text = .Rows(.CurrentCell.RowIndex).Cells("idNganh").Value
            ten.Text = .Rows(.CurrentCell.RowIndex).Cells("nameUser").Value
            cmnd.Text = .Rows(.CurrentCell.RowIndex).Cells("cmnd").Value
            toHopMon.Text = .Rows(.CurrentCell.RowIndex).Cells("tohopmon").Value
            nameNganh.Text = .Rows(.CurrentCell.RowIndex).Cells("tenNganh").Value
        End With
    End Sub
    Private Function updateNV() As Boolean
        Dim sqlQuery As String = String.Format("Update nguyenvong set idNganh = '{0}', nameUser = N'{1}', tohopmon = '{2}', tenNganh = N'{3}' where cmnd = '{4}'", idNganh.Text, ten.Text, toHopMon.Text, nameNganh.Text, cmnd.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(idNganh.Text) OrElse String.IsNullOrEmpty(nameNganh.Text) OrElse String.IsNullOrEmpty(toHopMon.Text)
    End Function

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If isEmpty() Then
            MsgBox("Vui long nhap day du cac thong tin")
        Else
            If updateNV() Then
                MsgBox("Chinh sua du lieu thanh cong")
                loadDataGridView()
            Else
                MsgBox("Chinh sua du lieu k thanh cong")
            End If
        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim idNguyenVong As String = Me.gvNguyenVong.Rows(Me.gvNguyenVong.CurrentCell.RowIndex).Cells("cmnd").Value
        Dim sqlQuery As String = String.Format("delete nguyenvong where cmnd = {0}", idNguyenVong)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MsgBox("da xoa thanh cong")
            loadDataGridView()
        Else
            MsgBox("Loi xoa du lieu")
        End If
    End Sub

    Private Sub updateNV_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDataGridView()
    End Sub
End Class