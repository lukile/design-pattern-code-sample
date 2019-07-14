public abstract class SoftDrink {
   
    public int Calories { get; set; }
    public List<SoftDrink> Flavors { get; set; }

    public SoftDrink(int calories) {
        Calories = calories;
        Flavors = new List<SoftDrink>();
    }

    public void DisplayCalories() {
        Console.WriteLine(this.GetType().Name + " : " + this.calories.ToString() + " calories.");

        foreach (var drink in this.Flavors) {
            drink.DisplayCalories;
        }
    }
}

