using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICalling
    {
        public string Number { get ; set; }

        public void CheckIfValid()
        {
            foreach (var ch in Number)
            {
                if (!char.IsDigit(ch))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }
            if(Number.Length == 7)
            {
                Console.WriteLine($"Dialing... {Number}");
            }
        }
    }
}
