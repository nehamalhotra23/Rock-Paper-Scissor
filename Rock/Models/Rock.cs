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
    }
}