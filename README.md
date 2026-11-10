# Control de Calificaciones

Prototipo de una aplicación de escritorio para registrar y consultar las calificaciones de estudiantes por materia. Calcula el promedio de tres notas y muestra si el estudiante está aprobado o reprobado.

## Integrantes

| Nombre | Carnet | Rol |
|--------|--------|-----|
| [Valeria Magaña] | [261274] | Base de datos, lógica e integración |
| [Debbie Navarrete] | [260016] | Diseño visual de la interfaz |

## Funciones del prototipo

- Registrar, actualizar y eliminar calificaciones
- Registrar nuevos estudiantes y nuevas materias
- Promedio y estado (Aprobado/Reprobado) calculados automáticamente
- Formulario "Autores" con los integrantes del grupo

## Tecnologías

- C# con Windows Forms (.NET Framework 4.8)
- Arquitectura en 3 capas: CapaDatos, CapaNegocio y CapaPresentacion
- SQL Server

## Cómo ejecutarlo

1. Clonar el repositorio.
2. Ejecutar el script `controlcalificaciones.sql` en SQL Server para crear la base de datos.
3. Revisar la cadena de conexión en `CapaDatos/Conexion.cs` y ajustarla a tu servidor si hace falta.
4. Abrir `ControlCalificaciones.slnx` en Visual Studio.
5. Establecer `CapaPresentacion` como proyecto de inicio y pulsar F5.