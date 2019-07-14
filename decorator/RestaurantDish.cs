//Abstract Component class
abstract class RestaurantDish {
    public abstract void Display();
} 


//Concrete Component class
class FreshSalad : RestaurantDish {
    private string _greens;
    private string _cheese;
    private string _dressing;

    public FreshSalad(string greens, string cheese, string dressing) {
        _greens = greens;
        _cheese = cheese;
        _dressing = dressing;
    }

    public override void Display() {
        Console.WriteLine("\nFresh Salad:");
        Console.WriteLine(" Greens: {0}", _greens);
        Console.WriteLine(" Cheese: {0}", _cheese);
        Console.WriteLine(" Dressing: {0}", _dressing);
    }
}

//Concrete Component class
class Pasta : RestaurantDish {
    private string _pastaType;
    private string _sauce;

    public Pasta(string pastaType, string sauce) {
        _pastaType = pastaType;
        _sauce = sauce;
    }

    public override void Display(){
        Console.WriteLine("\nClassic Pasta:");
        Console.WriteLine(" Pasta: {0}", _pastaType);
        Console.WriteLine(" Sauce: {0}", _sauce);
    }

}