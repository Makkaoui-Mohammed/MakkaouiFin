using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MakkaouiFin.Controllers
{
    public class ControllerMK : Controller
    {
        public string Welcome (string name, int ID=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},{ID}");
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}

//https://localhost:7154/ControllerMK/Welcome?name=simo&ID=6