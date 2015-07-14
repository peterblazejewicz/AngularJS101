using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using AngularJS101.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyNamespace
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {

        // GET: api/values
        [HttpGet]
        public IEnumerable<DOTAHero> Get()
        {
            HeroManager HM = new HeroManager();
            return HM.GetAll;
        }

        // GET api/values/7
        [HttpGet("{id}")]
        public DOTAHero Get(int id)
        {
            HeroManager HM = new HeroManager();
            return HM.GetHeroByID(id);
        }

    }
}
