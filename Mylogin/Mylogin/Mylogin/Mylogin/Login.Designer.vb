<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.linkaccnt = New Guna.UI.WinForms.GunaLinkLabel()
        Me.SignIn = New Guna.UI.WinForms.GunaButton()
        Me.password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.p3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnx = New Guna.UI.WinForms.GunaLabel()
        Me.rePass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaCheckBox2 = New Guna.UI.WinForms.GunaCheckBox()
        Me.signUp = New Guna.UI.WinForms.GunaButton()
        Me.passSignUp = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.userSignup = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.p1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p2.SuspendLayout()
        Me.p3.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p1.Controls.Add(Me.PictureBox1)
        Me.anima1.SetDecoration(Me.p1, Guna.UI.Animation.DecorationType.None)
        Me.p1.Location = New System.Drawing.Point(-1, 0)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(363, 537)
        Me.p1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.anima1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 251)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'p2
        '
        Me.p2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p2.BackColor = System.Drawing.Color.White
        Me.p2.Controls.Add(Me.closeBtn)
        Me.p2.Controls.Add(Me.GunaCheckBox1)
        Me.p2.Controls.Add(Me.l1)
        Me.p2.Controls.Add(Me.linkaccnt)
        Me.p2.Controls.Add(Me.SignIn)
        Me.p2.Controls.Add(Me.password)
        Me.p2.Controls.Add(Me.username)
        Me.anima1.SetDecoration(Me.p2, Guna.UI.Animation.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(365, 0)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(371, 537)
        Me.p2.TabIndex = 1
        '
        'closeBtn
        '
        Me.anima1.SetDecoration(Me.closeBtn, Guna.UI.Animation.DecorationType.None)
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Black
        Me.closeBtn.Location = New System.Drawing.Point(331, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.closeBtn.Size = New System.Drawing.Size(27, 23)
        Me.closeBtn.TabIndex = 5
        Me.closeBtn.Text = "X"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.anima1.SetDecoration(Me.GunaCheckBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox1.Location = New System.Drawing.Point(41, 323)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox1.TabIndex = 4
        Me.GunaCheckBox1.Text = "Show Password"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.anima1.SetDecoration(Me.l1, Guna.UI.Animation.DecorationType.None)
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.l1.Location = New System.Drawing.Point(72, 23)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(196, 72)
        Me.l1.TabIndex = 0
        Me.l1.Text = "LOGIN"
        Me.l1.Visible = False
        '
        'linkaccnt
        '
        Me.linkaccnt.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.linkaccnt.AutoSize = True
        Me.anima1.SetDecoration(Me.linkaccnt, Guna.UI.Animation.DecorationType.None)
        Me.linkaccnt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkaccnt.LinkColor = System.Drawing.Color.Silver
        Me.linkaccnt.Location = New System.Drawing.Point(126, 441)
        Me.linkaccnt.Name = "linkaccnt"
        Me.linkaccnt.Size = New System.Drawing.Size(89, 15)
        Me.linkaccnt.TabIndex = 3
        Me.linkaccnt.TabStop = True
        Me.linkaccnt.Text = "Create Account"
        '
        'SignIn
        '
        Me.SignIn.Animated = True
        Me.SignIn.AnimationHoverSpeed = 0.07!
        Me.SignIn.AnimationSpeed = 0.03!
        Me.SignIn.BackColor = System.Drawing.Color.Turquoise
        Me.SignIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignIn.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.SignIn, Guna.UI.Animation.DecorationType.None)
        Me.SignIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SignIn.FocusedColor = System.Drawing.Color.Empty
        Me.SignIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SignIn.ForeColor = System.Drawing.Color.White
        Me.SignIn.Image = Nothing
        Me.SignIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.SignIn.Location = New System.Drawing.Point(41, 372)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.SignIn.OnHoverForeColor = System.Drawing.Color.White
        Me.SignIn.OnHoverImage = Nothing
        Me.SignIn.OnPressedColor = System.Drawing.Color.Black
        Me.SignIn.Size = New System.Drawing.Size(252, 42)
        Me.SignIn.TabIndex = 2
        Me.SignIn.Text = "Sign in"
        Me.SignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'password
        '
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.password, Guna.UI.Animation.DecorationType.None)
        Me.password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password.HintForeColor = System.Drawing.Color.Silver
        Me.password.HintText = ""
        Me.password.isPassword = True
        Me.password.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.LineIdleColor = System.Drawing.Color.Gray
        Me.password.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.password.LineThickness = 3
        Me.password.Location = New System.Drawing.Point(41, 252)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(252, 44)
        Me.password.TabIndex = 1
        Me.password.Text = "Password"
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'username
        '
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.username, Guna.UI.Animation.DecorationType.None)
        Me.username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.HintForeColor = System.Drawing.Color.Silver
        Me.username.HintText = "Username"
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.LineIdleColor = System.Drawing.Color.Gray
        Me.username.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.username.LineThickness = 3
        Me.username.Location = New System.Drawing.Point(41, 161)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(252, 44)
        Me.username.TabIndex = 0
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'p3
        '
        Me.p3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p3.BackColor = System.Drawing.Color.White
        Me.p3.Controls.Add(Me.GunaLabel1)
        Me.p3.Controls.Add(Me.btnx)
        Me.p3.Controls.Add(Me.rePass)
        Me.p3.Controls.Add(Me.GunaCheckBox2)
        Me.p3.Controls.Add(Me.signUp)
        Me.p3.Controls.Add(Me.passSignUp)
        Me.p3.Controls.Add(Me.userSignup)
        Me.anima1.SetDecoration(Me.p3, Guna.UI.Animation.DecorationType.None)
        Me.p3.Location = New System.Drawing.Point(365, 23)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(327, 488)
        Me.p3.TabIndex = 2
        Me.p3.Visible = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(41, 21)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(245, 72)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "SIGN UP"
        '
        'btnx
        '
        Me.btnx.AutoSize = True
        Me.anima1.SetDecoration(Me.btnx, Guna.UI.Animation.DecorationType.None)
        Me.btnx.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnx.ForeColor = System.Drawing.Color.Silver
        Me.btnx.Location = New System.Drawing.Point(307, 3)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(18, 20)
        Me.btnx.TabIndex = 6
        Me.btnx.Text = "X"
        '
        'rePass
        '
        Me.rePass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.rePass, Guna.UI.Animation.DecorationType.None)
        Me.rePass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rePass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rePass.HintForeColor = System.Drawing.Color.Silver
        Me.rePass.HintText = "Re-Enter Password"
        Me.rePass.isPassword = False
        Me.rePass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rePass.LineIdleColor = System.Drawing.Color.Gray
        Me.rePass.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.rePass.LineThickness = 3
        Me.rePass.Location = New System.Drawing.Point(34, 268)
        Me.rePass.Margin = New System.Windows.Forms.Padding(4)
        Me.rePass.Name = "rePass"
        Me.rePass.Size = New System.Drawing.Size(252, 44)
        Me.rePass.TabIndex = 5
        Me.rePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaCheckBox2
        '
        Me.GunaCheckBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.anima1.SetDecoration(Me.GunaCheckBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox2.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox2.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox2.Location = New System.Drawing.Point(33, 333)
        Me.GunaCheckBox2.Name = "GunaCheckBox2"
        Me.GunaCheckBox2.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox2.TabIndex = 4
        Me.GunaCheckBox2.Text = "Show Password"
        '
        'signUp
        '
        Me.signUp.Animated = True
        Me.signUp.AnimationHoverSpeed = 0.07!
        Me.signUp.AnimationSpeed = 0.03!
        Me.signUp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signUp.BorderColor = System.Drawing.Color.Black
        Me.signUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.anima1.SetDecoration(Me.signUp, Guna.UI.Animation.DecorationType.None)
        Me.signUp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.signUp.FocusedColor = System.Drawing.Color.Empty
        Me.signUp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.signUp.ForeColor = System.Drawing.Color.White
        Me.signUp.Image = Nothing
        Me.signUp.ImageSize = New System.Drawing.Size(20, 20)
        Me.signUp.Location = New System.Drawing.Point(34, 396)
        Me.signUp.Name = "signUp"
        Me.signUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signUp.OnHoverBorderColor = System.Drawing.Color.Black
        Me.signUp.OnHoverForeColor = System.Drawing.Color.White
        Me.signUp.OnHoverImage = Nothing
        Me.signUp.OnPressedColor = System.Drawing.Color.Black
        Me.signUp.Size = New System.Drawing.Size(252, 42)
        Me.signUp.TabIndex = 2
        Me.signUp.Text = "Save"
        Me.signUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passSignUp
        '
        Me.passSignUp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.passSignUp, Guna.UI.Animation.DecorationType.None)
        Me.passSignUp.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.passSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passSignUp.HintForeColor = System.Drawing.Color.Silver
        Me.passSignUp.HintText = "Password"
        Me.passSignUp.isPassword = False
        Me.passSignUp.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passSignUp.LineIdleColor = System.Drawing.Color.Gray
        Me.passSignUp.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.passSignUp.LineThickness = 3
        Me.passSignUp.Location = New System.Drawing.Point(34, 202)
        Me.passSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.passSignUp.Name = "passSignUp"
        Me.passSignUp.Size = New System.Drawing.Size(252, 44)
        Me.passSignUp.TabIndex = 1
        Me.passSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'userSignup
        '
        Me.userSignup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.userSignup, Guna.UI.Animation.DecorationType.None)
        Me.userSignup.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.userSignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userSignup.HintForeColor = System.Drawing.Color.Silver
        Me.userSignup.HintText = "Username"
        Me.userSignup.isPassword = False
        Me.userSignup.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userSignup.LineIdleColor = System.Drawing.Color.Gray
        Me.userSignup.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.userSignup.LineThickness = 3
        Me.userSignup.Location = New System.Drawing.Point(34, 137)
        Me.userSignup.Margin = New System.Windows.Forms.Padding(4)
        Me.userSignup.Name = "userSignup"
        Me.userSignup.Size = New System.Drawing.Size(252, 44)
        Me.userSignup.TabIndex = 0
        Me.userSignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.anima1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.anima1.DefaultAnimation = Animation3
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 537)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p3)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.p1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.p3.ResumeLayout(False)
        Me.p3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents linkaccnt As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents SignIn As Guna.UI.WinForms.GunaButton
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents p3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnx As Guna.UI.WinForms.GunaLabel
    Friend WithEvents rePass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaCheckBox2 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents signUp As Guna.UI.WinForms.GunaButton
    Friend WithEvents passSignUp As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents userSignup As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents closeBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
