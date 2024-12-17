USE CUST;

-- Create user accounts with different roles
CREATE USER 'admin_user'@'localhost' IDENTIFIED BY 'admin_password';
CREATE USER 'staff_user'@'localhost' IDENTIFIED BY 'staff_password';
CREATE USER 'customer_user'@'localhost' IDENTIFIED BY 'customer_password';

-- Grant privileges for each user
GRANT ALL PRIVILEGES ON cust.* TO 'admin_user'@'localhost';
GRANT SELECT, INSERT, UPDATE ON cust.* TO 'staff_user'@'localhost';
GRANT SELECT ON cust.account TO 'customer_user'@'localhost';

-- Protect sensitive data by hashing the `No.` field (example sensitive data)
ALTER TABLE account ADD COLUMN hashed_no VARCHAR(255);
UPDATE account SET hashed_no = SHA2(`No.`, 256);

-- Create a view for `No.`, `Name`, and `bal`
CREATE VIEW account_summary AS
SELECT `No.`, `Name`, `bal`
FROM account;