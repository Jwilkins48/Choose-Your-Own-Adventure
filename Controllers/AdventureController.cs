using Microsoft.AspNetCore.Mvc;

namespace ChooseYourAdventure.Controllers;

[Route("adventure")]
public class AdventureController : Controller
{
    [HttpGet("start")]
    public IActionResult Start()
    {
        string? content =
            @"
            <h2>Kingdom of Veoria </h2>
            <p>Welcome to the land of Veoria, a beautiful and thriving Kingdom</p> 
            <p>In the Kingdom of Veoria, there is a fair and just King named King Faelar. He is aided by his loving daughter, Princess Elia</p> <br/>
            <p>20 years ago, the kingdom was plagued by an evil Witch named Isobel Jinx.</p>
            <p>With her power of transfiguration, Isobel disguised herself as a servant of the Queen with plans to kill her secretly and take her place as ruler.</p> <br/>
            <p>Isobel was discovered before her plan was complete and was surrounded by the kings men.</p>
            <p>In a desperate attempt to escape capture, Isobel created a large explosion that destroyed a large portion of the castle, killing many the king's men, and sadly, the Queen herself.</p>  
            <p>Isobel was presumed dead and the kingdom mourned the loss of their beloved Queen.</p> <br/>
            <p>Since that time, all has been calm and peaceful in the kingdom, but King Faelar can't seem to shake this terrible feeling that this isn't over...</p> 

            <h2>Choose Your Character: </h2>
            <h3><a href='/adventure/character/King'>King Faelar</a><br/><br/>
            <a href='/adventure/character/Princess'>Princess Elia</a> <br/><br/>
            <a href='/adventure/character/Knight'>Knight Alinar</a><h3><br/><br/>";

        return Content(content, "text / html");
    }
}
