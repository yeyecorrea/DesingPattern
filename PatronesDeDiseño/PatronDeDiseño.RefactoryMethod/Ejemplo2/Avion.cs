using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    public class Avion : IAutomovil
    {
        public bool Apagar()
        {
            throw new NotImplementedException();
        }

        public bool Arrancar()
        {
            throw new NotImplementedException();
        }

        public bool Encender()
        {
            throw new NotImplementedException();
        }

        public bool RecargarGasolina()
        {
            throw new NotImplementedException();
        }

        public bool TipoDeAutomovil()
        {
            throw new NotImplementedException();
        }

        string IAutomovil.TipoDeAutomovil()
        {
            throw new NotImplementedException();
        }
    }
}
