using System;
using CSharpConsoleRPG;

public class Player
{
    // How dow encapsulation work again?
    
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

    private int _playerHealth;
    public int PlayerHealth { get; set; }

    public bool PlayerIsDead { get; set; }

    //Constructor for the Player Class.
    public Player()
    {
        //Sets the players' health value to 100.
        PlayerHealth = 300;
    }
    /// <summary>
    /// This is called when the player is hit.
    /// </summary>
    /// <param name="hit_value"> The amount of damage the enemy will take. </param>
    public string PlayerTakesDamage(int hit_value)
    {
        //Subtracts health value by the hit_value.
        PlayerHealth = PlayerHealth - hit_value;

        //Check if the enemy is dead.
        if (PlayerHealth <= 0)
        {
            //The player is dead.
            PlayerDies();
        }
        //Write that the enemy got hit.
        return (PlayerName + " was hit for " + hit_value + " damage! You now have " + PlayerHealth + " remaining!");


        
    }

    private string PlayerDies()
    {
        //Write to the console that the enemy has defeated the player.
        return (PlayerName + " has died!");

        //Sets the boolean that the player has died.
        // PlayerIsDead = true;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="heal_value"></param>
    public string Heal(int heal_value)
    {
        PlayerHealth = PlayerHealth + heal_value;

        //If the player healt his higher than 100, it gets put to 100.
        if (PlayerHealth > 100)
        {
            PlayerHealth= 100;
        }
        
        //Write that the player healed themselves.
        return (PlayerName + " healed themselves for " + heal_value + " amount of hitpoints! You now have " + PlayerHealth + " hitpoints remaining!");
    }
}
