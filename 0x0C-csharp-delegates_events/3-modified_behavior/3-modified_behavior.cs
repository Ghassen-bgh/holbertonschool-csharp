using System;

/// <summary>
/// enum for modifier
/// </summary>
public enum Modifier
{
    /// <summary>
    /// weak modifier
    /// </summary>
    Weak,

    /// <summary>
    /// base modifier
    /// </summary>
    Base,

    /// <summary>
    /// strong modifier
    /// </summary>
    Strong
}

/// <summary>
/// delegate for calculating modifiers
/// </summary>
/// <param name="baseValue">base value</param>
/// <param name="modifier">modifier</param>
/// <returns>modified value</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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

    delegate void CalculateHealth(float amount);

    /// <summary>
    /// Take damage
    /// </summary>
    /// <param name="damage">Amount of damage</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
        }
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Heal damage
    /// </summary>
    /// <param name="heal">Amount of healing</param>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
        }
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validate HP
    /// </summary>
    /// <param name="newHp">New HP</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            hp = 0f;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

    /// <summary>
    /// Apply modifier
    /// </summary>
    /// <param name="baseValue">Base value</param>
    /// <param name="modifier">Modifier</param>
    /// <returns>Modified value</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2f;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else
        {
            return baseValue * 1.5f;
        }
    }
}
