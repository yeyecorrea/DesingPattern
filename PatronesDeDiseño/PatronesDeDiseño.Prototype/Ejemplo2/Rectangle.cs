using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Prototype.Ejemplo2
{
    /// <summary>
    /// Clase que crea un objecto en concreto e implementa la interfaz
    /// </summary>
    public class Rectangle : IShape
    {
        private int _width;
        private int _height;
        private int _x;
        private int _y;
        private string _color;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public IShape Clone()
        {
            return new Rectangle(_width, _height)
            {
                _x = this._x,
                _y = this._y,
                _color = this._color
            };
        }

        public void SetPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetColor(string color)
        {
            _color = color;
        }
    }
}
