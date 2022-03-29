--Drop TABLE MOTS;

/*
 * Création table Mots
 */
CREATE TABLE [dbo].[MOTS]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [mot] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
)
