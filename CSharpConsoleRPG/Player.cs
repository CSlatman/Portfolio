using System;
using CSharpConsoleRPG;

public class Player
{
    // How doe encapsulation work again?
    
    /// <summary>
    /// 
    /// </summary>
    private string _playerName;
    public string PlayerName
    {
        get { return _playerName; }
        set { _playerName = value; }
    }

    private int _playerLevel;
    public int PlayerLevel
    {
        get { return _playerLevel; }
        set { _playerLevel = value; }
    }

    private int _playerExperience;
    public int PlayerExperience
    {
        get { return _playerExperience; }
        set { _playerExperience = value; }
    }

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
        //Subtracts health value by the hit_value.
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

        //If the player healt his higher than 100, it gets put to 100.
        if (PlayerHealth > 100)
        {
            PlayerHealth= 100;
        }
        // Can also be changed to PlayerHealth = (PlayerHealth + heal_value > 100) ? (PlayerHealth + heal_value) : 100;
        // This is apparenty a ternary conditional opreator or statement? 


        //Write that the player healed themselves.
        Console.WriteLine(PlayerName + " healed themselves for " + heal_value + " amount of hitpoints! You now have " + PlayerHealth + " hitpoints remaining!");
    }
}
