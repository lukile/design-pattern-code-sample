abstract class SandwichBuilder {
    protected Sandwich sandwich;

    public Sandwich sandwich {
        get { return sandwich; }
    }

    public abstract void AddBread();
    public abstract void AddMeats();
    public abstract void AddCheese();
    public abstract void AddVeggies();
    public abstract void AddCondiments();
}