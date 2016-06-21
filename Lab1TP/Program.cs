using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1TP
{
    class warrior : InterfaceAtk, InterfaceMove
    {
        int level, x, y, dmg, range;
        String name;

        public warrior(int level, int x, int y, int dmg, int range, String name)
        {
            this.level = level;
            this.x = x;
            this.y = y;
            this.dmg = dmg;
            this.range = range;
            this.name = name;
        }

        public void moveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public int getDmg()
        {
            return this.dmg;
        }

        public int getRange()
        {
            return this.range;
        }

        public void attack()
        {
            Console.WriteLine(this.name + " attacked with " + getDmg() + " damage points");
        }
    }

    class cart : InterfaceMove
    {
        int x, y;

        public cart(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void moveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public void whereIsNow()
        {
            Console.WriteLine("Cart is now in (" + getX() + " , " + getY() + ")");
        }
    }

    class trap : InterfaceAtk
    {
        int dmg, range;

        public trap(int dmg, int range)
        {
            this.dmg = dmg;
            this.range = range;
        }

        public int getDmg()
        {
            return this.dmg;
        }

        public int getRange()
        {
            return this.range;
        }

        public void attack()
        {
            Console.WriteLine("Someone is caught and damaged with " + getDmg().ToString() + " damage points");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            warrior war = new warrior(10, 0, 0, 33, 2, "Dominic");
            war.attack();

            cart old = new cart(1, 0);
            old.moveTo(2, 1);
            old.whereIsNow();

            trap hunt = new trap(20, 1);
            hunt.attack();
            
            Console.ReadKey();
        }
    }
}
