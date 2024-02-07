using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.AbstractFactory.Ejemplo1
{
    /// <summary>
    /// Clase product que implementa la interfaz ICourse
    /// </summary>
    public class FrontEndCourse : ICourse
    {
        public void ShowDetails()
        {
            Console.WriteLine("FornEnd detalles del curso");
        }
    }
}
