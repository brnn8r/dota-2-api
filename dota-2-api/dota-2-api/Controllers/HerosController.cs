using dota_2_api.Models.Dota2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace dota_2_api.Controllers
{
    [Authorize]
    public class HerosController : ApiController
    {
        // GET: api/Heros
        public async Task<IEnumerable<IHero>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Heros/5
        public async Task<string> Get(int id)
        {
            return "value";
        }

        // POST: api/Heros
        public async void Post([FromBody]string value)
        {
        }

        // PUT: api/Heros/5
        public async void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Heros/5
        public async void Delete(int id)
        {
        }
    }
}
