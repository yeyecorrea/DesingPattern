﻿namespace PatronDeDiseño.RefactoryMethod.Ejemplo1
{
    /// <summary>
    /// Clase que creadora que hereda de la case CredicardFactory
    /// </summary>
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}
