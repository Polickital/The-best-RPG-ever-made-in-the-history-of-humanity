using System;

public class Player : Entity{
   public Player(int atk, int hp, string name) : base(atk, hp, name){
    Console.WriteLine($"{atk} {hp} {name}");   
   }
}