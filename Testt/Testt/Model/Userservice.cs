using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testt.Controllers.Model
{
    public class Userservice : IUserservice
    {
        List<User> listofusers = new List<Model.User>
        {
            //output
            new User(1,"oday","059574","ooo",DateTime.Now),
            new User(2,"uu","059574","ooao", DateTime.Now),
            new User(3,"oday","059574","ooo", DateTime.Now),
            new User(4,"oday","059574","ooo", DateTime.Now),
            new User(5,"oday","059574","ooo", DateTime.Now)

             };
        /// <summary>
        /// delete [http post and get and delete]
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var z = listofusers.FirstOrDefault(i => i.Id == id);
            listofusers.Remove(z);
        }

        public List<User> get()
        {
            return listofusers;
        }

        public User get(int id)
        {
            return listofusers.FirstOrDefault(i => i.Id == id);
        }

        public void Post(User user)
        {
            listofusers.Add(user);
        }
    }
}

