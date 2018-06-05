using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Computer
    {
        public string FirstName { get; set; }
        public int Play()
        {
            Random r = new Random();
            var num = r.Next(1, 4);
            switch (num)
            {
                case 1:FirstName = "石头";break;
                case 2:FirstName = "剪刀";break;
                case 3: FirstName = "布";break;
                
            }
            return num;
        }
    }
}
