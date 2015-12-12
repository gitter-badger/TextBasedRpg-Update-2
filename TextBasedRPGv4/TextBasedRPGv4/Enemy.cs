using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGv4
{
    class Enemy
    {

        public int Enemy_HP;
        public int Enemy_MaxDmg; 
        
        public Enemy()
        {
            Enemy_HP = 5;
            Enemy_MaxDmg = 2;
        }
        public int Enemy_hp
        {
            get { return Enemy_HP; }
            set { Enemy_HP = value; }
        }
        public int Enemy_MaxDMG
        {
            get { return Enemy_MaxDmg; }
            set { Enemy_MaxDmg = value; }
        }   
    }
}
