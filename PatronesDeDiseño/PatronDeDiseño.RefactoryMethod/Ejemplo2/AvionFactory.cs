namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    public class AvionFactory : AutomavilFactory
    {
        protected override IAutomovil MakeAutomovil()
        {
            IAutomovil automovil = new Avion();
            return automovil;
        }
    }
}
