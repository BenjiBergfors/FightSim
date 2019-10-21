using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {
        public int hp;
        public string name;
        static Random generator = new Random();

        public int Attack()
        {
            return generator.Next(11);
            
        }

        public void Hurt(int amount)
        {
            amount = generator.Next(11);
            hp -= amount;                
          
        }
        
        public bool IsAlive = true;


        public int GetHp;
    }


}
