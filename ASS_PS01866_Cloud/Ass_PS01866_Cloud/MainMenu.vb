Public Class MainMenu
    'button log out và quay lại form login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Control.Click
        Me.Close()
        Login.Show()
    End Sub
    'button đóng tất cả
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
        khachhang.Close()
        Login.Close()
        NhanVien.Close()
        SanPham.Close()
    End Sub
    'button chuyển đến form nhân viên
    Private Sub Button_Nhanvien_Click(sender As Object, e As EventArgs) Handles Button_Nhanvien.Click
        NhanVien.Show()
        Me.Hide()
    End Sub
    'button chuyển đến form sản phẩm
    Private Sub Button_Product_Click(sender As Object, e As EventArgs) Handles Button_Product.Click
        SanPham.Show()
        Me.Hide()
    End Sub
    'button chuyển đến form khách hàng
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bt_khachhang.Click
        khachhang.Show()
        Me.Hide()
    End Sub
End Class