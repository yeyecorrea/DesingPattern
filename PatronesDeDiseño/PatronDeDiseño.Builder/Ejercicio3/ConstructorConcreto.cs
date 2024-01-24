namespace PatronDeDiseño.Builder.Ejercicio3
{
    /// <summary>
    /// Clase constructora en concreto, crea un objecto producto en especifico, he implementa la interfaz constructora
    /// </summary>
    public class ConstructorConcreto : IConstructor
    {
        // instancia de la clase producto
        private Producto _producto = new Producto();

        // Una nueva instancia de constructor debe contener un objeto de producto en blanco, que
        // se utiliza en posteriores ensamblajes.
        public ConstructorConcreto()
        {
            this.Reiniciar();
        }

        public void Reiniciar()
        {
            this._producto = new Producto();
        }
        // Implementamos la interfaz
        public void ConstructorParteA()
        {
            throw new NotImplementedException();
        }

        public void ConstructorParteB()
        {
            throw new NotImplementedException();
        }

        public void ConstructorParteC()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// // Se supone que los constructores de hormigón deben proporcionar sus propios métodos para
        // recuperando resultados. Esto se debe a que varios tipos de constructores pueden
        // crear productos completamente diferentes que no siguen lo mismo
        // interfaz. Por lo tanto, dichos métodos no se pueden declarar en la base.
        // Interfaz del constructor (al menos en una programación de tipo estático
        // idioma).
        //
        // Generalmente, después de devolver el resultado final al cliente, un constructor
        // se espera que la instancia esté lista para comenzar a producir otro producto.
        // Por eso es una práctica habitual llamar al método reset al final
        // del cuerpo del método `GetProduct`. Sin embargo, este comportamiento no
        // obligatorio y puedes hacer que tus constructores esperen un reinicio explícito
        // llamada desde el código del cliente antes de deshacerse del resultado anterior.
        /// </summary>
        /// <returns></returns>
        public Producto ObtenerProducto()
        {
            Producto result = this._producto;
            this.Reiniciar();

            return result;
        }
    }
}
