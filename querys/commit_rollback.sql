#Creación BD:
create database Hoteles;

#Creación de tabla:
create table Departamentos (dep_id int not null, dep_nombre varchar (100));
drop table departamentos;

#Ingresar datos:
insert into Departamentos (dep_id, dep_nombre) values (1,'Diane Karla Bernal Félix'), (2,'Cristopher Acosta Rios'), (3,'Yair Valenzuela');

#Seleccionar tabla:
SELECT * FROM hoteles.departamentos;

#Creación consulta para agregar los datos:
SELECT * FROM departamentos ORDER BY dep_id;

#Creación de Commit
Commit;

#Update incorrecto:
update departamentos set dep_id = 1, dep_nombre = 'IT';

#Activación de autocommit:
set autocommit = 0;

#RollBack:
Rollback;