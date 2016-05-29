insert into RecruitedSet(Name, Surname, DateOfBirth, Education, Email, PhoneNumber, Nationality)
 values('Zenon', 'Kowalski', '20120618 10:34:09 AM', 'Podstawowe', 'zenon@zenon.pl', '123123123', 'Polska');
 go
 insert into ApplicationSet(Recruited_Id, Assistant_Id, Job_Id, YearsOfExpirience) 
	values(8, 1, 1, 2);