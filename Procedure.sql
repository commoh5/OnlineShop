-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL

USE [OnlineShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Sp_Account_Login(
	@Username varchar(20),
	@Password varchar(50))
AS
BEGIN
	DECLARE @Count int
	DECLARE @Res bit
	SELECT @Count = count(*) FROM Account WHERE UserName = @Username AND PassWord = @Password
	IF @Count > 0
		SET @Res = 1
	ELSE
		SET @Res = 0
	SELECT @Res
END

Sp_Account_Login 'admin','123123'

create table Account(
	UserName varchar(20) not null primary key,
	PassWord varchar(50))

insert into Account values('admin','123123')