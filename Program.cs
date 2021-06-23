using System;

namespace DatingProfile
{
    class Program
    {
        private static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");


            //add hobbies to array
            sam.SetHobbies(new string[]
                {
                "hobby1", "hobby2"
            });
            //Call method and print result
            Console.WriteLine(sam.ViewProfile());


        }
    }
}
