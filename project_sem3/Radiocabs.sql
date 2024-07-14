CREATE DATABASE RADIOCABS
GO
-- Table for Companies
CREATE TABLE Companies (
    CompanyID INT PRIMARY KEY,
    CompanyName VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    ContactPerson VARCHAR(255),
    Designation VARCHAR(255),
    Address VARCHAR(255),
    Mobile VARCHAR(15),
    Telephone VARCHAR(15),
    FaxNumber VARCHAR(15),
    Email VARCHAR(255),
    MembershipType VARCHAR(50),
    PaymentType VARCHAR(50)
);

-- Table for Drivers
CREATE TABLE Drivers (
    DriverID INT PRIMARY KEY,
    DriverName VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    ContactPerson VARCHAR(255),
    Address VARCHAR(255),
    City VARCHAR(100),
    Mobile VARCHAR(15),
    Telephone VARCHAR(15),
    Email VARCHAR(255),
    Experience VARCHAR(255),
    Description TEXT,
    PaymentType VARCHAR(50)
);

-- Table for Advertisements
CREATE TABLE Advertisements (
    AdvertisementID INT PRIMARY KEY,
    CompanyName VARCHAR(255) NOT NULL,
    Designation VARCHAR(255),
    Address VARCHAR(255),
    Mobile VARCHAR(15),
    Telephone VARCHAR(15),
    FaxNumber VARCHAR(15),
    Email VARCHAR(255),
    Description TEXT,
    PaymentType VARCHAR(50)
);

-- Table for Feedbacks
CREATE TABLE Feedbacks (
    FeedbackID INT PRIMARY KEY,
    Name VARCHAR(255),
    MobileNo VARCHAR(15),
    Email VARCHAR(255),
    City VARCHAR(100),
    Type VARCHAR(50),
    Description TEXT
);
