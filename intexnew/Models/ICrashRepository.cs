using System;

namespace intexnew.Models
{
    public class ICrashRepository
    {
        IQueryable<Crash> Crashes { get; }

        //included to allow CRUD from adimnistration end
        public void SaveCrash(Crashes C);
        public void CreateCrash(Crashes C);
        public void DeleteCrash(Crashes C);
    }
}
