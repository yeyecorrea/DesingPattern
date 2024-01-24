namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    /// <summary>
    /// Clase producto
    /// </summary>
    public class Carro : IAutomovil
    {
        public bool Apagar()
        {
            return true;
        }

        public bool Arrancar()
        {
            return true;
        }

        public bool Encender()
        {
            return false;
        }

        public bool RecargarGasolina()
        {
            return true;
        }

        public string TipoDeAutomovil()
        {
            return "Reanault 4";
        }
    }
}
