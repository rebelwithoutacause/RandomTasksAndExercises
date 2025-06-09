-- 1. Create the database and use it
CREATE DATABASE IF NOT EXISTS address_database;
USE address_database;

-- 2. Create the addresses table
CREATE TABLE addresses (
    street_number INT,
    street_name VARCHAR(100),
    area VARCHAR(100),
    town VARCHAR(100),
    district VARCHAR(100),
    country VARCHAR(100),
    continent VARCHAR(100),
    isCapital BOOLEAN
);

-- 4. Insert sample data
INSERT INTO addresses (street_number, street_name, area, town, district, country, continent, isCapital) VALUES
(10, 'Main St', 'Downtown', 'Buenos Aires', 'Capital District', 'Argentina', 'South America', TRUE),
(20, 'Second St', 'Old Town', 'São Paulo', 'São Paulo District', 'Brazil', 'South America', FALSE),
(15, 'High St', 'Central', 'London', 'Greater London', 'United Kingdom', 'Europe', TRUE),
(7, 'Maple Ave', 'Suburbs', 'Manchester', 'Greater Manchester', 'United Kingdom', 'Europe', FALSE),
(5, 'Elm St', 'North End', 'Berlin', 'Berlin District', 'Germany', 'Europe', TRUE);

-- 5a. Select all addresses located in a capital city
SELECT * FROM addresses WHERE isCapital = TRUE;

-- 5b. Select all addresses located in South America
SELECT * FROM addresses WHERE continent = 'South America';

-- 5c. Select all addresses located in Europe but only in NON-capital cities
SELECT * FROM addresses WHERE continent = 'Europe' AND isCapital = FALSE;
