using System;

namespace Bakery.Models
{
 public class Bread
 {

   public int Order {get; set;}

   public Bread(int order)
   {
    Order = order;
   }

   public int BreadCost()
   {
    int breadCost = 0;
    for (int i = 1; i <= Order; i ++)
    {
      if (i % 3 == 0)
      {
        breadCost += 0;
      }
      else
      {
        breadCost += 5;
      }
    }
    return breadCost;
   }
 }
}