using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLApp.Models
{
    public interface ITeamRepository
    {
        IQueryable<Team> Teams { get; }
    }
}
