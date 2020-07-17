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
      PastryCost = 5;
      PastryOrder = pastryOrder;
    }

    public static int AddPastryCost(int pastryOrder)
    {
      int fullPrice = pastryOrder * 2;
      return fullPrice;
    }

    public static int DiscountPastryCost(int PastryOrder)
    {
      int discountCost = (PastryOrder / 3) * 5;
      return discountCost;
  
    } 
  }
}