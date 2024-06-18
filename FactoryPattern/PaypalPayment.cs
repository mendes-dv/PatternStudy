namespace FactoryPattern;

public class PaypalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} with Paypal");
    }
}