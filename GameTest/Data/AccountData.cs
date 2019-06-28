using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameTest.Data
{
    public class AccountData
    {
        // Stores the player's current level.
        public int PlayerLevel { get; set; }

        // Stores the amount of money the player has.
        public int Money { get; set; }

        // Stores all of the buildings that the player owns with any relevant data.
        public List<Buildings> Buildings { get; set; }

        // Stores all of the vehicles that the player owns with any relevant data.
        public List<Vehicles> Vehicles { get; set; }
    }
}