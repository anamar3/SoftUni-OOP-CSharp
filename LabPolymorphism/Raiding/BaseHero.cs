using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            Name = name;
            
        }
        public virtual int Power { get; private set; }
        public string Name { get; private set; }

        public virtual void CastAbility()
        {
            
        }
    }
}
