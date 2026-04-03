namespace FactoryMethodDesignPattern
{
    // The CreditCard interface declares the operations that all 
    // concrete products must implement.
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}