namespace PatronDeDiseño.RefactoryMethod
{
    /// <summary>
    /// Interfaz que sera la firma de las funcionalidades comunes que las clases de productos concretas deberian implementar
    /// </summary>
    public interface ICreditCard
    {
        // Definimos los metodos que una targeta normalmente hace

        /// <summary>
        /// Optiene el tipo de targeta
        /// </summary>
        /// <returns>String: tipo de tarjeta</returns>
        string GetCardType();

        /// <summary>
        /// Retorna el limite de la tarjeta
        /// </summary>
        /// <returns>int: limite de la tarjeta</returns>
        int GetCreditLimit();

        /// <summary>
        /// Retorna el 
        /// </summary>
        /// <returns></returns>
        int GetAnnualCharge();
    }
}
