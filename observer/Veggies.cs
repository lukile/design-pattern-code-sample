abstract class Veggies {
    private double _pricerPerPound;
    private List<IRestaurant> _restaurants = new List<IRestaurant>();

    public Veggies(doublee pricerPerPound) {
        _pricerPerPound = pricerPerPound;
    }

    public void Notify() {
        foreach (IRestaurant restaurant in _restaurants) {
            restaurant.Update(this);
        }
    }
}