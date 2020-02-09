using System;
using System.Collections.Generic;

namespace ISP_Fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier(10, 20);
            HeavyArmoredSoldier heavyArmoredSoldier = new HeavyArmoredSoldier(7);

            List<IWalkable> soldiers = new List<IWalkable>();
            soldiers.Add(soldier);
            soldiers.Add(heavyArmoredSoldier);

            foreach (var sold in soldiers)
            {
                sold.Walk();
            }
        }
    }

    interface IRunnable : IWalkable
    {
        int RunSpeed { get; set; }
        void Run();
    }

    interface IWalkable
    {
        int MoveSpeed { get; set; }
        void Walk();
    }

    class Soldier : IRunnable
    {
        public int MoveSpeed { get; set; }
        public int RunSpeed { get; set; }

        public void Run()
        {
            Console.WriteLine("Soldier runs");
        }

        public void Walk()
        {
            Console.WriteLine("Soldier walks");
        }

        public Soldier(int moveSpeed, int runSpeed)
        {
            MoveSpeed = moveSpeed;
            RunSpeed = runSpeed;
        }
    }

    class HeavyArmoredSoldier : IWalkable
    {
        public int MoveSpeed { get; set; }

        public void Walk()
        {
            Console.WriteLine("Heavy armored soldier walks");
        }

        public HeavyArmoredSoldier(int moveSpeed)
        {
            MoveSpeed = moveSpeed;
        }
    }
}
