using System;

public class Enemy : Entity{
   public Enemy(int atk, int hp, string name) : base(atk, hp, name){
    Console.WriteLine($"{atk} {hp} {name}");   
   }
}