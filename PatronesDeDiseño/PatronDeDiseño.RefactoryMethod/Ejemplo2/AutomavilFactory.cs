using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
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
