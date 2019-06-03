using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotNetAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionController : ControllerBase
    {
        private readonly ChampionsContext context;
        public ChampionController(ChampionsContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public List<Champion> GetAllChampions(int? role, string sort, int? page, int length = 10, string dir = "asc")
        {
            IQueryable<Champion> query = context.Champions;
            if (role.HasValue)
            {
                query = query.Where(d => (int)d.Role == role);
            }

            if (page.HasValue)
            {
                query = query.Skip(page.Value * length);
            }


            if (!string.IsNullOrWhiteSpace(sort))
            {
                switch (sort)
                {
                    case "Attack":
                        if (dir == "asc")
                        {
                            query = query.OrderBy(d => d.Attack);
                        }
                        else if (dir == "desc")
                        {
                            query = query.OrderByDescending(d => d.Attack);
                        }
                        break;
                    case "Defense":
                        if (dir == "asc")
                        {
                            query = query.OrderBy(d => d.Defense);
                        }
                        else if (dir == "desc")
                        {
                            query = query.OrderByDescending(d => d.Defense);
                        }
                        break;
                    case "Magic":
                        if (dir == "asc")
                        {
                            query = query.OrderBy(d => d.Magic);
                        }
                        else if (dir == "desc")
                        {
                            query = query.OrderByDescending(d => d.Magic);
                        }
                        break;
                    case "Difficulty":
                        if (dir == "asc")
                        {
                            query = query.OrderBy(d => d.Difficuly);
                        }
                        else if (dir == "desc")
                        {
                            query = query.OrderByDescending(d => d.Difficuly);
                        }
                        break;
                }
            }
            query = query.Take(length);
            return query.ToList();
        }

        // GET: api/Champion/5
        [HttpGet("{id}")]
        public ActionResult<Champion> GetChampionById(int id)
        {
            var champion = context.Champions.Find(id);
            if (champion == null)
            {
                return NotFound();
            }
            return Ok(champion);

        }

        // POST: api/Champion
        [HttpPost]
        public IActionResult Post([FromBody] Champion champion)
        {
            //Add book
            context.Champions.Add(champion);
            context.SaveChanges();

            return Created("", champion);
        }

        // PUT: api/Champion
        public IActionResult Put([FromBody] Champion updatedChampion)
        {
            var orgChampion = context.Champions.Find(updatedChampion.Id);
            if (orgChampion == null)
            {
                return NotFound();
            }
            orgChampion.Name = updatedChampion.Name;
            orgChampion.Title = updatedChampion.Title;
            orgChampion.Attack = updatedChampion.Attack;
            orgChampion.Magic = updatedChampion.Magic;
            orgChampion.Defense = updatedChampion.Defense;
            orgChampion.Difficuly = updatedChampion.Difficuly;
            orgChampion.Role = updatedChampion.Role;
            context.SaveChanges();

            return Ok(orgChampion);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var champion = context.Champions.Find(id);
            if (champion == null)
            {
                return NotFound();
            }
            context.Champions.Remove(champion);
            context.SaveChanges();
            return NoContent();

        }
    }
}
