using System;

namespace Bakery.Models
{
 public class Special
 {

   public int Order {get; set;}

   public Special(int order)
   {
    Order = order;
   }

   public int  SpecialCost()
   {
    int  specialCost = 0;
    for (int i = 1; i <= Order; i ++)
    {
        specialCost += 4;
    }
      return specialCost;
   }

  }
}