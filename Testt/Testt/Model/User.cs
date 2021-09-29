using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testt.Model;
using Testt.Properties.Repositories;

namespace Testt.Controllers.Model
{
    //database
    public class User: IBaseModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public DateTime Dop { get; set; }

        public ICollection<Post> Posts { get; set; }


        public User()
        {

        }

        public User(int id, string name, string phone, string email, DateTime dop)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Dop = dop;
        }

      
    }
}
