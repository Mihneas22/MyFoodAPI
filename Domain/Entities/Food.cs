using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Nutriments
    {
        public double? carbohydrates { get; set; }
        public double? carbohydrates_100g { get; set; }
        public string? carbohydrates_unit { get; set; }
        public double? carbohydrates_value { get; set; }
        public int? energy { get; set; }
        public int? energykcal { get; set; }
        public int? energykcal_100g { get; set; }
        public string? energykcal_unit { get; set; }
        public int? energykcal_value { get; set; }
        public double? energykcal_value_computed { get; set; }
        public int? energy_100g { get; set; }
        public string? energy_unit { get; set; }
        public int? energy_value { get; set; }
        public double? fat { get; set; }
        public double? fat_100g { get; set; }
        public string? fat_unit { get; set; }
        public double? fat_value { get; set; }
        public int? fruitsvegetableslegumesestimatefromingredients_100g { get; set; }
        public int? fruitsvegetableslegumesestimatefromingredients_serving { get; set; }
        public double? fruitsvegetablesnutsestimatefromingredients_100g { get; set; }
        public double? fruitsvegetablesnutsestimatefromingredients_serving { get; set; }
        public int? novagroup { get; set; }
        public int? novagroup_100g { get; set; }
        public int? novagroup_serving { get; set; }
        public int? nutritionscorefr { get; set; }
        public int? nutritionscorefr_100g { get; set; }
        public double? proteins { get; set; }
        public double? proteins_100g { get; set; }
        public string? proteins_unit { get; set; }
        public double? proteins_value { get; set; }
        public double? salt { get; set; }
        public double? salt_100g { get; set; }
        public string? salt_unit { get; set; }
        public double? salt_value { get; set; }
        public double? saturatedfat { get; set; }
        public double? saturatedfat_100g { get; set; }
        public string? saturatedfat_unit { get; set; }
        public double? saturatedfat_value { get; set; }
        public double? sodium { get; set; }
        public double? sodium_100g { get; set; }
        public string? sodium_unit { get; set; }
        public double? sodium_value { get; set; }
        public double? sugars { get; set; }
        public double? sugars_100g { get; set; }
        public string? sugars_unit { get; set; }
        public double? sugars_value { get; set; }
    }

    public class NutriscoreData
    {
        public int? energy { get; set; }
        public int? energy_points { get; set; }
        public int? energy_value { get; set; }
        public double? fiber { get; set; }
        public int? fiber_points { get; set; }
        public double? fiber_value { get; set; }
        public double? fruits_vegetables_nuts_colza_walnut_olive_oils { get; set; }
        public int? fruits_vegetables_nuts_colza_walnut_olive_oils_points { get; set; }
        public double? fruits_vegetables_nuts_colza_walnut_olive_oils_value { get; set; }
        public string? grade { get; set; }
        public int? is_beverage { get; set; }
        public int? is_cheese { get; set; }
        public int? is_fat { get; set; }
        public int? is_water { get; set; }
        public int? negative_points { get; set; }
        public int? positive_points { get; set; }
        public double? proteins { get; set; }
        public int? proteins_points { get; set; }
        public double? proteins_value { get; set; }
        public double? saturated_fat { get; set; }
        public int? saturated_fat_points { get; set; }
        public double? saturated_fat_value { get; set; }
        public int? score { get; set; }
        public double? sodium { get; set; }
        public int? sodium_points { get; set; }
        public double? sodium_value { get; set; }
        public double? sugars { get; set; }
        public int? sugars_points { get; set; }
        public double? sugars_value { get; set; }
    }

    public class Product
    {
        public Nutriments? nutriments { get; set; }
        public NutriscoreData? nutriscore_data { get; set; }
        public string? nutrition_grades { get; set; }
        public string? product_name { get; set; }
    }

    public class Food
    {
        public string? code { get; set; }
        public Product? product { get; set; }
        public int? status { get; set; }
        public string? status_verbose { get; set; }
    }
}
