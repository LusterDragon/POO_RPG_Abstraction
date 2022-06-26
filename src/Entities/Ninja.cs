using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPGcomPOO.src.Entities
{
    class Ninja:Hero
    {
        public Ninja(string name, int level, string heroType,int hp,int mp) : base(name, level, heroType,hp,mp) 
        {
        
        }

        public override string Ataque()
        {
            return base.Name + " Atacou com shurikens";
        }

        public override string Ataque(int bonus)
        {
            if (bonus > 6)
            {
                return base.Name + " Efetuou um ataque de shurikens super efetivo com bônus de " + bonus;
            }
            else
            {
                return base.Name + " Efetuou um ataque de shurikens com força fraca com bônus de ataque de " + bonus;
            }
        }
    }
}
