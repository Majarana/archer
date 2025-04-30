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
            NumberOfArrows = NumberOfArrows + number;
            Console.WriteLine(number == 1 ? $"{NumberOfArrows} arrow was added. Now {Name} has got {NumberOfArrows} arrow in total. " : $"{NumberOfArrows} arrows were added! Now {Name} has got {NumberOfArrows} arrows in total.");
        }
        public void ViewStatus()
        {
            Console.WriteLine($"Archer´s name is {Name}!");
            Console.WriteLine($"{Name} has got {NumberOfArrows} arrows in total!");
        }
    }
}

