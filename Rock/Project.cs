using System;
using System.Collections.Generic;
using Game.Models;

namespace LiveProgam
{
   class Program 
    {
        static void Main() 
        {
            List<WeaponOfChoice> weaponList =  StartGame();
            
            // WeaponOfChoice player1Choice = Player1Choice(weaponList);
            // Console.WriteLine("Player 2: What do you choose? [rock/paper/scissor]");
            // string player2Choice = Console.ReadLine().ToLower();
            // Console.WriteLine("Player 1 " + WinTieLoss(player1Choice, player2Choice));

            GameplayLoop(weaponList);




        }

        public static List<WeaponOfChoice> StartGame() 
        {
            List<WeaponOfChoice> weaponList = new List<WeaponOfChoice> {};

            WeaponOfChoice error = new WeaponOfChoice("error", "error", "error", "error");
            WeaponOfChoice rock = new WeaponOfChoice("rock", "ties", "loses", "wins");
            WeaponOfChoice paper = new WeaponOfChoice("paper", "wins", "ties", "loses");
            WeaponOfChoice scissor = new WeaponOfChoice("scissor", "loses", "wins", "ties");
            weaponList.Add(error);
            weaponList.Add(rock);
            weaponList.Add(paper);
            weaponList.Add(scissor);
            return weaponList;
        }

        public static WeaponOfChoice Player1Choice(List<WeaponOfChoice> weaponList)
        {
            Console.WriteLine("Player 1: What do you choose? [rock/paper/scissor]");
            string playerChoice = Console.ReadLine().ToLower();
            WeaponOfChoice weapon = weaponList[0];
            for (int i=0; i<weaponList.Count; i++)
                {
                    if (playerChoice == weaponList[i].Name)
                    {
                        weapon = weaponList[i];
                    }
                }
            return weapon;
        }

        public static string WinTieLoss (WeaponOfChoice weapon, string player2Input)
        {
            string Player1WinTieLoss = "";
            switch (player2Input)
            {
                case "rock":
                    Player1WinTieLoss = weapon.RockStatus;
                     break;
                case "paper":
                    Player1WinTieLoss = weapon.PaperStatus;
                     break;
                case "scissor":
                    Player1WinTieLoss = weapon.ScissorStatus;
                     break;
            }
            return Player1WinTieLoss;
        }
        public static string Player2Chooses()
        {
            Console.WriteLine("Player 2: What do you choose? [rock/paper/scissor]");
            string player2Choice = Console.ReadLine().ToLower();
            if (player2Choice == "rock" || player2Choice == "paper" || player2Choice == "scissor")
            {
                player2Choice = player2Choice;
            }
            else
            {
                Console.WriteLine("I couldn't read that.");
                Player2Chooses();
            }
            return player2Choice;
        }


        public static void GameplayLoop(List<WeaponOfChoice> weaponList)
        {
            WeaponOfChoice player1Choice = Player1Choice(weaponList);
            string player2Choice = Player2Chooses();
            Console.WriteLine(player2Choice);
            Console.WriteLine("Player 1 " + WinTieLoss(player1Choice, player2Choice));
        }
    }
}

