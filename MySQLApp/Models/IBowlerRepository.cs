using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLApp.Models
{
    public interface IBowlerRepository
    {
        IQueryable<Bowler> Bowlers { get; }

        void AddBowler(Bowler bowler);
        void SaveChanges();
    }
}
