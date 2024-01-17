using Business.Abstract;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        private readonly ITransmissionService _transmissionService;
        public TransmissionsController()
        {
            _transmissionService = ServiceRegistration.TransmissionService;
        }

        [HttpGet] // GET http://localhost:5245/api/fuels
        public ICollection<Transmission> GetList()
        {
            IList<Transmission> transmissionList = _transmissionService.getList();
            return transmissionList; // JSON
        }

        //[HttpPost("/add")] // POST http://localhost:5245/api/fuels/add
        [HttpPost] // POST http://localhost:5245/api/fuels
        public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
        {
            AddTransmissionResponse response = _transmissionService.Add(request);

            //return response; // 200 OK
            return CreatedAtAction(nameof(GetList), response); // 201 Created
        }
    }
}
