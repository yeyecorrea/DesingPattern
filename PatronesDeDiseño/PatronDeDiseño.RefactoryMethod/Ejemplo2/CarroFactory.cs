namespace PatronDeDiseño.RefactoryMethod.Ejemplo2
{
    /// <summary>
    /// Clase que crea un objecto de una clase producto
    /// </summary>
    public class CarroFactory : AutomavilFactory
    {
        protected override IAutomovil MakeAutomovil()
        {
            IAutomovil automovil = new Carro();
            return automovil;
        }
    }
}
