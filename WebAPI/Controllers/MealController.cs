using Application.DTOs.Repository.AddMeal;
using Application.DTOs.Repository.GetMealByName;
using Application.DTOs.Repository.GetMeal;
using Application.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMeal _meal;

        public MealController(IMeal meal)
        {
            _meal = meal;
        }

        [HttpGet("getMealByName/{name}")]
        public async Task<ActionResult<GetMealByNameResponse>> GetMealAsync(string name)
        {
            var result = await _meal.GetMealByName(new GetMealByNameDTO { Name = name});
            return Ok(result);
        }

        [HttpPost("addMeal")]
        public async Task<ActionResult<AddMealResponse>> AddMealAsync(AddMealDTO addMealDTO)
        {
            var result = await _meal.AddMeal(addMealDTO);
            return Ok(result);
        }
    }
}
