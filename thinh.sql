
CREATE TABLE MAY
(
    MaMay varchar2(10) PRIMARY KEY,
    Loai nvarchar2(30),
    TrangThai nvarchar2(20),
    NguoiTao nvarchar2(50),
    NgayTao date default sysdate,
    NguoiSua nvarchar2(50),
    NgaySua date
);

CREATE TABLE KHACHHANG
(
    MaKH varchar2(10) primary key,
    HoTen nvarchar2(50),
    SoDienThoai varchar2(15),
    CCCD NUMBER(15),
    SoDu NUMBER(10,2),
    NguoiTao nvarchar2(50),
    NgayTao date default sysdate,
    NguoiSua nvarchar2(50),
    NgaySua date
);

CREATE TABLE DICHVU
(
    MaDV varchar2(10) PRIMARY KEY,
    TenDV nvarchar2(50),
    DonGia NUMBER (10, 2),
    NguoiTao nvarchar2(50),
    NgayTao date default sysdate,
    NguoiSua nvarchar2(50),
    NgaySua date
);

CREATE TABLE HOADON
(
    MaHD varchar2(10) NOT NULL,
    MaMay varchar2(10),
    MaKH varchar2(10),
    ThoiGianBatDau Date,
    ThoiGianKetThuc Date,
    TongTien NUMBER(10, 2),
    NguoiTao nvarchar2(50),
    NgayTao date default sysdate,
    NguoiSua nvarchar2(50),
    NgaySua date,
    Constraint PK_HD Primary key(MaHD),
    Constraint FK_HD_M foreign key(MaMay) references May(MaMay),
    Constraint FK_HD_KH foreign key(MaKH) references KhachHang(MaKH)
);

CREATE TABLE CHITIETHOADON_DV
(
    MaHD varchar2(10) NOT NULL,
    MaDV varchar2(10) NOT NULL,
    SoLuong NUMBER(10), 
    THANHTIEN NUMBER(10, 2),
    NguoiTao nvarchar2(50),
    NgayTao date,
    NguoiSua nvarchar2(50),
    NgaySua date,
    CONSTRAINT PK_CTHD Primary key(MAHD, MADV),
    CONSTRAINT FK_CTHD_HD foreign key(MaHD) references HoaDon(MaHD),
    CONSTRAINT FK_CTHD_DV foreign key(MaDV) references DichVu(MaDV)
);


---------------------------------------------INSERT--------------------------------------------------------------
CREATE TRIGGER THEM_MAY
BEFORE INSERT ON MAY
FOR EACH ROW
BEGIN
    :New.NguoiTao := USER;
    :New.NgayTao := SYSDATE;
END;

//trigger them khach hang
CREATE TRIGGER THEM_KhachHang
BEFORE INSERT ON KhachHang
FOR EACH ROW
BEGIN
    :New.NguoiTao := USER;
    :New.NgayTao := SYSDATE;
END;

//trigger bảng dịch vụ
CREATE OR REPLACE TRIGGER THEM_DICHVU
BEFORE INSERT ON DICHVU
FOR EACH ROW
BEGIN
    :NEW.NguoiTao := USER;
    :NEW.NgayTao := SYSDATE;
END;
/

//trigger hóa đơn
CREATE OR REPLACE TRIGGER THEM_HOADON
BEFORE INSERT ON HOADON
FOR EACH ROW
BEGIN
    :NEW.NguoiTao := USER;
    :NEW.NgayTao := SYSDATE;
END;
/

//trigger chi tiết hóa đơn
CREATE OR REPLACE TRIGGER THEM_CTHD
BEFORE INSERT ON CHITIETHOADON_DV
FOR EACH ROW
BEGIN
    :NEW.NguoiTao := USER;
    :NEW.NgayTao := SYSDATE;
END;
/

-------------------------------------------------------------------------------UPDATE----------------------------------------------------------
//sửa thông tin máy
CREATE OR REPLACE TRIGGER SUA_MAY
BEFORE UPDATE ON MAY
FOR EACH ROW
BEGIN
    :NEW.NguoiSua := USER;
    :NEW.NgaySua := SYSDATE;
