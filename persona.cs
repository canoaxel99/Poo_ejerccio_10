using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_10
{
    internal class persona
    {
        private string nom;
        private int edad;
        public persona()
        {

        }
        public persona(string nom, int edad)
        {
            this.Nom = nom;
            this.Edad = edad;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Edad { get => edad; set => edad = value; }
        public virtual void mostrar()
        {
            Console.WriteLine(this.nom);
            Console.WriteLine(this.edad);
        }
    }
}
