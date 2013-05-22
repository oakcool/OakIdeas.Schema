using OakIdeas.Schema.Microdata.Intangibles.Quantities;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues;

namespace OakIdeas.Schema.Microdata.Intangibles
{
    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    /// <see cref="http://www.schema.org/NutritionInformation"/>
    public class NutrionInformation : StructuredValue
    {
        /// <summary>
        /// The number of calories
        /// </summary>
        public Energy Calories { get; set; }
        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        public Mass CarbohydrateContent { get; set; }
        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        public Mass CholesterolContent { get; set; }
        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        public Mass FatContent { get; set; }
        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        public Mass FiberContent { get; set; }
        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        public Mass ProteinContent { get; set; }
        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        public Mass SaturatedFatContent { get; set; }
        /// <summary>
        /// The serving size, in terms of the number of volume or mass
        /// </summary>
        public string ServingSize { get; set; }
        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        public Mass SodiumContent { get; set; }
        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        public Mass SugarContent { get; set; }
        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        public Mass TransFatContent { get; set; }
        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        public Mass UnsaturatedFatContent { get; set; }
    }
}
