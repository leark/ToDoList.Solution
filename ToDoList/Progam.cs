using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("─────────────────────────────────────────────");
      Console.WriteLine("Would you like to add an item, view all items,");
      Console.WriteLine("clear all items or exit? (add/view/clear/exit)");
      string choice = Console.ReadLine().ToLower();
      if (choice == "add")
      {
        Console.WriteLine("─────────────────────────────────────────");
        Console.WriteLine("Please give us a description of the item.");
        string itemDesc = Console.ReadLine();
        Item item = new Item(itemDesc);
        Main();
      }
      else if (choice == "view")
      {
        List<Item> itemsList = Item.GetAll();
        Console.WriteLine("─────────────────────────");
        foreach (Item item in itemsList)
        {
          Console.WriteLine(item.Description);
        }
        Main();
      }
      else if (choice == "clear")
      {
        Item.ClearAll();
        Main();
      }
      else if (choice == "exit")
      {
        Console.WriteLine("─────────");
        Console.WriteLine("Good bye!");
      }
      else
      {
        Console.WriteLine("──────────────");
        Console.WriteLine("Invalid option");
        Main();
      }
    }
  }
}
