using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp002Crud
{
    public class Cerveza
    {
        public string Nombre { get; set; }
        public string Estilo { get; set;}
        public double Alcohol { get; set; }
        public Cerveza() {
            this.Nombre = "";
            this.Estilo = "";
            this.Alcohol = 0;
        }
        public Cerveza(string Nombre, string Estilo, double Alcohol) {
            this.Nombre= Nombre;
            this.Estilo = Estilo;
            this.Alcohol = Alcohol;
        }

    }
}
