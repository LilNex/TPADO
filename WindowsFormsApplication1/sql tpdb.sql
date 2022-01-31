create database tpdb
go 
use tpdb 

create table theme (codeTh int primary key identity,
intitule varchar(20))

create table livre (codel int primary key identity,
					titre varchar(20), auteur varchar(20),nbEx int, codeTh int foreign key references theme(codeTh))

create table adherent (codeA int primary key identity,
						nomA varchar(20),
						adresse varchar(500),
						dateInscription datetime)

create table emprunt (codeA int foreign key references adherent(codeA),
						codel int foreign key references livre(codel),
						dateEmprunt datetime,
						dateRetour datetime)


