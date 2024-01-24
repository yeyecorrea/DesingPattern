namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    /// <summary>
    /// Clase que crea un objecto de una clase producto
    /// </summary>
    public class MotoFactory : AutomavilFactory
    {
        protected override IAutomovil MakeAutomovil()
        {
            IAutomovil automovil = new Moto();
            return automovil;
        }
    }
}
