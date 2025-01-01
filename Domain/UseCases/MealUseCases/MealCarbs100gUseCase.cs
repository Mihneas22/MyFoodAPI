using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.MealUseCases
{
    public class MealCarbs100gUseCase
    {
        public double? MealCarbs100gCalculator(List<Food> foodList, List<int> foodWeights, int totalWeight)
        {
            double? sumCarbs = 0;
            double? sumWeight = 0;

            for (int i = 0; i < foodList.Count; i++)
            {
                sumCarbs += foodList[i].product!.nutriments!.carbohydrates_100g * foodWeights[i] / 100;
                sumWeight += foodWeights[i];
            }

            return 100*sumCarbs/sumWeight;
        }
    }
}
