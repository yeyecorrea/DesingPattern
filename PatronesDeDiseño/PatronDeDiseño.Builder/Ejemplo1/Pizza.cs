using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.Builder.Ejemplo1
{
    /// <summary>
    /// Esta es la clase del producto que se va a construir. En este caso, una pizza. Tiene atributos como masa, salsa, relleno y tamaño.
    /// </summary>
    public class Pizza
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamaño { get; set; }
        public bool EstaDoblada { get; set; }

        public Pizza()
        {

        }

        public Pizza(string tamaño, string masa, string salsa, string relleno, bool doblar)
        {
            Tamaño = tamaño;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
            EstaDoblada = doblar;
        }
    }
}
