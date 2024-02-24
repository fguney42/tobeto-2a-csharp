using Business;
using Business.Abstract;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        private readonly ITransmissionService _transmissionService;
        public TransmissionsController(ITransmissionService transmissionService)
        {
            _transmissionService = transmissionService;
        }

        [HttpGet]
        public GetTransmissionListResponse GetList([FromQuery] GetTransmissionListRequest request)
        {
            GetTransmissionListResponse response = _transmissionService.GetList(request);

            return response;
        }

        [HttpPost]
        public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
        {
            try
            {
                AddTransmissionResponse response = _transmissionService.Add(request);
                return CreatedAtAction(nameof(GetList), response);
            }
            catch (Core.CrossCuttingConcerns.Exceptions.BusinessException exception)
            {
                return BadRequest(
                    new Core.CrossCuttingConcerns.Exceptions.BusinessProblemDetails()
                    {
                        Title = "Business Exception",
                        Status = StatusCodes.Status400BadRequest,
                        Detail = exception.Message,
                        Instance = HttpContext.Request.Path
                    }
                );
            }
        }
    }
}
