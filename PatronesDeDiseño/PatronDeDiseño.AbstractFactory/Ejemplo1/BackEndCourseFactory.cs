using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.AbstractFactory.Ejemplo1
{
    /// <summary>
    /// Clase creadora que crea un producto en concreto (Concrete product)
    /// </summary>
    public class BackEndCourseFactory : ICourseFactory
    {
        public ICourse CreateBackEndCourse()
        {
            // retornamos la instancia de la clase producto producto
            return new BackEndCourse();
        }

        public ICourse CreateFrontEndCourse()
        {
            // retornamos la instancia de la clase producto producto
            return new FrontEndCourse();
        }
    }
}
