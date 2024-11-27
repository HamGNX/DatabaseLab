USE Clinic;
-- Drop foreign key constraints
ALTER TABLE Payment DROP FOREIGN KEY fk_AppointmentPay;
ALTER TABLE Medical_Record DROP FOREIGN KEY medical_record_ibfk_1;

-- Modify Appointment_ID column
ALTER TABLE Appointment MODIFY Appointment_ID INT NOT NULL AUTO_INCREMENT;

-- Recreate foreign key constraints
ALTER TABLE Payment
ADD CONSTRAINT fk_AppointmentPay FOREIGN KEY (Appointment_ID) REFERENCES Appointment(Appointment_ID);

ALTER TABLE Medical_Record
ADD CONSTRAINT medical_record_ibfk_1 FOREIGN KEY (Appointment_ID) REFERENCES Appointment(Appointment_ID);