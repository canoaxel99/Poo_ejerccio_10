using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_10
{
    internal class directivo: persona
    {
       private string categoria;

        public directivo(string nom, int edad, string categoria)
        {
            this.Nom = nom;
            this.Edad = edad;
            this.Categoria = categoria;
        }

        public string Categoria { get => categoria; set => categoria = value; }
        public override void mostrar()
        {
            Console.WriteLine("la categoria es: {0}", categoria);
        }
    }
}
