DROP TABLE [dbo].[CONTACT]

CREATE TABLE [dbo].[CONTACT] (
    [Id]    INT  IDENTITY (1, 1) NOT NULL,
    [firstname]   VARCHAR (50) NOT NULL,
    [lastname] VARCHAR (50) NOT NULL,
    [email] VARCHAR (60) NOT NULL,
    [phone] VARCHAR(17) NOT NULL,   
    [url] VARCHAR(500) NOT NULL,   
    PRIMARY KEY CLUSTERED ([Id] ASC)
);