
using SHOPFLIX;
using System;

Console.ReadLine();

var fullOrder = new FullOrder()
{
    Name = "Test",
    Number = 12,
     Email = "paplabros@gmail.com"
    //RecepientEmail = "paplabr@gmail.com",
};

var order = new Order()
{
    Name = "Test",
    RecepientEmail = "paplabr@gmail.com",
};

public class BaseOrder
{
    public string Name { get; set; }

    public int Number { get; set; }

    public int Weight { get; set; }
}

public class Order : BaseOrder
{
    public string RecepientEmail { get; set; }
}

public class FullOrder : BaseOrder
{
    public string Address { get; set; }

    public string Email { get; set; }


    public object PaymentMethod { get; set; }
}