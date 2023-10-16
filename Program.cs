using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main()
        {

            Driver time = Driver.TimeSet(DateTime.Now);
            Driver surucu1 = new Driver("Veli", "22", "2021", "beyaz Bentley");
            Driver surucu2 = new Driver("Ramazan", "24", "2012", "gri Symbol");

            Console.WriteLine("Yarış " + time.Time.ToLongTimeString() + "'da başladı.\n" + surucu1.Name + " " + surucu1.Age + " yaşında," + 
            surucu1.GetModel() + " model " + surucu1.GetMarka() + " aracı ile "+(time.Time.AddSeconds(1) - time.Time) + " fark ile yarışa başladı.");

            Console.WriteLine(surucu2.Name + " " + surucu2.Age + " yaşında," + surucu2.GetModel() + " model " + surucu2.GetMarka() + " aracı ile " + 
            (time.Time.AddSeconds(5) - time.Time)+" fark ile yarışa başladı.");
        }

         public class Car
         {
            //Araba özellikleri
            public string Marka { get; set; }
            public string Model { get; set; }

            public void car(string marka, string model)
            {
                Marka = marka;
                Model = model;
            }

         }

        public class Driver
        {

            Car car = new Car();

            //Sürücü Bilgileri
            public string Name { get; set; }
            public string Age { get; set; }
            public void SetModel(string Model) { Model = this.car.Model; }
            public string GetModel() { return this.car.Model; }
            public void SetMarka(string Marka) {  Marka =this.car.Marka ; }
            public string GetMarka() { return this.car.Marka; }



            //Başlangıç Zamanı Singleton
            public DateTime Time { get; set; }
            public  Driver(string name, string age,string model,string marka)
            {
                Name = name;
                Age = age;
                this.car.Model = model;
                this.car.Marka = marka;
                

            }
            private Driver(DateTime time)
            {
                Time = time;
            }
            private static Driver nesne2;
            public static Driver TimeSet(DateTime time)
            {
                if (nesne2 == null)
                {
                    nesne2 = new Driver(time);
                }
                return nesne2;
            }
         }
    }
}