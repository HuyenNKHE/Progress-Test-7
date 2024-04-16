using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Test_7
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Club<T> : IEnumerable<T> where T : IPlayer
    {
        private List<T> players = new List<T>();

        public event ActionDelegate AttackEvent;
        public event ActionDelegate DefenseEvent;

        public void Add(T player)
        {
            players.Add(player);
            double average = (player.Attack + player.Defense + player.Stamina + player.Speed + player.Power) / 5.0;
            if (average > 80)
            {
                AttackEvent += player.GetInfo;
            }
            else if (average > 60 && average <= 80)
            {
                DefenseEvent += player.GetInfo;
            }
        }

        public void RaiseAttackEvent()
        {
            AttackEvent?.Invoke();
        }

        public void RaiseDefenseEvent()
        {
            DefenseEvent?.Invoke();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
