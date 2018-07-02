using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient("Donny Darko");
            myLetterVariable.SetSender("Tom Ace");
            return View(myLetterVariable);
        }

        [Route("/journal")]
        public ActionResult Journal()
        {
            return View();
        }
    }
}
