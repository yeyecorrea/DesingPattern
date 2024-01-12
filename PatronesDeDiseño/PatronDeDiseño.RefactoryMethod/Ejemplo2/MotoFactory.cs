namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    public class MotoFactory : AutomavilFactory
    {
        protected override IAutomovil MakeAutomovil()
        {
            IAutomovil automovil = new Moto();
            return automovil;
        }
    }
}
