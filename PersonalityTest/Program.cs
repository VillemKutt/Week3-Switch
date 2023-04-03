﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityTest
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
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");

            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");

            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
