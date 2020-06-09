using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Billing.Controllers
{
    [EnableCors("CORS")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Billing-No-101", "Billing-No-104" };
        }
    }
}