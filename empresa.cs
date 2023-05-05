using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_10
{
    internal class empresa
    {
        private string nombre;

        public empresa(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
