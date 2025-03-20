
create database [Project.Net];

USE master;
drop database [Project.Net];

use [Project.Net];

CREATE TABLE Cinema (
    cinema_id INT IDENTITY(1,1) PRIMARY KEY,
    cinema_name NVARCHAR(255) NOT NULL,
    location NVARCHAR(255) NOT NULL
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

CREATE TABLE Film (
    film_id INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(100) NOT NULL, -- Tăng độ dài tiêu đề phim
    rated NVARCHAR(50), -- Giữ nguyên
    genre_id INT, 
    release_date DATE,
    director NVARCHAR(100), -- Tăng độ dài tên đạo diễn
    company_production NVARCHAR(100), -- Tăng độ dài tên công ty sản xuất
    descriptions NVARCHAR(500), -- Tăng độ dài mô tả phim
    thumbnail NVARCHAR(255), -- Đường dẫn ảnh có thể dài hơn
    film_status NVARCHAR(50),
    film_language NVARCHAR(50),

    FOREIGN KEY (genre_id) REFERENCES Genre(genre_id)
);

select * from Film;

CREATE TABLE Showtimes (
    showtime_id INT IDENTITY(1,1) PRIMARY KEY,
    film_id INT,
    cinema_id INT,
    screeningroom_id INT,
    show_date DATE NOT NULL, -- Ngày chiếu
    show_time TIME NOT NULL, -- Giờ chiếu
    FOREIGN KEY (film_id) REFERENCES Film(film_id),
    FOREIGN KEY (cinema_id) REFERENCES Cinema(cinema_id),
    FOREIGN KEY (screeningroom_id) REFERENCES ScreeningRoom(screeningroom_id)
);


CREATE TABLE ScreeningRoom (
    screeningroom_id INT IDENTITY(1,1) PRIMARY KEY,
    cinema_id INT,
    room_name NVARCHAR(50) NOT NULL,
    seat_capacity INT NOT NULL, -- Tổng số ghế trong phòng
    FOREIGN KEY (cinema_id) REFERENCES Cinema(cinema_id)
);



CREATE TABLE Seat (
    seat_id INT IDENTITY(1,1) PRIMARY KEY,
    screeningroom_id INT,
    showtime_id INT,
    seat_number NVARCHAR(10) NOT NULL,
    seat_status TINYINT DEFAULT 0, -- 0: Trống, 1: Đã đặt
    FOREIGN KEY (screeningroom_id) REFERENCES ScreeningRoom(screeningroom_id),
    FOREIGN KEY (showtime_id) REFERENCES Showtimes(showtime_id)
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



CREATE TABLE movieCinema (
    cinema_id INT,
    film_id INT,
    PRIMARY KEY (cinema_id, film_id),
    FOREIGN KEY (cinema_id) REFERENCES Cinema(cinema_id),
    FOREIGN KEY (film_id) REFERENCES Film(film_id)
);






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



INSERT INTO Cinema (cinema_name, location) VALUES
('Vincom Hung Vuong', '123 Main St'),
('Vincom Xuan Khanh', '456 Elm St'),
('Lotte Hung Vuong', '789 Oak St'),
('Lotte Xuan Khanh', '159 Pine St'),
('BigC 30/4', '753 Birch St'),
('CinemaGV', '852 Cedar St'),
('Room G', '369 Maple St'),
('Room H', '147 Spruce St'),
('Room I', '258 Walnut St'),
('Room J', '369 Cherry St');

INSERT INTO Showtimes (film_id, cinema_id, screeningroom_id, show_date, show_time) VALUES
(6, 1, 1, '2025-03-21', '10:00:00'),
(6, 1, 1, '2025-03-21', '14:00:00'),
(6, 1, 1, '2025-03-21', '18:30:00'),

(2, 2, 2, '2025-03-21', '09:00:00'),
(2, 2, 2, '2025-03-21', '13:30:00'),
(2, 2, 2, '2025-03-21', '17:45:00'),

(3, 3, 3, '2025-03-21', '11:15:00'),
(3, 3, 3, '2025-03-21', '15:45:00'),
(3, 3, 3, '2025-03-21', '20:00:00'),

(4, 4, 4, '2025-03-21', '12:00:00'),
(4, 4, 4, '2025-03-21', '16:15:00'),
(4, 4, 4, '2025-03-21', '19:45:00'),

(5, 5, 5, '2025-03-21', '08:30:00'),
(5, 5, 5, '2025-03-21', '13:00:00'),
(5, 5, 5, '2025-03-21', '17:30:00');



INSERT INTO Seat (screeningroom_id, showtime_id, seat_number, seat_status) VALUES
(1, 7, 'A1', 0),
(1, 7, 'A2', 1),
(1, 7, 'A3', 0),
(1, 7, 'A4', 1),
(1, 7, 'A5', 0),
(1, 8, 'A1', 0),
(1, 8, 'A2', 0),
(1, 8, 'A3', 1),
(1, 8, 'A4', 0),
(1, 8, 'A5', 1),

(2, 3, 'B1', 1),
(2, 3, 'B2', 0),
(2, 3, 'B3', 1),
(2, 3, 'B4', 0),
(2, 3, 'B5', 0),
(2, 4, 'B1', 0),
(2, 4, 'B2', 1),
(2, 4, 'B3', 0),
(2, 4, 'B4', 1),
(2, 4, 'B5', 0),

(3, 5, 'C1', 0),
(3, 5, 'C2', 1),
(3, 5, 'C3', 0),
(3, 5, 'C4', 0),
(3, 5, 'C5', 1),
(3, 6, 'C1', 1),
(3, 6, 'C2', 0),
(3, 6, 'C3', 0),
(3, 6, 'C4', 1),
(3, 6, 'C5', 0);


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

insert movieCinema(cinema_id,film_id) values(1,1);
insert movieCinema(cinema_id,film_id) values(1,2);
insert movieCinema(cinema_id,film_id) values(1,3);
insert movieCinema(cinema_id,film_id) values(1,4);
insert movieCinema(cinema_id,film_id) values(2,1);
insert movieCinema(cinema_id,film_id) values(2,2);
insert movieCinema(cinema_id,film_id) values(2,3);
insert movieCinema(cinema_id,film_id) values(2,4);

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


-- Chèn dữ liệu vào bảng ScreeningRoom
INSERT INTO ScreeningRoom (cinema_id, room_name, seat_capacity) VALUES
(1, 'Room A1', 100),
(1, 'Room A2', 120),
(2, 'Room B1', 80),
(2, 'Room B2', 90),
(3, 'Room C1', 150),
(3, 'Room C2', 130),
(4, 'Room D1', 110),
(4, 'Room D2', 140),
(5, 'Room E1', 95),
(5, 'Room E2', 105);


-- Chèn dữ liệu vào bảng Seat


-- Chèn dữ liệu vào bảng Film
INSERT INTO Film (title, genre_id, release_date, director, company_production, descriptions, thumbnail, film_status, film_language) VALUES
('The Avengers', 1, '2012-05-04', 'Joss Whedon', 'Marvel Studios', 'Superhero film', 'avenger', 'Now Showing', 'English - Vietnamese'),
('Inception', 5, '2010-07-16', 'Christopher Nolan', 'Warner Bros.', 'Sci-fi thriller', 'inception', 'Now Showing', 'English - Vietnamese'),
('Titanic', 6, '1997-12-19', 'James Cameron', '20th Century Fox', 'Romantic drama', 'titanic', 'Now Showing', 'English - Vietnamese'),
('The Conjuring', 4, '2013-07-19', 'James Wan', 'New Line Cinema', 'Horror film', 'conjuring', 'Now Showing', 'English - Vietnamese'),
('Toy Story', 8, '1995-11-22', 'John Lasseter', 'Pixar', 'Animated film', 'toystory', 'Now Showing', 'English - Vietnamese'),
('The Dark Knight', 1, '2008-07-18', 'Christopher Nolan', 'Warner Bros.', 'Superhero film', 'darkknight', 'Now Showing', 'English - Vietnamese'),
('Interstellar', 5, '2014-11-07', 'Christopher Nolan', 'Paramount', 'Sci-fi adventure', 'interstellar', 'Now Showing', 'English - Vietnamese'),
('Frozen', 10, '2013-11-27', 'Chris Buck', 'Disney', 'Fantasy animation', 'frozen', 'Now Showing', 'English - Vietnamese'),
('Parasite', 3, '2019-05-30', 'Bong Joon-ho', 'CJ Entertainment', 'Thriller drama', 'parasite', 'Now Showing', 'English - Vietnamese'),
('The Godfather', 3, '1972-03-24', 'Francis Ford Coppola', 'Paramount Pictures', 'Crime drama', 'godfather', 'Now Showing', 'English - Vietnamese');




SELECT seat_number, seat_status FROM Seat WHERE showtime_id = 3; -- Thay 1 bằng showtime_id cần kiểm tra
