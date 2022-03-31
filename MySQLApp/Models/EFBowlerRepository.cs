using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLApp.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingDbContext _context { get; set; }

        public EFBowlerRepository (BowlingDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<Bowler> Bowlers => _context.Bowlers;

        public void AddBowler(Bowler bowler)
        {
            _context.Bowlers.Add(bowler);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
