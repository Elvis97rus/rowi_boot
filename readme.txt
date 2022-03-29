2nd
patient - [id,name,gender,birthDate, address]
doctor - [id, name]
visit - [id,visitDate,visitPlace, symptoms, diagnosis, recommendations, patientId, doctorId, medicineId?]
medicine - [id, name, useMethod, effects, sidEffects ]
------------------------------------
sqlcmd -S 127.0.0.1 -U SA
create database [db-name];
select name from sys.databases;
delete from [countries] where name = ['Russia']


dotnet ef migrations add Initial
dotnet ef database update
