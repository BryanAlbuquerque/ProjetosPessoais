CREATE DATABASE Storage

USE Storage
GO

CREATE TABLE Admins
(
Email_Admin VARCHAR(50),
Senha VARCHAR(20),
RE_Colaborador INT
);

SELECT * FROM Admins

INSERT INTO Admins
(Email_Admin, Senha, RE_Colaborador)
VALUES
('StorageAdmin@gmail.com','140872','334627')

drop table Admins