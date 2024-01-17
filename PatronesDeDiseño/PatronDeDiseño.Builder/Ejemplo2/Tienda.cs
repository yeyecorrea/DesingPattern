namespace PatronDeDiseño.Builder.Ejemplo2
{
    /// <summary>
    /// Clase director, es aquella que define el orden en el que se deben ejecutar los pasos de cosntruccion
    /// </summary>
    public class Tienda
    {
        public void Constructor(VehiculoConstructor vehiculoConstructor)
        {
            vehiculoConstructor.ConstruirMotor();
            vehiculoConstructor.ConstruirChasis();
            vehiculoConstructor.ConstruirPuertas();
            vehiculoConstructor.ConstruirRuedas();
        }
    }
}
