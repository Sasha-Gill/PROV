using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_klasser_Sasha_Gill_TE17A
{
    class book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed = false;
        private Random generator;



       public book()
        {
            generator = new Random();
            rarity = generator.Next(100);
            actualValue = generator.Next(1000);

            
        }
     

        public void PrintInfo()
        {
            Console.WriteLine("Denna bok heter " + name+".");
            Console.WriteLine("Denna bok är "+rarity+"% sällsynt.");
            Console.WriteLine("Denna bok tillhör kategorin "+category+".");
            Console.WriteLine("Denna bok kostar "+price+"kr.");
            Console.ReadLine();
        }

        public int Evaluate()
        {
            int finalPrice = actualValue * rarity;
            return finalPrice;
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }







    }
}