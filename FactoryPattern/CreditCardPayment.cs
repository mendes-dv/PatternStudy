namespace FactoryPattern;

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} with Credit Card");
    }
}