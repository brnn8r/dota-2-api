using AutoMapper;
using dota_2_api.Models.Dota2.Interfaces;
using dota_2_api.Repositories.Interfaces;
using dota_2_api.ViewModels.Dota2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using dota_2_api.Services.Dota2;
using System.Linq.Dynamic;

namespace dota_2_api.Controllers
{
    [Authorize]
    public class HerosController : ApiController
    {
        private readonly IMapper mapper;
        private readonly IHeroRepository heroRepository;

        public HerosController(IMapper mapper, IHeroRepository heroRepository)
        {
            this.heroRepository = heroRepository;
            this.mapper = mapper;
        }

        // GET: api/Heros
        public async Task<IHttpActionResult> Get(string sort = "name")
        {
            try
            {
                var heros = mapper.Map<IEnumerable<HeroDto>>(heroRepository.Read()).                    
                    Sort(sort);                

                return Ok(heros);
            }
            catch(ParseException pe)
            {
                return BadRequest(String.Format("Invalid sort parameter {0}",sort));
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        // GET: api/Heros/axe        
        public async Task<IHttpActionResult> Get(string name, string sort = "name")
        {

            try
            {
                var hero = mapper.Map<HeroDto>(heroRepository.ReadByName(name));                

                if (hero == null)
                {
                    return NotFound();
                }

                return Ok(hero);
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        //// POST: api/Heros
        //public async void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Heros/5
        //public async void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Heros/5
        //public async void Delete(int id)
        //{
        //}
    }
}
