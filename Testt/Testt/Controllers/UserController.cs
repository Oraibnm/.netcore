using ApiApp.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testt.Controllers.Model;
using Testt.Properties.Repositories;

namespace Testt.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        IUserRepo userrepo = null;
        private readonly IMapper _mapper;


        /*public List<Users> users { get; set; } = new List<Users>()
        {
            new Users(){},
            new Users()
        };*/
        public UserController(IUserRepo userrepo , IMapper mapper)
        {

            this.userrepo = userrepo;
            this._mapper = mapper;

        }
        [HttpGet]
        public IEnumerable<UserViewModel> GetAll()
        {
            //  return userrepo.get();


            var u = _mapper.Map<IEnumerable<UserViewModel>>(userrepo.get());
            return u;
        }
        [HttpGet("{id}")]
        public User get(int id)
        {
            return userrepo.get(id);
        }

        [HttpPost]
        public void Post(User t)
        {
            userrepo.Post(t);
        }



        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            userrepo.Delete(id);

        }

    }
}
