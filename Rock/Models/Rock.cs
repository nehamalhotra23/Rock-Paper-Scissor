using System;
using System.Collections.Generic;
namespace Game.Models {

    public class WeaponOfChoice 
    {
        public string Name {get; set;}
        public string RockStatus {get; set;}
        public string PaperStatus {get; set;}    
        public string ScissorStatus {get; set;}      

        public WeaponOfChoice (string name, string rock, string paper, string scissor)
        {
            Name = name;
            RockStatus = rock;
            PaperStatus = paper;
            ScissorStatus = scissor;
        }
        // public static string WinTieLoss (WeaponOfChoice weapon, string player2Input)
        // {
        //     string Player1WinTieLoss = "";
        //     switch (player2Input)
        //     {
        //         case "rock":
        //             Player1WinTieLoss = weapon.RockStatus;
        //              break;
        //         case "paper":
        //             Player1WinTieLoss = weapon.PaperStatus;
        //              break;
        //         case "scissor":
        //             Player1WinTieLoss = weapon.ScissorStatus;
        //              break;
        //     }
        //     return Player1WinTieLoss;
        // }

    }
}