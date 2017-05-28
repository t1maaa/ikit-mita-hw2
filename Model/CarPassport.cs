using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarPassport
    {
        public Driver Owner { get; set; }
        public Car Car { get; }

       public CarPassport(Car car)
        {
            this.Car = car;
        }
    }
}
