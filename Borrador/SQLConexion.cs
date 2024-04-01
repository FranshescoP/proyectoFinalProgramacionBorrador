using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Borrador
{
     class SQLConexion
    {
        public SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-MVOUCJI;Initial Catalog=ProyectoPrueba;Integrated Security=True");

        public int Login(string usuario, string contraseña)
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("spLogin",cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@pass", contraseña);
                
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            } 
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            finally 
            { 
                cnn.Close(); 
            }
            return -1;
        }
    }
}
