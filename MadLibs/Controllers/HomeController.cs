using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Hello() { return "Hello"; }
  }
}