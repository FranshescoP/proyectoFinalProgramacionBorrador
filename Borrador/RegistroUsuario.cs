using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace Borrador
{
    public partial class RegistroUsuario : Form
    {
        consultas consul = new consultas();
        persona person = new persona();
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void regis()
        {

            try
            {
                person.Nombre = txtNombre.Text;
                person.Apellido = txtApellido.Text;
                person.Direccion = txtDireccion.Text;
                person.Pass = txtpass.Text;
                person.Tipodc = Convert.ToInt32(cboDocumentos.SelectedValue);
                person.Telefono = (float)Convert.ToInt32(txtTelefono.Text);
                person.NoDocumento = (float)Convert.ToInt64(txtDocumento.Text);


                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    Console.WriteLine("Esta vacio");
                }
                else
                {

                    try 
                    {
                        consul.AgregarHuespued(person);

                        MessageBox.Show("Se creo correctamnete el usuario");

                        frmlogin vistal = new frmlogin();
                        this.Hide();
                        vistal.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("error");
                    }
                }

            }
            catch (Exception i)
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }
        }

        private void registro_Click(object sender, EventArgs e)
        {
            regis();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            cboDocumentos.DataSource = consul.cargarComboDoc();
            cboDocumentos.DisplayMember = "tipoDoc";
            cboDocumentos.ValueMember = "idDoc";
        }
    }
}
