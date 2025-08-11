USE StorageDB
GO

CREATE TABLE Admins
(
Email_Admin VARCHAR(50),
Senha VARCHAR(20)
);

SELECT * FROM Admins

ALTER TABLE Admins
ALTER COLUMN Email_Admin VARCHAR(50);

INSERT INTO Admins
(Email_Admin, Senha, RE_Colaborador)
VALUES
('StorageAdmin@gmail.com','140872','334627')