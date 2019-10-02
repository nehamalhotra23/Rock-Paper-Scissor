using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;
using System.Collections.Generic;

namespace Game.Tests 
{
   [TestClass]
   public class WeaponTests 
   {
      [TestMethod]
       public void Game_UpdatesInList_True()
       {
           WeaponOfChoice newWeaponOfChoice = new WeaponOfChoice("rock", "ties", "loses", "wins");
           
           Assert.AreEqual("ties", newWeaponOfChoice.RockStatus);
       }
   }
}