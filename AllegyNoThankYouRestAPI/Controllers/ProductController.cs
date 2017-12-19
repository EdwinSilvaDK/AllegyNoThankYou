using System;


using System.Collections.Generic;
using AllegyNoThankYouBLL;
using AllegyNoThankYouBLL.BusinessObjects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace AllegyNoThankYouRestAPI.Controllers
{
    [EnableCors("MyPolicy")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        IBLLFacade facade;

        public ProductController(IBLLFacade facade)
        {
            this.facade = facade;
        }

        [HttpGet]
        public IEnumerable<ProductBO> Get()
        {
            return facade.ProductService.GetAll();
        }

        [HttpGet("{Id}")]
        public ProductBO Get(int Id)
        {
            return facade.ProductService.Get(Id);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                return Ok(facade.ProductService.Delete(Id));
            }
            catch (InvalidOperationException e)
            {
                return StatusCode(404, e.Message);
            }
        }

        [HttpPut("{Id}")]
        public ProductBO Put(int id, [FromBody] ProductBO pro)
        {
            return facade.ProductService.Update(pro);
        }


        [HttpPost]
        [Route("")]

        public ProductBO Post([FromBody] ProductBO pro)
        {
            return facade.ProductService.Create(pro);
        }


        [HttpPost]
        [Route("FilteredProducts")]
        public List<ProductBO> FilteredList([FromBody]List<int> ids)
        {

            var filterProduct = facade.ProductService.FilteretProduct(ids);
            return filterProduct;

        }
       




    }
}
