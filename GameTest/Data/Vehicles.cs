using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameTest.Data
{
    public class Vehicles
    {
        // Price to purchase the vehicle.
        public int Cost { get; set; }

        // What is returned when scrapping the vehicle.
        public int Scrap { get; set; }

        // Amount of health the vehicle has.
        public int Health { get; set; }

        // VehicleSize determines how many vehicle storage bays the vehicle takes up.
        public int Size { get; set; }

        // Stores how many times this vehicle can be built.
        public int Available { get; set; }

        // How fast the vehicle does its task.
        public int WorkerSpeed { get; set; }

        // How fast the vehicle moves.
        public int MoveSpeed { get; set; }
    }

    // Miners have no shields and are the only vehicles who can mine resources.
    public class Miner : Vehicles
    {
        // Amount of total storage the miner has.
        public int Storage { get; set; }

        // Amount of storage that is in use.
        public int StorageUsed { get; set; }

        // Which Processing plant to give resources to.
        public int AssignedPlant { get; set; }

        // Which asteroid the miner is assigned to.
        public int AssignedAsteroid { get; set; }
    }

    // ships are the only source of offensive damage.
    public class Ship : Vehicles
    {
        // Amount of extra armor the ship (may) have.
        public int Armor { get; set; }

        // What weapon is equipped to weapon slot 1.
        public string WeaponOne { get; set; }

        // What weapon is equipped to weapon slot 2.
        public string WeaponTwo { get; set; }

        // What kind of object the ship is attacking.
        public string Target { get; set; }
    }

    // Small, fast miner with low storage.
    public class MiniMiner : Miner { }

    // Best of both worlds mining ship.
    public class RegMiner : Miner { }

    // Big, slow miner with large storage.
    public class MegaMiner : Miner { }

    // Smallish, fast collector with okay storage for collecting resources from destroyed miners/ships.
    public class Scrapper : Miner { }

    // Small, fast offensive ships that deal 2x damage to enemy miners. Lasers only.
    public class Zapper : Ship { }

    // Medium sized offensive ship with small missiles and one laser.
    public class SmallBoy : Ship { }

    // Large offensive ship with multiple missiles launchers and bombing functionality. Receives 2x damage when bombing, but bombs do 3x damage to buildings.
    public class BigBoy : Ship { }
}