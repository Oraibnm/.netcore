using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Testt.Controllers.Model;
using Testt.Model;

namespace Testt.Properties.Repositories
{
    public class PostRepo : GenRepo<Post>, IPostRepo
    {
        private readonly AppDbContext _dbContext;
        public PostRepo(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
