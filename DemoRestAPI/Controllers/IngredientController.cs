using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoBLL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using DemoBLL.BusinessObjects;

namespace DemoRestAPI.Controllers
{
    [EnableCors("MyPolicy")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class IngredientController : Controller
    {
        IBLLFacade facade;

        public IngredientController(IBLLFacade facade)
        {
            this.facade = facade;
        }

        [HttpGet]
        public IEnumerable<IngredientBO> Get()
        {
            return facade.IngredientService.GetAll();
        }

        [HttpGet("{Id}")]
        public IngredientBO Get(int Id)
        {
            return facade.IngredientService.Get(Id);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                return Ok(facade.IngredientService.Delete(Id));
            }
            catch (InvalidOperationException e)
            {
                return StatusCode(404, e.Message);
            }
        }

        [HttpPut("{Id}")]
        public IngredientBO Put(int id, [FromBody] IngredientBO ind)
        {
            return facade.IngredientService.Update(ind);
        }

        [HttpPost]
        public IngredientBO Post([FromBody] IngredientBO ind)
        {
            return facade.IngredientService.Create(ind);
        }
    }
}
