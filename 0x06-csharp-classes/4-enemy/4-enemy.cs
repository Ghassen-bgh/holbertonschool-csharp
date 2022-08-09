using System;

namespace Enemies
{
    /// <summary>
    /// Class Zombie.
    /// </summary>
     class Zombie
    {
        public int health;
        public string name = "(No name)";
        public Zombie()
        {
            health = 0;
            
        }
        public Zombie(int value)
        {
            health = value;
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int GetHealth()
        {
            return health;
        }

    }
}
