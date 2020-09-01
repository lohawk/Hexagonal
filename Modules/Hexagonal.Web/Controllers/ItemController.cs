using Hexagonal.Business.Interface;
using Hexagonal.Business.Interface.Item;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hexagonal.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase, IItemController
    {
        private readonly IApplication _app;

        public ItemController(IApplication app) => _app = app;


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetItem(int id)
        {
            var resp = _app.Dispatch<ItemQuery, BusinessItemResult>(new ItemQuery(id));
            return resp == null
                ? NotFound()
                : (IActionResult)Ok(
                    new ItemDTOResult
                    {
                        Results = resp.Results.Select(r => new ItemDTO
                        {
                            Id = r.Id,
                            Data = r.Data
                        }).ToArray()
                    });
        }

        [HttpPost]
        public IActionResult CreateItem(CreateItem req)
        {
            var resp = _app.Dispatch<CreateItem, BusinessItem>(req);
            return resp == null ? Conflict() : (IActionResult)Ok(new ItemDTO
            {
                Id = resp.Id,
                Data = resp.Data
            });
        }
    }
}
