Public Class DangKiNguyenVong
    Private _DBAccess As New DataAccess

    'dinh nghia thu tuc load du lieu
    Private Sub loadDataGridView()
        Dim sqlQuery As String = String.Format("select idNganh, nameNganh, toHopMon from nganh where nam = 2021 group by idNganh, nameNganh, toHopMon")
        Dim dtable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dangkinguyenvongGV.DataSource = dtable
        With Me.dangkinguyenvongGV
            .Columns(0).HeaderText = "Mã ngành"
            .Columns(1).HeaderText = "Tên ngành"
            .Columns(2).HeaderText = "Tổ hợp môn"
            .Columns(0).Width = 200
            .Columns(1).Width = 350
            .Columns(2).Width = 290
        End With
    End Sub

    Private Sub DangKiNguyenVong_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDataGridView()
    End Sub

    Private Function insert() As Boolean
        Dim sqlQuery As String = "Insert into nguyenvong "
        sqlQuery += String.Format("values('{0}', N'{1}', '{2}', '{3}')", maNganh.Text, ten.Text, cmnd.Text, 2022)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(maNganh.Text) OrElse String.IsNullOrEmpty(ten.Text) OrElse String.IsNullOrEmpty(cmnd.Text)
    End Function

    Private Sub dangKyBtn_Click(sender As Object, e As EventArgs) Handles dangKyBtn.Click
        If isEmpty() Then
            MsgBox("Vui long nhap day du thong tin")
        Else
            If insert() Then
                MsgBox("Dang ky nguyen vong thanh cong")
            Else
                MsgBox("Dang ki k thanh cong")
            End If
        End If
    End Sub

End Class