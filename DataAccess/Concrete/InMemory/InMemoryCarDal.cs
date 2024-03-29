﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car (){Id = 55, BrandId = 10, ColorId = 12, ModelYear = 2000, DailyPrice = 100000},
                new Car (){Id = 60, BrandId = 10, ColorId = 123, ModelYear = 2005, DailyPrice = 50000},
                new Car (){Id = 65, BrandId = 20, ColorId = 546, ModelYear = 2005, DailyPrice = 250000},
                new Car (){Id = 70, BrandId = 20, ColorId = 546, ModelYear = 2000, DailyPrice = 109090},
                new Car (){Id = 75, BrandId = 30, ColorId = 546, ModelYear = 2018, DailyPrice = 75000},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar;
            deleteCar = _cars.FirstOrDefault(c => c.Id == car.Id);
            if (deleteCar != null)
            {
                _cars.Remove(deleteCar);
            }
            else
            {
                Console.WriteLine("The car is not valid");
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updataCar;
            updataCar = _cars.FirstOrDefault(c =>c.Id == car.Id); 
            if (updataCar != null)
            {
                updataCar.DailyPrice = car.DailyPrice;
                updataCar.BrandId = car.BrandId;
                updataCar.ColorId = car.ColorId;
                updataCar.ModelYear = car.ModelYear;
            }
            else
            {
                Console.WriteLine("Car is not valid");
            }
        }
    
    }

}
