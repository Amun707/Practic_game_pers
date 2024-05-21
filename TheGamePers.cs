using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_game_pers
{
    public class TheGamePers
    {
       
            string Name { get; set; }
            string Raise { get; set; }

            public T Weapon { get; set; }

            public TheGamePers(string name, string raise, T weapon)
            {
                Name = name;
                Raise = raise;
                Weapon = weapon;
            }

            public void Print()
            {
                Console.WriteLine($"Имя: {Name}, Расса: {Raise}, Оружие: ");
                
            }
        }

    }

