using System.Collections.Generic;
using OakIdeas.Schema.Core.Intangibles;

namespace OakIdeas.Schema.Core.CreativeWorks
{
    /// <summary>
    /// A recipe.
    /// </summary>
    /// <see cref="http://www.schema.org/Recipe"/>
    public class Recipe : CreativeWork
    {
        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        public string CookingMethod { get; set; }
        /// <summary>
        /// The time it takes to actually cook the dish, in ISO 8601 duration format.
        /// </summary>
        public Duration CookTime { get; set; }
        /// <summary>
        /// An ingredient used in the recipe.
        /// </summary>
        public IEnumerable<string> Ingredients { get; set; }
        /// <summary>
        /// Nutrition information about the recipe.
        /// </summary>
        public NutrionInformation Nutrion { get; set; }
        /// <summary>
        /// The length of time it takes to prepare the recipe, in ISO 8601 duration format.
        /// </summary>
        public Duration PrepTime { get; set; }
        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        public string RecipeCategory { get; set; }
        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethopian).
        /// </summary>
        public string RecipeCuisine { get; set; }
        /// <summary>
        /// The steps to make the dish.
        /// </summary>
        public string RecipeInstructions { get; set; }
        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        public string RecipeYield { get; set; }
        /// <summary>
        /// The total time it takes to prepare and cook the recipe, in ISO 8601 duration format.
        /// </summary>
        public Duration TotalTime { get; set; }
    }
}
