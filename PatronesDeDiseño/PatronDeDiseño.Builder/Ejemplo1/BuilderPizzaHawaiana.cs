using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.Builder.Ejemplo1
{
    /// <summary>
    /// Implementa la interfaz de BuilderPizza y construye y ensambla las partes del producto definiendo y manteniendo la representación. Define cómo se debe construir una pizza hawaiana.
    /// </summary>
    public class BuilderPizzaHawaiana : BuilderPizza
    {
        public BuilderPizzaHawaiana(string tamaño)
        {
            _pizza = new Pizza
            {
                Tamaño = tamaño
            };
        }
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Suave";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "piña+tomate+jamón";
        }
    }
}
