using Microsoft.AspNetCore.Mvc;
using System;
using MadLibs.Model;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult BaseForm() { return View(); }

    [Route("/formOne")]
    public ActionResult FormOne() { return View(); }

    [Route("/formTwo")]
    public string FormTwo() { return "Hello to form two"; }

    [Route("/responseOne")]
    public ActionResult ResponseOne(string nameOne, string nounOne, string verbOne, string verbTwo, string nameTwo, string adjectiveOne, string nameThree, string nounTwo, string adjectiveTwo)
    {
      StoryOne newStory = new StoryOne();
      newStory.NameOne = nameOne;
      newStory.NounOne = nounOne;
      newStory.VerbOne = verbOne;
      newStory.VerbTwo = verbTwo;
      newStory.NameTwo = nameTwo;
      newStory.AdjectiveOne = adjectiveOne;
      newStory.NameThree = nameThree;
      newStory.NounTwo = nounTwo;
      newStory.AdjectiveTwo = adjectiveTwo;
      return View(newStory);
    }
  }
}