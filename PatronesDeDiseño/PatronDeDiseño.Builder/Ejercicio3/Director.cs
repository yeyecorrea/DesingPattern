namespace PatronDeDiseño.Builder.Ejercicio3
{
    // El Director sólo es responsable de ejecutar los pasos de construcción en un
    // secuencia particular. Es útil cuando se producen productos de acuerdo con un
    // orden o configuración específica. Estrictamente hablando, la clase Directora es
    // opcional, ya que el cliente puede controlar los constructores directamente.
    public class Director
    {
        private IConstructor _constructor;

        public IConstructor Constructor
        {
            set { _constructor = value; }
        }

        // El Director puede construir varias variaciones de producto utilizando el mismo
        // pasos de construcción.
        public void ConstruirProductoMinimoViable()
        {
            this._constructor.ConstructorParteA();
        }

        public void ConstruirProductoDestacadoCompleto()
        {
            this._constructor.ConstructorParteA();
            this._constructor.ConstructorParteB();
            this._constructor.ConstructorParteC();
        }
    }
}
