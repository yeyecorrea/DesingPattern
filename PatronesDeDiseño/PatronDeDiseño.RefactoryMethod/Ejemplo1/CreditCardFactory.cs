namespace PatronDeDiseño.RefactoryMethod.Ejemplo1
{
    /// <summary>
    /// Clase creator declara el metodo de fabrica que va a devolver un objecto d euna clase Producto, las subclases CrediCardFactory normalmente proporciona la implementacion del metodo MakeProduct 
    /// </summary>
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        /// <summary>
        /// La responsabilidadd principal del creador no es crear los productos
        /// Por lo general, contiene cierta logica empresarial central que se basa en objectos Producto
        /// </summary>
        /// <returns>ICreditCard</returns>
        public ICreditCard CreateProdut()
        {
            ICreditCard creditCard = MakeProduct();
            return creditCard;
        }
    }
}
