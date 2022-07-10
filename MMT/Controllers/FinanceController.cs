using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMT.Controllers
{
    public class FinanceController : Controller
    {
        [HttpGet]
        [Route("Finance/GetMonthly")]
        public IActionResult GetMonthyOverview(int month, int UserID)
        {
            throw new NotImplementedException();
        }
    }
}
