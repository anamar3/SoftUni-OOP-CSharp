using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalling,IBrowsing
    {
       
       
        public string Number { get ; set; }
        public string URL { get ; set; }

        public void CheckIfValid()
        {
            foreach (var ch in Number)
            {
                if(!char.IsDigit(ch))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }
            if (Number.Length == 10)
            {
                Console.WriteLine($"Calling... {Number}");
            }
        }

        public void CheckURL()
        {
            foreach (var ch in URL)
            {
                if(char.IsDigit(ch))
                {
                    Console.WriteLine($"Invalid URL!");
                    return;
                }    
            }
            Console.WriteLine($"Browsing: {URL}!");
        }
    }
}
