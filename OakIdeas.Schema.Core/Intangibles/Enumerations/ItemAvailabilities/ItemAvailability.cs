namespace OakIdeas.Schema.Core.Intangibles.Enumerations.ItemAvailabilities
{
    /// <summary>
    /// A list of possible product availablity options.
    /// </summary>
    /// <see cref="http://www.schema.org/ItemAvailability"/>
    public enum ItemAvailability
    {
        /// <summary>
        /// Indicates that the item for sale has been discontinued.
        /// </summary>
        Discontinued,
        /// <summary>
        /// Indicates that the item for sale is in stock.
        /// </summary>
        InStock,
        /// <summary>
        /// Indicates that the item for sale is available only in brick-and-mortar stores.
        /// </summary>
        InStoreOnly,
        /// <summary>
        /// Indicates that the item for sale is available only online.
        /// </summary>
        OnlineOnly,
        /// <summary>
        /// Indicates that the item for sale is out of stock.
        /// </summary>
        OutOfStock,
        /// <summary>
        /// Indicates that the item for sale is available for pre-order.
        /// </summary>
        PreOrder
    }
}
