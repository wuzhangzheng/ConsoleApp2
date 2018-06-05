using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Computer
    {
        public string Name { get; set; }
        public int Play()
        {
            Random r = new Random();
            var num = r.Next(1, 4);
            switch (num)
            {
                case 1:Name = "石头";break;
                case 2:Name = "剪刀";break;
                case 3: Name = "布";break;
            }
            return num;
        }
    }
}
