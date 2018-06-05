using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Player
    {
        public string FirstName { get; set; }
        public int Play(string name)
        {
            this.FirstName = name;
            switch (name)
            {
                case "石头": return 1;
                case "剪刀": return 2;
                case "布": return 3;
                default: return 0;
            }

        }
    }
}
