using System;
interface Ipayment
{
    void makepayment(double amount);
    
}
class creaditcardpayment : Ipayment
{
    public void makepayment(double amount)
    {
        Console.WriteLine($"payment of {amount:c}  made using creaditcard");
    }
    
}
class paypalpayment : Ipayment
{
    public void makepayment(double amount)
    {
        Console.WriteLine($"payment of {amount:c} made using paypal");
    }
}
class upipayment : Ipayment
{
    public void makepayment(double amount)
    {
        Console.WriteLine($"payment of {amount:c} made using upi");
    }
}
class program
{
    static void Main()
    {
        Ipayment creaditcard = new creaditcardpayment();
        Ipayment paypal = new paypalpayment();
        Ipayment upi = new upipayment();
        creaditcard.makepayment(10000);
        paypal.makepayment(20000);
        upi.makepayment(30000);

    }
}
