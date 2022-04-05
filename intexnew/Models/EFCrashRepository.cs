using System;
namespace intexnew.Models
{
    public class EFCrashRepository : ICrashRepository
    {
        private CrashesDbContext context { get; set; }

        public EFCrashRepository(CrashesDbContext temp)
        {
            context = temp;
        }

        public IQueryable<Crash> Crashes => context.Crashes;


        //adding functionality from IBookRepository
        public void SaveBook(Crash c)
        {
            context.SaveChanges();
        }

        public void CreateBook(Crash c)
        {
            context.Add(c);
            context.SaveChanges();
        }

        public void DeleteBook(Crash c)
        {
            context.Remove(c);
            context.SaveChanges();
        }

    }
}
