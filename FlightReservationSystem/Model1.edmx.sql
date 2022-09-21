
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/06/2022 14:23:13
-- Generated from EDMX file: C:\Users\25192\source\repos\FlightReservationSystem\FlightReservationSystem\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Frs];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Flight_Plane]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Flight] DROP CONSTRAINT [FK_Flight_Plane];
GO
IF OBJECT_ID(N'[dbo].[FK_Reservation_Flight]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservation] DROP CONSTRAINT [FK_Reservation_Flight];
GO
IF OBJECT_ID(N'[dbo].[FK_Reservation_Seat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservation] DROP CONSTRAINT [FK_Reservation_Seat];
GO
IF OBJECT_ID(N'[dbo].[FK_Reservation_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservation] DROP CONSTRAINT [FK_Reservation_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Flight]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Flight];
GO
IF OBJECT_ID(N'[dbo].[Plane]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Plane];
GO
IF OBJECT_ID(N'[dbo].[Reservation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservation];
GO
IF OBJECT_ID(N'[dbo].[Seat]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Seat];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Flights'
CREATE TABLE [dbo].[Flights] (
    [f_id] int IDENTITY(1,1) NOT NULL,
    [flightTime] datetime  NOT NULL,
    [flightStatus] nvarchar(50)  NOT NULL,
    [flightPilot] nvarchar(50)  NOT NULL,
    [flightType] nvarchar(50)  NOT NULL,
    [plane_id] int  NOT NULL,
    [departure] nvarchar(50)  NOT NULL,
    [destination] nvarchar(50)  NOT NULL,
    [flightPrice] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Planes'
CREATE TABLE [dbo].[Planes] (
    [p_id] int IDENTITY(1,1) NOT NULL,
    [p_name] nvarchar(50)  NULL,
    [numOfBusSeats] int  NULL,
    [numOfEcoSeats] int  NULL,
    [numOfFirstClassSeats] int  NULL,
    [numOfPremiumSeats] int  NULL
);
GO

-- Creating table 'Reservations'
CREATE TABLE [dbo].[Reservations] (
    [rStatus] nvarchar(50)  NOT NULL,
    [flight_id] int  NULL,
    [seat_id] int  NULL,
    [user_id] int  NULL,
    [seatNo] int  NULL,
    [r_id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Seats'
CREATE TABLE [dbo].[Seats] (
    [s_id] int IDENTITY(1,1) NOT NULL,
    [seatPrice] decimal(18,0)  NULL,
    [seatType] nvarchar(50)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [u_id] int IDENTITY(1,1) NOT NULL,
    [u_name] nvarchar(50)  NULL,
    [pwd] nvarchar(50)  NULL,
    [email] nvarchar(50)  NULL,
    [tel] nvarchar(50)  NULL,
    [role] nvarchar(50)  NULL,
    [pass_id] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [f_id] in table 'Flights'
ALTER TABLE [dbo].[Flights]
ADD CONSTRAINT [PK_Flights]
    PRIMARY KEY CLUSTERED ([f_id] ASC);
GO

-- Creating primary key on [p_id] in table 'Planes'
ALTER TABLE [dbo].[Planes]
ADD CONSTRAINT [PK_Planes]
    PRIMARY KEY CLUSTERED ([p_id] ASC);
GO

-- Creating primary key on [r_id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [PK_Reservations]
    PRIMARY KEY CLUSTERED ([r_id] ASC);
GO

-- Creating primary key on [s_id] in table 'Seats'
ALTER TABLE [dbo].[Seats]
ADD CONSTRAINT [PK_Seats]
    PRIMARY KEY CLUSTERED ([s_id] ASC);
GO

-- Creating primary key on [u_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([u_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [plane_id] in table 'Flights'
ALTER TABLE [dbo].[Flights]
ADD CONSTRAINT [FK_Flight_Plane]
    FOREIGN KEY ([plane_id])
    REFERENCES [dbo].[Planes]
        ([p_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Flight_Plane'
CREATE INDEX [IX_FK_Flight_Plane]
ON [dbo].[Flights]
    ([plane_id]);
GO

-- Creating foreign key on [flight_id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_Reservation_Flight]
    FOREIGN KEY ([flight_id])
    REFERENCES [dbo].[Flights]
        ([f_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservation_Flight'
CREATE INDEX [IX_FK_Reservation_Flight]
ON [dbo].[Reservations]
    ([flight_id]);
GO

-- Creating foreign key on [seat_id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_Reservation_Seat]
    FOREIGN KEY ([seat_id])
    REFERENCES [dbo].[Seats]
        ([s_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservation_Seat'
CREATE INDEX [IX_FK_Reservation_Seat]
ON [dbo].[Reservations]
    ([seat_id]);
GO

-- Creating foreign key on [user_id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_Reservation_User]
    FOREIGN KEY ([user_id])
    REFERENCES [dbo].[Users]
        ([u_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservation_User'
CREATE INDEX [IX_FK_Reservation_User]
ON [dbo].[Reservations]
    ([user_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------