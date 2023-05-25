namespace ISP.Bad
{
    internal class Waiter : IRestaurantEmployee
    {
        public void CookFood()
        {
            throw new InvalidOperationException("cooking food is not part of waiter's job.");
        }

        public void ServeCustomer()
        {
            Console.WriteLine("Serving the customers");
        }

        public void WashDishes()
        {
            throw new InvalidOperationException("Dish washing is not part of waiter's job.");
        }
    }
}
