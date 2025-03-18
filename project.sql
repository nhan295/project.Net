
create database [Project.Net];

USE master;
drop database [Project.Net];

use [Project.Net];

create table Cinema (
	cinema_id int identity(1,1) primary key,
	cinema_room nvarchar(45),
	cinema_address nvarchar(45),
	total_rooms nvarchar(45)
);

select* from cinema;

create table Customer (
	cus_id int identity(1,1) primary key,
	cus_name nvarchar(45),
	cus_password nvarchar(45),
	cus_phone nvarchar(45),
	cus_email nvarchar(45),
	cus_address nvarchar(125),
	cus_birthday date
);
select * from Customer;

create table Genre (
	genre_id int identity(1,1) primary key,
	genre_name nvarchar(45)
);


create table Showtimes (
	showtime_id int identity(1,1) primary key,
	film_id int,
	time nvarchar(45),

	foreign key (film_id) references film(film_id)
);

create table ScreeningRoom (
	screeningroom_id int identity(1,1) primary key,
	cinema_id int,
	showtime_id int,
	screeningroom_seats nvarchar(45),
	screeningroom_name nvarchar(45),

	foreign key (cinema_id) references Cinema(cinema_id),
	foreign key (showtime_id) references Showtimes(showtime_id)
);

create table Invoice (
	invoice_id int identity(1,1) primary key,
	cus_id int,
	screeningroom_id int,
	film_id int,
	seat_id int,
	cinema_id int,
	showtime_id int,

	foreign key (seat_id) references Seat(seat_id),
	foreign key (cinema_id) references Cinema(cinema_id),
	foreign key (showtime_id) references Showtimes(showtime_id),
	foreign key (film_id) references Film(film_id), 
	foreign key (cus_id) references Customer(cus_id),
	foreign key (screeningroom_id) references ScreeningRoom(screeningroom_id),
);

create table Seat (
	seat_id int identity(1,1) primary key,
	screeningroom_id int,
	seat_number nvarchar(45),
	seat_status tinyint,

	foreign key (screeningroom_id) references ScreeningRoom(screeningroom_id)
);


create table Film(
	film_id int identity(1,1) primary key,
	title nvarchar(50),
	rated nvarchar(250),
	genre_id int,
	release_date date,
	director nvarchar(50),
	company_production nvarchar(50),
	descriptions nvarchar(50),
	thumbnail nvarchar(50),
	film_status nvarchar(50),
	film_language nvarchar(50)

	foreign key (genre_id) references Genre(genre_id),

);

CREATE PROCEDURE SearchFilmByTitle  
    @Title NVARCHAR(50)  
AS  
BEGIN  
    SET NOCOUNT ON;  

    SELECT 
        f.film_id, 
        f.title, 
        g.genre_name, 
        f.release_date, 
        f.director, 
        f.company_production, 
        f.descriptions, 
        f.thumbnail
    FROM Film f
    JOIN Genre g ON f.genre_id = g.genre_id
    WHERE f.title LIKE N'%' + @Title + '%';  
END;


CREATE PROCEDURE InsertCustomerIntoInvoice
    @invoice_id INT,
    @cus_name NVARCHAR(45)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @cus_id INT;
    SELECT @cus_id = cus_id FROM Customer WHERE cus_name = @cus_name;
    IF @cus_id IS NOT NULL
    BEGIN
        UPDATE Invoice SET cus_id = @cus_id WHERE invoice_id = @invoice_id;
        PRINT 'Cập nhật hóa đơn thành công!';
    END
    ELSE
    BEGIN
        PRINT 'Khách hàng không tồn tại!';
    END
END;
--change password
CREATE PROCEDURE ChangeUserPassword
    @UserId INT,
    @new_pwd NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Customer 
    SET cus_password = @new_pwd
    WHERE cus_id = @UserId;

    IF @@ROWCOUNT > 0
        SELECT 1 AS Success; -- Thành công
    ELSE
        SELECT 0 AS Success; -- Thất bại
END;

EXEC ChangeUserPassword 1, "1234";

-- Chèn dữ liệu vào bảng Cinema
INSERT INTO Cinema (cinema_room, cinema_address, total_rooms) VALUES
('Room A', '123 Main St', '5'),
('Room B', '456 Elm St', '3'),
('Room C', '789 Oak St', '4'),
('Room D', '159 Pine St', '2'),
('Room E', '753 Birch St', '6'),
('Room F', '852 Cedar St', '4'),
('Room G', '369 Maple St', '5'),
('Room H', '147 Spruce St', '3'),
('Room I', '258 Walnut St', '4'),
('Room J', '369 Cherry St', '2');

