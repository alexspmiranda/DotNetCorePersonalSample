# DotNetCorePersonalSample
DotNet Core with DDD (Domain-Driven Design) Sample, 
using EntityFramework and Dependency Injection.

To Start project correctly is necessary download DotNet Core SDK:
https://www.microsoft.com/net/download

----------------------------------------------------
----------------------------------------------------
---------------- DATABASE MYSQL --------------------
----------------------------------------------------
----------------------------------------------------


CREATE DATABASE ECOMMERCER;

USE ECOMMERCER;

CREATE TABLE PRODUCT_CLASS(
	ID_PRODUCT_CLASS INT PRIMARY KEY AUTO_INCREMENT,
	PRODUCT_CLASS VARCHAR(50)
);


CREATE TABLE PRODUCT(
	ID_PRODUCT_ VARCHAR(50),
	PRODUCT_NAME VARCHAR(255),
    ID_PRODUCT_CLASS INT,
    FOREIGN KEY (ID_PRODUCT_CLASS) REFERENCES PRODUCT_CLASS(ID_PRODUCT_CLASS)  
);

INSERT INTO PRODUCT_CLASS(PRODUCT_CLASS) VALUES("Smartphones");
INSERT INTO PRODUCT_CLASS(PRODUCT_CLASS) VALUES("Furnishing");

INSERT INTO PRODUCT(PRODUCT_NAME, ID_PRODUCT_CLASS) VALUES("Samsung Galaxy S8", 1);
INSERT INTO PRODUCT(PRODUCT_NAME, ID_PRODUCT_CLASS) VALUES("Moto Z2 Play", 1);

INSERT INTO PRODUCT(PRODUCT_NAME, ID_PRODUCT_CLASS) VALUES("Couch", 2);
