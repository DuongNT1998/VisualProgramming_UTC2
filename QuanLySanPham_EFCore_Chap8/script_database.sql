-- ===== 1. TẠO DATABASE =====
IF DB_ID('QL_SanPham') IS NOT NULL
BEGIN
    ALTER DATABASE QL_SanPham SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QL_SanPham;
END
GO

CREATE DATABASE QL_SanPham;
GO

USE QL_SanPham;
GO

-- ===== 2. BẢNG DanhMucSanPham =====
CREATE TABLE DanhMucSanPham
(
    iddm         INT IDENTITY(1,1) NOT NULL,
    TenDanhMuc   NVARCHAR(100)     NOT NULL,
    create_at    DATETIME          NOT NULL DEFAULT (GETDATE()),
    update_at    DATETIME          NULL,

    CONSTRAINT PK__DanhMucS__9DB7AA9C191906F5 PRIMARY KEY (iddm)
);
GO

-- ===== 3. BẢNG SanPham =====
CREATE TABLE SanPham
(
    idsp      INT IDENTITY(1,1)   NOT NULL,
    tensp     NVARCHAR(150)       NOT NULL,
    soluong   INT                 NOT NULL DEFAULT (0),
    dvt       NVARCHAR(20)        NULL,
    hinh_anh  NVARCHAR(255)       NULL,
    don_gia   DECIMAL(18,2)       NOT NULL DEFAULT (0),
    iddm      INT                 NOT NULL,

    CONSTRAINT PK__SanPham__9DBB2CF256B07C96 PRIMARY KEY (idsp),

    CONSTRAINT FK_SanPham_DanhMuc FOREIGN KEY (iddm)
        REFERENCES DanhMucSanPham (iddm)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);
GO
