-- =========================
-- DATABASE
-- =========================
CREATE DATABASE LogonLoginDB;
GO

USE LogonLoginDB;
GO

-- =========================
-- USERS
-- =========================
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME2 NULL DEFAULT GETDATE()
);
GO

-- =========================
-- NOTES
-- =========================
CREATE TABLE Notes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Content NVARCHAR(MAX) NOT NULL,
    UserId INT NOT NULL,
    CreatedAt DATETIME2 NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Notes_Users
    FOREIGN KEY (UserId) REFERENCES Users(Id)
    ON DELETE CASCADE
);
GO