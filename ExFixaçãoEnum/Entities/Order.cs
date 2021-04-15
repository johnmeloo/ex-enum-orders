using System;
using ExFixaçãoEnum.Entities;
using ExFixaçãoEnum.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace ExFixaçãoEnum.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status)
        {
            Date = date;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(double price, int quantity)
        {
            double sum = 0.0;
            foreach (OrderItem order in Items)
            {
                sum += order.SubTotal();
            }
            return sum;
        }
    }
}
