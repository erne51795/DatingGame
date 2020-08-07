using System;

namespace _7_4DatingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile Robert = new DatingProfile("Robert", "Williams", 50, "Male");
            Robert.WriteBio("Strong outdoors type");

            DatingProfile Barbara = new DatingProfile("Barbara", "Jones", 45, "Female");
            Barbara.WriteBio("new to this site");

            Robert.SendMessage("Hello Barbara", "Want to get some coffee?", Barbara);
            Barbara.ReadMessage();
        }
    }
}
