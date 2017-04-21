Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class khachhang
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01809.mssql.somee.com;packet size=4096;user id=huynt;pwd=Abc@12345;data source=ps01809.mssql.somee.com;persist security info=False;initial catalog=ps01809"
    'button load form lại nhiều lần sau khi nhấn nút button
    Private Sub khachhang_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Khachhang", KetNoi)
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    'button load form
    Private Sub khachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        'Timer1.Interval = 10000
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from khachhang", KetNoi)

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
    'button Sửa thông tin
    Private Sub Button_change_Click(sender As Object, e As EventArgs) Handles Bt_write.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE KhachHang set  Diachi_Kh= @Diachi_Kh, SoDT = @SoDT, TenKhachhang = @TenKhachhang where MaKhachHang = @MaKhachHang"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKhachHang", Txtmakh.Text)
            com.Parameters.AddWithValue("@TenKhachhang", Txttenkh.Text)
            com.Parameters.AddWithValue("@SoDT", txtsdt.Text)
            com.Parameters.AddWithValue("@Diachi_Kh", txtdiachi.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Sửa thông Tin thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        khachhang_Load()
    End Sub
    'button thêm thông tin lên somme
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Bt_Add.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO khachhang (Makhachhang,Tenkhachhang,soDT,Diachi_KH)"
        query &= "Values(@MaKhachHang,@TenKhachhang,@SoDT,@Diachi_Kh)"
        Using conn As New SqlConnection("workstation id=ps01809.mssql.somee.com;packet size=4096;user id=huynt;pwd=Abc@12345;data source=ps01809.mssql.somee.com;persist security info=False;initial catalog=ps01809")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKhachhang", Txtmakh.Text)
                    .Parameters.AddWithValue("@TenKhachhang", Txttenkh.Text)
                    .Parameters.AddWithValue("@SoDT", txtsdt.Text)
                    .Parameters.AddWithValue("@Diachi_KH", txtdiachi.Text)
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
                khachhang_Load()
            End Using
        End Using
    End Sub
    'khung chứa dữ liệu load từ somme
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        Txtmakh.Text = DataGridView1.Item(0, index).Value
        Txttenkh.Text = DataGridView1.Item(1, index).Value
        txtsdt.Text = DataGridView1.Item(2, index).Value
        txtdiachi.Text = DataGridView1.Item(3, index).Value
    End Sub
    'button quay lai main meunu
    Private Sub Bt_Back_Click(sender As Object, e As EventArgs) Handles Bt_Back.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
    'button Đóng tất cả form
    Private Sub Bt_Close_Click(sender As Object, e As EventArgs) Handles Bt_Close.Click
        Me.Close()
        MainMenu.Close()
        Login.Close()
        NhanVien.Close()
        SanPham.Close()
    End Sub
    'Button làm sạch các dữ liệu vừa nhập
    Private Sub Bt_Clear_Click(sender As Object, e As EventArgs) Handles Bt_Clear.Click
        txtdiachi.Clear()
        Txtmakh.Clear()
        txtsdt.Clear()
        Txttenkh.Clear()
    End Sub
    'Button delete thông tin
    Private Sub Bt_Delete_Click(sender As Object, e As EventArgs) Handles Bt_Delete.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from Khachhang where MaKhachhang = @MaKhachhang"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Makhachhang", Txtmakh.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xóa Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        khachhang_Load()
    End Sub
End Class