using APIs.Helpers;
using Domain.Entities;
using Domain.Main;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: api/<ItemController>
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            return Ok(_unitOfWork.Items.GetAll());
        }
    }
}