using Business.Abstract;
using Business.Requests.Car;
using Business.Responses.Car;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public GetCarListResponse GetList([FromQuery] GetCarListRequest request) // Referans tipleri varsayılan olarak request body'den alır.
        {
            GetCarListResponse response = _carService.GetList(request);
            return response; // JSON
        }

        [HttpPost]
        public ActionResult<AddCarResponse> Add(AddCarRequest request)
        {
            try
            {
                AddCarResponse response = _carService.Add(request);
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