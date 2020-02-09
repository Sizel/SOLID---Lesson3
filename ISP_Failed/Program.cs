using System;

namespace ISP_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier(10, 20);
            HeavyArmoredSoldier heavyArmoredSoldier = new HeavyArmoredSoldier(7);

            soldier.Run();
            soldier.Walk();

            heavyArmoredSoldier.Walk();
            Console.WriteLine(heavyArmoredSoldier.RunSpeed);
            heavyArmoredSoldier.Run();
        }
    }

    interface IMoveable
    {
        int MoveSpeed { get; set; }
        int RunSpeed { get; set; }
        void Run();
        void Walk();
    }

    class Soldier : IMoveable
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

    class HeavyArmoredSoldier : IMoveable
    {
        public int MoveSpeed { get; set; }
        public int RunSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void Run()
        {
            throw new NotImplementedException();
        }
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
