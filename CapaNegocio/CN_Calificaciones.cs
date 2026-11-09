using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class  CN_Calificaciones
    {
        private CD_Calificaciones cd = new CD_Calificaciones();
        public DataTable Listar()
        {
            return cd.Listar();
        }
        public void Insertar(int idEstudiante, int idMateria, decimal nota1, decimal nota2, decimal nota3)
        {
            Validar(nota1, nota2, nota3);
            cd.Insertar(idEstudiante, idMateria, nota1, nota2, nota3);
        }

        public void Actualizar(int idCalificacion, int idEstudiante, int idMateria, decimal nota1, decimal nota2, decimal nota3)
        {
            Validar(nota1, nota2, nota3);
            cd.Actualizar(idCalificacion, idEstudiante, idMateria, nota1, nota2, nota3);
        }
        public void Eliminar(int idCalificacion)
        {
            cd.Eliminar(idCalificacion);
        }
        private void Validar(decimal nota1, decimal nota2, decimal nota3)
        {
            if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10)
            {
                throw new Exception("Las notas deben estar entre 0 y 10.");
            }
        }
        public DataTable ListarEstudiantes()
        {
            return cd.ListarEstudiantes();
        }

        public DataTable ListarMaterias()
        {
            return cd.ListarMaterias();
        }
        
        public void InsertarEstudiante(string carnet, string nombre, string apellidos)
        {
            if (string.IsNullOrWhiteSpace(carnet) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellidos))
            {
                throw new Exception("Carnet, nombres y apellidos son obligatorios.");
            }
            cd.InsertarEstudiante(carnet.Trim(), nombre.Trim(), apellidos.Trim());
        }
            
        public void InsertarMateria(string nombreMateria)
        {
            if (string.IsNullOrWhiteSpace(nombreMateria))
            {
                throw new Exception("El nombre de la materia es obligatorio.");
            }
            cd.InsertarMateria(nombreMateria.Trim());
        }
    }
}
