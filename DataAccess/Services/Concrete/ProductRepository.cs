﻿using Core.Entities.Concrete;
using DataAccess.Context;
using DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Concrete
{
    public class ProductRepository(AppDbContext context) : 
        BaseRepository<Product>(context), IProductRepository
    {
    }
}
