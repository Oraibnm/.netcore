using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testt.Controllers.Model
{
   public interface IUserservice
    {
        public List<User> get();
        public User get(int id);
        public void Post(User user);
        public void Delete(int id);
    }
}
