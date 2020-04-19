Create database SmartBazar
 Use SmartBazar

 Create table tbl_Admin
 (
 ad_id int identity primary key,
 ad_username nvarchar(50) not null unique,
 ad_password nvarchar(50) not null,
 ad_createdOn datetime
 )

 select * from tbl_Admin
 insert into tbl_Admin values('faiz','123456',GETDATE())

 Create table tbl_Category
 (
 cat_id int identity primary key,
 cat_name nvarchar(50) not null unique,
 cat_createdOn datetime,
 cat_color nvarchar(20),
 cat_icon nvarchar(50) not null,
 cat_fk_Ad_id int foreign key references tbl_Admin(ad_id)
 )
 select * from tbl_Category

 
 Create table tbl_Product
 (
	pro_id int identity primary key,
	pro_name nvarchar(50) not null ,
	pro_image1 nvarchar(50) not null,
	pro_image2 nvarchar(50) ,
	pro_image3 nvarchar(50) ,
	pro_des nvarchar(50) not null,
	pro_price float,
	pro_fk_Cat_id int foreign key references tbl_Category(cat_id)
 )

 select * from tbl_Product

 create table tbl_Order
 (
 o_id int primary key identity,
 o_username nvarchar(50) not null,
 o_phoneNo nvarchar(20) not null,
 o_email nvarchar(30),
 o_createdOn datetime,
 o_approved bit default 0
 )

 select * from tbl_Order

 create table tbl_ProductsOrdered
 (
 op_id int primary key identity,
 op_fk_Pro_id int foreign key references tbl_Product(pro_id),
 op_qty int,
 op_unitPrice float,
 op_total float,
 op_fk_O_id int foreign key references tbl_Order(o_id),
 )

 select * from tbl_ProductsOrdered

 select * from sys.tables