using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Prototype.Ejemplo2
{
    public interface IShape
    {
        /// <summary>
        /// Metodo que clonara el objecto
        /// </summary>
        /// <returns></returns>
        IShape Clone();

        /// <summary>
        /// Metodo la posicion
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void SetPosition(int x, int y);

        /// <summary>
        /// Metodo que envia un color
        /// </summary>
        /// <param name="color"></param>
        void SetColor(string color);
        object GetX();
        object GetY();
        object GetColor();
    }
}
