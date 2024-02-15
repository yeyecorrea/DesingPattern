using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Prototype.Ejemplo2
{
    public class Client
    {
        public static void CreateObject(IShape prototype)
        {
            var newObj = prototype.Clone();
            Console.WriteLine($"Created new object of type {newObj.GetType().Name} with position ({((IShape)newObj).GetX()}, {((IShape)newObj).GetY()}) and color {((IShape)newObj).GetColor()}");
        }
    }
}
