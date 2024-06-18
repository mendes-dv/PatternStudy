using FactoryPattern;

var payment = PaymentFactory.create(PaymentMethod.CreditCard);
payment.Pay(100);