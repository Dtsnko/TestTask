CREATE TABLE [Order] (
Id INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
Number VARCHAR(50) NOT NULL,
Amount DECIMAL(18, 0) NOT NULL
);