Public Class xemDiemChuan
    'khai bao bien de truy xuat DB tu lop DatabaseAccess
    Private _DBAccess As New DataAccess

    'dinh nghia thu tuc load du lieu
    Private Sub loadDataGridView()
        Dim sqlQuery As String = String.Format("Select * from nganh")
        Dim dtable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.nganhGV.DataSource = dtable
        With Me.nganhGV
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
        filter.SelectedItem = "Ngành"
    End Sub


    'ham tim kiem
    Private Sub Search(value As String)
        Dim sqlQuery As String
        If filter.Text = "Ngành" Then
            sqlQuery = String.Format("Select * from nganh where nameNganh like N'%{0}%'", value)
        ElseIf filter.Text = "Năm" Then
            sqlQuery = String.Format("Select * from nganh where nam = '{0}'", value)
        End If
        Dim dtable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.nganhGV.DataSource = dtable
        With Me.nganhGV
            .Columns(0).HeaderText = "Mã ngành"
            .Columns(1).HeaderText = "Tên ngành"
            .Columns(2).HeaderText = "Tổ hợp môn"
            .Columns(3).HeaderText = "Điểm chuẩn"
            .Columns(4).HeaderText = "Năm"
            .Columns(1).Width = 340
            .Columns(2).Width = 200
        End With
    End Sub
    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        If searchTextBox.Text = "" Then
            loadDataGridView()
        Else
            Search(Me.searchTextBox.Text)
        End If
    End Sub
End Class