namespace FactoryPattern;

public class PaymentFactory
{
    public static IPayment create(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.Paypal:
                return new PaypalPayment();
            case PaymentMethod.CreditCard:
                return new CreditCardPayment();
            case PaymentMethod.GooglePay:
                return new GooglePayPayment();
            default:
                throw new NotSupportedException();
        }
    }
}