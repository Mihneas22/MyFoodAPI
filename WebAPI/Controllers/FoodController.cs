using Application.Services.GetFoodByCode;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.Services.GetFoodByCode;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFood _foodRepository;

        public FoodController(IFood foodRepository)
        {
            _foodRepository = foodRepository;
        }

        [HttpGet("getFoodByCode/{code}")]
        public async Task<ActionResult<GetFoodByCodeResponse>> GetFoodByCode(string code)
        {
            var result = await _foodRepository.GetFoodByCodeAsync(new GetFoodByCodeDTO { code = code });
            return Ok(result);
        }
    }
}
