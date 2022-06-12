Imports System.Configuration
Imports System.Data.SqlClient
Public Class DangKiNguyenVong
    Private _DBAccess As New DataAccess
    Private _connectionString As String = ConfigurationSettings.AppSettings("MyConnectionString")
    Private con As SqlConnection
    Private da As SqlDataAdapter
    'dinh nghia ham lay du lieu do vao table
    Private Function getDataTable(sqlQuery As String) As DataTable
        Dim dtable As New DataTable
        'khoi tao bien con
        con = New SqlConnection(_connectionString)
        'khoi tao bien da
        da = New SqlDataAdapter(sqlQuery, con)
        Try
            'open connection
            con.Open()
            'do du lieu vao dtable
            da.Fill(dtable)
        Catch ex As Exception
            'MsgBox(ex.Message, "error") 'thong bao neu co loi
        Finally
            con.Close()
        End Try
        Return dtable
    End Function
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

    Private Function insertNV() As Boolean
        Dim sqlQuery As String = "Insert into nguyenvong "
        sqlQuery += String.Format("values('{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}')", maNganh.Text, nameNganh.Text, ten.Text, cmnd.Text, 2022, thm.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function insertND() As Boolean
        Dim sqlQuery As String = String.Format("Select * from nguoidung where cmnd = '{0}'", cmnd.Text)
        Dim dtable As DataTable = getDataTable(sqlQuery)
        If dtable.Rows.Count <= 0 Then
            Dim sqlQuery1 As String = "Insert into nguoidung "
            sqlQuery1 += String.Format("values('N{0}', '{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}')", ten.Text, dob.Text, gender.Text, quequan.Text, sdt.Text, email.Text, cmnd.Text)
            Return _DBAccess.ExecuteNoneQuery(sqlQuery1)
        End If
        Return True
    End Function

    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(maNganh.Text) OrElse String.IsNullOrEmpty(ten.Text) OrElse String.IsNullOrEmpty(cmnd.Text)
    End Function

    Private Sub dangKyBtn_Click(sender As Object, e As EventArgs) Handles dangKyBtn.Click
        If isEmpty() Then
            MsgBox("Vui long nhap day du thong tin")
        Else
            If insertND() Then
                If insertNV() Then
                    MsgBox("Dang ky nguyen vong thanh cong")
                Else
                    MsgBox("Dang ki k thanh cong")
                End If
            End If
        End If
    End Sub

End Class