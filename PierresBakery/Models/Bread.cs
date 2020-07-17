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

    public int AddBreadCost()
    {
      if (BreadOrder >= 3)
      {
        int discountCost = (BreadOrder * 5) - ((BreadOrder / 3)*5);
        return discountCost;
      }
      else
      {
        int fullPrice = BreadOrder * 5;
        return fullPrice;
      }
    }
  }
}