using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine();
      Console.WriteLine(">>>  Welcome to Pierre's!  <<<");
      Console.WriteLine();
      Console.WriteLine("Loaves of bread are $5. >>Buy 2 and get 1 free!<<");
       Console.WriteLine("Pastries are $2. >>Get every 3rd pastry for only $1!<<");
       Console.WriteLine("*** Today's daily special is a slice of chocolate blueberry cheesecake for only 4$ ***");
      Console.WriteLine("How many lovely loaves can I get for you?");
      int loafResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("How many of our delicious pastries would you like?");
      int pastryResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many slices of the special can I add to your order?");
      int specialResponse = int.Parse(Console.ReadLine());

      Bread customerBread = new Bread(loafResponse); 
      Pastry customerPastry = new Pastry(pastryResponse);
      Special customerSpecial = new Special(specialResponse);

      int orderTotal = ((customerBread.BreadCost()+ customerPastry.PastryCost()) + customerSpecial.SpecialCost());
      
      Console.WriteLine("For your bread order of " + customerBread.Order + "\nPastry order of " + customerPastry.Order + "\nWith " + customerSpecial.Order + " slices of the special \nYour total will be " + orderTotal);


    }
  }
}