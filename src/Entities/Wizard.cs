using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPGcomPOO.src.Entities
{
    class Wizard:Hero
    {
        public Wizard(string name, int level, string heroType,int hp,int mp):base(name,level,heroType,hp,mp)
        {
          
        }
        public override string  Ataque() 
        {
            return base.Name + " Lançou magia";
        }

        public override string Ataque(int bonus) 
        {
            if (bonus > 6) 
            {
                return base.Name + " Lançou uma magia super efetiva com bônus de " + bonus;
            }
            else 
            {
                return base.Name + " Lançou magia com força fraca com bônus de ataque de " + bonus;
            }
        }
    }
}
