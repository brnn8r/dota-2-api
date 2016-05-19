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
using System.Web.Http.Description;
using Swashbuckle.Swagger.Annotations;
using dota_2_api.ViewModels.Dota2.Errors;

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
        /// <summary>
        /// Retreive the set of all Dota2 heros.
        /// </summary>
        /// <param name="sort">Allows you to sort by one or more fields on a Hero. e.g. To sort by strength gain per level descending and then name ascending: ?sort=-StrengthGainPerLevel,name</param>
        /// <param name="filter">Allows you to filter which heros are returned. e.g. To return only intelligence heros: ?filter=type:Intelligence</param>
        /// <returns>HeroDto</returns>
        [ResponseType(typeof(IEnumerable<HeroDto>))]
        [SwaggerResponse(HttpStatusCode.OK, Type=typeof(IEnumerable<HeroDto>))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type=typeof(UserError))]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> Get(string sort = "name", string filter = "")
        {
            try
            {
                var heros = mapper.Map<IEnumerable<HeroDto>>(heroRepository.Read()).                    
                    Sort(sort);                

                return Ok(heros);
            }
            catch(SortException se)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, new UserError("InvalidSortParameter", String.Format("Invalid sort parameter {0}", sort), String.Format("Invalid sort parameter {0}", sort))));

                //return BadRequest();



            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        // GET: api/Heros/axe      
        /// <summary>
        /// Retreive a specific hero by name.
        /// </summary>
        /// <param name="name">The name of the hero to retrieve.</param>        
        /// <returns>HeroDto</returns>
        [ResponseType(typeof(HeroDto))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(HeroDto))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> Get(string name)
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
