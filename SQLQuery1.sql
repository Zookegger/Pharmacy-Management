Create database Pharmacy_Management


use Pharmacy_Management

-- Bảng Cửa Hàng
CREATE TABLE CuaHang (
    MaCuaHang VARCHAR(10) PRIMARY KEY NOT NULL,
    TenCuaHang NVARCHAR(50),
    DiaChi NVARCHAR(100),
    SDT VARCHAR(10)
)


CREATE TABLE DuocSi (
    MaDuocSi VARCHAR(10) PRIMARY KEY NOT NULL,
    TenDuocSi NVARCHAR(50),
    NgaySinh DATE,
    SoDienThoai VARCHAR(10),
    Email VARCHAR(50)
)


-- Bảng Chứng Chỉ
CREATE TABLE ChungChi (
    MaChungChi VARCHAR(20) PRIMARY KEY NOT NULL,
    TenChungChi NVARCHAR(100),
    CoQuanCap VARCHAR(100),
    NgayCap DATE,
    NgayHetHan DATE,
    TinhTrang NVARCHAR(100)
)

-- Bảng Danh Sách Chứng Chỉ
CREATE TABLE DanhSachChungChi (
    MaDuocSi VARCHAR(10) ,
    MaChungChi VARCHAR(20) ,
    PRIMARY KEY (MaDuocSi, MaChungChi),
    FOREIGN KEY (MaDuocSi) REFERENCES DuocSi(MaDuocSi),
    FOREIGN KEY (MaChungChi) REFERENCES ChungChi(MaChungChi)
)

--Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKhachHang VARCHAR(10) PRIMARY KEY NOT NULL,
    TenKhachHang NVARCHAR(50),
    NgaySinh DATE,
    Email VARCHAR(50),
    SDT VARCHAR(10)
)

-- Bảng Đơn Thuốc
CREATE TABLE DonThuoc (
    MaDonThuoc VARCHAR(10) PRIMARY KEY,
    MaKhachHang VARCHAR(10),
    MaDuocSi VARCHAR(10),
    NgayLapDon DATETIME,
    TongGia MONEY,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaDuocSi) REFERENCES DuocSi(MaDuocSi)
)

-- Bảng Thuốc
CREATE TABLE Thuoc (
    MaThuoc VARCHAR(10) PRIMARY KEY NOT NULL,
    TenThuoc VARCHAR(50),
    DVT NVARCHAR(20),
    DonGia MONEY,
    SLT INT
)

-- Bảng Chi Tiết Đơn Thuốc
CREATE TABLE ChiTietDonThuoc (
    MaDonThuoc VARCHAR(10) NOT NULL,
    MaThuoc VARCHAR(10),
    NgayHetHan DATE,
    GiaTien  MONEY,
    PRIMARY KEY (MaDonThuoc, MaThuoc),
    FOREIGN KEY (MaDonThuoc) REFERENCES DonThuoc(MaDonThuoc),
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc)
)

-- Bảng Kho
CREATE TABLE Kho (
    MaKho VARCHAR(10) PRIMARY KEY NOT NULL,
    TenKho NVARCHAR(50),
    DiaChi NVARCHAR(100)
)

-- Bảng chi tiết kho
CREATE TABLE ChiTietKho(
	MaKho VARCHAR(10),                      
    MaThuoc VARCHAR(10),                                           
    SLT INT,                        
    PRIMARY KEY (MaKho, MaThuoc),    
    FOREIGN KEY (MaKho) REFERENCES Kho(MaKho),  
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc)
)

-- Bảng phiếu nhập từ kho	
CREATE TABLE PhieuNhapTuKho (
    MaPhieu VARCHAR(10) PRIMARY KEY NOT NULL,        
    MaThuoc VARCHAR(10),                     
    MaKho VARCHAR(10),                      
    MaDuocSi VARCHAR(10),                   
    SL INT,                          
    TinhTrang NVARCHAR(50),          
    NgayNhap DATETIME,                  
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc),  
    FOREIGN KEY (MaKho) REFERENCES Kho(MaKho),        
    FOREIGN KEY (MaDuocSi) REFERENCES DuocSi(MaDuocSi) 
)

-- Bảng Triệu Chứng
CREATE TABLE TrieuChung (
    MaTrieuChung VARCHAR(10) PRIMARY KEY NOT NULL,
    TenTrieuChung NVARCHAR(50),
    MoTa NVARCHAR(100)
)

-- Bảng Thành Phần
CREATE TABLE ThanhPhan (
    MaThanhPhan VARCHAR(10) PRIMARY KEY NOT NULL,
    TenThanhPhan NVARCHAR(100),
    CongDung NVARCHAR(100),
    DonViDoLuong NVARCHAR(20),
    MoTa NVARCHAR(200)
)

-- Bảng Thuốc - Triệu Chứng
CREATE TABLE Thuoc_TrieuChung (
    MaThuoc VARCHAR(10) NOT NULL,
    MaTrieuChung VARCHAR(10) NOT NULL,
    GhiChu NVARCHAR(100),
    PRIMARY KEY (MaThuoc, MaTrieuChung),
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc),
    FOREIGN KEY (MaTrieuChung) REFERENCES TrieuChung(MaTrieuChung)
)

-- Bảng Chi Tiết Thành Phần
CREATE TABLE ChiTietThanhPhan (
    MaThuoc VARCHAR(10) NOT NULL,
    MaThanhPhan VARCHAR(10) NOT NULL,
    HamLuong NVARCHAR(50),
    TiLe FLOAT,
    GhiChu NVARCHAR(255),
    PRIMARY KEY (MaThuoc, MaThanhPhan),
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc),
    FOREIGN KEY (MaThanhPhan) REFERENCES ThanhPhan(MaThanhPhan)
)

-- Bảng Nhà Cung Cấp
CREATE TABLE NhaCungCap (
    MaNhaCungCap VARCHAR(10) PRIMARY KEY NOT NULL,
    TenNhaCungCap NVARCHAR(50),
    DiaChi NVARCHAR(100),
    SDT VARCHAR(10),
    Email VARCHAR(50)
)

-- Bảng Chi Tiết Cung Cấp
CREATE TABLE ChiTietCungCap (
    MaThuoc VARCHAR(10) NOT NULL,
    MaNhaCungCap VARCHAR(10) NOT NULL,
    SL INT,
    PRIMARY KEY (MaThuoc, MaNhaCungCap),
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc),
    FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
)



INSERT INTO DuocSi  VALUES
('2280603097',N'Nguyễn Hữu Thịnh', '29/09/2004', '0934230042', 'thinh15v@gmail.com'),
('DS001', 'Nguyen Van A', '1985-05-15', '0123456789', 'nguyenvana@example.com'),
('DS002', 'Tran Thi B', '1990-08-20', '0987654321', 'tranthib@example.com'),
('DS003', 'Le Minh C', '1982-11-30', '0112233445', 'leminhc@example.com')

select * from DuocSi