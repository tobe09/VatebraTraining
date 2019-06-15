using System;

namespace Practise.Animal
{
    public interface ILivingThing
    {
        void Breathe(string gas);
    }

    public abstract class Animal: ILivingThing
    {
        public string Name { get; set; }

        public abstract void Breathe(string gas);

        public abstract void Hunt();
    }

    public class Dog: Animal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public override void Hunt()
        {
            Console.WriteLine("I am hunting Chicken");
        }

        public virtual void Bark()
        {
            Console.WriteLine("Woof!!! " + Name + " is barking");
        }

        public override string ToString()
        {
            string className = base.ToString();
            className = className + ", This is a dog.";

            return className;
        }

        public override void Breathe(string gas)
        {
            Console.WriteLine(Name + " is breathing!");
        }
    }

    public class Rotweiler: Dog
    {
        public Rotweiler() : base("Rotweiler")
        {
        }

        public override void Bark()
        {
            Console.WriteLine("Powerful woof!!!! " + Name + " is barking");
        }

        public void Bark(bool isAngry)
        {
            if (isAngry)
                Console.WriteLine("Angry Powerful woof!!!! " + Name + " is barking");
            else
                Console.WriteLine("Refular Powerful woof!!!! " + Name + " is barking");

        }
    }
}
