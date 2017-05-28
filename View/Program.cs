using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Model;

namespace View
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("FR001: Создаем Ладу (D) и красим в баклажановый цвет.");
            Car lada = new Car("Lada", Category.D);
            lada.Color = Color.Purple;
            Console.WriteLine($"FR001: Создано - {lada.Model}, Цвет - {lada.Color}");

            Console.WriteLine("\nFR002: Выводим имя водителя.");
            try
            {
                Console.WriteLine(lada.CarPassport.Owner.Name);
            }
            catch (Exception ex)
            {
                if (ex.GetType().Equals(typeof(NullReferenceException)))
                    Console.WriteLine("Водителя нет.");
            }
            
            Console.WriteLine("\nFR003: Нанимаем Вольдемара и выдаем ему права категории B и C.");
            Driver voldemar = new Driver(new DateTime(2001,9,11), "Voldemar" );
            voldemar.Category = Category.B | Category.C;
            Console.WriteLine($"FR003: Наняли - {voldemar.Name}, Права категории - {voldemar.Category}, Стаж - {voldemar.Experience} лет");


            Console.WriteLine("\nFR004: Даем Вротлемару Ладу и номер о777оо.");
            try
            {
                lada.ChangeOwner(voldemar, "o777oo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine("\nFR005: Добавим Вольдемару категорию D и назначаем водителем Лады еще раз.");
            voldemar.Category = voldemar.Category | Category.D;
            try
            {
                lada.ChangeOwner(voldemar, "o777oo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            Console.WriteLine("\nFR006: Выводим номер машины Вольдемара.");

            try
            {
                Console.WriteLine(voldemar.Car.CarNumber);
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(NullReferenceException))
                {
                    Console.WriteLine("Номера нет");
                }
            }
            Console.WriteLine("\nFR007: Выводим имя владельца Лады");

            try
            {
                Console.WriteLine(lada.CarPassport.Owner.Name);
            }
            catch (Exception ex)
            {
                if(ex.GetType() == typeof(NullReferenceException))
                    Console.WriteLine("Водителя нет.");
            }
        }
    }
}