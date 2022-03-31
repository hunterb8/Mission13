using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLApp.Models
{
    public class EFTeamRepository : ITeamRepository
    {
        private BowlingDbContext _context { get; set; }

        public EFTeamRepository(BowlingDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<Team> Teams => _context.Teams;
    }
}
