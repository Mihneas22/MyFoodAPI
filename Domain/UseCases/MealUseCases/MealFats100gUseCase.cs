using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.MealUseCases
{
    public class MealFats100gUseCase
    {
        public double? MealFats100gCalculator(List<Food> foodList, List<int> foodWeights, int totalWeight)
        {
            double? sumFats = 0;
            double? sumWeight = 0;

            for (int i = 0; i < foodList.Count; i++)
            {
                sumFats += foodList[i].product!.nutriments!.fat_100g * foodWeights[i] / 100;
                sumWeight += foodWeights[i];
            }

            return 100 * sumFats / sumWeight;
        }
    }
}
