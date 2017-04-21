Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Login
    'Button đăng nhập
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim chuoiketnoi As String = "workstation id=ps01809.mssql.somee.com;packet size=4096;user id=huynt;pwd=Abc@12345;data source=ps01809.mssql.somee.com;persist security info=False;initial catalog=ps01809"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNhanVien ='" & text_User.Text & "'and password='" & text_Password.Text & "' ", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết Nối Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None) 'Hiện bảng đăng nhập thành công'
                MainMenu.Show() 'Hiện bảng Menu'
                Me.Hide() 'Ẩn đi Khung Login'
            ElseIf text_User.Text = "" Or text_Password.Text = "" Then
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
        End Try

    End Sub
    'button exit
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles Button_exit.Click
        Me.Close()
        MainMenu.Close()
        SanPham.Close()
        khachhang.Close()
        NhanVien.Close()
        End
    End Sub
    'Button làm sạch (clear)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bt_clear.Click
        text_User.Clear()
        text_Password.Clear()
    End Sub
    'auto chạy hình ảnh
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label.Text = "pic1" Then
            image2.Image = My.Resources.Image1
            Label.Text = "pic2"
        ElseIf Label.Text = "pic2" Then
            image2.Image = My.Resources.Image2
            Label.Text = "pic3"
        ElseIf Label.Text = "pic3" Then
            image2.Image = My.Resources.Image3
            Label.Text = "pic4"
        ElseIf Label.Text = "pic4" Then
            image2.Image = My.Resources.Image4
            Label.Text = "pic5"
        ElseIf Label.Text = "pic5" Then
            image2.Image = My.Resources.Image5
            Label.Text = "pic1"
        End If
    End Sub
    'mặc định khi form login khởi động thì hình sẽ tự động chạy với thời gian 2s đổi 1 hình
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 2000
    End Sub
End Class
