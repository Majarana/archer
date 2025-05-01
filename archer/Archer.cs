using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace archer
{
    public class Archer
    {
        string Name { get; set; }
        int NumberOfArrows { get; set; }
        private bool isName = false;

        public Archer(string name, int numberOfArrows)
        {
            Name = name;
            NumberOfArrows = numberOfArrows;
        }

        public void ShootArrow()
        {
            if (NumberOfArrows > 0)
            {
                NumberOfArrows = NumberOfArrows - 1;
                Console.WriteLine($"{Name} successfully shot an arrow.");
            }
            else
            {
                Console.WriteLine($"{Name} doesn't have enough arrows.");
            }
        }
        public void AddArrows(int number)
        { 
            while (number < 0) 
            {
                Console.WriteLine("Please enter a positive number.");
                number= int.Parse(Console.ReadLine());
            }

            if (number == 0)
            {
                Console.WriteLine($"{number} arrows were added.");
                ViewStatus();
            }
            else
            {
                NumberOfArrows = NumberOfArrows + number;
                Console.WriteLine(number == 1 ? $"{number} arrow was added." : $"{number} arrows were added!");
                ViewStatus();
            }
        }
        public void ViewStatus()
        {
            if (!isName)
            {
                Console.WriteLine($"Archer´s name is {Name}!");
                isName = true;
            }
            Console.WriteLine($"{Name} has got {NumberOfArrows} arrow{(NumberOfArrows == 1 ? "" : "s")} in total.");
        }
    }
}

