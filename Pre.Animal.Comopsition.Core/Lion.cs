namespace Pre.Animal.Comopsition.Core;

public class Lion
{
    public string JungleName { get; set; }

    private Animal _animal;
    public string Color
    {
        get => _animal.Color;
        set => _animal.Color = value;
    }
    public Lion()
    {
        _animal = new Animal();
    }
    
    public void Eat()
    {
        _animal.Eat();    
        Console.WriteLine("guzzle, slurp"); 
    }

    public void Roar()
    {
        Console.WriteLine("Roarr!");
    }
}