using BlogApp.Application.Contracts.Persistence;
using BlogApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Persistence.Repositories
{
    public class _IndexRepository : GenericRepository<_Index>, I_IndexRepository
    {
        private readonly CleanArchDbContext _dbContext;

        public _IndexRepository(CleanArchDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
