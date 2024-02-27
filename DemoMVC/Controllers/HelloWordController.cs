using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace DemoMVC.Controllers;
{
    public class HelloWordController : Controller
    
    {
    public string  Index() 
    {return "Hello Word"}
    public string Welcome()
    {return "202"}
    }    
}

