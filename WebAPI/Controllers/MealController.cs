using Application.DTOs.Repository.AddMeal;
using Application.DTOs.Repository.GetMealByName;
using Application.DTOs.Repository.GetMeal;
using Application.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.Repository.AddRating;
using Application.DTOs.Repository.GetRatesForMeal;

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
        //GET
        [HttpGet("getMealByName/{name}")]
        public async Task<ActionResult<GetMealByNameResponse>> GetMealAsync(string name)
        {
            var result = await _meal.GetMealByName(new GetMealByNameDTO { Name = name });
            return Ok(result);
        }

        [HttpGet("rating/getRatesForMeal/{MealName}")]
        public async Task<ActionResult<GetRatesForMealResponse>> GetRatesForMealAsync(string MealName)
        {
            var result = await _meal.GetRatesForMeal(new GetRatesForMealDTO { MealName = MealName });
            return Ok(result);
        }


        //POST  
        [HttpPost("addMeal")]
        public async Task<ActionResult<AddMealResponse>> AddMealAsync(AddMealDTO addMealDTO)
        {
            var result = await _meal.AddMeal(addMealDTO);
            return Ok(result);
        }

        [HttpPost("rating/addRating")]
        public async Task<ActionResult<AddRatingResponse>> AddRatingAsync(AddRatingDTO addRatingDTO)
        {
            var result = await _meal.AddRatingForMeal(addRatingDTO);
            return Ok(result);
        }
    }
}
