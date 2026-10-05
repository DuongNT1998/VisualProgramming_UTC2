create table Categories(
id int primary key identity(1,1),
Name nvarchar(40) not null,
create_date datetime not null,
update_date datetime not null
)

create table Product(
id int primary key identity(1,1),
Name nvarchar(40) not null, --Example: N72
FilePath varchar(130) not null, --example: N72.jpg
Price money not null,
Description text not null,
storage varchar(30) not null,
Category_id int not null,
create_date datetime not null,
update_date datetime not null,
 FOREIGN KEY (Category_id) REFERENCES Categories(id)
)
CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(30) NOT NULL,
    Password NVARCHAR(30) NOT NULL
);
