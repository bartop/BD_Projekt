insert into RoleSet(name) values ('Administrator'),
	('Asistant'), ('Recruiter'), ('Supervisor');

insert into dbo.WorkerSet values ('root', '$MYHASH$V1$10000$k2tOGYDeBmd2IgvKEGIHrnJ6Hjzhz/r5tLWt0CJCGg32osgo', 
	(select id from RoleSet where name = 'Administrator') 
	, null);
