namespace ConsoleApp1;

public interface IPerformCalculation 

{
   public   decimal   PerformCalculation(decimal a, decimal b);
    
}

class Addition : IPerformCalculation
{
   public decimal PerformCalculation(decimal a, decimal b)
   {
         return a + b;
      
   }
}

//same for subtraction, multiplication and division
class Subtraction : IPerformCalculation
{
   public decimal PerformCalculation(decimal a, decimal b)
   {
         return a - b;
      
   }
}

class Multiplication : IPerformCalculation
{
   public decimal PerformCalculation(decimal a, decimal b)
   {
         return a * b;
      
   }
}

class Division : IPerformCalculation
{
   public decimal PerformCalculation(decimal a, decimal b)
   {
         return a / b;
      
   }
}

