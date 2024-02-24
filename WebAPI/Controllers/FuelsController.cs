using Business;
using Business.Abstract;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelsController : ControllerBase
    {

        private readonly IFuelService _fuelService;
        public FuelsController(IFuelService fuelService)
        {
            _fuelService = fuelService;
        }

        [HttpGet]
        public GetFuelListResponse GetList([FromQuery] GetFuelListRequest request) // Referans tipleri varsayılan olarak request body'den alır.
        {
            GetFuelListResponse response = _fuelService.GetList(request);
            return response; // JSON
        }

        //[HttpPost("/add")]
        [HttpPost]
        public ActionResult<AddFuelResponse> Add(AddFuelRequest request)
        {
            try
            {
                AddFuelResponse response = _fuelService.Add(request);
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
