using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.AddCustomer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            //Chamar use case para adicionar o customer
            return Created("", input);
        }
    }
}
