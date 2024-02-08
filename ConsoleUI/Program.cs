﻿using Business.Concrete;
using DataAccess.Concrete.InEntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAllCarsTEST();
            //GetCarsByIdTEST();
            //GetCarsByBrandIdTEST();



        }

        private static void GetAllCarsTEST()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("Id: " + car.Id +
                                  "\nBrandId: " + car.BrandId +
                                  "\nColorId: " + car.ColorId +
                                  "\nModelYear: " + car.ModelYear +
                                  "\nDailyPrice: " + car.DailyPrice +
                                  "\nCarName: " + car.CarName);
                Console.WriteLine("-----------------------------------");
            }
        }

        private static void GetCarsByBrandIdTEST()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            List<Car> byBrand = carManager2.GetCarsyByBrandId(50);
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            foreach (Car car in byBrand)
            {
                Console.WriteLine("Id: " + car.Id +
                                "\nBrandId: " + car.BrandId +
                                "\nColorId: " + car.ColorId +
                                "\nModelYear: " + car.ModelYear +
                                "\nDailyPrice: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
        }

        private static void GetCarsByIdTEST()
        {
            CarManager carManager1 = new CarManager(new EfCarDal());

            List<Car> byColor = carManager1.GetCarsByColorId(102);
            foreach (Car car in byColor)
            {
                Console.WriteLine("Id: " + car.Id +
                                "\nBrandId: " + car.BrandId +
                                "\nColorId: " + car.ColorId +
                                "\nModelYear: " + car.ModelYear +
                                "\nDailyPrice: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
        }
    }

}
