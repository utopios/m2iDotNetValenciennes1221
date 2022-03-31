
/*
 * Création table [Student]
 */
CREATE TABLE [dbo].[Student]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Lastname] VARCHAR(50) NOT NULL, 
    [Firstname] VARCHAR(50) NOT NULL,     
    [StudentCardId] VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)

/*
 * Création table [Email]
 */
CREATE TABLE [dbo].[Email]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL,    
    PRIMARY KEY CLUSTERED ([id] ASC)
)

/*
 * Création table [Course]
 */
CREATE TABLE [dbo].[Course]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,       
    [Name] VARCHAR(50) NOT NULL,
    [Professor] VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)

/*
 * Création table [StudentsEmail]
 */
CREATE TABLE [dbo].[StudentsEmails]
(
    [StudentId] INT NOT NULL,    
    [EmailId]   INT NOT NULL,
    CONSTRAINT [PK_StudentsEmails] PRIMARY KEY CLUSTERED ([StudentId] ASC, [EmailId] ASC),
    CONSTRAINT [FK_StudentsEmails_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_StudentsEmails_Email_EmailId] FOREIGN KEY ([EmailId]) REFERENCES [dbo].[Email] ([Id]) ON DELETE CASCADE
)
GO
CREATE NONCLUSTERED INDEX [IX_StudentsEmails_EmailId]
    ON [dbo].[StudentsEmails]([EmailId] ASC);

/*
 * Création table [StudentsCourses]
 */
CREATE TABLE [dbo].[StudentsCourses]
(
    [StudentId]       INT    NOT NULL,    
    [CourseId]       INT    NOT NULL,
    CONSTRAINT [PK_StudentsCourses] PRIMARY KEY CLUSTERED ([StudentId] ASC, [CourseId] ASC),
    CONSTRAINT [FK_StudentsCourses_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_StudentsCourses_Email_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]) ON DELETE CASCADE
)
GO
CREATE NONCLUSTERED INDEX [IX_StudentsCourses_EmailId]
    ON [dbo].[StudentsCourses]([CourseId] ASC);

/*
 * Insertion des étudiants [Student]
 */
 INSERT INTO [Student] ([Lastname], [Firstname], [StudentCardId])
 VALUES ('Legrand','Zorro','17023N'),
        ('Doe','Janes','16823C'),
        ('Apeupré','Jean-michel','16587R'),
        ('Darc','Jeannes','17023N'),
        ('Onette','Camille','15268Z'),
        ('Auboisdormant','Abel','17023N'),
        ('Henette','Claire','14965J'),
        ('Garcin ','Lazarre','17865U'),
        ('Afritt','Barack','17854P'),
        ('Tomie','Anna','14125D'),
        ('Voyance','Claire','14073W')

/*
 * Insertion des emails [Student]
 */
 INSERT INTO [Email] ([Email])
 VALUES ('zorro@estarrive.fr'),
        ('zorro@estreparti.fr'),
        ('janes.doe@whoami.com'),
        ('janes.doe@perdu.com'),
        ('j.michel@apeupre.fr'),
        ('jeanne.darc@audika.fr'),
        ('jeanne.darc@doremi.fr'),
        ('camilleonette@caroule.fr'),
        ('abel.auboisdormant@apple.com'),
        ('claire.henette@tavu.com'),
        ('garcin.lazarre@voyage-sncf.fr'),
        ('garcin.lazarre@tchoutchou.pfff'),
        ('barack.afritt@chti.fr'),
        ('anna.tomie@moncorps.fr'),
        ('claire.voyance@chienguide.fr')

/*
 * Ralation [Student] / [Emails] 
 */
 INSERT INTO [StudentsEmails] ([StudentId],[EmailId])
 VALUES (1,1),
        (1,2),
        (2,3),
        (2,4),
        (3,5),
        (4,6),
        (4,7),
        (5,8),
        (6,9),
        (7,10),
        (8,11),
        (8,12),
        (9,13),
        (10,14),
        (11,15)
        

/*
 * Insertion des Cours [Course]
 */
 INSERT INTO [Course] ([Name], [Professor])
 VALUES ('Mathématiques','Mr Bogdanov Igor'),
        ('Physique','Mr Bogdanov Grichka'),
        ('Franglais','Mr Di Persio Anthony'),
        ('Sport','Mme Matty Mimie'),
        ('Economie','Mlle Nabilla'),
        ('Géopolitique','Mr Poutine Vladimir')
        
/*
 * Ralation [Student] / [Course] 
 */
 INSERT INTO [StudentsCourses] ([StudentId],[CourseId])
 VALUES (1,1),
        (1,2),
        (1,6),
        (2,3),
        (2,4),
        (2,6),
        (3,1),
        (3,2),
        (3,3),
        (3,5),
        (3,6),
        (4,1),
        (4,3),
        (4,5),
        (4,6),
        (5,1),
        (5,2),
        (5,5),
        (6,1),
        (6,3),
        (6,4),
        (6,5),
        (7,2),
        (7,3),
        (7,5),
        (7,6),
        (8,1),
        (8,2),
        (8,6),
        (9,1),
        (9,3),
        (9,4),
        (9,5),
        (9,6),
        (10,2),
        (10,3),
        (10,4),
        (10,5),
        (10,6),
        (11,3),
        (11,4),
        (11,5),
        (11,6)
        