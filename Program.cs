
using System.ComponentModel.Design;

namespace MyAdventure
{
    class CYOA
    {
        private static void Main(string[] arguments)
        {
            // declare story strings
            string username, computer, start, bestfriend, direction, oldman, gender, sandquery;

            // give story strings name values
            computer = "Drew";
            bestfriend = "Brian";
            oldman = "Antwon";

            Console.WriteLine("Hello! Before we begin, Let's get your name...");

            username = Console.ReadLine()!;

            Console.WriteLine("Excellent, " + username + ".");

            Console.WriteLine("He(he) or She(she)?");

            gender = Console.ReadLine()!;

            Console.WriteLine("So, your a " + gender + " and your name is " + username + ".");

            Console.WriteLine("This story is made to be interactive, with winding paths. The decisions you make along the way will dictate where you end up. Oh, I'm " + computer + " by the way.");

            Console.WriteLine("Let's begin. Type 'Yes' to start: ");

            start = Console.ReadLine()!;
            // if start, use paramaters user defined
            if (start == "Yes")
            {
                Console.WriteLine("Last night must've been rough. I can't even remember where I was or who I was with. Could it have been " + bestfriend + "? Ehh...probably not.");
            }

            Console.WriteLine("Doesn't matter much now. My body is cold and my bones ache.");
            Console.WriteLine("Shrubs and flowers surround me. Besides the fauna, nothing lives. Should I head North, East, or West?");

            direction = Console.ReadLine()!;
            // direction for user
            if (direction == "North")
            {
                Console.WriteLine("The trees get taller and the taller the more you proceed. Hidden animals make noises few can tolerate.");
                Console.WriteLine("A strange man approaches me. He's tall and dirty. And his beard - bigger than his head!");
                Console.WriteLine("'Hello...who are you? ' I am " + username + ". I've headed north from behind the foliage. I'm trying to figure out why I am here.");
                Console.WriteLine("Who are you, bearded man? The old man takes a deep breath and tells all. " + oldman + ", to you.");
                Console.WriteLine(oldman + "wants me to follow him. He has something he would like to show me...");
            }
            else if (direction == "East")
            {
                Console.WriteLine("The north seems a bit too harsh. And the west appears to be a dead-end. I better stick east.");
                Console.WriteLine("After walking for a long while, nothing. Radio silence. My phone's dead so I have no way of contacting anybody. And my feet are blistered.");
                Console.WriteLine("Animal sounds ring in my ear. The sound is too much to bear. 'Ahhh!!!' " + username + " ran as fast as " + gender + "could until slamming into an old man's back.");
                Console.WriteLine("Hey! Watch where you're going. I'm " + oldman + " by the way. Follow me... ");
            }
            else
            {
                Console.WriteLine("Crap!! " + username + " died.");

                return;
            }
            Console.WriteLine(username + " followed " + oldman + " past the forest. Large oak trees were replaced by sand dunes.");
            Console.WriteLine("Snakes slithered to " + oldman + ".");
            Console.WriteLine("Some time had passed, " + username + " and " + oldman + " were exhausted.");
            Console.WriteLine("The pair sat down in the hot sand to rest. However, " + username + " noticed a lizard inching toward them.");

            Console.WriteLine("Should " + username + " and " + oldman + " try to kill it or run? Type 'kill' or 'run'");
            sandquery = Console.ReadLine()!;
            // user decision
            if (sandquery == "kill")
            {
                Console.WriteLine(username + " and " + oldman + " stomped on the lizard once, but it escaped.");
                Console.WriteLine("Phew that was close, said " + oldman + ". Let's keep going. Hopefully, we'll find something!");
                Console.WriteLine("The desert ceased. " + username + " noticed a small door directly ahead.");
                Console.WriteLine("They opened the door, and lived to see another day.");
                Console.WriteLine("Congratulations, " + username + " and " + oldman + "! You made it to the end!");

                return;
            }
            else if (sandquery == "run")
            {
                Console.WriteLine("The pair escaped posthaste. The lizard caught up to " + oldman + " and killed him!");
                Console.WriteLine("Since " + username + " is without a partner, " + gender + " continued through the desert.");
                Console.WriteLine(username + " found a door at the end of the desert and " + gender + " stepped through it.");
                Console.WriteLine("Congratulations, " + username + ". You made it to the end!");

                Console.WriteLine("Unfortunately, " + oldman + " isn't here to celebrate with you.");
                // end program
                return;
            }
        }
    }
}