using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's!");
      Console.WriteLine("Loaves of bread are $5. >>Buy 2 and get 1 free!<<");
      Console.WriteLine("Pastry are $2. >>Get every 3rd pastry for only $1!<<");
      Console.WriteLine("How may loaves can I get for you?");
      Console.WriteLine("How many of our delicious pastries would you like?");

      int loafResponse = int.Parse(Console.ReadLine());
      int pastryResponse = int.Parse(Console.ReadLine());

      Bread customerBread = new Bread(loafResponse); 
      Pastry customerPastry = new Pastry(pastryResponse);
      
      Console.WriteLine("For your bread order of " + customerBread.Order + " your total will be " + customerBread.BreadCost());


    }
  }
}