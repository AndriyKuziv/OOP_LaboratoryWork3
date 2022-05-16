using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public interface IHeroesDAL
    {
        List<Heroes> SelectAllHeroes();
        void AddHero(string n, int h, int dps);
    }

    public class HeroesDAL : IHeroesDAL
    {
        List<Heroes> heroesList = new List<Heroes>();

        public void AddHero(string n, int h, int dps)
        {
            heroesList.Add(new Heroes() { Name = n, HP = h, DPS = dps});
        }

        public List<Heroes> SelectAllHeroes()
        {
            //heroesList.Add(new Heroes() { Name = "Sanya", HP = 100, DPS = 200 });
            //heroesList.Add(new Heroes() { Name = "Petya", HP = 500, DPS = 10 });
            //heroesList.Add(new Heroes() { Name = "Taras", HP = 1000, DPS = 2000 });

            return heroesList;
        }
    }
}
