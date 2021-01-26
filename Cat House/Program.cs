using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cat_House
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(new string(' ', (Console.WindowWidth - "Pet Shop".Length) / 2));
                Console.WriteLine("PET SHOP");
                Console.Write(new string('=', Console.WindowWidth));
                Console.WriteLine();
                Console.ResetColor();

                const int eatCountForCats = 3;
                const int playCountForCats = 5;

                Cat cat1 = new Cat("Micky", 1, 400, 70, "male");
                Cat cat2 = new Cat("Sandora", 2, 250, 30, "male");
                Cat cat3 = new Cat("Elvis", 3, 150, 10, "male");
                Cat cat4 = new Cat("Moral", 3, 300, 50, "female");

                CatHouse catHouse = new CatHouse();
                catHouse.AddCat(cat1);
                catHouse.AddCat(cat2);
                catHouse.AddCat(cat3);
                catHouse.AddCat(cat4);               

                Cat cat5 = new Cat("Nicki", 4, 500, 90, "Female");
                catHouse.AddCat(cat5);

                for (int i = 0; i < playCountForCats; i++)
                {
                    cat1.Play(); cat2.Play(); cat3.Play(); cat4.Play(); cat5.Play();
                }
                for (int i = 0; i < eatCountForCats; i++)
                {
                    cat1.Eat(); cat2.Eat(); cat3.Eat(); cat4.Eat(); cat5.Eat();
                }

                PetShop petShop = new PetShop();
                petShop.AddCatHouse(catHouse);

                petShop.Show();
                Console.WriteLine($"All Cats Price in Cat Houses: {petShop.GetCatsPriceInTheCatHouses()}");
                
                // Cat removedCat = catHouse.RemoveByNickName(cat1.NickName);//works
                // removedCat.Show();
                //Console.WriteLine();
            }
            catch (InvalidOperationException content)
            {
                Console.WriteLine(content);
            }
        }
    }
}
