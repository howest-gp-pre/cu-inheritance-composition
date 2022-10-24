namespace Pre.Animal.Comopsition.Core;

public class Lion: Animal
{
    public string JungleName { get; set; }
    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("guzzle, slurp"); 
    }

    public void Roar()
    {
        Console.WriteLine("Roarr!");
    }
}