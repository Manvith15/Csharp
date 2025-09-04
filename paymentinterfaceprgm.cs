using System;

namespace PaymentSystem
{ }

public interface IPayment
{
    void MakePayment(double Amount);
}
public class Paypalpayment : IPayment

{
    public void MakePayment(double Amount)
    {
        Console.WriteLine(Amount);
    }
}
public class UPIPayment : IPayment
{
    public void MakePayment(double Amount)
    {
        Console.WriteLine(Amount);
    }
}
public class Creditcardpayment: IPayment
{
    public void MakePayment(double Amount)
    {
        Console.WriteLine(Amount);
    }

}
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("payment system");

        IPayment Creditcardpayment = new Creditcardpayment();
        IPayment Paypalpayment = new Paypalpayment();
        IPayment UPIpayment = new UPIPayment();

        double amount = 1000;

        Console.WriteLine("using credit card");
        Creditcardpayment.MakePayment(amount);
        Console.WriteLine("using paypal");
        Paypalpayment.MakePayment(75.25);
        Console.WriteLine("using UPI");
        UPIpayment.MakePayment(50.00);

        
    }
}

   