using PatronDeDiseño.RefactoryMethod;
using PatronDeDiseño.RefactoryMethod.Ejemplo1;

ICreditCard creditCard = new PlatinumFactory().CreateProdut();
if (creditCard != null)
{
    Console.WriteLine($"Card Type: {creditCard.GetCardType()}");
    Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit()}");
    Console.WriteLine($"Annual Charge: {creditCard.GetAnnualCharge()}");

}else
{
    Console.WriteLine("Invalid Card Type");
}