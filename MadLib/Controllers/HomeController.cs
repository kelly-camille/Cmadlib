
using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    /*
    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }
    */
    [Route("/")]
    public ActionResult Landing() { return View(); }

    [Route("/Tacos")]
    public ActionResult Tacos() { return View(); }

    [Route("/CompletedTacos")]
    public ActionResult CompletedTacos(string noun, string person, string foods, string foods2, string verb, string saying, string ride, string adjective, string color, string animal)
    {
      KeyWordVariableTacos myKeyWordVariable = new KeyWordVariableTacos();
      myKeyWordVariable.Person = person;
      myKeyWordVariable.Noun = noun;
      myKeyWordVariable.Foods = foods;
      myKeyWordVariable.Foods2 = foods2;
      myKeyWordVariable.Saying = saying;
      myKeyWordVariable.Verb = verb;
      myKeyWordVariable.Ride = ride;
      myKeyWordVariable.Color = color;
      myKeyWordVariable.Adjective = adjective;
      myKeyWordVariable.Animal = animal;
      return View(myKeyWordVariable);
    }

    [Route("/Form")]//should be landing pages that take us to different forms
    public ActionResult Form() { return View(); }
    
    [Route("/CompleteMadLib")]
    public ActionResult CompleteMadLib(string noun, string noun2, string noun3, string noun4, string verb, string verb2, string verb3, string adjective, string adjective2, string occupation)
    {
      KeyWordVariable myKeyWordVariable = new KeyWordVariable();
      myKeyWordVariable.Occupation = occupation;
      myKeyWordVariable.Noun = noun;
      myKeyWordVariable.Noun2 = noun2;
      myKeyWordVariable.Noun3 = noun3;
      myKeyWordVariable.Noun4 = noun4;
      myKeyWordVariable.Verb = verb;
      myKeyWordVariable.Verb2 = verb2;
      myKeyWordVariable.Verb3 = verb3;
      myKeyWordVariable.Adjective = adjective;
      myKeyWordVariable.Adjective2 = adjective2;
      return View(myKeyWordVariable);
    }
  }
}
