using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_10
{
    internal class  empleado: persona
    {
        private float sueldo_bruto;

        public empleado(string nom, int edad, float sueldo_bruto)
        {

            this.Nom = nom;
            this.Edad = edad;
            this.Sueldo_bruto = sueldo_bruto;
        }

        public float Sueldo_bruto { get => sueldo_bruto; set => sueldo_bruto = value; }
        public override void mostrar()
        {
            Console.WriteLine("el salario bruto es : {0}",this.sueldo_bruto );
        }
        public void calsal()
        {
            Console.WriteLine("el salario neto es :{0} ", this.sueldo_bruto);
        }
    }
}
