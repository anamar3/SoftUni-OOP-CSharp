using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNums = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string[] sites = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < phoneNums.Length; i++)
            {
                if (phoneNums[i].Length == 10)
                {
                    Smartphone smartphone = new Smartphone();
                    smartphone.Number = phoneNums[i];
                    smartphone.CheckIfValid();

                }
                else if (phoneNums[i].Length == 7)
                {
                    StationaryPhone stphone = new StationaryPhone();
                    stphone.Number = phoneNums[i];
                    stphone.CheckIfValid();
                }
            }
            for (int i = 0; i < sites.Length; i++)
            {
                Smartphone smartphone = new Smartphone();
                smartphone.URL = sites[i];
                smartphone.CheckURL();
            }

        }
    }
}
