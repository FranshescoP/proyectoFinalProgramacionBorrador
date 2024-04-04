using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador
{
    public class consultas
    {
        SQLConexion doc = new SQLConexion();
        persona person = new persona();

        public DataTable cargarComboDoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("obtenerTipoDocumentos", doc.cnn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int AgregarHuespued(persona person)
        {
            int filasAfectadas = 0;

            try
            {
                doc.cnn.Open();
                SqlCommand agr = new SqlCommand("sp_registrarHuesped", doc.cnn);
                agr.CommandType = CommandType.StoredProcedure;

                agr.Parameters.AddWithValue("@noDocumento", person.NoDocumento);
                agr.Parameters.AddWithValue("@nombre", person.Nombre);
                agr.Parameters.AddWithValue("@apellido", person.Apellido);
                agr.Parameters.AddWithValue("@direccion", person.Direccion);
                agr.Parameters.AddWithValue("@telefono", person.Telefono);
                agr.Parameters.AddWithValue("@tipodc", person.Tipodc);
                agr.Parameters.AddWithValue("@pass", person.Pass);

                filasAfectadas = agr.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                // You can log the exception details or handle it as needed
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error inesperado: " + ex.Message);
            }
            finally
            {
                // Close the connection in the finally block to ensure it's always closed
                if (doc.cnn.State == ConnectionState.Open)
                {
                    doc.cnn.Close();
                }
            }
            return filasAfectadas;
        }
    }
}