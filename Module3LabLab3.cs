using System;//includes the whole system (math, namespace etc)
namespace TacoBurritoLab {
    class Program {
        
        //Main method --its called when the program runs
        static void Main(string[]args){ 
            //Output Welcome Message
            Console.WriteLine("Welcome to the Taco & burrito decision Maker");
            
            //Promt user for more info about their hunger level
            Console.Write("How hungrey are you on a scale of 1-10? ");
            int hungerLevel = int.Parse(Console.ReadLine());//Parse == Input()

            //Use an if-else statement to suggest food based on hunger levle
            if(hungerLevel >= 8) {
                Console.WriteLine("Wow! You're super hungry you should get both tacos and burritos");
            }
            else if (hungerLevel >= 5){
                Console.WriteLine("Sounds like your moderatly hungry, I suggest a burrito");
            }else {
                Console.WriteLine( "You're not that hungry you should opt for a taco");
            }
            //Terminary operator version
            String reccomendation = (hungerLevel >=5) ? "Tacos" : "Burritos";
            Console.WriteLine($"I recommend: {reccomendation}");

            //Switch statment decides what output based on a case
            //Hungerlevel will determine which case executes in this switch statement
            switch (hungerLevel){
                case 10:
                Console.WriteLine("You are a taco and burrito champ!");
                    break;//Cuts off the switch statement 
                case 8:
                case 7:
                    Console.WriteLine("Burrito time!");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Taco it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a snack");
                    break;
            }
        } 
    }
}