using System;
using System.Collections.Generic;



    public class order
    {
    public List<IceCream> items { get; set; }
    public double TotalCost { get; set; }

    public order() 
    { 
        items = new List<IceCream>();
        TotalCost = 0;
    
    }

    public void Add(IceCream icecream) 
    {
        items.Add(icecream);
        TotalCost += icecream.Cost;
    }

    public void ShowOrder()
    {
        Console.WriteLine("Your order:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Flavor} - ${item.Cost}" );
        }
        Console.WriteLine($"Total Cost: $(TotalCost)");
    }
    }

