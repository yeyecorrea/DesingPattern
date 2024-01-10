namespace PatronDeDiseño.RefactoryMethod
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 8000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 12000;
        }
    }
}
