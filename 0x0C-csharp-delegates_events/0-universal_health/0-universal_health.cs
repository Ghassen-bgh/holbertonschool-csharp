using System;

/// <summary>
/// Class Player
/// </summary>
public class Player
{
    string name;
    float maxHp;
    float hp;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Name of the player</param>
    /// <param name="maxHp">Max health of the player</param>
    public Player(string name ="Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Print the health of the player
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
}
