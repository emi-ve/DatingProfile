using System;

namespace DatingProfile
{
    // CLASS
    class Profile
    {

        // Fields to store data
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // CONSTRUCTORS (special method that is used to initialize &  assign initial values to the data members of the same class
        public Profile(string name, int age, string city, string country, string pronouns)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }

        //METHODS- code block that can be called later

        public string ViewProfile()
        {
            // putting together bio, incuding list of strings
            string bio = $"Name: {name}, \nAge: {age}, \nCity: {city}, \nCountry: {country}, \nPronouns: {pronouns},";
            //bio string will add "Hobbies:" after Pronouns

            if (hobbies.Length > 0)
            {
                bio += "\nHobbies:";
            }
            else
                bio += "No hobbies :/";
            //loop through hobbies, print out "hobby" each time it is looped through the array. return bio from the method
            foreach (string hobby in hobbies)
            {
                Console.WriteLine(hobby);
                bio += $" / {hobby} ";
            }
            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
