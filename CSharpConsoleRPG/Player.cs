using System;
using CSharpConsoleRPG;

public class Player
{
    private string _playerName;
    public string PlayerName { get; set; }

    private int _playerLevel;
    public int PlayerLevel { get; set; }

    private int _playerHealth;
    public int PlayerHealth { get; set; }

    private int _playerGold;
    public int PlayerGold { get; set; }

    public bool PlayerIsDead { get; set; }

    //Constructor for the Player Class.
    public Player()
    {
        //Sets the players' health value to 100.
        PlayerHealth = 100;
    }
    /// <summary>
    /// This is called when the enemy is hit.
    /// </summary>
    /// <param name="hit_value"> The amount of damage the enemy will take. </param>
    public void PlayerTakesDamage(int hit_value)
    {
        PlayerHealth = PlayerHealth - hit_value;

        //Write that the enemy got hit.
        Console.WriteLine(PlayerName + " was hit for " + hit_value + " damage! You now have " + PlayerHealth + " remaining!");


        //Check if the enemy is dead.
        if (PlayerHealth <= 0)
        {
            //The player is dead.
            PlayerDies();
        }
    }

    private void PlayerDies()
    {
        //Write to the console that the enemy has defeated the player.
        Console.WriteLine(PlayerName + " has died!");

        //Sets the boolean that the player has died.
        PlayerIsDead = true;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="heal_value"></param>
    public void Heal(int heal_value)
    {
        PlayerHealth = PlayerHealth + heal_value;

        //Write that the player healed themselves.
        Console.WriteLine(PlayerName + " healed themselves for " + heal_value + " amount of hitpoints! You now have " + PlayerHealth + " hitpoints remaining!");
    }
}
