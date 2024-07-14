CREATE table categories(
   Id int primary key identity(1,1),
   Name nvarchar(255) not null unique
);
create table products(
   Id int primary key identity(1,1),
   Name nvarchar(255) not null,
   Thumbnail varchar(255),
   Price decimal(12,4) not null check(Price >= 0),
   Qty int not null CHECK(Qty >= 0) DEFAULT 0,
   Description ntext,
   CategoryId int not NULL FOREIGN key REFERENCES categories(Id)
   );
   create table users(
   Id int primary key identity(1,1),
   FullName nvarchar(255) not null,
   Email varchar(255) not null unique,
   Password varchar(255) not null,
   Tel varchar(20),
   Age int check(Age > 0)
   ); 