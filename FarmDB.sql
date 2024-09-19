CREATE TABLE Animals (
    AnimalId INT IDENTITY(1,1) PRIMARY KEY,
    AnimalType VARCHAR(50) NOT NULL,
    BirthDate DATE,
    MilkGiven DECIMAL(5,2)
);