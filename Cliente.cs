using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_holman_B
{
    internal class Cliente: persona
    {
        private int tel_cont;

        public Cliente(string nom, int edad, int tel_cont)
        {
            this.Nom = nom;
            this.Edad = edad;
            this.Tel_cont = tel_cont;
        }

        public int Tel_cont { get => tel_cont; set => tel_cont = value; }
        public override void mostrar()
        {
            Console.WriteLine("nombre:{0}",this.Nom);
            Console.WriteLine("edad:{0}",this.Edad);
            Console.WriteLine("telefono: {0}",this.tel_cont);
        }
    }
}
