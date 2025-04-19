using Core.Entities.Concrete;
using DataAccess.Context;
using DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Concrete
{
    public class CategoryRepository(AppDbContext context) : 
        BaseRepository<Category>(context), ICategoryRepository
    {
    }
}
