--Suppression de la tables éxistantes
DROP TABLE CONTACT


--Création de la table
CREATE TABLE CONTACT
(
id INT PRIMARY KEY IDENTITY(1,1),
lastname VARCHAR(50) NOT NULL,
firstname VARCHAR(50) NOT NULL,
email VARCHAR(50) NOT NULL,
phone VARCHAR(17) NOT NULL,
age INT NOT NULL
);



-- Insertion de Contact
INSERT INTO [dbo].[CONTACT] ( [lastname], [firstname], [email], [phone], [age])
VALUES ( N'DI PERSIO', N'Anthony', N'anthony@utopios.net', N'+33 6 41 52 63 87', 26),
( N'ABADI', N'Ihab', N'ihab@utopios.net', N'+33 6 14 25 36 78', 34),
( N'DARK', N'Jeanne', N'jeanne@dark.com', N'+33 6 66 08 49 92', 18),
( N'LEGRAND', N'Zorro', N'zorro@estarrive.fr', N'+33 3 20 45 63 21', 95)