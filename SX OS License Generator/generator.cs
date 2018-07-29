using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SX_OS_License_Generator
{
    class generator
    {
        public string code;

        static Random rand = new Random();
        static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static char letter = chars[rand.Next(0, chars.Length - 1)];
        static string nums = "1234567890";
        static int num = rand.Next(0, nums.Length - 1);

        public string getCode()
        {
            string randomCode = "";
            for (int i = 0; i < 12; i++)
            {
                if (i < 10)
                {
                    randomCode += chars[rand.Next(0, chars.Length - 1)];
                }
                else if (i > 9)
                {
                    randomCode += rand.Next(0, nums.Length - 1);
                }
            }
            return randomCode;
        }

        public void wait(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

    }
}
