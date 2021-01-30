using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public class Product : IEntity  // public yaptığımız zaman bu classa diğer katmanlarda ulaşabilir demek. 
        //internal demek zaten o klasör ulaşabilir demek yani entities
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
