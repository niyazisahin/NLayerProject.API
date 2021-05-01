using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTOs
{
    public class CategoryWihtProductDto : CategoryDto
    {
        // İsim duyarlılığı var. İsimler model isimleriyle aynı olmalı.
        public ICollection<ProductDto> Product { get; set; }
    }
}
