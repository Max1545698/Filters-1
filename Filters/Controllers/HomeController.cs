using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    //[RequireHttps]
    //[HttpsOnly]
    //[Profile]
    //[ViewResultDetails]
    //[RangeException]
    //[TypeFilter(typeof(DiagnosticsFilter))]
    //[TypeFilter(typeof(TimeFilter))]
    //[ServiceFilter(typeof(TimeFilter))]
    [Message("This is the Controller-Scoped Filter",Order=10)]
    public class HomeController : Controller
    {
        //[RequireHttps]
        [Message("This is the First Action-Scoped Filter",Order = 1)]
        [Message("This is the Second Action-Scoped Filter",Order = -1)]
        public ViewResult Index()
        {
            return View("Message", "This is the Index action on the Home controller");
        }

        //[RequireHttps]
        public ViewResult SecondAction()
        {
            return View("Message", "This is the SecondAction action on the Home controller");
        }

        public ViewResult GenerateException(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            else if (id > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return View("Message", $"The value is {id}");
            }
        }
    }
}