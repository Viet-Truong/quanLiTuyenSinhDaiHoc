Imports System.Runtime.InteropServices
Public Class QuanLiTuyenSinhDaiHocUTE
    'FIELDS'
    Private currentButton As Button
    Private random As Random
    Private tempIndex As Integer
    Private activeForm As Form
    'CONSTRUCTOR'
    Public Sub New()
        InitializeComponent()
        random = New Random()
        currentButton = New Button()
        Me.btnCloseChildForm.Visible = False
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
    End Sub
    'METHODS'
    Private Function SelectThemeColor() As Color
        Dim color As String = ThemesColor.ColorList(0)
        Return ColorTranslator.FromHtml(color)
    End Function
    Private Sub ActivateButton(btnSender As Object)
        If btnSender IsNot Nothing Then
            If currentButton.Name <> CType(btnSender, Button).Name Then
                DisableButton()
                Dim color As Color = SelectThemeColor()
                currentButton = CType(btnSender, Button)
                currentButton.BackColor = color
                currentButton.ForeColor = Color.White
                currentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
                panelTitleBar.BackColor = color
                PanelLogo.BackColor = ThemesColor.ChangeColorBrightness(color, -0.3)
                ThemesColor.PrimaryColor = color
                ThemesColor.SecondaryColor = ThemesColor.ChangeColorBrightness(color, -0.3)
                btnCloseChildForm.Visible = True
            End If
        End If
    End Sub
    Private Sub DisableButton()
        For Each previousBtn As Control In panelMenu.Controls
            If previousBtn.[GetType]() = GetType(Button) Then
                previousBtn.BackColor = Color.FromArgb(51, 204, 255) '51, 51, 76)
                previousBtn.ForeColor = Color.Gainsboro
                previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            End If
        Next
    End Sub
    Private Sub OpenChildForm(childForm As Form, btnSender As Object)
        If activeForm IsNot Nothing Then activeForm.Close()
        ActivateButton(btnSender)
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.panelDesktopPane.Controls.Add(childForm)
        Me.panelDesktopPane.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblTitle.Text = childForm.Text
        lblTitle.Left = (panelTitleBar.ClientSize.Width \ 2) - (lblTitle.Width \ 2)
        lblTitle.Top = (panelTitleBar.ClientSize.Height \ 2) - (lblTitle.Height \ 2)
    End Sub
    Private Sub btnCloseChildForm_Click(sender As Object, e As EventArgs) Handles btnCloseChildForm.Click
        If (Not (activeForm) Is Nothing) Then
            activeForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        DisableButton()
        lblTitle.Text = "TRANG CHỦ"
        panelTitleBar.BackColor = Color.FromArgb(51, 204, 255)
        PanelLogo.BackColor = Color.FromArgb(51, 153, 255)
        currentButton = New Button()
        btnCloseChildForm.Visible = False
        lblTitle.Left = (panelTitleBar.ClientSize.Width \ 2) - (lblTitle.Width \ 2)
        lblTitle.Top = (panelTitleBar.ClientSize.Height \ 2) - (lblTitle.Height \ 2)
    End Sub
    'DRAG FORM'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub xemDiemChuanBtn_Click(sender As Object, e As EventArgs) Handles xemDiemChuanBtn.Click
        OpenChildForm(New xemDiemChuan(), sender)
    End Sub

    Private Sub dknvBtn_Click(sender As Object, e As EventArgs) Handles dknvBtn.Click
        OpenChildForm(New DangKiNguyenVong(), sender)
    End Sub

    Private Sub updateNVBtn_Click(sender As Object, e As EventArgs) Handles updateNVBtn.Click
        OpenChildForm(New updateNV(), sender)
    End Sub

    Private Sub accountBtn_Click(sender As Object, e As EventArgs) Handles accountBtn.Click
        OpenChildForm(New account(), sender)
    End Sub

    Private Sub introductionBtn_Click(sender As Object, e As EventArgs) Handles introductionBtn.Click
        OpenChildForm(New Introduction(), sender)
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        Login.Show()
    End Sub
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class