<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Button_Control = New System.Windows.Forms.Button()
        Me.Button_Nhanvien = New System.Windows.Forms.Button()
        Me.Button_Product = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_khachhang = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Control
        '
        Me.Button_Control.BackgroundImage = CType(resources.GetObject("Button_Control.BackgroundImage"), System.Drawing.Image)
        Me.Button_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Control.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Control.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Control.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Control.Location = New System.Drawing.Point(12, 12)
        Me.Button_Control.Name = "Button_Control"
        Me.Button_Control.Size = New System.Drawing.Size(117, 91)
        Me.Button_Control.TabIndex = 0
        Me.Button_Control.UseVisualStyleBackColor = True
        '
        'Button_Nhanvien
        '
        Me.Button_Nhanvien.BackColor = System.Drawing.Color.Transparent
        Me.Button_Nhanvien.BackgroundImage = CType(resources.GetObject("Button_Nhanvien.BackgroundImage"), System.Drawing.Image)
        Me.Button_Nhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Nhanvien.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Nhanvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Nhanvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nhanvien.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Nhanvien.Location = New System.Drawing.Point(258, 12)
        Me.Button_Nhanvien.Name = "Button_Nhanvien"
        Me.Button_Nhanvien.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_Nhanvien.Size = New System.Drawing.Size(117, 91)
        Me.Button_Nhanvien.TabIndex = 1
        Me.Button_Nhanvien.UseVisualStyleBackColor = False
        '
        'Button_Product
        '
        Me.Button_Product.BackgroundImage = CType(resources.GetObject("Button_Product.BackgroundImage"), System.Drawing.Image)
        Me.Button_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Product.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Product.Location = New System.Drawing.Point(381, 12)
        Me.Button_Product.Name = "Button_Product"
        Me.Button_Product.Size = New System.Drawing.Size(117, 91)
        Me.Button_Product.TabIndex = 2
        Me.Button_Product.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.BackgroundImage = CType(resources.GetObject("Button_Close.BackgroundImage"), System.Drawing.Image)
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Location = New System.Drawing.Point(504, 12)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(117, 91)
        Me.Button_Close.TabIndex = 3
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'bt_khachhang
        '
        Me.bt_khachhang.BackgroundImage = CType(resources.GetObject("bt_khachhang.BackgroundImage"), System.Drawing.Image)
        Me.bt_khachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_khachhang.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bt_khachhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_khachhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_khachhang.Location = New System.Drawing.Point(135, 12)
        Me.bt_khachhang.Name = "bt_khachhang"
        Me.bt_khachhang.Size = New System.Drawing.Size(117, 91)
        Me.bt_khachhang.TabIndex = 5
        Me.bt_khachhang.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(632, 338)
        Me.Controls.Add(Me.bt_khachhang)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Product)
        Me.Controls.Add(Me.Button_Nhanvien)
        Me.Controls.Add(Me.Button_Control)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Control As System.Windows.Forms.Button
    Friend WithEvents Button_Nhanvien As System.Windows.Forms.Button
    Friend WithEvents Button_Product As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bt_khachhang As System.Windows.Forms.Button
End Class
