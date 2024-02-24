using Business.Abstract;
using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualCustomersController : ControllerBase
    {
        private readonly IIndividualCustomerService _individualCustomerService;

        public IndividualCustomersController(IIndividualCustomerService individualCustomerService)
        {
            _individualCustomerService = individualCustomerService;
        }

        [HttpGet] // GET http://localhost:5245/api/individualcustomers
        public ActionResult<GetIndividualCustomerListResponse> GetList([FromQuery] GetIndividualCustomerListRequest request)
        {
            GetIndividualCustomerListResponse response = _individualCustomerService.GetList(request);
            return Ok(response);
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/individualcustomers/1
        public ActionResult<GetIndividualCustomerByIdResponse> GetById([FromRoute] GetIndividualCustomerByIdRequest request)
        {
            GetIndividualCustomerByIdResponse response = _individualCustomerService.GetById(request);
            return Ok(response);
        }

        [HttpPost] // POST http://localhost:5245/api/individualcustomers
        public ActionResult<AddIndividualCustomerResponse> Add([FromBody] AddIndividualCustomerRequest request)
        {
            AddIndividualCustomerResponse response = _individualCustomerService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id },
                value: response
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/individualcustomers/1
        public ActionResult<UpdateIndividualCustomerResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateIndividualCustomerRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateIndividualCustomerResponse response = _individualCustomerService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/individualcustomers/1
        public ActionResult<DeleteIndividualCustomerResponse> Delete([FromRoute] DeleteIndividualCustomerRequest request)
        {
            DeleteIndividualCustomerResponse response = _individualCustomerService.Delete(request);
            return Ok(response);
        }
    }
}
