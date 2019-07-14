class Rare : Doneness {

    public Rare(Doneness state) : this(state.CurrentTemp, state.Steak) { } 

    public Rare(double CurrentTemp, Steak steak) {
        this.currentTemp = currentTemp;
        this.steak = steak;
        canEat = true;

        Initialize();
    }

    public void Initialize() {
        lowerTemp = 130;
        upperTemp = 139.999999999;
        canEat = true; 
    }

    public override void AddTemp(double amount)
    {
        currentTemp += amount;
        DonenessCheck();
    }

    public override void RemoveTemp(double amount)
    {
        currentTemp -= amount;
        DonenessCheck();
    }

    public override void DonenessCheck() {
        if (currentTemp < lowerTemp) {
            steak.State = new Uncooked(this);
        } else if (currentTemp > upperTemp) {
            steak.State = new MediumRare(this);
        }
    }
}