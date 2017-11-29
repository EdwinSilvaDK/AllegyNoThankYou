using System.Collections.Generic;
using DemoBLL;
using DemoBLL.BusinessObjects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DemoRestAPI.Controllers
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
	    public void delete(int Id)
	    {
	        facade.ProductService.Delete(Id);
	    }

	    [HttpPut("{Id}")]
	    public ProductBO Put(int id,[FromBody] ProductBO pro)
	    {
	        return facade.ProductService.Update(pro);
	    }

	    [HttpPost]
	    public ProductBO Post([FromBody] ProductBO pro)
	    {
	        return facade.ProductService.Create(pro);
	    }
	}
}
