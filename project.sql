
﻿-- Tạo database
CREATE DATABASE [Project.Net];
USE [Project.Net];
use master;
drop database [Project.Net];
-- Tạo bảng
CREATE TABLE Cinema (
    cinema_id INT IDENTITY(1,1) PRIMARY KEY,
    cinema_name NVARCHAR(255) NOT NULL,
    location NVARCHAR(255) NOT NULL
);
select* from Cinema;

CREATE TABLE Genre (
    genre_id INT IDENTITY(1,1) PRIMARY KEY,
    genre_name NVARCHAR(45) NOT NULL
);

CREATE TABLE Customer (
    cus_id INT IDENTITY(1,1) PRIMARY KEY,
    cus_name NVARCHAR(45) NOT NULL,
    cus_password NVARCHAR(45) NOT NULL,
    cus_phone NVARCHAR(45) NOT NULL,
    cus_email NVARCHAR(45) NOT NULL,
    cus_address NVARCHAR(125),
    cus_birthday DATE
);
select * 

CREATE TABLE ScreeningRoom (
    screeningroom_id INT IDENTITY(1,1) PRIMARY KEY,
    cinema_id INT,
    room_name NVARCHAR(50) NOT NULL,
    seat_capacity INT NOT NULL,
    FOREIGN KEY (cinema_id) REFERENCES Cinema(cinema_id)
);

CREATE TABLE Film (
    film_id INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(100) NOT NULL,
    rated NVARCHAR(50),
	price int,
    genre_id INT,
    release_date DATE,
    director NVARCHAR(100),
    company_production NVARCHAR(100),
    descriptions NVARCHAR(500),
    thumbnail NVARCHAR(255),
    film_status NVARCHAR(50),
    film_language NVARCHAR(50),
    FOREIGN KEY (genre_id) REFERENCES Genre(genre_id)
);

CREATE TABLE Showtimes (
    showtime_id INT IDENTITY(1,1) PRIMARY KEY,
    film_id INT,
    cinema_id INT,
    screeningroom_id INT,
    show_date DATE NOT NULL,
    show_time TIME NOT NULL,
    FOREIGN KEY (film_id) REFERENCES Film(film_id),
    FOREIGN KEY (cinema_id) REFERENCES Cinema(cinema_id),
    FOREIGN KEY (screeningroom_id) REFERENCES ScreeningRoom(screeningroom_id)
);

CREATE TABLE Seat (
    seat_id INT IDENTITY(1,1) PRIMARY KEY,
    screeningroom_id INT,
    showtime_id INT,
    seat_number NVARCHAR(10) NOT NULL,
    seat_status TINYINT DEFAULT 0,
    FOREIGN KEY (screeningroom_id) REFERENCES ScreeningRoom(screeningroom_id),
    FOREIGN KEY (showtime_id) REFERENCES Showtimes(showtime_id)
);

CREATE TABLE Invoice (
    invoice_id INT IDENTITY(1,1) PRIMARY KEY,
    cus_id INT,
    screeningroom_id INT,
    film_id INT,
    seat_id INT,
    cinema_id INT,
    showtime_id INT,
    FOREIGN KEY (cus_id) REFERENCES Customer(cus_id),
    FOREIGN KEY (screeningroom_id) REFERENCES ScreeningRoom(screeningroom_id),
    FOREIGN KEY (film_id) REFERENCES Film(film_id),
    FOREIGN KEY (seat_id) REFERENCES Seat(seat_id),
    FOREIGN KEY (cinema_id) REFERENCES Cinema(cinema_id),
    FOREIGN KEY (showtime_id) REFERENCES Showtimes(showtime_id)
);

CREATE TABLE MovieCinema (
    cinema_id INT,
    film_id INT,
    PRIMARY KEY (cinema_id, film_id),
    FOREIGN KEY (cinema_id) REFERENCES Cinema(cinema_id),
    FOREIGN KEY (film_id) REFERENCES Film(film_id)
);






SELECT showtime_id, show_time FROM Showtimes 
                     WHERE film_id = 2 AND cinema_id = 2 AND show_date = '2025-03-22';









-- Chèn dữ liệu vào bảng Cinema
INSERT INTO Cinema (cinema_name, location) VALUES
(N'CGV Sense City', N'Lầu 3, Sense City 1, Đại Lộ Hòa Bình, Q. Ninh Kiều, Tp. Cần Thơ'),
(N'CGV Vincom Hùng Vương', N'Vincom Hùng Vương, 02 Hùng Vương, Q. Ninh Kiều, Tp. Cần Thơ'),
(N'CGV Vincom Xuân Khánh', N'Tầng 5, Tòa nhà 209, Đường 30/04, Phường Xuân Khánh, Quận Ninh Kiều, Tp. Cần Thơ'),
(N'Lotte Cần Thơ', N'Big C, Lô số 1, KDC Hưng Phú 1, P. Hưng Phú, Q. Cái Răng, Tp. Cần Thơ'),
(N'Lotte Ninh Kiều', N'Tầng 3, Lotte Mart Cần Thơ, số 84 đường Mậu Thân, P. An Hòa, Q. Ninh Kiều, Tp. Cần Thơ.');


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


