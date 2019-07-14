/// <summary>
/// A Concrete Strategy class
/// </summary>
class OvenBaking : CookStrategy
{
    public override void Cook(string food)
    {
        Console.WriteLine("\nCooking " + food + " by oven baking it.");
    }
}