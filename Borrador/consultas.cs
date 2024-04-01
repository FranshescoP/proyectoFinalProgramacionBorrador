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

        public int AgregarHuespued()
        {
            doc.cnn.Open();
            SqlCommand agr = new SqlCommand("registrarHuesped", doc.cnn);

            agr.Parameters.AddWithValue("@nombre", person.Nombre ?? "");
            agr.Parameters.AddWithValue("@apellido", person.Apellido ?? "");
            agr.Parameters.AddWithValue("@direccion", person.Direccion ?? "");
            agr.Parameters.AddWithValue("@telefono", person.Telefono);
            agr.Parameters.AddWithValue("@noDocumento", person.NoDocumento);
            agr.Parameters.AddWithValue("@tipodc", person.Tipodc);
            agr.Parameters.AddWithValue("@pass", person.Pass ?? "");

            int filasAfectadas = agr.ExecuteNonQuery();
            doc.cnn.Close();

            return filasAfectadas;
        }

    }
}
