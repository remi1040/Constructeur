using Constructeur;

class Program
{
    public static void Main(string[] args)
    {
        Building b1 = new Building(5,20);
        Building b2 = new Building(10);

        Console.WriteLine(b1.GetFloorMaxSize());
        
        Console.WriteLine(b2.GetSize());
    }
}