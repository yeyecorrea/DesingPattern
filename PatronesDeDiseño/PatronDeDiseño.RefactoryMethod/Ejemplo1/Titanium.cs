namespace PatronDeDiseño.RefactoryMethod.Ejemplo1
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 18000;
        }
    }
}
