/* --------------------------------------------------------------
--   Please fill in your details in this comment block --  
--   Student ID: 6522780088
--   Fullname: Teerachot Khusuwan
--   Section: 3
------------------------------------------------------------- */

DROP DATABASE IF EXISTS tinycompany; 
CREATE DATABASE IF NOT EXISTS tinycompany;
USE tinycompany;

-- Department Table 
CREATE TABLE department(
    dnumber     INT          NOT NULL PRIMARY KEY,  -- dnumber is a primary key
    dname       VARCHAR(20)  NOT NULL,
    location    VARCHAR(100), -- location is nullable 
    CONSTRAINT chk_dnumber CHECK (dnumber >= 1 AND dnumber <= 20) -- dnumber range from 1 to 20
);

-- Project Table 
CREATE TABLE project(
    pnumber     INT          NOT NULL PRIMARY KEY,  -- pnumber is a primary key
    pname       VARCHAR(50)  NOT NULL,
    dept_no     INT          NOT NULL,
    CONSTRAINT FK_DeptProj FOREIGN KEY (dept_no) REFERENCES department(dnumber)
);

-- Employee Table 
CREATE TABLE employee(
    fname       VARCHAR(20)  NOT NULL,
    lname       VARCHAR(20)  NOT NULL,
    ssn         VARCHAR(9)   NOT NULL PRIMARY KEY,
    bdate       DATE         NOT NULL,
    sex         VARCHAR(1)      NOT NULL,
    salary      DECIMAL(12, 2),
    dept_no     INT,
    CONSTRAINT chk_sex CHECK (sex IN ('M', 'F')),
    CONSTRAINT fk_dept_no FOREIGN KEY (dept_no) REFERENCES department(dnumber)
);

-- Assignment Table 
CREATE TABLE assignment(
    essn        VARCHAR(9)   NOT NULL,
    proj_no     INT          NOT NULL,
    hours       DECIMAL(9, 2),
    hourly_rate DECIMAL(9, 2),
    CONSTRAINT fk_essn FOREIGN KEY (essn) REFERENCES employee(ssn),
    CONSTRAINT fk_proj_no FOREIGN KEY (proj_no) REFERENCES project(pnumber),
    CONSTRAINT pk_assignment PRIMARY KEY (essn, proj_no)
);