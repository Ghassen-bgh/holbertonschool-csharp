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
    string status;


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
        this.maxHp = maxHp;
        this.hp = this.maxHp;
        status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Print the health of the player
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    /// <summary>
    /// Delegate for calculating health
    /// </summary>
    /// <param name="amount">amount of health</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Take damage
    /// </summary>
    /// <param name="damage">Amount of damage</param>
    public void TakeDamage(float damage)
    {
        float Newhp = hp;
        if (damage < 0f)
        {
            damage = 0f;
            Console.WriteLine("{0} takes 0 damage!", name);
        }
        else
        {
            Newhp = hp - damage;
            Console.WriteLine("{0} takes {1} damage!", name, damage);
        }
        ValidateHP(Newhp);
    }

    /// <summary>
    /// Heal damage
    /// </summary>
    /// <param name="heal">Amount of healing</param>
    public void HealDamage(float heal)
    {
        float Newhp = hp;
        if (heal < 0f)
        {
            heal = 0f;
            Console.WriteLine("{0} heals 0 HP!", name);
        }
        else
        {
            Newhp = hp + heal;
            Console.WriteLine("{0} heals {1} HP!", name, heal);
        }
        ValidateHP(Newhp);
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
        HPCheck(this, new CurrentHPArgs(hp));
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
        else if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        else
        {
            return baseValue;
        }
    }

    /// <summary>
    /// Event Handler.
    /// </summary>
    public event  EventHandler<CurrentHPArgs> HPCheck;
    /// <summary>
    /// CheckStatus: method.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">List of arguments.</param>

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = ($"{name} is in perfect health!");
        else if (e.currentHp >= maxHp / 2f )
            status = ($"{name} is doing well!");
        else if (e.currentHp >= maxHp / 4f)
            status = ($"{name} isn't doing too great...");
        else if (e.currentHp > 0)
            status = ($"{name} needs help!");
        else
            status = ($"{name} is knocked out");
        Console.WriteLine(status);
    }

}

/// <summary>
/// Class CurrentHPArgs
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Current HP
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="newHp">New HP</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}