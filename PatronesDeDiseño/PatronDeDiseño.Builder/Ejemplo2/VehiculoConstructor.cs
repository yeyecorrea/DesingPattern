namespace PatronDeDiseño.Builder.Ejemplo2
{
    /// <summary>
    /// Clase constructora abstracta
    /// La interfaz constructora especifica métodos para crear las
    /// distintas partes de los objetos del producto.
    /// </summary>
    public abstract class VehiculoConstructor
    {
        protected Vehiculo vehiculo;

        /// <summary>
        /// Obtenemos las instacia de la clase produco, es decir Vehiculo
        /// </summary>
        public Vehiculo Vehiculo
        {
            // Retornamos la isntancia de la clase producto
            get { return vehiculo; }
        }

        // Definimos los metodos abstractos de los vehiculos
        public abstract void ConstruirChasis();
        public abstract void ConstruirMotor();
        public abstract void ConstruirRuedas();
        public abstract void ConstruirPuertas();

    }
}
