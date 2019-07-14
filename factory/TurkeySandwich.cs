//Concrete creator
class TurkeySandwich : Sandwich {
    
    public override void CreateIngredient() {
        Ingredients.Add(new Bread());
        Ingredients.Add(new Mayonnaise());
        Ingredients.Add(new Turkey());
        Ingredients.Add(new Turkey());
        Ingredients.Add(new Bread());
    }
}