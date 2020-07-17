using System;
using System.Collections.Generic;

namespace BakeryBread.Model
{
  public class Bread
  {
    public int BreadCost { get; set; }
    public int BreadOrder { get; set; }
    
    public Bread (int breadOrder)
    {
      BreadOrder = breadOrder;
      BreadCost = 5;
    }

    public static int AddBreadCost(int breadOrder)
    {
      int fullPrice = breadOrder * 5;
      return fullPrice;
    }
      

    public static int DiscountBreadCost(int breadOrder)
    { 
      int discountCost = (breadOrder * 5) - ((breadOrder / 3)*5);
      return discountCost;
    }
  }
}