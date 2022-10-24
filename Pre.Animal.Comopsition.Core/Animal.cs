namespace Pre.Animal.Comopsition.Core;

public class Animal
{
    public string Color { get; set; }

    public virtual void Eat()
    {
        Console.WriteLine("processing food");
    }
}