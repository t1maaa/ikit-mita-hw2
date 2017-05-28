using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public string Model { get; }
        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }//
        public Category Category { get; set; }
        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
                if ((driver.Category & this.Category) != 0)
                {
                    this.CarPassport.Owner = driver;
                    this.CarNumber = carNumber;
                    driver.OwnCar(this);
                }
                else
                {
                    throw new Exception($"Водитель {driver.Name} ({driver.Category}) не соответствует категории ТС {this.Model} ({this.Category})");
                }

        }

        public Car(string model, Category catetgory)
        {
            Model = model;
            Category = catetgory;
            CarPassport = new CarPassport(this);
        }
    }
}
