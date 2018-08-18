using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    public class GlobalController : Controller
    {
        public ViewResult Index() => View("Message", "This is the Global controller"); 
    }
}