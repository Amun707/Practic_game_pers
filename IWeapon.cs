using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_game_pers
{
    
    
        public interface IWeapon
        {
            public static string Name { get; set; }
            public int Force { get; set; }
            public string Properties { get; set; }
            public void Print();

        }

    }

