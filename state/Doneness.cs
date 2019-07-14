abstract class Doneness {
    protected Steak steak;
    protected double currentTemp;
    protected double lowerTemp;
    protected double upperTemp;
    protected bool canEat;

    public Steak steak {
        get { return steak; }
        set { steak = value; }
    }

    public double CurrentTemp {
        get { return currentTemp; }
        set { currentTemp = value; }
    }

    public abstract void AddTemp (double temp);
    public abstract void RemoveTemp(double temp);
    public abstract void DonenessCheck();
}