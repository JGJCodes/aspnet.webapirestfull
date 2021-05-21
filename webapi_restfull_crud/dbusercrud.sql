

CREATE TABLE User(
	id int primary key NOT NULL,
	name varchar(50) NULL,
	email varchar(50) NULL,
	phone varchar(50),
	date_register date
)

INSERT INTO user values(1,'jorge','jorge@email.com','8211321423','2021-05-20')