-- Chèn dữ liệu vào bảng Customer
INSERT INTO Customer (cus_name, cus_password, cus_phone, cus_email, cus_address, cus_birthday) VALUES
('John Doe', 'pass123', '123456789', 'john@example.com', 'New York', '2003-05-20'),
('Jane Smith', 'pass456', '987654321', 'jane@example.com', 'Los Angeles', '2003-05-20'),
('Alice Brown', 'alice789', '456123789', 'alice@example.com', 'Chicago', '2003-05-20'),
('Bob White', 'bob321', '321654987', 'bob@example.com', 'Houston', '2003-05-20'),
('Charlie Black', 'charlie654', '789321456', 'charlie@example.com', 'San Francisco', '2003-05-20'),
('David Green', 'david987', '159753468', 'david@example.com', 'Seattle', '2003-05-20'),
('Eve Blue', 'eve456', '357159486', 'eve@example.com', 'Denver', '2003-05-20'),
('Frank Yellow', 'frank123', '951753846', 'frank@example.com', 'Boston', '2003-05-20'),
('Grace Pink', 'grace789', '753159246', 'grace@example.com', 'Miami', '2003-05-20'),
('Henry Orange', 'henry321', '852963741', 'henry@example.com', 'Dallas', '2003-05-20');


-- Chèn dữ liệu vào bảng Genre
INSERT INTO Genre (genre_name) VALUES
('Action'),
('Comedy'),
('Drama'),
('Horror'),
('Sci-Fi'),
('Romance'),
('Thriller'),
('Animation'),
('Mystery'),
('Fantasy');

-- Chèn dữ liệu vào bảng Showtimes
INSERT INTO Showtimes (time) VALUES
('10:00 AM'),
('12:30 PM'),
('3:00 PM'),
('5:30 PM'),
('8:00 PM'),
('10:30 PM'),
('1:00 AM'),
('3:30 AM'),
('6:00 AM'),
('8:30 AM');

-- Chèn dữ liệu vào bảng ScreeningRoom
INSERT INTO ScreeningRoom (cinema_id, screeningroom_seats, screeningroom_name) VALUES
(1,'50', 'Screen 1'),
(2,'40', 'Screen 2'),
(3,'30', 'Screen 3'),
(4,'20', 'Screen 4'),
(5,'60', 'Screen 5'),
(6,'45', 'Screen 6'),
(7,'35', 'Screen 7'),
(8,'25', 'Screen 8'),
(9,'55', 'Screen 9'),
(10,'50', 'Screen 10');

-- Chèn dữ liệu vào bảng Seat
INSERT INTO Seat (seat_number, seat_status) VALUES
('A1', 1),
('B2', 0),
('C3', 1),
('D4', 0),
('E5', 1),
('F6', 1),
('G7', 0),
('H8', 1),
('I9', 0),
('J10', 1);

-- Chèn dữ liệu vào bảng Film
INSERT INTO Film (title, genre_id, release_date, director, company_production, descriptions, thumbnail, film_status, film_language) VALUES
('The Avengers', 1, '2012-05-04', 'Joss Whedon', 'Marvel Studios', 'Superhero film', 'avengers', 'Now Showing', 'English - Vietnamese'),
('Inception', 5, '2010-07-16', 'Christopher Nolan', 'Warner Bros.', 'Sci-fi thriller', 'inception', 'Now Showing', 'English - Vietnamese'),
('Titanic', 6, '1997-12-19', 'James Cameron', '20th Century Fox', 'Romantic drama', 'titanic', 'Now Showing', 'English - Vietnamese'),
('The Conjuring', 4, '2013-07-19', 'James Wan', 'New Line Cinema', 'Horror film', 'conjuring', 'Now Showing', 'English - Vietnamese'),
('Toy Story', 8, '1995-11-22', 'John Lasseter', 'Pixar', 'Animated film', 'toystory', 'Now Showing', 'English - Vietnamese'),
('The Dark Knight', 1, '2008-07-18', 'Christopher Nolan', 'Warner Bros.', 'Superhero film', 'darkknight', 'Now Showing', 'English - Vietnamese'),
('Interstellar', 5, '2014-11-07', 'Christopher Nolan', 'Paramount', 'Sci-fi adventure', 'interstellar', 'Now Showing', 'English - Vietnamese'),
('Frozen', 10, '2013-11-27', 'Chris Buck', 'Disney', 'Fantasy animation', 'frozen', 'Now Showing', 'English - Vietnamese'),
('Parasite', 3, '2019-05-30', 'Bong Joon-ho', 'CJ Entertainment', 'Thriller drama', 'parasite', 'Now Showing', 'English - Vietnamese'),
('The Godfather', 3, '1972-03-24', 'Francis Ford Coppola', 'Paramount Pictures', 'Crime drama', 'godfather', 'Now Showing', 'English - Vietnamese');



select title, release_date, s.time, descriptions, rated, genre_name, director, film_language
                                                from film f inner join Showtimes s on f.film_id = s.film_id
                                                inner join Genre g on f.genre_id = g.genre_id
                                                where f.film_id=2;