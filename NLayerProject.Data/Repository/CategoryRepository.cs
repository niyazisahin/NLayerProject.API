﻿using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext;}
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await appDbContext.Categories.Include(x => x.Product).
                SingleOrDefaultAsync(x=>x.Id == categoryId);
        }


    }
}
