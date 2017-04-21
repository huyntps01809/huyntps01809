<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class khachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(khachhang))
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.Txttenkh = New System.Windows.Forms.TextBox()
        Me.Txtmakh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Bt_Clear = New System.Windows.Forms.Button()
        Me.Bt_Delete = New System.Windows.Forms.Button()
        Me.Bt_write = New System.Windows.Forms.Button()
        Me.Bt_Add = New System.Windows.Forms.Button()
        Me.Bt_Close = New System.Windows.Forms.Button()
        Me.Bt_Back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdiachi
        '
        Me.txtdiachi.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdiachi.Location = New System.Drawing.Point(171, 161)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(223, 27)
        Me.txtdiachi.TabIndex = 26
        '
        'txtsdt
        '
        Me.txtsdt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsdt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsdt.Location = New System.Drawing.Point(171, 123)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(223, 27)
        Me.txtsdt.TabIndex = 25
        '
        'Txttenkh
        '
        Me.Txttenkh.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttenkh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txttenkh.Location = New System.Drawing.Point(171, 85)
        Me.Txttenkh.Name = "Txttenkh"
        Me.Txttenkh.Size = New System.Drawing.Size(223, 27)
        Me.Txttenkh.TabIndex = 24
        '
        'Txtmakh
        '
        Me.Txtmakh.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmakh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtmakh.Location = New System.Drawing.Point(171, 47)
        Me.Txtmakh.Name = "Txtmakh"
        Me.Txtmakh.Size = New System.Drawing.Size(223, 27)
        Me.Txtmakh.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(13, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Mã Khách Hàng :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(13, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Địa Chỉ KH :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(13, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Số Điện Thoại :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(13, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tên Khách Hàng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(62, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Information Of Customer "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(538, 184)
        Me.DataGridView1.TabIndex = 29
        '
        'Bt_Clear
        '
        Me.Bt_Clear.BackgroundImage = CType(resources.GetObject("Bt_Clear.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bt_Clear.FlatAppearance.BorderSize = 0
        Me.Bt_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.Bt_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Clear.Location = New System.Drawing.Point(420, 198)
        Me.Bt_Clear.Name = "Bt_Clear"
        Me.Bt_Clear.Size = New System.Drawing.Size(130, 100)
        Me.Bt_Clear.TabIndex = 33
        Me.Bt_Clear.UseVisualStyleBackColor = True
        '
        'Bt_Delete
        '
        Me.Bt_Delete.BackgroundImage = CType(resources.GetObject("Bt_Delete.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bt_Delete.FlatAppearance.BorderSize = 0
        Me.Bt_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.Bt_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Delete.Location = New System.Drawing.Point(284, 198)
        Me.Bt_Delete.Name = "Bt_Delete"
        Me.Bt_Delete.Size = New System.Drawing.Size(130, 100)
        Me.Bt_Delete.TabIndex = 32
        Me.Bt_Delete.UseVisualStyleBackColor = True
        '
        'Bt_write
        '
        Me.Bt_write.BackgroundImage = CType(resources.GetObject("Bt_write.BackgroundImage"), System.Drawing.Image)
        Me.Bt_write.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_write.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bt_write.FlatAppearance.BorderSize = 0
        Me.Bt_write.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.Bt_write.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_write.Location = New System.Drawing.Point(148, 198)
        Me.Bt_write.Name = "Bt_write"
        Me.Bt_write.Size = New System.Drawing.Size(130, 100)
        Me.Bt_write.TabIndex = 31
        Me.Bt_write.UseVisualStyleBackColor = True
        '
        'Bt_Add
        '
        Me.Bt_Add.BackgroundImage = CType(resources.GetObject("Bt_Add.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Add.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bt_Add.FlatAppearance.BorderSize = 0
        Me.Bt_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.Bt_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Add.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bt_Add.Location = New System.Drawing.Point(12, 198)
        Me.Bt_Add.Name = "Bt_Add"
        Me.Bt_Add.Size = New System.Drawing.Size(130, 100)
        Me.Bt_Add.TabIndex = 30
        Me.Bt_Add.UseVisualStyleBackColor = True
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
        Me.Bt_Close.Location = New System.Drawing.Point(480, 1)
        Me.Bt_Close.Name = "Bt_Close"
        Me.Bt_Close.Size = New System.Drawing.Size(75, 40)
        Me.Bt_Close.TabIndex = 35
        Me.Bt_Close.UseVisualStyleBackColor = False
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
        Me.Bt_Back.Location = New System.Drawing.Point(400, 1)
        Me.Bt_Back.Name = "Bt_Back"
        Me.Bt_Back.Size = New System.Drawing.Size(75, 40)
        Me.Bt_Back.TabIndex = 34
        Me.Bt_Back.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(401, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 141)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'khachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 500)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Bt_Close)
        Me.Controls.Add(Me.Bt_Back)
        Me.Controls.Add(Me.Bt_Clear)
        Me.Controls.Add(Me.Bt_Delete)
        Me.Controls.Add(Me.Bt_write)
        Me.Controls.Add(Me.Bt_Add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.Txttenkh)
        Me.Controls.Add(Me.Txtmakh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "khachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents Txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents Txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Bt_Clear As System.Windows.Forms.Button
    Friend WithEvents Bt_Delete As System.Windows.Forms.Button
    Friend WithEvents Bt_write As System.Windows.Forms.Button
    Friend WithEvents Bt_Add As System.Windows.Forms.Button
    Friend WithEvents Bt_Close As System.Windows.Forms.Button
    Friend WithEvents Bt_Back As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
