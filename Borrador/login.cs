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

namespace Borrador
{
    public partial class frmlogin : Form
    {
        SQLConexion sqlControl = new SQLConexion(); 

        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result = sqlControl.Login(txtusuario.Text, txtPass.Text);

            if (result == 1) {
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.ShowDialog();
            } else if (result == 0){
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            this.Hide();
            registroUsuario.ShowDialog();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
