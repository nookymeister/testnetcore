﻿using System;
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
       [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET: api/Inbox/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // GET: api/Inbox/


        [HttpGet]
        [Route("GetList")]
        public ActionResult GetList()
        {
            var modelList = new List<InboxViewModels>
            {
                new InboxViewModels() { DocID = 1 , Date = "2019-03-15" },
                new InboxViewModels() { DocID = 2 , Date = "2019-03-16" },
                new InboxViewModels() { DocID = 3 , Date = "2019-03-17" },
                new InboxViewModels() { DocID = 4 , Date = "2019-03-18" }
        };
            return Ok(modelList);
        }

        [HttpGet]
        [Route("GetDetail")]
        public ActionResult GetDetail(int DocID)
        {
            var modelList = new List<InboxViewModels>
            {
                new InboxViewModels() { DocID = 1 , Date = "2019-03-15" },
                new InboxViewModels() { DocID = 2 , Date = "2019-03-16" },
                new InboxViewModels() { DocID = 3 , Date = "2019-03-17" },
                new InboxViewModels() { DocID = 4 , Date = "2019-03-18" }
            };
            
            return Ok(modelList);
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
