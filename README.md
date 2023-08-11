# MÔN THI: Lập Trình Cơ Sở Dữ Liệu THỜI GIAN: 90 phút
HÌNH THỨC THI: Tự luận trên máy (Sinh viên được sử dụng tài liệu giấy)
 
# ĐỀ 4
>Lưu ý: Sinh viên tạo một project web MVC với tên là HOTEN_MSSV_SOMAY_DETHI (không dấu, ví dụ NguyenVan_123456_B01_De4).

## Câu 1 (1 điểm)

-	Tạo database `QuanLyBanHangThi` từ file scripts `QuanLyBanHangThi.sql`.
-	Sử dụng LinQ kết nối database `QuanLyBanHangThi` với project (tạo LinQ to SQL Classes đặt tên là `QuanLyBanHang.dbml`).
-	Chạy thành công project không phát sinh lỗi.

## Câu 2 (3 điểm)

Tạo controller có tên `KhachHang` và thực hiện các xử lý sau:

-	Hiển thị danh sách tất cả khách hàng theo thứ tự giảm dần của tên quốc gia (1 điểm).
-	Thêm mới một khách hàng (1 điểm)
-	Sửa thông tin một khách hàng (1 điểm)


## Câu 3 (6 điểm)

-	Trong View hiển thị danh sách khách hàng, thêm một `ActionLink` có tên **Thống kê** (Trước `ActionLink Delete`) link này sẽ gọi 1 `ActionResult` có tên là `TinhDoanhSo` (1 điểm). Và thêm một `ActionLink` có tên **TK Số lượng SP** (Sau `ActionLink Delete`) link này sẽ gọi 1 `ActionResult` có tên là `DemSLSP` (1 điểm).
 
-	Khi người dùng click vào link **Thống kê**, sẽ hiển thị một view chứa các thông tin như mẫu, trong đó tổng doanh số là tổng thành tiền của tất cả các đơn hàng khách hàng đó đã đặt (2 điểm):

Thống kê tổng doanh số
Mã khách hàng:	ALFKI
Tên công ty:	Alfreds Futterkiste
Tổng doanh số:	3600.40

-	Khi người dùng click vào link **TK Số lượng SP**, sẽ hiển thị một view chứa các thông tin như mẫu, trong đó tổng số lượng sản phẩm của tất cả các đơn hàng khách hàng đó đã đặt (2 điểm):

Thống kê số lượng sản phẩm
Mã khách hàng:	ALFKI
Tên công ty:	Alfreds Futterkiste
Tổng sản phẩm:	86 sản phẩm
