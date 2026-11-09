using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Calificaciones
    {
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_listar_calificaciones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }
        public DataTable ListarEstudiantes()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_estudiante, carnet + ' - ' + nombres + ' ' + apellidos AS nombre " +
                    "FROM estudiantes ORDER BY apellidos, nombres", con);
                da.Fill(tabla);
            }
            return tabla;

        }

        public DataTable ListarMaterias()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_materia, nombre_materia FROM materias ORDER BY nombre_materia", con);
                da.Fill(tabla);
            }
            return tabla;
        }

        public void InsertarEstudiante(string carnet, string nombres, string apellidos)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO estudiantes (carnet, nombres, apellidos) VALUES (@carnet, @nombres, @apellidos)", con);
                cmd.Parameters.AddWithValue("@carnet", carnet);
                cmd.Parameters.AddWithValue("@nombres", nombres);
                cmd.Parameters.AddWithValue("@apellidos", apellidos);
                con.Open();
                try
                { 
                 cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                        throw new Exception("El carnet del estudiante ya está registrado.");
                    throw;
                }
            }
        }

        public void InsertarMateria(string nombreMateria)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO materias (nombre_materia) VALUES (@nombre_materia)", con);      
                cmd.Parameters.AddWithValue("@nombre_materia", nombreMateria);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                        throw new Exception("La materia ya está registrada.");
                    throw;
                }
            }
        }
        public void Insertar(int idEstudiante, int idMateria, decimal nota1, decimal nota2, decimal nota3)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_insertar_calificacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@id_materia", idMateria);
                cmd.Parameters.AddWithValue("@nota1", nota1);
                cmd.Parameters.AddWithValue("@nota2", nota2);
                cmd.Parameters.AddWithValue("@nota3", nota3);
                con.Open();
                EjecutarComando(cmd);
            }
        }

        public void Actualizar(int idCalificacion, int idEstudiante, int idMateria, decimal nota1, decimal nota2, decimal nota3)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_actualizar_calificacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_calificacion", idCalificacion);
                cmd.Parameters.AddWithValue("@id_estudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@id_materia", idMateria);
                cmd.Parameters.AddWithValue("@nota1", nota1);
                cmd.Parameters.AddWithValue("@nota2", nota2);
                cmd.Parameters.AddWithValue("@nota3", nota3);
                con.Open();
                EjecutarComando(cmd);
            }
        }

        public void Eliminar(int idCalificacion)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_eliminar_calificacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Calificacion", idCalificacion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void EjecutarComando(SqlCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("Este estudiante ya tiene una calificación registrada en esa materia.");
                if (ex.Number == 547)
                    throw new Exception("El estudiante o la materia indicados no existen.");
                throw;
            }
        }
    }
}