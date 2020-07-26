using System;
using System.Collections.Generic;

namespace Bakery.Models
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
      int pastryTotal = (PastryOrder * PastryCost - (PastryOrder / 3));
      return pastryTotal;
    }  
  }
}