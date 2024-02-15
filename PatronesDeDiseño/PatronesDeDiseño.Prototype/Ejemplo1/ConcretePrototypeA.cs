using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Prototype.Ejemplo1
{
    /// <summary>
    /// Clase concreta que implementa la interfaz
    /// </summary>
    public class ConcretePrototypeA : IPrototype
    {
        public int PropertyA { get; set; }

        /// <summary>
        /// Metodo Clone que creara una nueva insancia de ConcretePrototypeA 
        /// </summary>
        /// <returns></returns>
        public IPrototype Clone()
        {
            return new ConcretePrototypeA { PropertyA = this.PropertyA };
        }
    }
}
