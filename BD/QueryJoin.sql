SELECT * FROM sedena.unidades_aprendizaje;
SELECT DISTINCT
	unidades_aprendizaje.nombre_unidad_aprendizaje,
    unidades_aprendizaje.semestre,
    carreras.nombre_carrera,
    academias.nombre_academia
FROM carreras
JOIN unidades_aprendizaje
	ON carreras.id = unidades_aprendizaje.fk_id_carrera
JOIN academias
	ON academias.id = unidades_aprendizaje.fk_id_academia
WHERE unidades_aprendizaje.semestre = '1';

SELECT DISTINCT
	doscentes.nombre_doscente,
    doscentes.apellido_paterno_doscente,
    calificaciones_unidades_aprendizaje.id,
    calificaciones_unidades_aprendizaje.calificacion,
    unidades_aprendizaje.nombre_unidad_aprendizaje,
    academias.nombre_academia,
    carreras.nombre_carrera
FROM doscentes
JOIN calificaciones_unidades_aprendizaje
	ON doscentes.id = calificaciones_unidades_aprendizaje.fk_id_doscentes
JOIN unidades_aprendizaje
	ON calificaciones_unidades_aprendizaje.id = unidades_aprendizaje.fk_id_academia
JOIN academias
	ON unidades_aprendizaje.fk_id_academia = academias.id
JOIN carreras
	ON unidades_aprendizaje.id = carreras.id;