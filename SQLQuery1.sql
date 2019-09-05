create  table ImageUpload
(
	ImageID int primary key identity,
	ImageURL varchar(100) not null,
	ImageName varchar(50) not null
)