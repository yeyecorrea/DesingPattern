using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Prototype.Ejemplo1
{
    /// <summary>
    /// Clase cliente que utiliza el prototipo para crear nuevos objetos.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Método que acepta un prototipo y crea un nuevo objeto a partir de él.
        /// </summary>
        /// <param name="prototype"></param>
        public static void CreateObject(IPrototype prototype)
        {
            var newObject = prototype.Clone();
            Console.WriteLine($"Created new object with property value {((ConcretePrototypeA)newObject).PropertyA}");
        }
    }
}
