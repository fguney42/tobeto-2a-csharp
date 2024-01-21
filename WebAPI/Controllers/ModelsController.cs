using Business.Abstract;
using Business.Requests.Model;
using Business.Responses.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _modelService;
        public ModelsController(IModelService modelService)
        {
            _modelService = modelService;
        }

        [HttpGet]
        public GetModelListResponse GetList([FromQuery] GetModelListRequest request) // Referans tipleri varsayılan olarak request body'den alır.
        {
            GetModelListResponse response = _modelService.GetList(request);
            return response; // JSON
        }

        [HttpGet("Brand")]
        public GetModelListResponse GetListByBrand([FromQuery] GetModelListRequestByBrand request)
        {
            GetModelListResponse response = _modelService.GetListByBrand(request);
            return response;
        }

        [HttpGet("Fuel")]
        public GetModelListResponse GetListByFuel([FromQuery] GetModelListRequestByFuel request)
        {
            GetModelListResponse response = _modelService.GetListByFuel(request);
            return response;
        }

        [HttpGet("Transmission")]
        public GetModelListResponse GetListByTransmission([FromQuery] GetModelListRequestByTransmission request)
        {
            GetModelListResponse response = _modelService.GetListByTransmission(request);
            return response;
        }

        [HttpPost]
        public ActionResult<AddModelResponse> Add(AddModelRequest request)
        {
            try
            {
                AddModelResponse response = _modelService.Add(request);
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