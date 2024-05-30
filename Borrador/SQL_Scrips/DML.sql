USE ProyectoPrueba;

INSERT INTO TIPODOCUMENTO VALUES ('DPI');
INSERT INTO TIPODOCUMENTO VALUES ('PASAPORTE');
INSERT INTO TIPODOCUMENTO VALUES ('LICENCIA');

INSERT INTO PERMISOS VALUES('Administrador');
INSERT INTO PERMISOS VALUES('Colaborador');
INSERT INTO PERMISOS VALUES('Huesped');

INSERT INTO PUESTOS VALUES('Gerente',1);
INSERT INTO PUESTOS VALUES('Recepcion',2);
INSERT INTO PUESTOS VALUES('Seguridad',2);
INSERT INTO PUESTOS VALUES('Limpieza',2);
INSERT INTO PUESTOS VALUES('Cocineros',2);
INSERT INTO PUESTOS VALUES('Camareros',2);
INSERT INTO PUESTOS VALUES('Botones',2);

INSERT INTO PERSONAL VALUES('123456','Pedro','Perez', 15152035, 1);

INSERT INTO HUESPUED VALUES(3606940710101, 'Angel', 'Martinez', 'Zona 15', 39452010, 1,3);

INSERT INTO USUARIOS VALUES(3606940710101, 'camino2024');

SELECT * FROM TIPODOCUMENTO;
SELECT * FROM PERMISOS;
SELECT * FROM PUESTOS;
SELECT * FROM PERSONAL;
SELECT * FROM HUESPUED;
SELECT * FROM USUARIOS;