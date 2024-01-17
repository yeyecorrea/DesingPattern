using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.Builder.Ejemplo1
{
    /// <summary>
    /// Define una interfaz para crear partes del objeto Producto. En este caso, define los métodos para construir el tamaño, la masa, la salsa y el relleno de la pizza.
    /// </summary>
    public abstract class BuilderPizza
    {
        protected Pizza _pizza;

        public string Tamaño { get; set; }

        public Pizza ObtenerPizza()
        {
            return _pizza;
        }

        public void CrearNuevaPizza()
        {
            _pizza = new Pizza();
        }

        public virtual void PasoPrepararMasa()
        {

        }

        public virtual void PasoAñadirSalsa()
        {

        }

        public virtual void PasoPrepararRelleno()
        {

        }

        public virtual void PasoDoblarPoizza()
        {

        }
    }
}
