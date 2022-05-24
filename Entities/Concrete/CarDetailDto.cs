using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Name { get; set; } //BrandName
        public string ColorName { get; set; }


    }
}
