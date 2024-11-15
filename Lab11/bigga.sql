SELECT  ABS(-25) AS Absolute_Value,  
        PI() AS Pi_Value,  
        POW(2, 5) AS Power_Calculation;

-- Create products table
CREATE TABLE products ( 
    product_id INT PRIMARY KEY, 
    product_name VARCHAR(50), 
    price DECIMAL(10, 2) 
);

-- Insert data into products
INSERT INTO products (product_id, product_name, price) VALUES 
(1, 'Laptop', 800.00), 
(2, 'Mouse', 25.00), 
(3, 'Keyboard', 50.00), 
(4, 'Monitor', 200.00), 
(5, 'Printer', 120.00);

-- Query for min, max, and average prices
SELECT  MIN(price) AS Minimum_Price,  
        MAX(price) AS Maximum_Price,  
        AVG(price) AS Average_Price  
FROM products;

SELECT  LENGTH('DatabaseProgramming') AS String_Length,  
        UPPER('DatabaseProgramming') AS Uppercase_String,  
        REVERSE('DatabaseProgramming') AS Reversed_String;

SELECT  NOW() AS Current_DateTime,  
        YEAR('2023-11-14') AS Year_Extracted,  
        DATEDIFF('2024-01-01', '2023-11-14') AS Days_Between;

SELECT  VERSION() AS MySQL_Version,  
        DATABASE() AS Current_Database,  
        USER() AS CurrentUser;

DELIMITER //
CREATE FUNCTION square(num INT)  
RETURNS INT
DETERMINISTIC
BEGIN
    RETURN num * num;
END //
DELIMITER ;

-- Test the function
SELECT square(5) AS Square_of_5, square(10) AS Square_of_10;

DELIMITER //
CREATE FUNCTION calculate_discount(price DECIMAL(10,2), discount DECIMAL(5,2)) 
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    RETURN price - (price * discount / 100);
END //
DELIMITER ;

-- Test the function
SELECT  calculate_discount(250, 10) AS Price_after_10_percent_discount,
        calculate_discount(250, 15) AS Price_after_15_percent_discount;

DELIMITER //
CREATE FUNCTION is_even(num INT) 
RETURNS BOOLEAN
DETERMINISTIC
BEGIN
    RETURN num % 2 = 0;
END //
DELIMITER ;

-- Test the function
SELECT is_even(4) AS Is_4_Even, is_even(7) AS Is_7_Even;

DELIMITER //
CREATE FUNCTION customer_category(purchase_amount DECIMAL(10,2)) 
RETURNS VARCHAR(20)
DETERMINISTIC
BEGIN
    DECLARE category VARCHAR(20);

    IF purchase_amount >= 500 THEN
        SET category = 'Premium';
    ELSEIF purchase_amount BETWEEN 100 AND 499 THEN
        SET category = 'Standard';
    ELSE
        SET category = 'Basic';
    END IF;

    RETURN category;
END //
DELIMITER ;

-- Test the function
SELECT  customer_category(600) AS Category_600,
        customer_category(300) AS Category_300,
        customer_category(50) AS Category_50;

-- Create employees table
CREATE TABLE employees ( 
    id INT PRIMARY KEY AUTO_INCREMENT, 
    name VARCHAR(50), 
    position VARCHAR(50), 
    salary DECIMAL(10, 2) 
);

-- Insert data into employees
INSERT INTO employees (name, position, salary) VALUES  
('Alice', 'Developer', 55000.00), 
('Bob', 'Manager', 75000.00), 
('Charlie', 'Analyst', 60000.00), 
('David', 'Developer', 67000.00), 
('Eve', 'Manager', 80000.00);

-- Create procedure to get all employees
DELIMITER //
CREATE PROCEDURE get_all_employees()
BEGIN
    SELECT * FROM employees;
END //
//
DELIMITER ;

-- Call the procedure
CALL get_all_employees();

DELIMITER //
CREATE PROCEDURE get_employees_by_position(IN emp_position VARCHAR(50)) 
BEGIN
    SELECT * FROM employees WHERE position = emp_position;
END //
//
DELIMITER ;

-- Call the procedure with example
CALL get_employees_by_position('Developer');

DELIMITER //
CREATE PROCEDURE get_total_salary(OUT total_salary DECIMAL(10, 2)) 
BEGIN
    SELECT SUM(salary) INTO total_salary FROM employees;
