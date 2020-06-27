create table [Gym].[dbo].[statistika]
(
IDstatistika int primary key,
mesec date,
godina date,
prihod float,
IDrezultat int not null,
foreign key (IDrezultat) references rezultati(IDrezultati)
);