using System;
using System.ComponentModel.DataAnnotations;

namespace SupermarketAPI.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
