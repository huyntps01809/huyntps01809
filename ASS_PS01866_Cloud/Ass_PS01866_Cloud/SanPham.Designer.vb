<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SanPham))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bt_Add = New System.Windows.Forms.Button()
        Me.bt_write = New System.Windows.Forms.Button()
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.Bt_Clear = New System.Windows.Forms.Button()
        Me.Bt_Back = New System.Windows.Forms.Button()
        Me.Bt_Close = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Txtmakh = New System.Windows.Forms.TextBox()
        Me.TxtmaSP = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtchitietSP = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Sản Phẩm :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đơn Giá (VNĐ) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số Lượng (cuốn) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mã Khách Hàng :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(12, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Chi Tiết Sản Phẩm :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(390, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Bt_Add
        '
        Me.Bt_Add.BackgroundImage = CType(resources.GetObject("Bt_Add.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Add.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bt_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.Bt_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Add.Location = New System.Drawing.Point(12, 237)
        Me.Bt_Add.Name = "Bt_Add"
        Me.Bt_Add.Size = New System.Drawing.Size(130, 100)
        Me.Bt_Add.TabIndex = 8
        Me.Bt_Add.UseVisualStyleBackColor = True
        '
        'bt_write
        '
        Me.bt_write.BackgroundImage = CType(resources.GetObject("bt_write.BackgroundImage"), System.Drawing.Image)
        Me.bt_write.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_write.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bt_write.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.bt_write.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.bt_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_write.Location = New System.Drawing.Point(148, 237)
        Me.bt_write.Name = "bt_write"
        Me.bt_write.Size = New System.Drawing.Size(130, 100)
        Me.bt_write.TabIndex = 9
        Me.bt_write.UseVisualStyleBackColor = True
        '
        'bt_delete
        '
        Me.bt_delete.BackgroundImage = CType(resources.GetObject("bt_delete.BackgroundImage"), System.Drawing.Image)
        Me.bt_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_delete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bt_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.bt_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_delete.Location = New System.Drawing.Point(284, 237)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(130, 100)
        Me.bt_delete.TabIndex = 10
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'Bt_Clear
        '
        Me.Bt_Clear.BackgroundImage = CType(resources.GetObject("Bt_Clear.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Clear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bt_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.Bt_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Clear.Location = New System.Drawing.Point(420, 237)
        Me.Bt_Clear.Name = "Bt_Clear"
        Me.Bt_Clear.Size = New System.Drawing.Size(130, 100)
        Me.Bt_Clear.TabIndex = 11
        Me.Bt_Clear.UseVisualStyleBackColor = True
        '
        'Bt_Back
        '
        Me.Bt_Back.BackColor = System.Drawing.Color.White
        Me.Bt_Back.BackgroundImage = CType(resources.GetObject("Bt_Back.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Back.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bt_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bt_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Back.Location = New System.Drawing.Point(390, 13)
        Me.Bt_Back.Name = "Bt_Back"
        Me.Bt_Back.Size = New System.Drawing.Size(75, 50)
        Me.Bt_Back.TabIndex = 12
        Me.Bt_Back.UseVisualStyleBackColor = False
        '
        'Bt_Close
        '
        Me.Bt_Close.BackColor = System.Drawing.Color.White
        Me.Bt_Close.BackgroundImage = CType(resources.GetObject("Bt_Close.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bt_Close.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bt_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bt_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Close.Location = New System.Drawing.Point(475, 13)
        Me.Bt_Close.Name = "Bt_Close"
        Me.Bt_Close.Size = New System.Drawing.Size(75, 50)
        Me.Bt_Close.TabIndex = 13
        Me.Bt_Close.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 351)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(531, 109)
        Me.DataGridView1.TabIndex = 14
        '
        'Txtmakh
        '
        Me.Txtmakh.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmakh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtmakh.Location = New System.Drawing.Point(181, 14)
        Me.Txtmakh.Name = "Txtmakh"
        Me.Txtmakh.Size = New System.Drawing.Size(203, 27)
        Me.Txtmakh.TabIndex = 15
        '
        'TxtmaSP
        '
        Me.TxtmaSP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtmaSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtmaSP.Location = New System.Drawing.Point(181, 52)
        Me.TxtmaSP.Name = "TxtmaSP"
        Me.TxtmaSP.Size = New System.Drawing.Size(203, 27)
        Me.TxtmaSP.TabIndex = 16
        '
        'txttensp
        '
        Me.txttensp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttensp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttensp.Location = New System.Drawing.Point(181, 90)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(203, 27)
        Me.txttensp.TabIndex = 17
        '
        'txtsoluong
        '
        Me.txtsoluong.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsoluong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsoluong.Location = New System.Drawing.Point(181, 128)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(203, 27)
        Me.txtsoluong.TabIndex = 18
        '
        'txtdongia
        '
        Me.txtdongia.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdongia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdongia.Location = New System.Drawing.Point(181, 166)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(203, 27)
        Me.txtdongia.TabIndex = 19
        '
        'txtchitietSP
        '
        Me.txtchitietSP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchitietSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtchitietSP.Location = New System.Drawing.Point(181, 204)
        Me.txtchitietSP.Name = "txtchitietSP"
        Me.txtchitietSP.Size = New System.Drawing.Size(203, 27)
        Me.txtchitietSP.TabIndex = 20
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Bt_Close
        Me.ClientSize = New System.Drawing.Size(559, 472)
        Me.Controls.Add(Me.txtchitietSP)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.TxtmaSP)
        Me.Controls.Add(Me.Txtmakh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Bt_Close)
        Me.Controls.Add(Me.Bt_Back)
        Me.Controls.Add(Me.Bt_Clear)
        Me.Controls.Add(Me.bt_delete)
        Me.Controls.Add(Me.bt_write)
        Me.Controls.Add(Me.Bt_Add)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "SanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Product"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Bt_Add As System.Windows.Forms.Button
    Friend WithEvents bt_write As System.Windows.Forms.Button
    Friend WithEvents bt_delete As System.Windows.Forms.Button
    Friend WithEvents Bt_Clear As System.Windows.Forms.Button
    Friend WithEvents Bt_Back As System.Windows.Forms.Button
    Friend WithEvents Bt_Close As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents TxtmaSP As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtchitietSP As System.Windows.Forms.TextBox
End Class
