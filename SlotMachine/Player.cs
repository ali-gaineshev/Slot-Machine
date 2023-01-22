using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Player
    {
        //modify this by adding email,phone and any other additional details
        public string name;
        public int money;
        public Player(string name,int money)
        {
            this.name = name;
            this.money = money;
        }
        public int get_money()
        {
            return money;
        }
        public string get_user()
        {
            return name;
        }
        public void add_money(int add)
        {
            this.money += add;
        }
        public void lose_money(int lost)
        {
            this.money -= lost;
        }
    }
}
