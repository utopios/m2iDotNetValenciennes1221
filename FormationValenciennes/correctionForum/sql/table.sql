CREATE TABLE abonne(
                       id int primary key identity(1,1),
                       first_name varchar not null,
                       last_name varchar not null,
                       email varchar not null,
                       phone varchar not null,
                       password varchar not null
);

CREATE TABLE moderateur(
                           id int primary key identity(1,1),
                           abonne_id int not null,
);

CREATE TABLE nouvelle(
                         id int primary key identity(1,1),
                         subject varchar not null,
                         content text,
                         abonne_id int not null,
                         forum_id int not null
);

CREATE TABLE forum (
                       id int primary key identity(1,1),
                       name varchar not null
);

CREATE table abonnes_forum(
                              id int primary key identity(1,1),
                              abonne_id int not null,
                              forum_id int not null,
);

CREATE table moderateurs_forum(
                                  id int primary key identity(1,1),
                                  moderateur_id int not null,
                                  forum_id int not null
);