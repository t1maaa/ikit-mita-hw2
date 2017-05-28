using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Flags]
    public enum Category { A = 1, B = 2, C = 4, D = 8, E = 16, F = 32 }
    public class Driver
    {
        public DateTime LicenceDate { get; }
        public string Name { get; }

        public int Experience
        {
            get
            {
                if (DateTime.Today.Month < LicenceDate.Month)
                {
                    return DateTime.Today.Year - LicenceDate.Year - 1;
                }
                else if (DateTime.Today.Month > LicenceDate.Month)
                {
                    return DateTime.Today.Year - LicenceDate.Year;
                }
                else
                {
                    if (DateTime.Today.Day < LicenceDate.Day)
                    {
                        return DateTime.Today.Year - LicenceDate.Year - 1;
                    }
                    else
                    {
                        return DateTime.Today.Year - LicenceDate.Year;
                    }
                }
            }
        }

        public Category Category { get; set;}

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            Car = car;
        }

        public Driver(DateTime licenceDate, string name)
        {
            this.LicenceDate = licenceDate;
            this.Name = name;
        }
    }
}
