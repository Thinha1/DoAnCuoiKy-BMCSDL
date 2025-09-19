# 🖥️ Hệ Thống Quản Lý Tiệm Net

## 📌 Giới thiệu
Đây là một project **Quản lý Net** được xây dựng bằng **C# WinForms** kết nối với **Oracle Database**.  
Hệ thống không chỉ quản lý thông tin máy trạm, người dùng, thời gian sử dụng… mà còn áp dụng **các thuật toán mã hoá cơ bản** để tăng cường bảo mật dữ liệu nhạy cảm (tài khoản, mật khẩu, thông tin người dùng).

---

## ⚙️ Công nghệ sử dụng
- **Ngôn ngữ**: C# (.NET Framework / WinForms)  
- **CSDL**: Oracle Database  
- **Thư viện**: `Oracle.ManagedDataAccess` để kết nối Oracle  
- **Thuật toán mã hoá**:
  - Hiện chưa có

---

## 📂 Chức năng chính
- **Đăng nhập / Đăng xuất người dùng** (có mã hoá mật khẩu)  
- **Quản lý máy trạm** (mở máy, tắt máy, trạng thái hoạt động)  
- **Quản lý người dùng** (thông tin, lịch sử đăng nhập, thời gian sử dụng)  
- **Tính tiền dịch vụ** dựa trên thời gian online  
- **Bảo mật dữ liệu** với các thuật toán mã hoá khi lưu vào DB  
- **Kill session** trên Oracle khi logout để đảm bảo đồng bộ  

---

## 🛠️ Cài đặt
1. Clone repo về máy:
   ```bash
   git clone (https://github.com/Thinha1/DoAnCuoiKy-BMCSDL.git
