using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dota_2_api.Controllers
{
    [Authorize]
    public class HerosController : ApiController
    {
        // GET: api/Heros
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Heros/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Heros
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Heros/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Heros/5
        public void Delete(int id)
        {
        }
    }
}
