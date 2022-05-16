using System;
using System.Collections.Generic;

namespace OOP3
{

    class Program
    {
        static void Main(string[] args)
        {
            HeroesBL heroesBL = new HeroesBL(new HeroesDAL());
            heroesBL.NewHero();
            List<Heroes> heroesList = heroesBL.GetAllHeroes();

            foreach (Heroes h in heroesList)
            {
                Console.WriteLine("Name: {0}, HP: {1}, DPS: {2}", h.Name, h.HP, h.DPS);
            }
        }
    }
}