-- Chèn dữ liệu vào bảng Film
INSERT INTO Film (title, rated, price,genre_id, release_date, director, company_production, descriptions, thumbnail, film_status, film_language) VALUES
('The Avengers','13+',159000, 1, '2012-05-04', 'Joss Whedon', 'Marvel Studios', 'Superhero film', 'avenger', 'Showing', 'English - Vietnamese'),
('Inception','13+',139000, 5, '2010-07-16', 'Christopher Nolan', 'Warner Bros.', 'Sci-fi thriller', 'inception', 'Showing', 'English - Vietnamese'),
('Titanic','13+',210000, 6, '1997-12-19', 'James Cameron', '20th Century Fox', 'Romantic drama', 'titanic', 'Showing', 'English - Vietnamese'),
('The Conjuring','R',119000, 4, '2013-07-19', 'James Wan', 'New Line Cinema', 'Horror film', 'conjuring', 'Showing', 'English - Vietnamese'),
('Toy Story', 'G',175000,8, '1995-11-22', 'John Lasseter', 'Pixar', 'Animated film', 'toystory', 'Showing', 'English - Vietnamese'),
('The Dark Knight','PG-13',195000, 1, '2008-07-18', 'Christopher Nolan', 'Warner Bros.', 'Superhero film', 'darkknight', 'Comming', 'English - Vietnamese'),
('Interstellar','PG-13',175000, 5, '2014-11-07', 'Christopher Nolan', 'Paramount', 'Sci-fi adventure', 'interstellar', 'Comming', 'English - Vietnamese'),
('Frozen','PG', 125000, 10,'2013-11-27', 'Chris Buck', 'Disney', 'Fantasy animation', 'frozen', 'Comming', 'English - Vietnamese'),
('Parasite','R',159000,3, '2019-05-30', 'Bong Joon-ho', 'CJ Entertainment', 'Thriller drama', 'parasite', 'Comming', 'English - Vietnamese'),
('The Godfather','R',115000, 3, '1972-03-24', 'Francis Ford Coppola', 'Paramount Pictures', 'Crime drama', 'godfather', 'Comming', 'English - Vietnamese');

delete from Showtimes;
DBCC CHECKIDENT ('Showtimes', RESEED, 0);

-- Chèn dữ liệu vào bảng Showtimes
INSERT INTO Showtimes (film_id, cinema_id, screeningroom_id, show_date, show_time) VALUES
(1, 1, 1, '2025-03-21', '10:00'),
(2, 1, 2, '2025-03-21', '14:00'),
(4, 1, 1, '2025-03-21', '18:30'),
(6, 1, 2, '2025-03-21', '09:00'),
(8, 1, 1, '2025-03-21', '13:30'),
(10, 1, 2, '2025-03-21', '17:45'),


(1, 2, 3, '2025-03-21', '11:15'),
(3, 2, 4, '2025-03-21', '15:45'),
(5, 2, 3, '2025-03-21', '20:00'),
(6, 2, 4, '2025-03-21', '12:00'),
(7, 2, 3, '2025-03-21', '16:15'),
(9, 2, 4, '2025-03-21', '19:45'),
(10, 2, 3, '2025-03-21', '08:30'),


(1, 3, 5, '2025-03-21', '13:00'),
(2, 3, 6, '2025-03-21', '17:30'),
(4, 3, 5, '2025-03-21', '10:00'),
(6, 3, 6, '2025-03-21', '14:00'),
(7, 3, 5, '2025-03-21', '18:30'),
(8, 3, 6, '2025-03-21', '09:00'),
(10, 3, 5, '2025-03-21', '13:30'),


(3, 4, 7, '2025-03-21', '17:45'),
(4, 4, 8, '2025-03-21', '11:15'),
(5, 4, 7, '2025-03-21', '15:45'),
(7, 4, 8, '2025-03-21', '20:00'),
(9, 4, 8, '2025-03-21', '12:00'),


(2, 5, 9, '2025-03-21', '16:15'),
(3, 5, 9, '2025-03-21', '19:45'),
(5, 5, 10, '2025-03-21', '08:30'),
(8, 5, 10, '2025-03-21', '13:00'),
(9, 5, 10, '2025-03-21', '17:30');


-- Chèn dữ liệu vào bảng Seat

delete from Seat;

DECLARE @showtime_id INT = 1;
DECLARE @screeningroom_id INT;
DECLARE @seat_number NVARCHAR(10);
DECLARE @index INT;

WHILE @showtime_id <= 30  
BEGIN
    -- Lấy screeningroom_id từ suất chiếu
    SELECT @screeningroom_id = screeningroom_id FROM Showtimes WHERE showtime_id = @showtime_id;

    -- Tạo 10 ghế từ A1 đến A10
    SET @index = 0;
    WHILE @index <= 9  
    BEGIN
        SET @seat_number = 'A' + CAST(@index AS NVARCHAR);
        
        INSERT INTO Seat (screeningroom_id, showtime_id, seat_number, seat_status)
        VALUES (@screeningroom_id, @showtime_id, @seat_number, 0);

        SET @index = @index + 1;
    END

    SET @showtime_id = @showtime_id + 1;
END

--change pass
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


INSERT INTO MovieCinema (cinema_id, film_id) VALUES
(1, 1), (2, 1), (3, 1),
(1, 2), (3, 2), (5, 2),
(2, 3), (4, 3), (5, 3),
(1, 4), (3, 4), (4, 4),
(2, 5), (4, 5), (5, 5),
(1, 6), (2, 6), (3, 6),
(2, 7), (3, 7), (4, 7),
(1, 8), (3, 8), (5, 8),
(2, 9), (4, 9), (5, 9),
(1, 10), (2, 10), (3, 10);














