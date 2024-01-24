namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    /// <summary>
    /// Clase que crea un objecto de una clase producto
    /// </summary>
    public class AvionFactory : AutomavilFactory
    {
        protected override IAutomovil MakeAutomovil()
        {
            IAutomovil automovil = new Avion();
            return automovil;
        }
    }
}
