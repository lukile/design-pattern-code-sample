public class Town {
    private static Town instance = new Town();

    public static Town GetInstance() {
        if(instance == null) {
            instance = new Town();
        } else {
            return instance;
        }
    }
}