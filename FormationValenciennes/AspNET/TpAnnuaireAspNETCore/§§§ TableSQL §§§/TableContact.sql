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


INSERT INTO [dbo].[CONTACT] ( [firstname], [lastname], [email], [phone], [url]) VALUES ( N'ANTHONY', N'Di Persio', N'anthony@utopios.net', N'+33 6 45 12 36 98', N'images/97ca6f4f-d072-4fab-928f-3226ae09b1fd-MyAvatar.png')
INSERT INTO [dbo].[CONTACT] ( [firstname], [lastname], [email], [phone], [url]) VALUES ( N'Noah', N'Di Persio', N'noah@monemail.com', N'+33 6 74 85 32 14', N'images/e55294ef-9849-4e0e-a12f-ed0ad6547130-informatique1.jpg')
INSERT INTO [dbo].[CONTACT] ( [firstname], [lastname], [email], [phone], [url]) VALUES ( N'Eliott', N'Di Persio', N'eliott@monemail.com', N'+33 6 85 74 96 36', N'images/0948e253-a193-43f4-ba05-8fddceef9edb-langfr-1024px-France_départementale.svg.png')

