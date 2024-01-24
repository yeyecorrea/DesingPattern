namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    /// <summary>
    /// Inerfaz que define los metodos de un automovil
    /// </summary>
    public interface IAutomovil
    {
        bool Encender();
        bool Apagar();
        bool Arrancar();
        bool RecargarGasolina();
        string TipoDeAutomovil();
    }
}
