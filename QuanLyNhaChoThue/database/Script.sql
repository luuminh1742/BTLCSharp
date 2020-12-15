/*
Created		12/8/2020
Modified		12/12/2020
Project		
Model		
Company		
Author		
Version		
Database		MS SQL 7 
*/
create database QuanLyNhaThue
go
use QuanLyNhaThue
go

Create table [Users] (
	[Id] Integer Identity NOT NULL,
	[UserName] Varchar(200) NULL,
	[Password] Varchar(255) NULL,
	[FullName] Nvarchar(100) NULL,
	[Gender] Nchar(10) NULL,
	[Address] Nvarchar(255) NULL,
	[Phone] Char(12) NULL,
	[CreatedDate] Datetime NULL,
	[ModifiedDate] Datetime NULL,
	[Status] Bit NULL,
	[RoomId] Integer NULL,
Primary Key  ([Id])
) 
go

Create table [House] (
	[Id] Integer Identity NOT NULL,
	[Name] Nvarchar(200) NULL,
	[Address] Nvarchar(255) NULL,
	[Description] Nvarchar(255) NULL,
	[UserId] Integer NOT NULL,
Primary Key  ([Id])
) 
go

Create table [Room] (
	[Id] Integer Identity NOT NULL,
	[HouseId] Integer NOT NULL,
	[RoomName] Nvarchar(50) NOT NULL,
	[RoomMoney] Integer NOT NULL,
	[ElectricMoney] Integer NULL,
	[WaterMoney] Integer NULL,
	[NetworkMoney] Integer NULL,
	[OtherMoney] Integer NULL,
	[NetworkMoneyType] Nvarchar(255) NULL,
	[WaterMoneyType] Nvarchar(255) NULL,
	[LastElectricNumber] Integer NULL,
	[LastWaterNumber] Integer NULL,
	[Member] Integer NULL,
	[Description] Nvarchar(255) NULL,
	[Status] Bit NULL,
Primary Key  ([Id])
) 
go

Create table [Bill] (
	[Id] Integer Identity NOT NULL,
	[RoomId] Integer NOT NULL,
	[MemberName] Nvarchar(255) NULL,
	[RoomMoney] Integer NULL,
	[ElectricMoney] Integer NULL,
	[WaterMoney] Integer NULL,
	[NetworkMoney] Integer NULL,
	[OtherMoney] Integer NULL,
	[LastElectricNumber] Integer NULL,
	[ElectricNumber] Integer NULL,
	[LastWaterNumber] Integer NULL,
	[WaterNumber] Integer NULL,
	[TotalMoney] Integer NULL,
	[ModifiedBy] Nvarchar(100) NULL,
	[CreatedDate] Datetime NULL,
	[ModifiedDate] Datetime NULL,
	[Status] Bit NULL,
Primary Key  ([Id])
) 
go


Alter table [House] add  foreign key([UserId]) references [Users] ([Id]) 
go
Alter table [Room] add  foreign key([HouseId]) references [House] ([Id]) 
go
Alter table [Bill] add  foreign key([RoomId]) references [Room] ([Id]) 
go
Alter table [Users] add  foreign key([RoomId]) references [Room] ([Id]) 
go


Set quoted_identifier on
go

Set quoted_identifier off
go

 -- trigger

 --di?n nu?c
create trigger InsertBill
on Bill
for insert
as
	begin
		declare @BillId int;
		declare @RoomId int;
		declare @LastWaterNumber int;
		declare @LastElectricNumber int;
		declare @LastWaterNumberOld int;
		declare @LastElectricNumberOld int;
		select @BillId=Id from inserted
		select @RoomId=RoomId from inserted where Id=@BillId
		select @LastWaterNumber = LastWaterNumber from inserted where Id=@BillId
		select @LastElectricNumber = LastElectricNumber from inserted where Id=@BillId
		select @LastWaterNumberOld = LastWaterNumber from Room where Id=@RoomId
		select @LastElectricNumberOld = LastElectricNumber from Room where Id=@RoomId
		if(@LastElectricNumber<@LastElectricNumberOld or @LastWaterNumber<@LastWaterNumberOld)
		begin
			rollback;
		end
		else
			update Room set LastWaterNumber=@LastWaterNumber, LastElectricNumber=@LastElectricNumber where Id=@RoomId
	end

--thêm
create trigger InsertUser
on Users
for insert
as
	begin
		declare @UserIdNew int;
		declare @RoomIdForUser int;
		select @UserIdNew=Id from inserted
		select @RoomIdForUser=RoomId from inserted where Id=@UserIdNew
		update Room set Member=Member+1, Status=1 where Id=@RoomIdForUser
		
	end

--xóa
create trigger DeleteUser
on Users
for delete
as
	begin
		declare @UserIdNew int;
		declare @RoomIdForUser int;
		select @UserIdNew=Id from deleted
		select @RoomIdForUser=RoomId from deleted where Id=@UserIdNew
		update Room set Member=Member-1 where Id=@RoomIdForUser
		declare @Member int;
		select @Member=Member from Room where Id=@RoomIdForUser
		if(@Member=0)
			update Room set Status=0 where Id=@RoomIdForUser
	end



	select * from Users


select * from Bill


alter view View_Statistic
as
	select u.UserName,b.Status
	,convert(char(2),month(b.CreatedDate))+'-'+convert(char(4),year(b.CreatedDate))  as 'Date'
	, count(b.Status) as 'Count'
	from Bill as b inner join Room as r on b.RoomId = r.Id
	inner join House as h on r.HouseId = h.Id
	inner join Users as u on h.UserId = u.Id
	group by convert(char(2),month(b.CreatedDate))+'-'+convert(char(4),year(b.CreatedDate)), b.Status,u.UserName
	
select * from View_Statistic order by Date ,Status 
