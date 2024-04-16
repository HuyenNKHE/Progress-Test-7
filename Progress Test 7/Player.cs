using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Test_7
{
    using System;

    public class Player : IPlayer
    {
        public string Name { get; }
        public int Age { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Stamina { get; }
        public int Speed { get; }
        public int Power { get; }

        public Player(string name, int age, int attack, int defense, int stamina, int speed, int power)
        {
            Name = name;
            Age = age;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
            Speed = speed;
            Power = power;
        }

        public void GetInfo()
        {
            double average = (Attack + Defense + Stamina + Speed + Power) / 5.0;
            Console.WriteLine($"Name: {Name}, Age: {Age}, Average points: {average:F2}");
        }
    }
}
