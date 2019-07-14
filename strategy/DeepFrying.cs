/// <summary>
/// A Concrete Strategy class
/// </summary>
class DeepFrying : CookStrategy
{
    public override void Cook(string food)
    {
        Console.WriteLine("\nCooking " + food + " by deep frying it");
    }
}