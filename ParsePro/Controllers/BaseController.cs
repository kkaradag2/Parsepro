using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParsePro.Controllers
{
    public class BaseController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(string className)
        {
            return Ok(new { Message = "Method is working",
                            CreateDate = DateTime.Now,
                            ClassName = className,
                            StatusCode = HttpStatusCode.OK});
        }

        
    }
}
