using FactoryMethodDesignPattern.cards;

namespace FactoryMethodDesignPattern
{
    // TitaniumFactory Concrete Creators override the factory MakeProduct method
    // to create and return the Platinum Product
    public class TitaniumFactory : CreditCardFactory
    {
        // The signature of the method uses the abstract product CreditCard type,
        // Even though the concrete Titanium product is returned from the method.
        // This way the Abstract Creator CreditCardFactory can stay independent of concrete product classes.
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
}