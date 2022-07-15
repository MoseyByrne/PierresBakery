using System;

namespace Bakery.Models
{
 public class Pastry
 {

   public int Order {get; set;}

   public Pastry(int order)
   {
    Order = order;
   }

   public int  PastryCost()
   {
    int  pastryCost = 0;
    for (int i = 1; i <= Order; i ++)
    {
      if (i % 3 == 0)
      {
         pastryCost += 0;
      }
      else
      {
         pastryCost += 5;
      }
    }
    return pastryCost;
   }
 }
}