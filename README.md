# 🖥️ Hệ Thống Quản Lý Tiệm Net

## 📌 Giới thiệu
Đây là một project **Quản lý Net** được xây dựng bằng **C# WinForms** kết nối với **Oracle Database**.  
Hệ thống không chỉ quản lý thông tin máy trạm, người dùng, thời gian sử dụng… mà còn áp dụng **các thuật toán mã hoá cơ bản** để tăng cường bảo mật dữ liệu nhạy cảm (tài khoản, mật khẩu, thông tin người dùng).

---

## ⚙️ Công nghệ sử dụng
- **Ngôn ngữ**: C# (WinForms)  
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
   git clone https://github.com/Thinha1/DoAnCuoiKy-BMCSDL.git

# Quy trình làm việc với github

## Khi bắt đầu làm việc
1. Cập nhật repository mới nhất
```bash
git pull origin main
```
2. Tạo nhánh riêng để làm việc
```bash
git checkout -b ten-nhanh-cua-ban
```
## Trong quá trình làm việc
1. Thêm file đã chỉnh sửa vào staging
```bash
git add .
```
2. Commit thay đổi với mô tả cụ thể
```bash
git commit -m "Mô tả ngắn về thay đổi"
```
3. Đẩy nhánh lên repository
```bash
git push origin ten-nhanh-cua-ban
```
4. Tạo Pull Request (PR) trên GitHub để review và merge vào nhánh chính

## Khi kết thúc công việc
1. Chuyển về nhánh chính
```bash
git checkout main
```
2. Cập nhật lại repository mới nhất
```bash
git pull origin main
```
