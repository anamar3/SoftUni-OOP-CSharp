using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat: Animal
    {
        public Cat(string name,string FF):base( name, FF)
        {
            
        }
        

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
}
