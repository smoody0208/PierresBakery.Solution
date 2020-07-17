using BakeryBread.Model;
using BakeryPastry.Model;
using System.Collections.Generic;
using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery!");
      Console.WriteLine("Would you like to order bread or pastries?");
      Console.WriteLine("please type in 'bread' for bread options or 'pastry' for pastry options.");
      string menuOption = Console.ReadLine();

      if (menuOption == "bread")
      {
        Console.WriteLine("Todays specials! Buy 2, get 1 free. A single loaf costs $5.");
        Console.WriteLine("How many loafs would you like to order?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread newBreadOrder = new Bread(breadOrder);
        int firstBreadOrder = newBreadOrder.AddBreadCost();
        Console.WriteLine(firstBreadOrder);
        Console.WriteLine("Would you like to add another item to your order? Type 'yes' or 'no'.");
        string AnotherOrder = Console.ReadLine();
      }
      else if(menuOption == "pastry")
      { 
        Console.WriteLine("Todays specials! Buy 1 for $2 or 3 for $5.");
        Console.WriteLine("How many loafs would you like to order?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Bread newPastryOrder = new Bread(pastryOrder);
        int firstPastryOrder = newPastryOrder.AddBreadCost();
        Console.WriteLine(firstBreadOrder);
      }  
    }
    public static CheckOut()
    {
      Console.WriteLine
    }
  }
}