END;
/


CREATE OR REPLACE TRIGGER SUA_KHACHHANG
BEFORE UPDATE ON KHACHHANG
FOR EACH ROW
BEGIN
    :NEW.NguoiSua := USER;
    :NEW.NgaySua := SYSDATE;
END;
/



CREATE OR REPLACE TRIGGER SUA_HOADON
BEFORE UPDATE ON HOADON
FOR EACH ROW
BEGIN
    :NEW.NguoiSua := USER;
    :NEW.NgaySua := SYSDATE;
END;
/


CREATE OR REPLACE TRIGGER SUA_CTHD
BEFORE UPDATE ON CHITIETHOADON_DV
FOR EACH ROW
BEGIN
    :NEW.NguoiSua := USER;
    :NEW.NgaySua := SYSDATE;
END;
/



-- Thêm dữ liệu cho bảng MAY
INSERT INTO MAY (MaMay, Loai, TrangThai) VALUES ('M01', N'PC', N'Hoạt động');
INSERT INTO MAY (MaMay, Loai, TrangThai) VALUES ('M02', N'Laptop', N'Bảo trì');
INSERT INTO MAY (MaMay, Loai, TrangThai) VALUES ('M03', N'PC', N'Hoạt động');

-- Thêm dữ liệu cho bảng KHACHHANG
INSERT INTO KHACHHANG (MaKH, HoTen, SoDienThoai, CCCD, SoDu) 
VALUES ('KH01', N'Nguyễn Văn A', '0909123456', 123456789012345, 100000);
INSERT INTO KHACHHANG (MaKH, HoTen, SoDienThoai, CCCD, SoDu) 
VALUES ('KH02', N'Trần Thị B', '0912345678', 987654321098765, 50000);
INSERT INTO KHACHHANG (MaKH, HoTen, SoDienThoai, CCCD, SoDu) 
VALUES ('KH03', N'Lê Văn C', '0922334455', 112233445566778, 200000);

-- Thêm dữ liệu cho bảng DICHVU
INSERT INTO DICHVU (MaDV, TenDV, DonGia) VALUES ('DV01', N'Nước suối', 10000);
INSERT INTO DICHVU (MaDV, TenDV, DonGia) VALUES ('DV02', N'Coca Cola', 15000);
INSERT INTO DICHVU (MaDV, TenDV, DonGia) VALUES ('DV03', N'Mì xào', 30000);

-- Thêm dữ liệu cho bảng HOADON
INSERT INTO HOADON (MaHD, MaMay, MaKH, ThoiGianBatDau, ThoiGianKetThuc, TongTien) 
VALUES ('HD01', 'M01', 'KH01', TO_DATE('2025-09-30 08:00','YYYY-MM-DD HH24:MI'),
        TO_DATE('2025-09-30 10:00','YYYY-MM-DD HH24:MI'), 0);

INSERT INTO HOADON (MaHD, MaMay, MaKH, ThoiGianBatDau, ThoiGianKetThuc, TongTien) 
VALUES ('HD02', 'M02', 'KH02', TO_DATE('2025-09-30 09:00','YYYY-MM-DD HH24:MI'),
        TO_DATE('2025-09-30 11:30','YYYY-MM-DD HH24:MI'), 0);

-- Thêm dữ liệu cho bảng CHITIETHOADON_DV
INSERT INTO CHITIETHOADON_DV (MaHD, MaDV, SoLuong, ThanhTien) 
VALUES ('HD01', 'DV01', 2, 20000);
INSERT INTO CHITIETHOADON_DV (MaHD, MaDV, SoLuong, ThanhTien) 
VALUES ('HD01', 'DV03', 1, 30000);
INSERT INTO CHITIETHOADON_DV (MaHD, MaDV, SoLuong, ThanhTien) 
VALUES ('HD02', 'DV02', 3, 45000);


SELECT * FROM KHACHHANG


COMMIT;



