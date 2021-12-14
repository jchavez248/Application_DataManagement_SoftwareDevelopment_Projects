-- -------- --CREATING TABLES ----------
 create table if not exists Producers (
     prod_id int primary key,
     mov_id int,
     finance_company text,
     prod_amount int,
     money_spent_on_film int
 );

 create table if not exists Actors (
   act_id int primary key,
   mov_id int,
   act_first_name text,
   act_last_name text,
   act_gender text,
   role text
 );

 create table if not exists Directors (
   dr_id int primary key,
   mov_id int,
   dir_first_name text,
   dir_last_name text
 );

 create table if not exists Editors (
   edit_id int primary key,
   mov_id int,
   edit_first_name text,
   edit_last_name text
 );

 create table if not exists Movie (
   mov_id int primary key,
   mov_title text,
   mov_year int,
   mov_lang text,
   mov_runtime varchar(255),
   mov_region text
 );

-- -------- -- POPULATING TABLES ----------
-- Producers (prod_id, mov_id, finance_company, prod_amount, money_spent_on_film)
 INSERT INTO Producers VALUES(12324, 34543, 'JPMorgan-Chase', 2668829, 1058629);
 INSERT INTO Producers VALUES(12325, 34544, 'Bank of America', 304559, 304000);
 INSERT INTO Producers VALUES(12326, 34545, 'Wells Fargo', 3057430, 1506742);
 INSERT INTO Producers VALUES(12327, 34546, 'Citibank/Citigroup', 2661920, 2661920);
 INSERT INTO Producers VALUES(12328, 34547, 'U.S. Bank/U.S. Bancorp', 7216091, 7146733);
 INSERT INTO Producers VALUES(12329, 34548, 'PNC', 1541777, 1500000);
 INSERT INTO Producers VALUES(12330, 34549, 'Capital One', 7954834, 6470983);
 INSERT INTO Producers VALUES(12331, 34550, 'TD Bank', 4335714, 4500000);
 INSERT INTO Producers VALUES(12332, 34551, 'Bank of New York Mellon', 838614, 850867);
 INSERT INTO Producers VALUES(12333, 34552, 'State Street', 9854610, 9500843);

-- Actors (act_id, mov_id, act_first_name, act_last_name, act_gender, role)
 INSERT INTO Actors VALUES(334, 34552, 'Jack', 'Nicholson', 'Male', 'Leading Male');
 INSERT INTO Actors VALUES(335, 34544, 'Marlon', 'Brando', 'Male', 'Leading Male');
 INSERT INTO Actors VALUES(336, 34545, 'Robert', 'De Niro', 'Male', 'Supporting Actor');
 INSERT INTO Actors VALUES(337, 34546, 'Al', 'Pacino', 'Male', 'Supporting Actor');
 INSERT INTO Actors VALUES(338, 34547, 'Dustin', 'Hoffman', 'Male', 'Supporting Actor');
 INSERT INTO Actors VALUES(339, 34548, 'Meryl', 'Streep', 'Female', 'Leading Female');
 INSERT INTO Actors VALUES(340, 34549, 'Audrey', 'Hepburn', 'Female', 'Leading Female');
 INSERT INTO Actors VALUES(341, 34550, 'Judy', 'Garland', 'Female', 'Supporting Actress');
 INSERT INTO Actors VALUES(342, 34551, 'Julie', 'Andrews', 'Female', 'Supporting Actress');
 INSERT INTO Actors VALUES(343, 34552, 'Barbra', 'Streisand', 'Female', 'Extra');

-- Directors (dir_id, mov_id, dir_first_name, dir_last_name)
 INSERT INTO Directors VALUES(1565, 34552, 'Steven', 'Spielberg');
 INSERT INTO Directors VALUES(1566, 34544, 'Martin', 'Scorsese');
 INSERT INTO Directors VALUES(1567, 34545, 'Alfred', 'Hitchcock');
 INSERT INTO Directors VALUES(1568, 34546, 'Stanley', 'Kubrick');
 INSERT INTO Directors VALUES(1569, 34547, 'Francis', 'Ford Coppola');
 INSERT INTO Directors VALUES(1570, 34548, 'Woody', 'Allen');
 INSERT INTO Directors VALUES(1571, 34549, 'Billy', 'Wilder');
 INSERT INTO Directors VALUES(1572, 34550, 'John', 'Huston');
 INSERT INTO Directors VALUES(1573, 34551, 'Peter', 'Jackson');
 INSERT INTO Directors VALUES(1574, 34552, 'James', 'Cameron');

-- Editors (edit_id, mov_id, edit_first_name, edit_last_name)
 INSERT INTO Editors VALUES(98, 34552, 'Kevin', 'Basta');
 INSERT INTO Editors VALUES(99, 34544, 'Jesus', 'Chavez');
 INSERT INTO Editors VALUES(100, 34545, 'Eduardo', 'Benitez');
 INSERT INTO Editors VALUES(101, 34546, 'Tom', 'Green');
 INSERT INTO Editors VALUES(102, 34547, 'Clayton', 'Kershaw');
 INSERT INTO Editors VALUES(103, 34548, 'Bobby', 'Lee');
 INSERT INTO Editors VALUES(104, 34549, 'Joey', 'Baker');
 INSERT INTO Editors VALUES(105, 34550, 'Mike', 'Judge');
 INSERT INTO Editors VALUES(106, 34551, 'Dwight', 'Howard');
 INSERT INTO Editors VALUES(107, 34552, 'Jesse', 'Kerplotnik');

