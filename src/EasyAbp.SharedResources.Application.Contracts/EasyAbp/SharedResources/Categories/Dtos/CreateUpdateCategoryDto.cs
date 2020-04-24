using System;
using System.ComponentModel;
namespace EasyAbp.SharedResources.Categories.Dtos
{
    public class CreateUpdateCategoryDto
    {
        [DisplayName("CategoryParentCategoryId")]
        public Guid? ParentCategoryId { get; set; }

        [DisplayName("CategoryName")]
        public string Name { get; set; }
        
        [DisplayName("IsCommon")]
        public bool IsCommon { get; set; }
    }
}