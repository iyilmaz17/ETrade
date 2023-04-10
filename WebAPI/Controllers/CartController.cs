using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpGet("aaaa")]
        public IActionResult GetAll(int userId)
        {
            //Thread.Sleep(2000);
            var result = _cartService.GetSummary(userId);
            if (result.IsSuccess)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }
    }
}
