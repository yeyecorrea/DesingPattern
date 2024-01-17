namespace PatronDeDiseño.Builder.Ejemplo2
{
    /// <summary>
    /// Clase director
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
