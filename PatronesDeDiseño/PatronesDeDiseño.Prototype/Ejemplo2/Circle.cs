using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Prototype.Ejemplo2
{
    /// <summary>
    /// Clas que crea un objecto en concreto e implementa la interfaz
    /// </summary>
    public class Circle : IShape
    {
        private int _radius;
        private int _x;
        private int _y;
        private string _color;

        public Circle(int radius)
        {

            _radius = radius;

        }

        public IShape Clone()
        {
            return new Circle(_radius)
            {
                _x = this._x,
                _y = this._y,
                _color = this._color
            };
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void SetPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
