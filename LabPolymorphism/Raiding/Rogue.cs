using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue: BaseHero
    {
        public Rogue(string name) : base(name)
        {

        }
        public override int Power => 80;
        public override void CastAbility()
        {
            Console.WriteLine($"{GetType().Name} - {Name} hit for {Power} damage");
        }
    }
}
