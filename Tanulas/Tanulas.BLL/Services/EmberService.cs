using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanulas.BLL.Interfaces;
using Tanulas.DAL;
using Tanulas.DAL.Entities;

namespace Tanulas.BLL.Services
{
    public class EmberService : IEmberService
    {
        private readonly TanulasDbContext _dbContext;

        public EmberService(TanulasDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Ember> GetEmberek()
        {
            return _dbContext.Emberek.ToList();
        }
    }
}
