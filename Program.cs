using System;

namespace dood
{
    class Program
    {
        static void Main(string[] args)
        {
            var Player = new Player(20, 100, "Man");
            var Enemy = new Enemy (15, 125, "Dood");
            while (!Enemy.IsDead() && !Player.IsDead()){
                Enemy.DealsDamage(Player);
                Player.Status();
                if (Player.IsDead()) break;
                Player.DealsDamage(Enemy);
                Enemy.Status();
                if (Enemy.IsDead()) break;
                
            }
            
        }
    }
}
