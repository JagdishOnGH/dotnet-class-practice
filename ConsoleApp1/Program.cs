// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");
var continueLoop = true;

decimal f1 = 10;
decimal f2 = 20;
while (continueLoop)
    
{
    Console.WriteLine("Enter an operation (+, -, *, /) or type 'exit' to quit");
    var input = Console.ReadLine();
    if (input != null)
    {
        //if input contains any of the following characters, it will return the corresponding operation (+, -, *, /)
        if(input == "+" || input == "-" || input == "*" || input == "/")
        {
            try
            {
                Console.WriteLine("Enter first number");
                f1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter second number");
                f2 = Convert.ToDecimal(Console.ReadLine());
                IPerformCalculation calculation = input switch
                {
                    "+" => new Addition(),
                    "-" => new Subtraction(),
                    "*" => new Multiplication(),
                    "/" => new Division(),
                    _ => throw new InvalidOperationException("Invalid operation")
                };
                Console.WriteLine(calculation.PerformCalculation(f1, f2));
            }
            catch (FormatException e)

            {
                Console.WriteLine(e.GetType());
                Console.WriteLine("Only numbers (0-9) are allowed! Retry?");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine("Division by zero is not allowed! Retry?");
            }
            catch (Exception e)
            {
               
                Console.WriteLine("An error occurred! Retry?");
                
            }
        }
        else if(input == "exit")
        {
            Environment.Exit(0);
            continueLoop = false;
        }
        else
        {
            Console.WriteLine("Invalid operation");
        }
    
    
    }
    
}

