using Business.Abstract;
using Business.Requests;
using Business.Requests.Customer;
using Business.Responses.Customer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet] // GET http://localhost:5245/api/customers
        public ActionResult<GetCustomerListResponse> GetList([FromQuery] GetCustomerListRequest request)
        {
            GetCustomerListResponse response = _customerService.GetList(request);
            return Ok(response);
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/customers/1
        public ActionResult<GetCustomerByIdResponse> GetById([FromRoute] GetCustomerByIdRequest request)
        {
            GetCustomerByIdResponse response = _customerService.GetById(request);
            return Ok(response);
        }

        [HttpPost] // POST http://localhost:5245/api/customers
        public ActionResult<AddCustomerResponse> Add([FromBody] AddCustomerRequest request)
        {
            AddCustomerResponse response = _customerService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id },
                value: response
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/customers/1
        public ActionResult<UpdateCustomerResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateCustomerRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateCustomerResponse response = _customerService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/customers/1
        public ActionResult<DeleteCustomerResponse> Delete([FromRoute] DeleteCustomerRequest request)
        {
            DeleteCustomerResponse response = _customerService.Delete(request);
            return Ok(response);
        }
    }
}