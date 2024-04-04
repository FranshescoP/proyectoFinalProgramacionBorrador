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
        public SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-MVOUCJI;Initial Catalog=ProyectoPrueba;Integrated Security=True");
        persona person = new persona();

        public DataTable cargarComboDoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("obtenerTipoDocumentos", cnn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int AgregarHuespued(persona person)
        {
            cnn.Open();

            SqlCommand agr = new SqlCommand("sp_registrarHuesped", cnn);
            agr.CommandType = CommandType.StoredProcedure;

            agr.Parameters.AddWithValue("@noDocumento", person.NoDocumento);
            agr.Parameters.AddWithValue("@nombre", person.Nombre);
            agr.Parameters.AddWithValue("@apellido", person.Apellido);
            agr.Parameters.AddWithValue("@direccion", person.Direccion);
            agr.Parameters.AddWithValue("@telefono", person.Telefono);
            agr.Parameters.AddWithValue("@tipodc", person.Tipodc);
            agr.Parameters.AddWithValue("@pass", person.Pass);

            try
            {
                agr.ExecuteNonQuery();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            cnn.Close();

            return -1;
        }
    }
}
