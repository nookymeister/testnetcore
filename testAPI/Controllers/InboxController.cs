using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testAPI.Models;

namespace testAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InboxController : ControllerBase
    {
        // GET: api/Inbox
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Inbox/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // GET: api/Inbox/
        [HttpGet]
        public ActionResult Get([FromBody]InboxViewModels model)
        {
            return Ok(model);
        }

        // POST: api/Inbox
        [HttpPost]
        public void Post([FromBody] InboxViewModels model)
        {
        }

        // PUT: api/Inbox/5
        [HttpPut]
        public void Put([FromBody]InboxViewModels model)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
