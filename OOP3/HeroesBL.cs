using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{

    internal class HeroesBL
    {
        public IHeroesDAL heroesDAL;


        public HeroesBL(IHeroesDAL heroesDAL)
        {
            this.heroesDAL = heroesDAL;
        }
        public List<Heroes> GetAllHeroes()
        {
            return heroesDAL.SelectAllHeroes();
        }
        public void NewHero()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("HP: ");
            int hp = Convert.ToInt32(Console.ReadLine());
            Console.Write("DPS: ");
            int dps = Convert.ToInt32(Console.ReadLine());
            heroesDAL.AddHero(name, hp, dps);
        }
    }
}
