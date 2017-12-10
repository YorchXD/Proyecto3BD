DELETE FROM comentario WHERE codigo='c5';
DELETE FROM es_cliente WHERE refcliente='18295593-0' AND refveterinaria='90987965';
DELETE FROM horaconsulta WHERE codigo='c08';
DELETE FROM mascota WHERE num_registro='010';
DELETE FROM medico WHERE run='20145722-k';
DELETE FROM moderador WHERE run='9343931-7';
DELETE FROM reserva_hora WHERE refhoraconsulta='c04' AND refmedico='21691096-6' AND refmascota='04';
DELETE FROM revisar_comentario WHERE refmoderador='22988361-5' AND refcomentario='c16';
DELETE FROM sucursal WHERE num_permiso='27976';

/*Los siguientes DELETE debieran arrojar error debido a que una veterinaria y un cliente no se puede eliminar*/
DELETE FROM veterinaria WHERE rut='90735465';
DELETE FROM cliente WHERE run='22992706-k';