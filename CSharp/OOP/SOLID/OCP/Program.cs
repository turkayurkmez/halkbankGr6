// See https://aka.ms/new-console-template for more information
Customer customer = new Customer() { Name = "TÜRKAY", CartType = new GoldCart() };
OrderManager orderManager = new OrderManager() { Customer = customer };
Console.WriteLine(orderManager.GetDiscountedPrice(1000));

Console.WriteLine("Hello, World!");
//OCP; Open-Closed Principle
//Bir nesne gelişime AÇIK değişime KAPALI olmalı.




public abstract class CartType
{
    public abstract double GetDiscountedPrice(double totalPrice);

}

class StandardCart : CartType
{
    public override double GetDiscountedPrice(double totalPrice)
    {
        return totalPrice * .95;
    }
}

class SilverCart : CartType
{
    public override double GetDiscountedPrice(double totalPrice)
    {
        return totalPrice * .90;
    }
}
class GoldCart : CartType
{
    public override double GetDiscountedPrice(double totalPrice)
    {
        return totalPrice * .85;
    }
}
class PremiumCart : CartType
{
    public override double GetDiscountedPrice(double totalPrice)
    {
        return totalPrice * .80;
    }
}

public class Customer
{
    public string Name { get; set; }
    public CartType CartType { get; set; }

}

public class OrderManager
{
    public Customer Customer { get; set; }
    public double GetDiscountedPrice(double totalPrice)
    {
        double price = Customer.CartType.GetDiscountedPrice(totalPrice);

        return price;
    }
}