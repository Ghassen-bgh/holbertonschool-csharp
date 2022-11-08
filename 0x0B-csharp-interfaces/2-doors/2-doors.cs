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

