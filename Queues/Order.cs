using System.Data;
using System.Xml.Linq;

namespace Queues
{
    class Order
    {
        private int OrderId { get; set; }
        private int NumberOfItems { get; set; }

        public Order(int orderId, int numberOfItems)
        {
            this.OrderId = orderId;
            this.NumberOfItems = numberOfItems;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, Name: {NumberOfItems}";
        }
    }
}