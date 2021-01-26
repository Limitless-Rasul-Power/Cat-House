namespace Cat_House
{
    public class CatPropertyOperations
    {
        static public void IncrementPrice(ref double price) => price += (price * 10.0) / 100.0;
        static public void IncrementMealQuantity(ref int mealQuantity) => mealQuantity += (mealQuantity * 85) / 100;
    }
}
