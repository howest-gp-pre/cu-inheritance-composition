namespace Pre.Animal.Comopsition.Core;

public class Dog: Animal
{
    public string Owner { get; set; }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("gobble, chomp, champ");
    }

    public void Bark()
    {
        Console.WriteLine("Bark!");
    }
}