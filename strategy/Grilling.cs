/// <summary>
/// A Concrete Strategy class
/// </summary>
class Grilling : CookStrategy
{
    public override void Cook(string food)
    {
        Console.WriteLine("\nCooking " + food + " by grilling it.");
    }
}