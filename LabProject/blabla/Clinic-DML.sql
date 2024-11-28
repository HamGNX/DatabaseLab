USE Clinic;

INSERT INTO `Specialty` (`Specialty_ID`, `Specialty_Name`) VALUES ('0', 'Not Sure'), ('2', 'Dentistry'), ('3', 'Cardiology'), ('4', 'Neurology'), ('5', 'Orthopedics'), ('6', 'Pediatrics'), ('7', 'Psychiatry'), ('8', 'Radiology'), ('9', 'Surgery'), ('10', 'Urology');

INSERT INTO `Doctor` (`Doctor_ID`, `FName`, `LName`, `Specialty_ID`, `Password`) VALUES ('2', 'JJ', 'JJ', '2', NULL),
('3', 'John', 'Oldman', '3', NULL),
('4', 'Noel', 'Nemesis', '4', NULL),
('5', 'Jack', 'and Jill', '5', NULL),
('6', 'Ham', 'za', '6', NULL),
('7', 'First', 'min', '7', NULL),
('8', 'Jared', 'Leto', '8', NULL),
('9', 'Chill', 'Guy', '9', NULL),
('10', 'Bhoon', 'God', '10', NULL);