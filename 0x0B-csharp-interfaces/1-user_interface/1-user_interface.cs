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
/// TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Durability of the object
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// IsCollected property
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Interact method
    /// </summary>
    public void Interact()
    {


    }
    
    /// <summary>
    /// Break method
    /// </summary>
    public void Break()
    {


    }

    /// <summary>
    /// Collect method
    /// </summary>
    public void Collect()
    {


    }
}

