//using Business.Concrete;
//using DataAccess.Concrete.EntityFramework;
//using Entities.Concrete;

//namespace ConsoleUI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //AddBrandTest(); //success
//            //DeleteBrandTest(); //success
//            //UpdateBrandTest(); //success
//            //GetAllBrandsTest(); //success
//            //GetByIdTest(); //success

//            //AddColorTest(); //success
//            //DeleteColorTest(); //success
//            //UpdateColorTest(); //success
//            //GetAllColorsTest(); //success
//            //GetByIdColorTest(); //success

//            //AddCarTest(); //success
//            //DeleteCarTest(); //success
//            //UpdateCarTest(); //fail
//            //GetAllCarsTest(); //success
//            //GetByIdCarTest(); //success

//            //UpdateCarTest2(); //success

//            //UserAdd();
//            //RentalAddTest();

//        }

//        private static void RentalAddTest()
//        {
//            RentalManager rentalManager = new RentalManager(new EfRentalDal());
//            rentalManager.Add(new Rental
//            {
//                CarId = 2,
//                CustomerId = 4,
//                RentDate = DateTime.Now

//            });
//        }

        

//        private static void UpdateCarTest2()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            carManager.Update(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 600, Description = "Captiva", ModelYear = 2012 });
//        }

//        private static void GetByIdCarTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            Console.WriteLine(carManager.GetById(1).Data.DailyPrice);
//        }

//        private static void GetAllCarsTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            var result = carManager.GetCarDetails();
//            if (result.Success == true)
//            {
//                foreach (var car in result.Data)
//                {
//                    Console.WriteLine("{0} - {1} - {2} - {3}", car.BrandName, car.Description, car.ColorName, car.DailyPrice);
//                }
//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }

//        }

//        private static void UpdateCarTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            carManager.Update(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 600 });
//            //Daily price has been updated, but model year and description has turned to null !!!
//            //we have to add model year and description also
//        }

//        private static void DeleteCarTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            carManager.Delete(new Car { Id = 6 });
//            //Id =6 car has been deleted
//        }

//        private static void AddCarTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 500, Description = "Captiva", ModelYear = 2015, Id = 1 });
//            carManager.Add(new Car { BrandId = 7, ColorId = 3, DailyPrice = 500, Description = "i20", ModelYear = 2015, Id = 2 });
//            carManager.Add(new Car { BrandId = 7, ColorId = 5, DailyPrice = 300, Description = "i30", ModelYear = 2012, Id = 3 });
//            carManager.Add(new Car { BrandId = 7, ColorId = 4, DailyPrice = 200, Description = "i20", ModelYear = 2011, Id = 4 });
//            carManager.Add(new Car { BrandId = 6, ColorId = 1, DailyPrice = 500, Description = "Fiorino", ModelYear = 2015, Id = 5 });
//            carManager.Add(new Car { BrandId = 5, ColorId = 1, DailyPrice = 500, Description = "Corolla", ModelYear = 2018, Id = 6 });
//        }

//        private static void GetByIdColorTest()
//        {
//            ColorManager colorManager = new ColorManager(new EfColorDal());
//            Console.WriteLine(colorManager.GetById(4).Data.ColorName);
//        }

//        private static void GetAllColorsTest()
//        {
//            ColorManager colorManager = new ColorManager(new EfColorDal());
//            var result = colorManager.GetAll();
//            if (result.Success == true)
//            {
//                foreach (var color in result.Data)
//                {
//                    Console.WriteLine(color.ColorName);
//                }
//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }

//        }

//        private static void UpdateColorTest()
//        {
//            ColorManager colorManager = new ColorManager(new EfColorDal());
//            colorManager.Update(new Color { ColorId = 3, ColorName = "Silver" });
//            //ColorId=3 is updated to Silver
//        }

//        private static void DeleteColorTest()
//        {
//            ColorManager colorManager = new ColorManager(new EfColorDal());
//            colorManager.Delete(new Color { ColorId = 2 });
//            //Metallic silver has been deleted.
//        }

//        private static void AddColorTest()
//        {
//            ColorManager colorManager = new ColorManager(new EfColorDal());
//            colorManager.Add(new Color { ColorId = 1, ColorName = "Metallic Black" });
//            colorManager.Add(new Color { ColorId = 2, ColorName = "Metallic Silver" });
//            colorManager.Add(new Color { ColorId = 3, ColorName = "Metallic Grey" });
//            colorManager.Add(new Color { ColorId = 4, ColorName = "Metallic Blue" });
//            colorManager.Add(new Color { ColorId = 5, ColorName = "Matte Black" });
//            colorManager.Add(new Color { ColorId = 6, ColorName = "Matte Silver" });
//        }

//        private static void GetByIdTest()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());
//            Console.WriteLine(brandManager.GetById(2).Data.BrandName);
//        }

//        private static void GetAllBrandsTest()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());
//            var result = brandManager.GetAll();
//            if (result.Success == true)
//            {
//                foreach (var brand in result.Data)
//                {
//                    Console.WriteLine(brand.BrandName);
//                }
//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }

//        }

//        private static void UpdateBrandTest()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());
//            brandManager.Update(new Brand { BrandId = 2, BrandName = "Audi" });
//            //Audi has replaced by Mercedes
//        }

//        private static void DeleteBrandTest()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());
//            brandManager.Delete(new Brand { BrandId = 6 });
//            //The car that has BrandId = 6 has been deleted.
//        }

//        private static void AddBrandTest()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());
//            brandManager.Add(new Brand { BrandId = 1, BrandName = "Chevrolet" });
//            brandManager.Add(new Brand { BrandId = 2, BrandName = "Audi" });
//            brandManager.Add(new Brand { BrandId = 3, BrandName = "Honda" });
//            brandManager.Add(new Brand { BrandId = 4, BrandName = "BMW" });
//            brandManager.Add(new Brand { BrandId = 5, BrandName = "Toyota" });
//            brandManager.Add(new Brand { BrandId = 6, BrandName = "Mercedes" });
//        }
//    }
//}