using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib, mis hinde kasutaja sai;
            //Kui kasutaja sai 'A', konsool kuvab "Suurepärane!";
            //'B', konsool kuvab "Väga hea!";
            //'C', konsool kuvab "Hea!";
            //'D', konsool kuvab "Rahuldav";
            //'E', konsool kuvab "Kasin";
            //'F', konsool kuvab "Puudulik";
            //Kui kasutaja sisestab midagi muud, siis konsool kuvab vale väärtus;

            Console.WriteLine("Palun sisestage oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Śuurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Vale väärtus!");
            }

        }
    }
}
