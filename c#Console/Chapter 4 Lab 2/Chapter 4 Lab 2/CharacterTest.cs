using System;

//Edited by: Stephen Britt
//     Date: 2/5/2022

class CharacterTest {
    static void Main() {
        Character char1 = new Character();

        Console.WriteLine($"Empty-constructor object name: {char1.Name}");
        Console.WriteLine($"Empty-constructor object race: {char1.Race}");
        Console.WriteLine($"Empty-constructor object class: {char1.AClass}");
        Console.WriteLine($"Empty-constructor object health: {char1.GetHealthInfo()}");
        Console.WriteLine();
        Console.WriteLine($"Empty-constructor object levels up.");
        char1.LevelUp();
        Console.WriteLine($"Empty-constructor object health: {char1.GetHealthInfo()}");
        Console.WriteLine();
        Console.WriteLine();

        Character char2 = new Character("My Character", "Paladin", "Half-Elf");
        Console.WriteLine($"Multi-arg constructor object name: {char2.Name}");
        Console.WriteLine($"Multi-arg constructor object race: {char2.Race}");
        Console.WriteLine($"Multi-arg constructor object class: {char2.AClass}");
        Console.WriteLine($"Multi-arg constructor object health: {char2.GetHealthInfo()}");
        Console.WriteLine();
        Console.WriteLine($"Multi-arg constructor object levels up.");
        char2.LevelUp();
        Console.WriteLine($"Multi-arg constructor object health: {char2.GetHealthInfo()}");
        Console.WriteLine($"Multi-arg constructor object rests.");
        char2.Rest();
        Console.WriteLine($"Multi-arg constructor object health: {char2.GetHealthInfo()}");
        Console.WriteLine();
        Console.WriteLine($"Multi-arg constructor object attacks and deals {char2.GetAttackValue()} damage.");
        Console.WriteLine($"Multi-arg constructor object blocks {char2.GetArmorValue()} damage.");
        Console.WriteLine($"Multi-arg constructor object takes 25 damage.");
        char2.DamageHitPoints(25);
        Console.WriteLine($"Multi-arg constructor object gains 500 experience points.");
        char2.IncreaseXP(500);
        Console.WriteLine($"Multi-arg constructor object is level {char2.GetLevel()} and has {char2.GetExperiencePoints()} experience points.");
        Console.WriteLine();
        Console.WriteLine($"Multi-arg constructor object health: {char2.GetHealthInfo()}");
        Console.WriteLine($"Multi-arg constructor object heals for 5 hit points.");
        char2.RestoreHitPoints(5);
        Console.WriteLine($"Multi-arg constructor object health: {char2.GetHealthInfo()}");
        Console.WriteLine($"Multi-arg constructor object heals for 50 hit points.");
        char2.RestoreHitPoints(50);
        Console.WriteLine($"Multi-arg constructor object health: {char2.GetHealthInfo()}");
    } // end method 
} // end class