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
      if (PastryOrder >= 3)
      {
        int discountCost = ((PastryOrder / 3) * 5);
        return discountCost;
      }  
      else
      {
        int fullPrice = PastryOrder * PastryCost;
        return fullPrice;
      }
    }
  }
}