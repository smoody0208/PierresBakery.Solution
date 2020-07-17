using System;
using System.Collections.Generic;

namespace BakeryBread.Model
{
  class Bread
  {
    public int BreadCost { get; set; }
    public int BreadOrder { get; set; }
    
    public static Bread (int BreadOrder)
    {
      BreadCost = 5;
      BreadOrder = breadOrder;
    }

    private static int AddBreadCost(int breadOrder)
    {
      int fullPrice = breadOrder * breadCost;
      return fullPrice;
    }
      

    private static int DiscountBreadCost(int breadOrder)
    { 
      int discountCost = (breadOrder * breadCost) - ((breadOrder / 3)*breadCost);
      return discountCost;
    }
  }
}