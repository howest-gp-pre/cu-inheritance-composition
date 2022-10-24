namespace Pre.Animal.Comopsition.Core;

public class Dog
{
    private Animal _animal;
    public string Owner { get; set; }

    public string Color
    {
        get => _animal.Color;
        set => _animal.Color = value;
    }

    public Dog()
    {
        _animal = new Animal();
    }

    public void Eat()
    {
        _animal.Eat();
        Console.WriteLine("gobble, chomp, champ");
    }

    public void Bark()
    {
        Console.WriteLine("Bark!");
    }
}