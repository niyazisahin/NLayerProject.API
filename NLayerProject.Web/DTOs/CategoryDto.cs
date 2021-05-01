using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTOs
{
    public class CategoryDto
    {
        //DTO : görünmesini istediğimiz özellikler için kullandığımız yapı.
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} alanı boş geçilemez.")]
        public string Name { get; set; }
    }
}
