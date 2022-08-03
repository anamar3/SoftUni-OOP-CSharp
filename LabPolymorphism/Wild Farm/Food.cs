using System;
using System.Collections.Generic;
using System.Text;


    public class Food : IFood
    {
        public Food(int quantity)
        {
            Quantity=quantity;
        }
        public int Quantity { get; set; }
    }

