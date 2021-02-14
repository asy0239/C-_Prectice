using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.goldPrint();
            p.hp = 293;
            Console.WriteLine("ho : " + p.hp);
        }
    }
}

class Player
{
    public int gold = 1000;
    public int exp = 10;
    public int att = 29;
    public int def = 32;
     
    public int hp
    {
        get; set;
    }
    public void goldPrint()
    {
        Console.WriteLine(gold);
    }

}

class monster
{
    public int hp { get; set;}

    public int def { get; set; }
    
}
