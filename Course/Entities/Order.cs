using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace Course.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double totalSum = 0f;

            foreach (OrderItem item in Items)
            {
                totalSum += item.subTotal();
            }

            return totalSum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToShortDateString() + ')' + " - " + Client.Email);
            sb.AppendLine("Order items: ");
            
            foreach(OrderItem item in Items)
                sb.AppendLine($"{item.Product.Name}, ${item.Price.ToString("F2",CultureInfo.InvariantCulture)}, " +
                $"Quantity: {item.Quantity}, Subtotal: {item.subTotal().ToString("F2",CultureInfo.InvariantCulture)}");

            sb.AppendLine("Total price: $" + this.total());
            return sb.ToString();
        }
    }
}