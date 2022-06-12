Imports System.Configuration
Imports System.Data.SqlClient

Public Class Login
    Private _DBAccess As New DataAccess
    'khai bao bien de ket noi csdl
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

    'dinh nghia ham kiem tra username, password
    Private Function checkLogin(user As String, pass As String) As Boolean
        Dim sqlQuery As String = String.Format("Select * from account where userName = '{0}' and passWord = '{1}'", user, pass)
        Dim dtable As DataTable = getDataTable(sqlQuery)
        Return dtable.Rows.Count > 0
    End Function

    'dinh nghia ham check username co trung k 
    Private Function checkUser(user As String) As Boolean
        Dim sqlQuery As String = String.Format("Select * from account where userName = '{0}'", user)
        Dim dtable As DataTable = getDataTable(sqlQuery)
        Return dtable.Rows.Count > 0
    End Function

    'dinh nghia ham kiem tra user, pass co trong hay k 
    Private Function isEmpty(user As String, pass As String) As Boolean
        'tra ve true neu username va password empty
        Return String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(pass)
    End Function
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        If isEmpty(username.Text, password.Text) Then
            MsgBox("Vui long nhap username va password")
        Else
            If checkLogin(username.Text, password.Text) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Hide()
                QuanLiTuyenSinhDaiHocUTE.Show()
            Else
                MsgBox("tai khoan hoac mat khau sai vui long nhap lai")
            End If
        End If
    End Sub
    Private Sub linkaccnt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaccnt.LinkClicked
        anima1.HideSync(p2)
        anima1.ShowSync(p3)
    End Sub

    Private Sub btnx_Click(sender As Object, e As EventArgs) Handles btnx.Click
        anima1.HideSync(p3)
        anima1.ShowSync(p2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anima1.ShowSync(l1)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(p2)
    End Sub

    Private Sub GunaCheckBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaCheckBox1.MouseClick
        If password.isPassword Then
            password.isPassword = False
        Else
            password.isPassword = True
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub insert(user As String, pass As String)
        Dim sqlQuery As String = "Insert into account "
        sqlQuery += String.Format("values('{0}', '{1}')", user, pass)
        _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Sub

    Private Sub signUp_Click(sender As Object, e As EventArgs) Handles signUp.Click
        If checkUser(userSignup.Text) = False And isEmpty(userSignup.Text, passSignUp.Text) = False Then
            If passSignUp.Text = rePass.Text Then
                insert(userSignup.Text, passSignUp.Text)
                MsgBox("Dang ki thanh cong")
                'inputInfo.show(userSignup.Text)
            Else
                MsgBox("mat khau k trung khop")
            End If
        ElseIf isEmpty(userSignup.Text, passSignUp.Text) = True Then
            MsgBox("vui long nhap day du thong tin")
        ElseIf checkUser(userSignup.Text) Then
            MsgBox("tai khoan da ton tai")
        End If
    End Sub
End Class