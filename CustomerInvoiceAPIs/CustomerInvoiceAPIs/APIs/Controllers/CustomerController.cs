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
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Ok(_unitOfWork.Customers.GetAll());
        }

        // POST: api/<CustomerController>
        [HttpPost]
        public ActionResult Post(Customer customer)
        {
            _unitOfWork.Customers.Create(customer);
            //save changes
            _unitOfWork.Complete();
            return Ok();
        }
    }
}