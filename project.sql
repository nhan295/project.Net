
create database [Project.Net];

USE master;
drop database [Project.Net];

use [Project.Net];

create table Cinema (
	cinema_id int primary key,
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

create table Genre (
	genre_id int primary key,
	genre_name nvarchar(45)
);


create table Showtimes (
	showtime_id int primary key,
	time nvarchar(45)
);

create table ScreeningRoom (
	screeningroom_id int primary key,
	cinema_id int,
	showtime_id int,
	screeningroom_seats nvarchar(45),
	screeningroom_name nvarchar(45),

	foreign key (cinema_id) references Cinema(cinema_id),
	foreign key (showtime_id) references Showtimes(showtime_id)
);

create table Invoice (
	invoice_id int primary key,
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
	seat_id int primary key,
	screeningroom_id int,
	seat_number nvarchar(45),
	seat_status tinyint,

	foreign key (screeningroom_id) references ScreeningRoom(screeningroom_id)
);


create table Film(
	film_id int primary key,
	title nvarchar(50),
	rated nvarchar(250),
	genre_id int,
	release_date date,
	director nvarchar(50),
	company_production nvarchar(50),
	desciption nvarchar(50),
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
        f.desciption, 
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


-- Chèn dữ liệu vào bảng Cinema
INSERT INTO Cinema (cinema_id, cinema_room, cinema_address, total_rooms) VALUES
(1, 'Room A', '123 Main St', '5'),
(2, 'Room B', '456 Elm St', '3'),
(3, 'Room C', '789 Oak St', '4'),
(4, 'Room D', '159 Pine St', '2'),
(5, 'Room E', '753 Birch St', '6'),
(6, 'Room F', '852 Cedar St', '4'),
(7, 'Room G', '369 Maple St', '5'),
(8, 'Room H', '147 Spruce St', '3'),
(9, 'Room I', '258 Walnut St', '4'),
(10, 'Room J', '369 Cherry St', '2');

-- Chèn dữ liệu vào bảng Customer
INSERT INTO Customer (cus_id, cus_name, cus_password, cus_phone, cus_email, cus_address, cus_birthday) VALUES
(1, 'John Doe', 'pass123', '123456789', 'john@example.com', 'New York', '2003-05-20'),
(2, 'Jane Smith', 'pass456', '987654321', 'jane@example.com', 'Los Angeles', '2003-05-20'),
(3, 'Alice Brown', 'alice789', '456123789', 'alice@example.com', 'Chicago', '2003-05-20'),
(4, 'Bob White', 'bob321', '321654987', 'bob@example.com', 'Houston', '2003-05-20'),
(5, 'Charlie Black', 'charlie654', '789321456', 'charlie@example.com', 'San Francisco', '2003-05-20'),
(6, 'David Green', 'david987', '159753468', 'david@example.com', 'Seattle', '2003-05-20'),
(7, 'Eve Blue', 'eve456', '357159486', 'eve@example.com', 'Denver', '2003-05-20'),
(8, 'Frank Yellow', 'frank123', '951753846', 'frank@example.com', 'Boston', '2003-05-20'),
(9, 'Grace Pink', 'grace789', '753159246', 'grace@example.com', 'Miami', '2003-05-20'),
(10, 'Henry Orange', 'henry321', '852963741', 'henry@example.com', 'Dallas', '2003-05-20');


-- Chèn dữ liệu vào bảng Genre
INSERT INTO Genre (genre_id, genre_name) VALUES
(1, 'Action'),
(2, 'Comedy'),
(3, 'Drama'),
(4, 'Horror'),
(5, 'Sci-Fi'),
(6, 'Romance'),
(7, 'Thriller'),
(8, 'Animation'),
(9, 'Mystery'),
(10, 'Fantasy');

-- Chèn dữ liệu vào bảng Showtimes
INSERT INTO Showtimes (showtime_id, time) VALUES
(1, '10:00 AM'),
(2, '12:30 PM'),
(3, '3:00 PM'),
(4, '5:30 PM'),
(5, '8:00 PM'),
(6, '10:30 PM'),
(7, '1:00 AM'),
(8, '3:30 AM'),
(9, '6:00 AM'),
(10, '8:30 AM');

-- Chèn dữ liệu vào bảng ScreeningRoom
INSERT INTO ScreeningRoom (screeningroom_id, cinema_id, showtime_id, screeningroom_seats, screeningroom_name) VALUES
(1, 1, 1, '50', 'Screen 1'),
(2, 2, 2, '40', 'Screen 2'),
(3, 3, 3, '30', 'Screen 3'),
(4, 4, 4, '20', 'Screen 4'),
(5, 5, 5, '60', 'Screen 5'),
(6, 6, 6, '45', 'Screen 6'),
(7, 7, 7, '35', 'Screen 7'),
(8, 8, 8, '25', 'Screen 8'),
(9, 9, 9, '55', 'Screen 9'),
(10, 10, 10, '50', 'Screen 10');

-- Chèn dữ liệu vào bảng Seat
INSERT INTO Seat (seat_id, screeningroom_id, seat_number, seat_status) VALUES
(1, 1, 'A1', 1),
(2, 2, 'B2', 0),
(3, 3, 'C3', 1),
(4, 4, 'D4', 0),
(5, 5, 'E5', 1),
(6, 6, 'F6', 1),
(7, 7, 'G7', 0),
(8, 8, 'H8', 1),
(9, 9, 'I9', 0),
(10, 10, 'J10', 1);

-- Chèn dữ liệu vào bảng Film
INSERT INTO Film (film_id, title, genre_id, release_date, director, company_production, description, thumbnail, film_status, film_language) VALUES
(1, 'The Avengers', 1, '2012-05-04', 'Joss Whedon', 'Marvel Studios', 'Superhero film', 'avengers.jpg', 'Now Showing', 'English - Vietnamese'),
(2, 'Inception', 5, '2010-07-16', 'Christopher Nolan', 'Warner Bros.', 'Sci-fi thriller', 'inception.jpg', 'Now Showing', 'English - Vietnamese'),
(3, 'Titanic', 6, '1997-12-19', 'James Cameron', '20th Century Fox', 'Romantic drama', 'titanic.jpg', 'Now Showing', 'English - Vietnamese'),
(4, 'The Conjuring', 4, '2013-07-19', 'James Wan', 'New Line Cinema', 'Horror film', 'conjuring.jpg', 'Now Showing', 'English - Vietnamese'),
(5, 'Toy Story', 8, '1995-11-22', 'John Lasseter', 'Pixar', 'Animated film', 'toystory.jpg', 'Now Showing', 'English - Vietnamese'),
(6, 'The Dark Knight', 1, '2008-07-18', 'Christopher Nolan', 'Warner Bros.', 'Superhero film', 'darkknight.jpg', 'Now Showing', 'English - Vietnamese'),
(7, 'Interstellar', 5, '2014-11-07', 'Christopher Nolan', 'Paramount', 'Sci-fi adventure', 'interstellar.jpg', 'Now Showing', 'English - Vietnamese'),
(8, 'Frozen', 10, '2013-11-27', 'Chris Buck', 'Disney', 'Fantasy animation', 'frozen.jpg', 'Now Showing', 'English - Vietnamese'),
(9, 'Parasite', 3, '2019-05-30', 'Bong Joon-ho', 'CJ Entertainment', 'Thriller drama', 'parasite.jpg', 'Now Showing', 'English - Vietnamese'),
(10, 'The Godfather', 3, '1972-03-24', 'Francis Ford Coppola', 'Paramount Pictures', 'Crime drama', 'godfather.jpg', 'Now Showing', 'English - Vietnamese');



