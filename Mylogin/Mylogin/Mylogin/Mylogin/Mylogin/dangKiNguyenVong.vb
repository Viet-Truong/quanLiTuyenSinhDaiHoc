Public Class DangKiNguyenVong

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

    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(maNganh.Text) OrElse String.IsNullOrEmpty(ten.Text) OrElse String.IsNullOrEmpty(cmnd.Text)
    End Function

    Private Sub dangKyBtn_Click(sender As Object, e As EventArgs) Handles dangKyBtn.Click
        If isEmpty() Then
            MsgBox("Vui long nhap day du thong tin")
        Else
            'insert du lieu

        End If
    End Sub
End Class