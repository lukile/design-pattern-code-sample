//Creator
abstract class Sandwich {
    private List<Ingredient> _ingredient = new List<Ingredient>();

    public Sandwich() {
        CreateIngredient();
    }

    //FACTORY METHOD
    public abstract void CreateIngredient();

    public List<Ingredient> Ingredients {
        get { return _ingredient; }
    }
}