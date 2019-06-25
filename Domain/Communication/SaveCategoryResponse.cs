using System;
using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        public Category category { get; private set; }

        private SaveCategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            this.category = category;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public SaveCategoryResponse(Category category) : this(true, string.Empty, category)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveCategoryResponse(string message) : this(false, message, null)
        { }
    }
}
