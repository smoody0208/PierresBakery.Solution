using System;
using System.Collections.Generic;

namespace BakeryPastry.Model
{
  public class Pastry
  {
    public int PastryCost { get; set; }
    public int PastryOrder { get; set; }
    
    public Pastry (int pastryOrder)
    {
      PastryCost = 2;
      PastryOrder = pastryOrder;
    }

    public int AddPastryItem()
    {
      int fullPrice = PastryOrder * PastryCost;
      return fullPrice;
    }

    public int DiscountPastryCost()
    {
      int discountCost = (PastryOrder / 3) * 5;
      return discountCost;
  
    } 
  }
}