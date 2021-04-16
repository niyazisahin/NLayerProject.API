using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seed
{
    public class ProductSeed: IEntityTypeConfiguration<Product>
    {
        private readonly int[] ids;
        public ProductSeed(int[] _ids)
        {
            ids = _ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product { Id = 1, Name = "Kurşun Kalem", CategoryId = ids[0], Price = 50.5m, Stock = 100 });
            builder.HasData(new Product { Id = 2, Name = "Tükenmez Kalem", CategoryId = ids[0], Price = 75.5m, Stock = 100 });
            builder.HasData(new Product { Id = 3, Name = "Pilot Kalem", CategoryId = ids[0], Price = 100.5m, Stock = 100 });
            builder.HasData(new Product { Id = 4, Name = "Küçük Boy Defter", CategoryId = ids[1], Price = 50.5m, Stock = 100 });
            builder.HasData(new Product { Id = 5, Name = "Orta Boy Defter", CategoryId = ids[1], Price = 60.5m, Stock = 100 });
            builder.HasData(new Product { Id = 6, Name = "Büyük Boy Defter", CategoryId = ids[1], Price = 70.5m, Stock = 100 });
        }
    }
}
