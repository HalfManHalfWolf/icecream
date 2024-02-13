using System;


    public class store
    {
    public void Start()
    {
        Console.WriteLine("Welcome to Cali's Ice Cream!");
        order order = new order();

        while (true)
        {
            Console.WriteLine("Enter flavor:");
            string flavor = Console.ReadLine();
            if (flavor.ToLower() == "done")
            {
                break;
            }
            Console.WriteLine("Enter price:");
            double price;
            IceCream icecream = new Icecream(flavor, cost);
            order.Add(icecream);
        }
        order.ShowOrder();
    }

    }

