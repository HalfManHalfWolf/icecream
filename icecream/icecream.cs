public class IceCream
{
    string Flavor { get; set; }
    double Cost { get; set; }

    IceCream(string Flavor, double Cost)
    {
        Flavor = Flavor;
        Cost = Cost;
    }
}