using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada tema lemmik värv;
            //Kui kasutaja sisestab "punane", konsool kuvab "Oled romantiline";
            //Kui kasutaja sisestab "sinine", oled töökas;
            //Kui kasutaja sisestab "roheline", oled looduse sõber;
            //Kui kasutaja sisestab midagi muud, konsool kuvab "Oled {userColor} ükssarvik";

            Console.WriteLine("Palun sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;

                    

            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
