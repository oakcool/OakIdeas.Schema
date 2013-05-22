using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Microdata.Organizations.LocalBusinesses.FoodEstablishments
{
    /// <summary>
    /// A food-related business.
    /// </summary>
    /// <see cref="http://www.schema.org/FoodEstablishment"/>
    public class FoodEstablishment : LocalBusiness
    {
        /// <summary>
        /// Either Yes/No, or a URL at which reservations can be made.
        /// </summary>
        public string AcceptsReservations { get; set; }
        /// <summary>
        /// Either the actual menu or a URL of the menu.
        /// </summary>
        public string Menu { get; set; }
        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        public string ServesCuisine { get; set; }
    }
}
