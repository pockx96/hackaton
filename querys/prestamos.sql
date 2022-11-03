INSERT INTO `lab_herramientas`.`prestamo_alumno` (`matricula`, `nombre`, `materia`, `Herramienta`, `cantidad`, `fecha_salida`, `fecha_regreso`, `estado`, `lab`) 
VALUES ('19302325', 'Jose Martinez', 'telecomunicaciones', 'pinzas', '4', '02-11-2022', '05-11-2022', 'Pendiente' , 'Sistemas');
INSERT INTO `lab_herramientas`.`prestamo_alumno` (`matricula`, `nombre`, `materia`, `Herramienta`, `cantidad`, `fecha_salida`, `fecha_regreso`, `estado`, `lab`) 
VALUES ('22586562', 'Fernando Guerrero', 'carreteras', 'Destornilladores', '7', '03-11-2022', '04-11-2022', 'Finalizado', 'Civil' );
INSERT INTO `lab_herramientas`.`prestamo_alumno` (`matricula`, `nombre`, `materia`, `Herramienta`, `cantidad`, `fecha_salida`, `fecha_regreso`, `estado`, `lab`) 
VALUES ('20124567', 'Manuel Gonzales', 'ejemplo', 'Torno', '4', '02-11-2022', '03-11-2022', 'Pendiente' , 'Industrial');

INSERT INTO `lab_herramientas`.`prestamo_empleado` (`numero_de_control`, `nombre`, `celular`, `necesidad`, `herramienta`, `cantidad`, `fecha_salida`, `fecha_regreso`, `estado`, `lab`) 
VALUES ('35', 'ejemplo1', '6384534543', 'x', 'destornilladores', '4', '02-09-2022', '04-09-2022', 'Pendiente', 'Sistemas');
INSERT INTO `lab_herramientas`.`prestamo_empleado` (`numero_de_control`, `nombre`, `celular`, `necesidad`, `herramienta`, `cantidad`, `fecha_salida`, `fecha_regreso`, `estado`, `lab`) 
VALUES ('80', 'ejemplo2', '6389594965', 'x', 'Pinzas', '6', '02-09-2022', '04-09-2022', 'Finalizado', 'Civil');
INSERT INTO `lab_herramientas`.`prestamo_empleado` (`numero_de_control`, `nombre`, `celular`, `necesidad`, `herramienta`, `cantidad`, `fecha_salida`, `fecha_regreso`, `estado`, `lab`) 
VALUES ('60', 'ejemplo3', '6383453957', 'x', 'Torno', '1', '02-09-2022', '03-09-2022', 'Pendiente', 'Industrial');
