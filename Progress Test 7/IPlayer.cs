using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Test_7
{
    public interface IPlayer
    {
        string Name { get; }
        int Age { get; }
        int Attack { get; }
        int Defense { get; }
        int Stamina { get; }
        int Speed { get; }
        int Power { get; }
        void GetInfo();
    }

}
