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

        private void registro_Click(object sender, EventArgs e)
        {
            try
            {
                person.Telefono = (float)Convert.ToInt32(txtTelefono.Text);
                person.NoDocumento = Convert.ToInt64(txtDocumento.Text);
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message, "Debe de llenar los campos de telefono y numero de documento");
            }

            person.Nombre = txtNombre.Text;
            person.Apellido = txtApellido.Text;
            person.Direccion = txtDireccion.Text;
            person.Pass = txtpass.Text;
            person.Tipodc = Convert.ToInt32(cboDocumentos.SelectedValue);

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }
            else
            {
                consul.AgregarHuespued(person);
                MessageBox.Show("Se creo correctamente el usuario");
                frmlogin vistal = new frmlogin();
                this.Hide();
                vistal.ShowDialog();
            }

        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            cboDocumentos.DataSource = consul.cargarComboDoc();
            cboDocumentos.DisplayMember = "tipoDoc";
            cboDocumentos.ValueMember = "idDoc";
        }
    }
}