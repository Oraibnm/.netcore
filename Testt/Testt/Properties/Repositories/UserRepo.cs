using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testt.Controllers.Model;

namespace Testt.Properties.Repositories
{
    public class UserRepo : GenRepo<User>, IUserRepo
    {
        private readonly AppDbContext _dbContext;
        public UserRepo(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
