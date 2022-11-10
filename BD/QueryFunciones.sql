set global log_bin_trust_function_creators = 1;

DELIMITER $$
create function crack_login(_matricula varchar(45), _contrasena varchar(45))
returns int
begin
	if(select count(*) from usuarios where matricula = _matricula and contrasena = _contrasena) > 0 then
    return 1;
    else
	return 0;
    end if;
end$$
DELIMITER ;

DELIMITER $$
create function crack_user(_matricula varchar(20))
returns int
begin
	if(select count(*) from discentes where matricula_discente = _matricula) > 0 then
    return 1;
    else
	return 0;
    end if;
end$$
DELIMITER ;

select carrera, Count(carrera) as Total from sedena.discentes group by carrera;
select sexo, Count(sexo) as Total from sedena.discentes group by sexo;
select sexo, Count(sexo) as Total from sedena.discentes where generacion = 2018 group by sexo;

select NOMBRE, APELLIDOS, SALARIO from EMPLEADOS order by SALARIO;

SELECT matricula_discente, nombre_discente, apellido_paterno_discente, apellido_materno_discente, promedio from sedena.discentes where generacion = "75 (2016 - 2022)" order by promedio desc limit 3;