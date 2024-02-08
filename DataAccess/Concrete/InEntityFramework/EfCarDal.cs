﻿using Core.DataAccess;
using Core.DataAccess.EntitFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InEntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Rent_A_CarContext>, ICarDal
    {
       
    }

}