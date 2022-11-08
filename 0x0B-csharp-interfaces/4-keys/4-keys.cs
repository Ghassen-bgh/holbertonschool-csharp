using System;
/// <summary>
/// Abstract class
/// </summary>

    public abstract class Base
    {
        /// <summary>
        /// Name of the object
        /// </summary>
        public string name {get; set; }

        /// <summary>
        /// Override ToString method
        /// </summary>
        public override string ToString()
        {
            return $"{name} is a {GetType().Name}";
        }
    }

    /// <summary>
    /// Interface Interactive
    /// </summary>

    public interface IInteractive
    {
        /// <summary>
        /// Interact method
        /// </summary>
        void Interact();
    }

    /// <summary>
    /// Interface Breakable
    /// </summary>
    public interface IBreakable
    {
        /// <summary>
        /// Durability of the object
        /// </summary>
        int durability { get; set; }
        /// <summary>
        /// Break method
        /// </summary>
        void Break();
    }

    /// <summary>
    /// Interface Collectable
    /// </summary>
    public interface ICollectable
    {
        /// <summary>
        /// IsCollected property
        /// </summary>
        bool isCollected{ get; set; }
        /// <summary>
        /// Collect method
        /// </summary>
        void Collect(); 
    }

/// <summary>
///  test object class inherits from Base and IInteractive
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for Door class
    /// </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// Interact method
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Decoration class inherits from Base, IInteractive, IBreakable
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// IsQuestItem property
    /// </summary>
    public bool isQuestItem;
    /// <summary>
    /// Durability property
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Constructor for Decoration class
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact method
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// <summary>
    /// Break method
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}

/// <summary>
/// Key class inherits from Base, ICollectable
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// IsCollected property
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Constructor for Key class
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collect method
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
            Console.WriteLine($"You have already picked up the {name}.");
    }
}