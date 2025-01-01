using Application.DTOs.Services.GetFoodByCode;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.GetFoodByCode
{
    public class FoodService : IFood
    {
        private readonly HttpClient _httpClient;

        public FoodService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetFoodByCodeResponse> GetFoodByCodeAsync(GetFoodByCodeDTO getFoodByCodeDTO)
        {
            var connection = await _httpClient.GetAsync($"https://world.openfoodfacts.net/api/v2/product/{getFoodByCodeDTO.code}?fields=product_name,nutriscore_data,nutriments,nutrition_grades");
            var result = await connection.Content.ReadFromJsonAsync<Food>();

            if (connection.StatusCode != System.Net.HttpStatusCode.OK)
                return new GetFoodByCodeResponse(false, "Unsucesfull retrieval");

            return new GetFoodByCodeResponse(true, "Succesfull retrieval!", result!);
        }
    }
}
