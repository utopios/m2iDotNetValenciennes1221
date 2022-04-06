
CREATE TABLE Users
(
	id int primary key identity(1,1),
	login varchar(50) not null,
	password varchar(50) not null,
	token varchar(200)
);