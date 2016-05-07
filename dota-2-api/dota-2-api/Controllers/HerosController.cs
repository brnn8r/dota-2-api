using dota_2_api.Models.Dota2.Interfaces;
using dota_2_api.Repositories.Interfaces;
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
        private readonly IHeroRepository heroRepository;

        public HerosController(IHeroRepository heroRepository)
        {
            this.heroRepository = heroRepository;
        }

        // GET: api/Heros
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var heros = heroRepository.Read();

                return Ok(heros);
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        // GET: api/Heros/5
        public async Task<IHttpActionResult> Get(int id)
        {
            return Ok("value");
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
