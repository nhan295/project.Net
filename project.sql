use [Project.Net];

create table Cinema (
	cinema_id int primary key,
	cinema_room nvarchar(45),
	cinema_address nvarchar(45),
	total_rooms nvarchar(45)
);

select* from cinema;

create table Customer (
	cus_id int primary key,
	cus_name nvarchar(45),
	cus_password nvarchar(45),
	cus_phone nvarchar(45),
	cus_email nvarchar(45),
	cus_address nvarchar(125)
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
	seat_number nvarchar(45),
	movie_title nvarchar(45),
	cinema_name nvarchar(45),
	cinema_address nvarchar(45),
	ticket_price nvarchar(45),
	show_time nvarchar(45),
	ticket_type nvarchar(45),

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