END //
//
DELIMITER ;

-- Call the procedure and display the result
CALL get_total_salary(@total_salary);
SELECT @total_salary;

DELIMITER //
CREATE PROCEDURE get_highest_paid_employee(
    IN emp_position VARCHAR(50), 
    OUT emp_name VARCHAR(50), 
    OUT emp_salary DECIMAL(10, 2)
)
BEGIN
    SELECT name, salary INTO emp_name, emp_salary
    FROM employees
    WHERE position = emp_position
    ORDER BY salary DESC
    LIMIT 1;
END //
//
DELIMITER ;

-- Call the procedure and display results
CALL get_highest_paid_employee('Manager', @emp_name, @emp_salary);
SELECT @emp_name, @emp_salary;

DELIMITER //
CREATE PROCEDURE check_salary_threshold(IN emp_id INT, IN threshold DECIMAL(10, 2)) 
BEGIN
    DECLARE emp_salary DECIMAL(10, 2);

    SELECT salary INTO emp_salary FROM employees WHERE id = emp_id;

    IF emp_salary > threshold THEN
        SELECT CONCAT('Employee ', emp_id, ' earns above the threshold.');
    ELSE
        SELECT CONCAT('Employee ', emp_id, ' does not earn above the threshold.');
    END IF;
END //
//
DELIMITER ;

-- Call the procedure with example
CALL check_salary_threshold(1, 3000);

CREATE TABLE employees ( 
    id INT PRIMARY KEY AUTO_INCREMENT, 
    name VARCHAR(50), 
    position VARCHAR(50), 
    created_at TIMESTAMP 
);

DELIMITER //
CREATE TRIGGER set_created_at 
BEFORE INSERT ON employees
FOR EACH ROW 
BEGIN
    SET NEW.created_at = CURRENT_TIMESTAMP;
END //
//
DELIMITER ;

-- Test the trigger
INSERT INTO employees (name, position) VALUES ('Alice', 'Developer');
SELECT * FROM employees;

CREATE TABLE orders (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    product_name VARCHAR(50),
    amount DECIMAL(10, 2)
);

CREATE TABLE order_log (
    log_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id INT,
    message VARCHAR(100)
);

DELIMITER //
CREATE TRIGGER log_order 
AFTER INSERT ON orders
FOR EACH ROW 
BEGIN
    INSERT INTO order_log (order_id, message)  
    VALUES (NEW.order_id, CONCAT('Order for ', NEW.product_name, ' was placed.'));
END //
//
DELIMITER ;

-- Test the trigger
INSERT INTO orders (product_name, amount) VALUES ('Laptop', 999.99);
SELECT * FROM order_log;

CREATE TABLE products ( 
    product_id INT PRIMARY KEY AUTO_INCREMENT, 
    product_name VARCHAR(50), 
    price DECIMAL(10, 2), 
    last_modified TIMESTAMP 
);

DELIMITER //
CREATE TRIGGER update_last_modified 
BEFORE UPDATE ON products
FOR EACH ROW 
BEGIN
    IF NEW.price != OLD.price THEN
        SET NEW.last_modified = CURRENT_TIMESTAMP;
    END IF;
END //
//
DELIMITER ;

-- Insert initial data and test trigger
INSERT INTO products (product_name, price) VALUES ('Phone', 299.99);
UPDATE products SET price = 349.99 WHERE product_id = 1;
SELECT * FROM products;

CREATE TABLE customers ( 
    customer_id INT PRIMARY KEY AUTO_INCREMENT, 
    customer_name VARCHAR(50) 
);

CREATE TABLE deletion_log ( 
    log_id INT PRIMARY KEY AUTO_INCREMENT, 
    message VARCHAR(100) 
);

DELIMITER //
CREATE TRIGGER log_deletion 
AFTER DELETE ON customers
FOR EACH ROW 
BEGIN
    INSERT INTO deletion_log (message) 
    VALUES (CONCAT('Customer ', OLD.customer_name, ' was deleted.'));
END //
//
DELIMITER ;

-- Test the trigger
INSERT INTO customers (customer_name) VALUES ('John Doe');
DELETE FROM customers WHERE customer_name = 'John Doe';
SELECT * FROM deletion_log;