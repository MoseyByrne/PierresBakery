using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {


      string [] compliments = new string [] {"That color looks great on you! Let's find you a pastry to match.", "You've got good taste coming in here!", "I've been waiting for someone interesting to walk in :D"};
      Random rnd = new Random();
      int index = rnd.Next(0,compliments.Length);
   
      Console.WriteLine("\n>>>  Welcome to Pierre's!  <<<");
      Console.WriteLine(compliments[index]);
      Console.WriteLine("\nLoaves of Sourdough bread are $5.   >>Buy 2 and get 1 free!<<");
      Console.WriteLine("Loaves of Sprouted bread are $6.");
       Console.WriteLine("Pastries are $2.    >>Get every 3rd pastry for only $1!<<");
       Console.WriteLine("\n*** Today's daily special is a slice of chocolate blueberry cheesecake for only 4$ ***\n");
      Console.WriteLine("How many lovely Sourdough loaves can I get for you?");
      int sourdoughResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("How many nommy Sprouted loaves would you like?");
      int sproutedResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("How many of our delicious pastries would you like?");
      int pastryResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many slices of the special can I add to your order?");
      int specialResponse = int.Parse(Console.ReadLine());

      Bread customerBread = new Bread(sourdoughResponse); 
      Bread customerSproutedBread = new Bread(sproutedResponse);
      Pastry customerPastry = new Pastry(pastryResponse);
      Special customerSpecial = new Special(specialResponse);

      int orderTotal = ((customerBread.BreadCost()+ customerPastry.PastryCost()) + (customerSproutedBread.SproutedCost() + customerSpecial.SpecialCost())); // is there a cleaner way to do this?
      
      Console.WriteLine("Here is you order: \n   " + customerBread.Order + " Sourdough \n   " + customerBread.Order + " Sprouted \n   " + customerPastry.Order + " Pastry \n   " + customerSpecial.Order + " Special \nYour total is: " + orderTotal);


    }
  }
}