using System;

namespace ConsoleApp2
{   

    class Program
    {                
        static void Beacon(Terran terran)
        {
            terran.Recovery();
        }
        static void Main(string[] args)  
        {
            Marine marine = new Marine();
            Firebet firebet = new Firebet();
            Ghost ghost = new Ghost();

            marine.Health -= 17;
            firebet.Health -= 10;
            ghost.Health -= 10;


            Beacon(marine);
            Beacon(firebet);
            Beacon(ghost);

        }
    }
}