-- Movie (mov_id, mov_title, mov_year, mov_lang, mov_runtime, mov_region)
 INSERT INTO Movie VALUES(34552, 'The Godfather', 1972, 'English', '175', 'Italy');
 INSERT INTO Movie VALUES(34544, 'The Shawshank Redemption', 1994, 'English', '142', 'America');
 INSERT INTO Movie VALUES(34545, 'Schindlers List', 1993, 'German', '193', 'Germany');
 INSERT INTO Movie VALUES(34546, 'Raging Bull', 1980, 'English', '129', 'New York');
 INSERT INTO Movie VALUES(34547, 'Casablanca', 1941, 'English', '102', 'America');
 INSERT INTO Movie VALUES(34548, 'Citizen Kane', 1941, 'English', '119', 'California');
 INSERT INTO Movie VALUES(34549, 'Gone With The Wind', 1939, 'English', '238', 'America');
 INSERT INTO Movie VALUES(34550, 'The Wizard of Oz', 1939, 'English', '102', 'Kansas');
 INSERT INTO Movie VALUES(34551, 'One Flew Over The Cuckoos Nest', 1975, 'English', '133', 'America');
 INSERT INTO Movie VALUES(34553, 'Lawrence of Arabia', 1962, 'English', '228', 'Turkey');  

 select * from Producers;
 select * from Actors;
 select * from Directors;
 select * from Editors;
 select * from Movie;

-------- -- SAMPLE QUERIES ----------
select distinct 
  prod_id, 
  prod_amount 
from Producers 
where finance_company in ('JPMorgan-Chase','Bank of America','Citibank/Citigroup') 
order by prod_amount desc;

select distinct 
  act_id, 
  act_first_name, 
  act_last_name 
from Actors 
where role in ('Leading Male') 
order by act_last_name asc ;

select distinct 
  act_id, 
  act_first_name,
  act_last_name 
from Actors
where role in ('Leading Female') 
order by act_last_name asc ;

select distinct 
  dr_id, 
  dir_first_name, 
  dir_last_name 
from Directors 
where dr_id > 1570;

select distinct 
  edit_id, 
  mov_id, 
  edit_first_name, 
  edit_last_name 
from Editors 
where edit_first_name in ('Clayton', 'Bobby', 'Mike', 'Dwight') 
order by edit_id;

select distinct 
  mov_title, 
  mov_lang, 
  mov_year 
from Movie 
where mov_year >= 1990 
and mov_runtime > 120 
order by mov_year;

select distinct 
  mov_title, 
  mov_year 
from Movie 
where mov_region in ('America') 
order by mov_year asc;

select distinct 
  dr_id, 
  mov_id 
from Directors 
where dir_first_name in ('Steven') 
and dir_last_name in ('Spielberg');

select distinct 
  prod_amount, 
  money_spent_on_film 
from Producers 
where prod_amount < 1000000
order by 1,2;

select distinct 
  edit_id, 
  mov_id, 
  edit_first_name, 
  edit_last_name 
from Editors 
where edit_first_name in ('Tom') 
and edit_last_name in ('Green') 
order by edit_id;

select distinct 
  a.mov_title, 
  a.mov_year, 
  a.mov_runtime 
from Movie a 
join Directors b on a.mov_id = b.mov_id 
where b.dr_id in ('1569')
order by a.mov_year desc;

select distinct 
  a.prod_id, 
  a.mov_id, 
  a.finance_company, 
  a.prod_amount 
from Producers a 
join Actors b on a.mov_id = b.mov_id 
where b.act_id >= 334
order by 1,2,3,4;

select distinct 
  a.act_id, 
  a.mov_id, 
  a.act_first_name, 
  a.act_last_name, 
  a.act_gender, 
  a.role 
from Actors a 
join Directors b on a.mov_id = b.mov_id 
where a.role like ('%Supporting%') 
and b.mov_id > 34544
order by 1,2,3,4,5,6;

select distinct 
  a.mov_title, 
  a.mov_year, 
  a.mov_runtime 
from Movie a 
join Editors b on a.mov_id = b.mov_id 
where b.edit_id > '100'
order by 1,2,3;

select distinct 
  a.edit_first_name, 
  a.edit_last_name 
from Editors a 
left join Producers b on a.mov_id = b.mov_id 
where b.money_spent_on_film < 1000000
order by 1,2;

select prod_id, mov_id, finance_company, prod_amount, money_spent_on_film
from Producers
order by finance_company desc;

select act_id, mov_id, act_first_name, act_last_name, act_gender, role
from Actorsproducers
order by act_first_name AND act_last_name;

select dr_id, mov_id, dir_first_name, dir_last_name
from Directors
order by dir_first_name AND dir_last_name;

select edit_id, mov_id, edit_first_name, edit_last_name
from Editors 
order by edit_first_name AND edit_last_name;

select mov_id, mov_title, mov_year, mov_lang, mov_runtime, mov_region
from Movie
order by mov_year desc;