using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testt.Properties.Repositories
{
    public interface IGenRepo<T> where T : class, IBaseModel
    {
        public IEnumerable<T> get();
        public T get(int id);
        public void Post(T t);
        public void Delete(int id);
    }
}
