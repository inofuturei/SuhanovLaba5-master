using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationDemo
{
    public class OrderService
    {
        private readonly ILogger _logger;

        public OrderService(ILogger logger)
        {
            _logger = logger;
        }

        public void PlaceOrder(string product)
        {
            _logger.Log($"Order placed for: {product}");
        }
    }

}
