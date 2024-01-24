namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    /// <summary>
    /// Clase producto
    /// </summary>
    public class Moto : IAutomovil
    {
        public bool Apagar()
        {
            throw new NotImplementedException();
        }

        public bool Arrancar()
        {
            throw new NotImplementedException();
        }

        public bool Encender()
        {
            throw new NotImplementedException();
        }

        public bool RecargarGasolina()
        {
            throw new NotImplementedException();
        }

        public bool TipoDeAutomovil()
        {
            throw new NotImplementedException();
        }

        string IAutomovil.TipoDeAutomovil()
        {
            throw new NotImplementedException();
        }
    }
}
