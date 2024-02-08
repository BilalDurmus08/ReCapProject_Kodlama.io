﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void AddBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
        List<Brand> GetAllBrands();
        Brand GetBrandById(int id);

    }

}
