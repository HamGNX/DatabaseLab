--Exercise 1
CREATE DATABASE lab12;
USE lab12;
CREATE TABLE Users (UserId INT, UserName VARCHAR(50), Password VARCHAR(50));
INSERT INTO Users VALUES (1, 'John', 'password123'), (2, 'Jane', 'secure456');

SELECT * FROM Users WHERE UserId = 105 OR 1=1;

--Exercise 2
CREATE TABLE Products (ProductID INT, ProductName VARCHAR(100));
INSERT INTO Products VALUES (1, 'Laptop'), (2, 'Smartphone');

CREATE USER 'readonly_user'@'localhost' IDENTIFIED BY 'password123';
GRANT SELECT ON lab12.* TO 'readonly_user'@'localhost';

SELECT user FROM mysql.user;

SHOW GRANTS FOR 'readonly_user'@'localhost';

mysql -u readonly_user -p

SELECT * FROM Products;

INSERT INTO Products VALUES (3, 'Tablet');

GRANT SELECT, INSERT ON lab12.* TO 'readonly_user'@'localhost';
SHOW GRANTS FOR 'readonly_user'@'localhost';

--Exercise 3
SELECT MD5('password123');
SELECT SHA1('password123');

SELECT AES_ENCRYPT('SensitiveData', 'SecretKey');
SELECT AES_DECRYPT(AES_ENCRYPT('SensitiveData', 'SecretKey'), 'SecretKey');

--Exercise 4
CREATE TABLE Employees (EmployeeID INT, Name VARCHAR(50), Salary DECIMAL(10, 2));
INSERT INTO Employees VALUES (1, 'Alice', 5000), (2, 'Bob', 4000);

CREATE VIEW SecureView AS
SELECT EmployeeID, Name FROM Employees
WHERE Salary > 4500;

SELECT * FROM SecureView;

--Exercise 5
CREATE TABLE customers (ID INT, Name VARCHAR(50), Age INT, Address VARCHAR(50), Salary VARBINARY(255));

INSERT INTO customers VALUES (1, 'John', 36, 'Australia', AES_ENCRYPT('3000', 'SecretKey'));
INSERT INTO customers VALUES (2, 'Kane', 25, 'Africa', AES_ENCRYPT('1500', 'SecretKey'));
INSERT INTO customers VALUES (3, 'Neil', 23, 'Korea', AES_ENCRYPT('2000', 'SecretKey'));
INSERT INTO customers VALUES (4, 'Chan', 25, 'China', AES_ENCRYPT('6500', 'SecretKey'));
INSERT INTO customers VALUES (5, 'Haddin', 27, 'USA', AES_ENCRYPT('8500', 'SecretKey'));
INSERT INTO customers VALUES (6, 'Kusal', 22, 'Sri Lanka', AES_ENCRYPT('4500', 'SecretKey'));
INSERT INTO customers VALUES (7, 'Maui', 24, 'Thailand', AES_ENCRYPT('10000', 'SecretKey'));

CREATE VIEW customer_salary AS
SELECT ID, Name, AES_DECRYPT(Salary, 'SecretKey') AS Salary FROM customers;

SELECT * FROM customers;

SELECT * FROM customer_salary;