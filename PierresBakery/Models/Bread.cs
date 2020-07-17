using System;
using System.Collections.Generic;

namespace Bakery.Model
{
  public static class Bread
  {
    // public int TotalBread { get; set; }
    
    // public Bread (int totalBread)
    // {
    //   TotalBread = totalBread;
    // }

    public static int AddBreadCost(int userInput)
    {
      int breadCost = 5;
      int fullPrice = userInput * breadCost;
      return fullPrice;
    }
      

    public static int DiscountBreadCost(int userInput)
    { 
      int breadCost = 5;
      int discountCost = (userInput * breadCost) - ((userInput / 3)*breadCost);
      return discountCost;
    }

  }
}