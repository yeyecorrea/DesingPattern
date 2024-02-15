using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Prototype.Ejemplo1
{
    /// <summary>
    /// Interfaz IPrototype declara los metodos de clonacion
    /// </summary>
    public interface IPrototype
    {
        /// <summary>
        /// Metodo que clonara los objectos
        /// </summary>
        /// <returns></returns>
        IPrototype Clone();
    }
}
