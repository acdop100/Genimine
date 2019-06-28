using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace GameTest.Data
{
    // Holds data for every asteroid field in orbit.
    public class AsteroidField
    {
        private readonly int TempRandom1;
        private readonly int TempRandom2;

        public readonly int DimensionMax;

        public Dictionary<(int, int), Asteroids> AllAsteroids { get; set; }

        public AsteroidField(int NumOfPlayers)
        {
            DimensionMax = 200 + (100 * NumOfPlayers);

            AllAsteroids = new Dictionary<(int, int), Asteroids>(DimensionMax);

            int NumOfAsteroids = NumOfPlayers * new Random().Next(8, 17);

            // For each asteroid that we should have, pick a random spot in the field (that is not occupied) and put a new asteroid there.
            for (int asteroid = 0; asteroid < NumOfAsteroids; asteroid++)
            {
                do
                {
                    TempRandom1 = new Random().Next(10, DimensionMax - 10);
                    TempRandom2 = new Random().Next(10, DimensionMax - 10);
                }
                while (!AllAsteroids.ContainsKey((TempRandom1, TempRandom2)));

                AllAsteroids.Add((TempRandom1, TempRandom2), new Asteroids(asteroid));
            }
        }
    }

    public class Asteroids
    {
        // Amount of resources this asteroid has before it runs out.
        public int Resources { get; set; }

        // ID to help miners know which asteroid they are to mine,
        public int AsteroidID { get; set; }

        // Generate a random size(to do) and amount of resources in each asteroid.
        public Asteroids(int num)
        {
            Resources = new Random().Next(20, 101);
            AsteroidID = num;
        }
    }
}