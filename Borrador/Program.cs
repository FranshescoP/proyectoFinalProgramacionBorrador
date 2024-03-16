using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            frmlogin login = new frmlogin();

            login.ShowDialog();
        }
    }
}
