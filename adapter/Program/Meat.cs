using System;

public class Meat {
    protected string MeatName;
    protected float SafeCookTempFahrenheit;
    protected float SafeCookTempCelsius;
    protected double CaloriesPerOunce;
    protected double ProteinPerOunce;

    public Meat(string meat) {
        this.MeatName = meat;
    }
    
    public virtual void LoadData() {
        Console.WriteLine("\nMeat: {0} ------ ", MeatName);
    }
}
