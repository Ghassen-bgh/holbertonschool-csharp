using System;
/// <summary>
/// Abstract class
/// </summary>

    public abstract class Base
    {
        public string name {get; set; }

        public override string ToString()
        {
            return $"{name} is a {GetType().Name}";
        }
    }

    public interface IInteractive
    {
        void Interact();
    }

    public interface IBreakable
    {
        int durability { get; set; }
        void Break();
    }

    public interface ICollectable
    {
        bool isCollected{ get; set; }
        void Collect(); 
    }

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {

        
    }
    
    public void Break()
    {


    }

    public void Collect()
    {


    }
}

