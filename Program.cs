using System;

namespace ScuffedStoryExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Welcome my friend! Welcome to the ScuffedStoryExperience. Suit urself up for some fuckery!\n" +
                "Write down all the random words you come up with and get a random story afterwards!\n" +
                "Sounds cool right? Thought so you little bitch! Now let's get moving.\n"
                );

            Console.Write("[Press Enter to continue]");
            Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter first noun]: ");
            string noun1 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter second noun]: ");
            string noun2 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter third noun]: ");
            string noun3 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter fourth noun]: ");
            string noun4 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter a random Name]: ");
            string name1 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter another random Name]: ");
            string name2 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter first adjective]: ");
            string adject1 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter second adjective]: ");
            string adject2 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter first verb]: ");
            string verb1 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter second verb]: ");
            string verb2 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter third verb]: ");
            string verb3 = Console.ReadLine();
            Console.Clear();

            Console.Write("[Enter a name of location]: ");
            string location = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(
                "Good Job!\n" +
                "You've filled out all the words and we're gonna make some fucked up shit for you in return!\n" +
                "Have Fun!"
                );
            Console.Write("[Press Enter to continue]");
            Console.ReadLine();
            Console.Clear();

            string story = $"There once was a {adject1} fella named {name1}. {name1} is {verb1} in {location}.\n" +
                $"Suddenly, {adject2} {name2} appeared in front of {name1}.\n" +
                $"{name2} start to {verb2} {noun1} towards {name1}.\n" +
                $"{name1} calls da {noun2} and {verb3} {noun3} towards {name2}\n" +
                $"{noun2} showed up and strangled {name2} with a {noun4}.\n";


            Console.WriteLine($"{story}\n\nWow, There's nothing like a happy end eh? hope you enjoyed the shitshow!\n" +
                $"I'm gonna go drink some {noun3} out of that {noun2} if u know what i'm sayin'\n" +
                $"See you next time, Fucker!");
            Console.Write("[Press Enter to quit]");
            Console.ReadLine(); 
        }
    }
}
