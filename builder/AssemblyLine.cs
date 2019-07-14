class AssemblyLine {
    public void Assemble(SandwichBuilder sandwichBuilder) {
        sandwichBuilder.AddBread();
        sandwichBuilder.AddMeats();
        sandwichBuilder.AddCheese();
        sandwichBuilder.AddVeggies();
        sandwichBuilder.AddCondiments();
    }
}