using System;
using System.Collections.Generic;
using System.Text;


    public interface IBuyer
    {
    public string Name { get; }
        public void BuyFood();
        public int Food { get; }
    }

