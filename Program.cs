using LechuRestSharp.EntityFrameworkCode;
using Microsoft.EntityFrameworkCore;

namespace LechuRestSharp
{
    internal class Program
    {
        public void SaveToDb()
        {
            DbContextOptions<LechuDBContext> options = new DbContextOptions<LechuDBContext>();
            using (var ctx = new LechuDBContext(options))
            {

                Cars cars = new Cars();
                Consume consume = new Consume();
                cars = consume.Run();

                Console.WriteLine("\nTo jest response odpalony z klasy program  : \n");

                Cars carsToBeSavedInDb = new Cars()
                {
                    make = cars.make,
                    year = cars.year,
                    fuel_type = cars.fuel_type,
                    model = cars.model
                };
                try
                {
                    var lol = ctx.Cities.FirstAsync();
                    Console.WriteLine(lol.Result);
                    ctx.Cities.Add(carsToBeSavedInDb);

                    ctx.SaveChanges();
                }
                catch (AggregateException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("end");


            }
        }


        //public void populateCarEntity()
        //{
        //    Cars cars = new Cars();
        //    Consume consume = new Consume();
        //    cars = consume.Run();

        //    Console.WriteLine("\nTo jest response odpalony z klasy program  : \n");

        //    Cars carsToBeSavedInDb = new Cars()
        //    {
        //        make = cars.make,
        //        year = cars.year,
        //        fuel_type = cars.fuel_type,
        //        model = cars.model
        //    };
        //}

        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.SaveToDb();       
        }
    }
}