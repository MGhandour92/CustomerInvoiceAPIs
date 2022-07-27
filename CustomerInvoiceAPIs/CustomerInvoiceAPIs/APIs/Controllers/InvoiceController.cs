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
    public class InvoicesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvoicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<IEnumerable<InvoiceHeader>> Get()
        {
            return Ok(_unitOfWork.InvoiceHeaders.GetFullInvoices());
        }
    }
}