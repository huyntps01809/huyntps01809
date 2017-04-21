<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_User = New System.Windows.Forms.TextBox()
        Me.text_Password = New System.Windows.Forms.TextBox()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Bt_clear = New System.Windows.Forms.Button()
        Me.Button_exit = New System.Windows.Forms.Button()
        Me.image2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label = New System.Windows.Forms.Label()
        CType(Me.image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'text_User
        '
        Me.text_User.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.text_User.Location = New System.Drawing.Point(124, 52)
        Me.text_User.Name = "text_User"
        Me.text_User.Size = New System.Drawing.Size(192, 27)
        Me.text_User.TabIndex = 2
        '
        'text_Password
        '
        Me.text_Password.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.text_Password.Location = New System.Drawing.Point(124, 94)
        Me.text_Password.Name = "text_Password"
        Me.text_Password.Size = New System.Drawing.Size(192, 27)
        Me.text_Password.TabIndex = 3
        '
        'Button_Login
        '
        Me.Button_Login.BackColor = System.Drawing.Color.White
        Me.Button_Login.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button_Login.FlatAppearance.BorderSize = 4
        Me.Button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Login.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button_Login.Location = New System.Drawing.Point(12, 133)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(97, 46)
        Me.Button_Login.TabIndex = 4
        Me.Button_Login.Text = "Đăng nhập"
        Me.Button_Login.UseVisualStyleBackColor = False
        '
        'Bt_clear
        '
        Me.Bt_clear.BackColor = System.Drawing.Color.White
        Me.Bt_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bt_clear.FlatAppearance.BorderSize = 4
        Me.Bt_clear.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_clear.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Bt_clear.Location = New System.Drawing.Point(115, 132)
        Me.Bt_clear.Name = "Bt_clear"
        Me.Bt_clear.Size = New System.Drawing.Size(97, 46)
        Me.Bt_clear.TabIndex = 5
        Me.Bt_clear.Text = "Làm mới"
        Me.Bt_clear.UseVisualStyleBackColor = False
        '
        'Button_exit
        '
        Me.Button_exit.BackColor = System.Drawing.Color.White
        Me.Button_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button_exit.FlatAppearance.BorderSize = 4
        Me.Button_exit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_exit.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button_exit.Location = New System.Drawing.Point(218, 132)
        Me.Button_exit.Name = "Button_exit"
        Me.Button_exit.Size = New System.Drawing.Size(98, 46)
        Me.Button_exit.TabIndex = 6
        Me.Button_exit.Text = "Exit"
        Me.Button_exit.UseVisualStyleBackColor = False
        '
        'image2
        '
        Me.image2.BackColor = System.Drawing.Color.Transparent
        Me.image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.image2.ErrorImage = Nothing
        Me.image2.InitialImage = Nothing
        Me.image2.Location = New System.Drawing.Point(322, 0)
        Me.image2.Name = "image2"
        Me.image2.Size = New System.Drawing.Size(200, 185)
        Me.image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image2.TabIndex = 7
        Me.image2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(57, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Welcome To Tiki.vn"
        '
        'Timer1
        '
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(396, 108)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(27, 13)
        Me.Label.TabIndex = 11
        Me.Label.Text = "pic1"
        Me.Label.Visible = False
        '
        'Login
        '
        Me.AcceptButton = Me.Button_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button_exit
        Me.ClientSize = New System.Drawing.Size(523, 186)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.image2)
        Me.Controls.Add(Me.Button_exit)
        Me.Controls.Add(Me.Bt_clear)
        Me.Controls.Add(Me.Button_Login)
        Me.Controls.Add(Me.text_Password)
        Me.Controls.Add(Me.text_User)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        CType(Me.image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents text_User As System.Windows.Forms.TextBox
    Friend WithEvents text_Password As System.Windows.Forms.TextBox
    Friend WithEvents Button_Login As System.Windows.Forms.Button
    Friend WithEvents Bt_clear As System.Windows.Forms.Button
    Friend WithEvents Button_exit As System.Windows.Forms.Button
    Friend WithEvents image2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label As System.Windows.Forms.Label

End Class
