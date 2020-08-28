using Hexagonal.Application.Interface;
using Hexagonal.Application.Interface.Item;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.App.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IApplication _app;

        public ItemController(IApplication app) => _app = app;


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetItem(int id)
        {
            var resp = _app.Dispatch<ItemQuery, ItemResults>(new ItemQuery(id));
            return resp == null ? NotFound() : (IActionResult)Ok(resp);
        }

        [HttpPost]
        public IActionResult CreateItem(CreateItem req)
        {
            var resp = _app.Dispatch<CreateItem, ItemResult>(req);
            return resp == null ? Conflict() : (IActionResult)Ok(resp);
        }
    }
}
