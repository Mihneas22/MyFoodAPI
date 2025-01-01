using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.MealUseCases
{
    public class MealProtein100gUseCase
    {
        public double? MealProtein100gCalculator(List<Food> foodList, List<int> foodWeights, int totalWeight)
        {
            double? sumProteins= 0;
            double? sumWeight = 0;

            for (int i = 0; i < foodList.Count; i++)
            {
                sumProteins += foodList[i].product!.nutriments!.proteins_100g * foodWeights[i] / 100;
                sumWeight += foodWeights[i];
            }

            return 100 * sumProteins / sumWeight;
        }
    }
}
