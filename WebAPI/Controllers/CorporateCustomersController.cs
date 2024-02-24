﻿// CorporateCustomersController.cs
using Business.Abstract;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateCustomersController : ControllerBase
    {
        private readonly ICorporateCustomerService _corporateCustomerService;

        public CorporateCustomersController(ICorporateCustomerService corporateCustomerService)
        {
            _corporateCustomerService = corporateCustomerService;
        }

        [HttpGet] // GET http://localhost:5245/api/corporatecustomers
        public ActionResult<GetCorporateCustomerListResponse> GetList([FromQuery] GetCorporateCustomerListRequest request)
        {
            GetCorporateCustomerListResponse response = _corporateCustomerService.GetList(request);
            return Ok(response);
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/corporatecustomers/1
        public ActionResult<GetCorporateCustomerByIdResponse> GetById([FromRoute] GetCorporateCustomerByIdRequest request)
        {
            GetCorporateCustomerByIdResponse response = _corporateCustomerService.GetById(request);
            return Ok(response);
        }

        [HttpPost] // POST http://localhost:5245/api/corporatecustomers
        public ActionResult<AddCorporateCustomerResponse> Add([FromBody] AddCorporateCustomerRequest request)
        {
            AddCorporateCustomerResponse response = _corporateCustomerService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id },
                value: response
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/corporatecustomers/1
        public ActionResult<UpdateCorporateCustomerResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateCorporateCustomerRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateCorporateCustomerResponse response = _corporateCustomerService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/corporatecustomers/1
        public ActionResult<DeleteCorporateCustomerResponse> Delete([FromRoute] DeleteCorporateCustomerRequest request)
        {
            DeleteCorporateCustomerResponse response = _corporateCustomerService.Delete(request);
            return Ok(response);
        }
    }
}
