using System;

public class Sandwich : SandwichPrototype
{
    private string Bread;
    private string Meat;
    private string Cheese;
    private string Veggies;

    public Sandwich(string bread, string meat, string cheese, string veggies) {
        Bread = bread;
        Meat = meat;
        Cheese = cheese;
        Veggies = veggies;
    }
    
    public override SandwichPrototype Clone() {
        string ingredientList = GetIngredientList();
        Console.WriteLine("Cloning sandwich with the ingredients: {0}", ingredientList.Remove(ingredientList.LastIndexOf(",")));
        return MemberwiseClone() as SandwichPrototype; ;
    }
    
    private string GetIngredientList() {}
    
    
}
