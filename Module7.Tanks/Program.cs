using MyClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<Tank> t34 = new List<Tank>();
            List<Tank> panteras = new List<Tank>();
            Tank t_34 = new Tank();
            Tank pantera = new Tank();
            Tank result = new Tank();

            int countOfTanks = 5;

            for (int i = 0; i < countOfTanks; i++)
            {
                t_34 = new Tank("T-34", rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                pantera = new Tank("Pantera", rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                //tanks.Add(t_34);
                //tanks.Add(pantera);
                t34.Add(t_34);
                panteras.Add(pantera);

            }

            War(t34, panteras, countOfTanks);



        }
        static void War(List<Tank> t34, List<Tank> panteras, int countOfTanks)
        {
            for (int i = 0; i < countOfTanks; i++)
            {
                Console.WriteLine("Пара №{0}", i + 1);
                Tank.PrintInfo(t34[i], panteras[i]);

                if (t34[i] ^ panteras[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Победитель сражения: T-34\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Победитель сражения: Pantera\n");
                    Console.ResetColor();
                }


            }
        }

    }


}
