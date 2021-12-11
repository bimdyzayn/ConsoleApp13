using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            building.Print("Информация о здании Building", "");
            building.Print("Адрес здания", building.adress);
            building.Print("Длина здания", building.lengh);
            building.Print("Высота здания", building.widh);
            building.Print("Ширина здания", building.height);

            MultiBuilding multiBuilding = new MultiBuilding();

            multiBuilding.Print("Информация о здании MultiBuilding", "");
            multiBuilding.Print("Адрес здания", multiBuilding.adress);
            multiBuilding.Print("Длина здания", multiBuilding.lengh);
            multiBuilding.Print("Высота здания", multiBuilding.widh);
            multiBuilding.Print("Ширина здания", multiBuilding.height);
            multiBuilding.Print("Этажность", multiBuilding.level);

            Console.ReadLine();

        }
    }
    class Building
    {
        public string adress { get; set; }
        public string lengh { get; set; }
        public string widh { get; set; }
        public string height { get; set; }
        public Building()
        {
            adress = "Вузовкое озеро 19";
            lengh = "20";
            widh = "30";
            height = "40";
         
        }
        public void Print (string key, string value)
        {
            Console.WriteLine(key+":"+value);

            
        }
     
    }

    sealed class MultiBuilding: Building
    {

        public string level { get; set; }

        public MultiBuilding()
        {
     
            level = "15";

        }
        public void Print(string key, string value)
        {
            base.Print(key, value);


        }

    }

    }

