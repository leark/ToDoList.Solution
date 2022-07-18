using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/todolist")]
    public ActionResult ToDoList(string item1)
    {
      Item myToDoListItem = new Item(item1);
      // Console.WriteLine(myToDoListItem.Description); // print content of string item1 that was stored in Description of myToDoListItem
      Item item2 = new Item("item 2");

      return View(Item.GetAll());
    }

    [Route("/")]
    public ActionResult Home() { return View(); }
  }
}