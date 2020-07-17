using System;
using System.Collections.Generic;

namespace BakeryBread.Model
{
  public static class Bread
  {
    public int BreadCost { get; set; }
    public int BreadOrder { get; set; }
    
    public Bread (int BreadOrder)
    {
      BreadCost = 5;
      BreadOrder = breadOrder;
    }

    public static int AddBreadCost(int breadOrder)
    {
      int fullPrice = userInput * breadCost;
      return fullPrice;
    }
      

    public static int DiscountBreadCost(int breadOrder)
    { 
      int discountCost = (userInput * breadCost) - ((userInput / 3)*breadCost);
      return discountCost;
    }

  }
}