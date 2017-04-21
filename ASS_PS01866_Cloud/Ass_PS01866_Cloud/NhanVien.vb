Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class NhanVien
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01809.mssql.somee.com;packet size=4096;user id=huynt;pwd=Abc@12345;data source=ps01809.mssql.somee.com;persist security info=False;initial catalog=ps01809"
    'câu lệnh load form load lại nhiều lần
    Private Sub NhanVien_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    'câu lệnh load Form
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 10000
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    'Câu lệnh sửa đổi thông tin
    Private Sub Button_change_Click(sender As Object, e As EventArgs) Handles Button_change.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Nhanvien set  password = @password, TenNhanVien = @TenNhanVien where MaNhanVien = @MaNhanVien"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaNhanVien", Text_User.Text)
            com.Parameters.AddWithValue("@password", Text_Password.Text)
            com.Parameters.AddWithValue("@TenNhanVien", Text_Name.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Sửa thông Tin thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        NhanVien_Load()
    End Sub
    'Câu lệnh thêm dữ liệu
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO NhanVien (MaNhanVien,password,TenNhanVien)"
        query &= "Values(@MaNhanVien,@password,@TenNhanVien)"
        Using conn As New SqlConnection("workstation id=ps01809.mssql.somee.com;packet size=4096;user id=huynt;pwd=Abc@12345;data source=ps01809.mssql.somee.com;persist security info=False;initial catalog=ps01809")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNhanVien", Text_User.Text)
                    .Parameters.AddWithValue("@Password", Text_Password.Text)
                    .Parameters.AddWithValue("@TenNhanVien", Text_Name.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
                tb.Clear()
                DataGridView1.DataSource = tb
                DataGridView1.DataSource = Nothing
                NhanVien_Load()
            End Using
        End Using
    End Sub
    'hiện thông tin từ CSDL
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        Text_User.Text = DataGridView1.Item(0, index).Value
        Text_Password.Text = DataGridView1.Item(1, index).Value
        Text_Name.Text = DataGridView1.Item(2, index).Value
    End Sub
    'tao button xóa hết các thông tin đang hiện trên *.text
    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        Text_Name.Clear()
        Text_Password.Clear()
        Text_User.Clear()
    End Sub
    'tạo button quay lại mainmenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
    'tạo button đóng tất cả
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MainMenu.Close()
        Login.Close()
        SanPham.Close()
        Khachhang.Close()
    End Sub
    'xoa thong tin
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from NhanVien where MaNhanVien = @MaNhanVien"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaNhanVien", Text_User.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xóa Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        NhanVien_Load()
    End Sub
    'tạo auto update
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        NhanVien_Load()
    End Sub
End Class