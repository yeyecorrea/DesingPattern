using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    /// <summary>
    /// La clase Creator declara el método de fábrica que se supone debe devolver un objecto de una clase Producto
    /// </summary>
    public abstract class AutomavilFactory
    {
        protected abstract IAutomovil MakeAutomovil();

        public IAutomovil CreateAutomovil()
        {
            IAutomovil automovil = this.MakeAutomovil();
            return automovil;
        }
    }
}
