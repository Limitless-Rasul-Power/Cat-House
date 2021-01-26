using System;
using System.Text;

namespace Cat_House
{
    public class Cat
    {
        private int _mealQuantityOfCatToday = default;
        public string NickName { get; set; } = String.Empty;
        private int _age;
        private int _mealQuantity;
        private double _price;
        public int Energy { get; private set; } = 100;
        private string _gender;

        public Cat(in string nickName, in int age, in int mealQuantity, in double price, in string gender)
        {
            NickName = nickName;
            Age = age;
            MealQuantity = mealQuantity;
            Price = price;
            Gender = gender;
            _mealQuantityOfCatToday = (MealQuantity * 10) / 100;
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidOperationException("Age must be more than -1.");

                _age = value;
            }
        }
        public int MealQuantity
        {
            get
            {
                return _mealQuantity;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Meal Quantity must be more than 0.");

                _mealQuantity = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Price must be more than 0.");

                _price = value;
            }
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value.Trim().ToLower() != "male" && value.Trim().ToLower() != "female")
                    throw new InvalidOperationException("Gender must be \"Male\" or \"Female\"");

                _gender = value;
            }
        }

        public void Eat()
        {
            if (Energy == 0)
            {
                Console.WriteLine("Energy is 0 go to sleep. Cat can't eat something with 0 Energy.");
                return;
            }

            CatPropertyOperations.IncrementPrice(ref _price);
            CatPropertyOperations.IncrementMealQuantity(ref _mealQuantityOfCatToday);
            const int eatingEnergy = 20;
            if (Energy + eatingEnergy <= 100)
                Energy += eatingEnergy;
        }
        public void Play()
        {
            const int playEnergy = 10;
            if (Energy - playEnergy >= 0)
                Energy -= playEnergy;
            else
                Console.WriteLine("Energy is 0 go to sleep. Cat can't play with 0 Energy.");
        }
        public void Sleep()
        {
            const int sleepEnergy = 50;
            if (Energy + sleepEnergy <= 100)
                Energy += sleepEnergy;
        }

        public void Show()
        {
            string trimVersionOfGender = Gender.Trim();

            StringBuilder gender = new StringBuilder();
            gender.Append(char.ToUpper(trimVersionOfGender[0]))
                  .Append(trimVersionOfGender.Substring(1));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Cat Nick Name: {NickName}");
            Console.WriteLine($"Cat Age: {Age} years old");
            Console.WriteLine($"Cat Meal Quantitiy: {MealQuantity} gr");
            Console.WriteLine($"Cat Price: {Price} $");
            Console.WriteLine($"Cat Gender: {gender}");
            Console.WriteLine($"Cat Energy: {Energy}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cat Meal Quantity Today: {_mealQuantityOfCatToday} gr");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
