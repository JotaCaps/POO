// See https://aka.ms/new-console-template for more information
using aula1_enum.Entities.Enums;
using aula1_enum.Entities;
using System;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);
