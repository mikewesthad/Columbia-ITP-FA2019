using static System.Console;

namespace VirtualPet
{
    class VirtualPet
    {
        public string Name;
        public string Mood;
        public int AgeInDays;
        public int HungerLevel;
        public bool IsAwake = false;

        // A static field lives on the class itself and NOT on the instances. Sometime you have 
        // data about the class, but that wouldn't make sense to have on each instance, e.g. 
        // tracking the total number of pets in our virtual game world.
        static public int NumPetsCreated = 0;

        // A static method lives on a class and NOT on the instances. Inside of a static method, 
        // you can access static fields (e.g. NumPetsCreated) but not instance fields.
        static public void DisplayNumPetsCreated()
        {
            WriteLine("There are currently " + NumPetsCreated + " pets alive in the world.");
        }

        // A constructor that takes no parameters and sets some of the fields to default values.
        public VirtualPet()
        {
            Name = "Unknown";
            Mood = "Unknown";
            AgeInDays = 0;
            HungerLevel = 0;
            NumPetsCreated = NumPetsCreated + 1;
        }

        // A constructor that takes three parameters and uses them to set the fields.
        public VirtualPet(string name, string mood, int ageInDays, int hungerLevel)
        {
            Name = name;
            Mood = mood;
            AgeInDays = ageInDays;
            HungerLevel = hungerLevel;
            NumPetsCreated = NumPetsCreated + 1;
        }

        public void Greet()
        {
            WriteLine("Why hello, my name is " + Name + ".");
            WriteLine("I am " + AgeInDays + " days old.");
            WriteLine("I am currently feeling: " + Mood + ".");
            WriteLine("I am " + HungerLevel + "% hungry.");
        }
    }
}
