Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class SanPham
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01809.mssql.somee.com;packet size=4096;user id=huynt;pwd=Abc@12345;data source=ps01809.mssql.somee.com;persist security info=False;initial catalog=ps01809"
    'Form tự load lại nhiều lần sau khi thêm, sửa, xóa thông tin
    Private Sub SanPham_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", KetNoi)
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Timer1.Enabled = True
        ' Timer1.Interval = 20000 
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", KetNoi)

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
    'button quay lại form Main menu
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Bt_Back.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
    'button đóng tất cả các form
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Bt_Close.Click
        Me.Close()
        MainMenu.Close()
        NhanVien.Close()
        Login.Close()
        khachhang.Close()
    End Sub
    'button làm trống các thông tin đã được nhập
    Private Sub Bt_Clear_Click(sender As Object, e As EventArgs) Handles Bt_Clear.Click
        TxtmaSP.Clear()
        Txtmakh.Clear()
        txttensp.Clear()
        txtsoluong.Clear()
        txtdongia.Clear()
        txtchitietSP.Clear()
    End Sub
    'Show dữ liệu lên DataGriwView
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TxtmaSP.Text = DataGridView1.Item(0, index).Value
        txttensp.Text = DataGridView1.Item(1, index).Value
        txtdongia.Text = DataGridView1.Item(2, index).Value
        txtsoluong.Text = DataGridView1.Item(3, index).Value
        txtchitietSP.Text = DataGridView1.Item(4, index).Value
        Txtmakh.Text = DataGridView1.Item(5, index).Value
    End Sub
    'button thêm sản phẩm lên CSDL somme
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bt_Add.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO SanPham (MASP,TenSP,Dongia,SOluong,ChitietSP,Khachhang_makhachhang)"
        query &= "Values(@MASP,@TenSP,@Dongia,@SOluong,@ChitietSP,@Khachhang_makhachhang)"
        Using conn As New SqlConnection("workstation id=ps01809.mssql.somee.com;packet size=4096;user id=huynt;pwd=Abc@12345;data source=ps01809.mssql.somee.com;persist security info=False;initial catalog=ps01809")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MASP", TxtmaSP.Text)
                    .Parameters.AddWithValue("@TenSP", txttensp.Text)
                    .Parameters.AddWithValue("@SOluong", txtsoluong.Text)
                    .Parameters.AddWithValue("@Dongia", txtdongia.Text)
                    .Parameters.AddWithValue("@ChitietSP", txtchitietSP.Text)
                    .Parameters.AddWithValue("@Khachhang_makhachhang", Txtmakh.Text)
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
                SanPham_Load()
            End Using
        End Using
    End Sub
    'button xóa thông tin CSDL trên Somme
    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from Sanpham where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", TxtmaSP.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        SanPham_Load()
    End Sub
    'button sửa dữ liệu rùi update lên CSDL trên somme
    Private Sub bt_write_Click(sender As Object, e As EventArgs) Handles bt_write.Click
       Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Sanpham set   chitietsp = @chitietsp, dongia=@dongia ,Soluong=@soluong, tensp =@tensp, khachhang_Makhachhang =@khachhang_makhachhang where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MASP", TxtmaSP.Text)
            com.Parameters.AddWithValue("@TenSP", txttensp.Text)
            com.Parameters.AddWithValue("@Soluong", txtsoluong.Text)
            com.Parameters.AddWithValue("@Dongia", txtdongia.Text)
            com.Parameters.AddWithValue("@chitietsp", txtchitietSP.Text)
            com.Parameters.AddWithValue("@khachhang_makhachhang", Txtmakh.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Sửa thông Tin Không thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        SanPham_Load()
    End Sub
End Class