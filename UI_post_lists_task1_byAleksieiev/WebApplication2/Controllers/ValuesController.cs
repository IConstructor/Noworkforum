using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication2
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Topic> Get()
        {
            List<Topic> collection = new List<Topic>
            {
                new Topic()
                {
                Author = "Denys Aleksieiev",
                Date = DateTime.Today,
                Subject = "Want to buy a car",
                Groups = new List<string>
                {
                    "Kudryashova 14",
                    "Zhylianskaya"
                },
                Tags = new List<string>
                {
                    "[SPAM]",
                    "[SELL]"
                }
                },
                new Topic()
                {
                Author = "Igor Ivanov",
                Date = DateTime.Today,
                Subject = "Want to buy a car",
                Groups = new List<string>
                {
                    "Kudryashova 14",
                    "Zhylianskaya"
                },
                Tags = new List<string>
                {
                    "[SPAM]",
                    "[SELL]"
                }
                }
            };

            return collection;
        }



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
