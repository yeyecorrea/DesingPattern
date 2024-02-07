using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.AbstractFactory.Ejemplo1
{
    /// <summary>
    /// Interfaz creadora
    /// </summary>
    public interface ICourseFactory
    {
        /// <summary>
        /// Metodo que crea un curso en especifico de tipo ICourse
        /// </summary>
        /// <returns></returns>
        ICourse CreateFrontEndCourse();

        /// <summary>
        /// Metodo que crea un curso en especifico de tipo ICourse
        /// </summary>
        /// <returns></returns>
        ICourse CreateBackEndCourse();
    }
}
