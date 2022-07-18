using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult ToDoList() { return View(); }
  }
}