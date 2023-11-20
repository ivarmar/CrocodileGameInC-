using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;

namespace CrocodileGameInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random number1 = new Random();
            Random number2 = new Random();

            int userPoints = 0;
            var play = true;

            while (play)
            {
                Console.WriteLine("Type either <, > or =, depending on what you think it is");

                var Number1 = number1.Next(1, 12);
                var Number2 = number2.Next(1, 12);
                Console.WriteLine($"{Number1}" + " " + "_" +" " + $"{Number2}");
                var userInput = Console.ReadLine();


                if (Number1 < Number2)
                {
                    
                    if (userInput == "<")
                    {
                        userPoints++;
                        Console.WriteLine(
                            $"You are correct {Number1} is indeed less than {Number2} you have gained 1 point, you currently have {userPoints} Points");
                        
                    }
                    else if (userInput == ">" || userInput == "=")

                    {
                        userPoints--;
                        Console.WriteLine($"You are wrong, we have deducted 1 point, you have {userPoints}");
                    }


                }
                else if (Number1 == Number2)
                {
                    
                    if (userInput == "=")
                    {
                        Console.WriteLine(
                            $"You are correct {Number1} is indeed equal to {Number2} you have gained 1 point, you have {userPoints} Points");
                        userPoints++;
                    }
                    else if (userInput == ">" || userInput == "<")

                    {
                        userPoints--;
                        Console.WriteLine($"You are wrong, we have deducted 1 point you have {userPoints}");
                    }
                }
                else if (Number1 > Number2)

                {
                    
                    if (userInput == ">")
                    {
                        userPoints++;
                        Console.WriteLine(
                            $"You are correct {Number1} is indeed greater than {Number2} you have gained 1 point, you have {userPoints} ");
                        
                    }
                    else if (userInput == "<" || userInput == "=")

                    {
                        userPoints--;
                        Console.WriteLine($"You are wrong, we have deducted 1 point you have {userPoints}");
                    }
                }

            }
            
            //Console.WriteLine("continue play? (yes/no)");
            //string continue = Console.ReadLine().ToLower();
            //if (continue != "yes")
            //{
              //  play = false;
                //Console.WriteLine($" you got {userPoints}");

            //}

            
        }
    }
}