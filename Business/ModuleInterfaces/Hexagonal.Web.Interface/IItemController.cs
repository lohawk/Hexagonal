using Hexagonal.Business.Interface.Item;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.Web.Controllers
{
    public interface IItemController
    {
        IActionResult CreateItem(CreateItem req);
        IActionResult GetItem(int id);
    }
}