using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador
{
    public class persona
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private float telefono;
        private int tipodc;
        private float noDocumento;
        private string pass;

        public float NoDocumento { get => noDocumento; set => noDocumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public float Telefono { get => telefono; set => telefono = value; }
        public int Tipodc { get => tipodc; set => tipodc = value; }
        public string Pass { get => pass; set => pass = value; }


    }
}
