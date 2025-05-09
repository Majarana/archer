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
            if (number > 0)
            {
                NumberOfArrows = NumberOfArrows + number;
                Console.WriteLine($"{number} arrows were added. Archer have {NumberOfArrows} now.");
            }
            else
            {
                Console.WriteLine($"You can add positive number of arrows.");
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

