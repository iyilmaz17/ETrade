using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Thread.Sleep(2000);
            var result = _brandService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }
    }
}
