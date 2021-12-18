--author table
CREATE TABLE Author(name varchar(50) NOT NULL,
	address varchar(200) NOT NULL,
 CONSTRAINT PK_Author PRIMARY KEY(name,address));

--user table
CREATE TABLE Users(
	username varchar(50) NOT NULL,
	password varchar(50) NOT NULL,
	address varchar(200) NOT NULL,
	gender char(1) NOT NULL,
 CONSTRAINT PK_User PRIMARY KEY(username));

--publisher table
CREATE TABLE Publisher(
	name varchar(50) NOT NULL,
	address varchar(200) NULL,
	phone varchar(15) NOT NULL,
 CONSTRAINT PK_Publisher PRIMARY KEY 
(
	name
));

--book table
CREATE TABLE Book(
	isbn varchar(20) NOT NULL,
	title varchar(50),
	price numeric(6, 2),
	year int,
	pages int,
	genre varchar(15),
	pub_name varchar(50),
	auth_name varchar(50),
	auth_address varchar(200),
	count int NULL,
CONSTRAINT PK_Book PRIMARY KEY(isbn));

--add foreign key constraint to book table
ALTER TABLE Book ADD CONSTRAINT FK_Book_Auth FOREIGN KEY(auth_name, auth_address)
REFERENCES Author(name,address);

--add foreign key constraint to book table
ALTER TABLE Book ADD CONSTRAINT FK_Book_Pub FOREIGN KEY(pub_name)
REFERENCES Publisher (name);

--basket table
CREATE TABLE Basket(
	id bigint NOT NULL,
	username varchar(50),
	ship_address varchar(100) NULL,
	status varchar(20) NULL,
	CONSTRAINT PK_Basket_1 PRIMARY KEY(id)
);

--add foreign key constraint to basket table
ALTER TABLE Basket ADD CONSTRAINT FK_Basket_User FOREIGN KEY(username)
REFERENCES Users (username);

--basketbook table
CREATE TABLE BasketBook(
	basket_id bigint NOT NULL,
	book_isbn varchar(20) NOT NULL,
	count int NULL,
	CONSTRAINT PK_Basket PRIMARY KEY(basket_id,book_isbn)
);

--add foreign key constraint to basketbook table
ALTER TABLE BasketBook ADD CONSTRAINT FK_BasketBook_Basket FOREIGN KEY(basket_id)
REFERENCES Basket(id);

--add foreign key constraint to basketbook table
ALTER TABLE BasketBook ADD CONSTRAINT FK_BasketBook_Book FOREIGN KEY(book_isbn)
REFERENCES Book (isbn);
