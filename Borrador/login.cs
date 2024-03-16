using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
