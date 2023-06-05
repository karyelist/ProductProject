using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class ProductLog
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductId { get; set; }

        public string MyProperty { get; set; }
    }
}
