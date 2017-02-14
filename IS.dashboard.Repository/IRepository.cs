using System.Collections.Generic;

namespace IS.Dashboard.Repository
{
    public  interface IRepository<T> where T : class
    {
         IList<T> FindAll();
         T Find(int key);
         IList<T> Find(string property, string value);
         IList<T> Find(string property, int id);

         void Add(T entity);
         void Delete(T entity);
         void Update();
    }
}
