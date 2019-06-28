namespace GameTest.Data
{
    public class Buildings
    {
        // Price to purchase the building.
        public int Cost { get; set; }

        // Price to upgrade the building.
        public int UpgradeCost { get; set; }

        // Amount of health the building has.
        public int Health { get; set; }

        // Size determines how many blocks of space the building takes up.
        public int Size { get; set; }

        // Stores how many times this building can be built.
        public int Available { get; set; }

        // How fast the building does its task.
        public int WorkSpeed { get; set; }
    }

    // Building that holds money and manages level upgrades.
    public class Base : Buildings
    {
        public Base()
        {
            Health = 1000;
            UpgradeCost = 2000;
            Size = 5;
        }
    }

    // For researching ship and building upgrades.
    public class Lab : Buildings
    {
        public Lab()
        {
            Cost = 2500;
            UpgradeCost = 4000;
            Health = 400;
            Size = 2;
            Available = 1;
            WorkSpeed = 1;
        }
    }

    // Used to efficiently process the resources from asteroids.
    public class ProcessingPlant : Buildings
    {
        public ProcessingPlant()
        {
            Cost = 3000;
            UpgradeCost = 4500;
            Health = 500;
            Size = 3;
            Available = 2;
            WorkSpeed = 1;
        }
    }

    // Used to build miners.
    public class WorkerFactory : Buildings
    {
        public WorkerFactory()
        {
            Cost = 250;
            UpgradeCost = 900;
            Health = 200;
            Size = 4;
            Available = 5;
            WorkSpeed = 1;
        }
    }

    // Used to build offensive ships.
    public class WarFactory : Buildings
    {
        public WarFactory()
        {
            Cost = 800;
            UpgradeCost = 1500;
            Health = 800;
            Size = 4;
            Available = 5;
            WorkSpeed = 1;
        }
    }

    // Used to repair ships and miners, but not if the vehicle was totally destroyed.
    public class RepairCenter : Buildings
    {
        public RepairCenter()
        {
            Cost = 5000;
            UpgradeCost = 9000;
            Health = 700;
            Size = 2;
            Available = 3;
            WorkSpeed = 1;
        }
    }

    // Used to defend your base from attackers.
    public class Turret : Buildings
    {
        public Turret()
        {
            Cost = 1000;
            UpgradeCost = 2300;
            Health = 750;
            Size = 1;
            Available = 4;
            WorkSpeed = 1;
        }
    }
}