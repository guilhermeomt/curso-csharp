namespace Course.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public double subTotal()
        {
            return Quantity * Price;
        }
    }

}