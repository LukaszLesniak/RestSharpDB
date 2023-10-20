using LechuRestSharp.EntityFrameworkCode;
using Microsoft.EntityFrameworkCore;

namespace LechuRestSharp
{
    internal class Program
    {
        public void Run1()
        {

            DbContextOptions<LechuDBContext> options = new DbContextOptions<LechuDBContext>();
            using (var ctx = new LechuDBContext(options))
            {
                //var cities = new Author()
                //{
                //    Id = 3,
                //    AuthorName = "a",
                //    FirstName = "b",
                //    LastName = "c",
                //};
                //try
                //{
                //    var lol = ctx.Cities.FirstAsync();
                //    Console.WriteLine(lol.Result);
                //    ctx.Cities.Add(cities);

                //    ctx.SaveChanges();
                //}
                //catch (AggregateException e)
                //{
                //    Console.WriteLine(e.Message);
                //}
                //Console.WriteLine("end");


            }
        }
        static void Main(string[] args)
        {
            Consume consume = new Consume();
            consume.Run();

            Program pr = new Program(); 
            pr.Run1();
        }
    }
}