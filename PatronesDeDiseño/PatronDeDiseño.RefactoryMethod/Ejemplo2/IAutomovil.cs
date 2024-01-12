using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    public interface IAutomovil
    {
        bool Encender();
        bool Apagar();
        bool Arrancar();
        bool RecargarGasolina();
        string TipoDeAutomovil();
    }
}
