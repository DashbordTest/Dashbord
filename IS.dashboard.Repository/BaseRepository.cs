using System.Collections.Generic;
using Castle.ActiveRecord;
using IS.DashBoard.Common;

namespace IS.Dashboard.Repository
{
    public class BaseRepository<T> : ActiveRecordBase,IRepository<T> where T:class
    {
        public BaseRepository(){
            InitMapping.Init();
        }

        public IList<T> FindAll()
        {
            //ActiveRecordBase.FindAll(typeof(T),"");
            return null;
        }

        public T Find(int key)
        { 
            return (T)FindByPrimaryKey(typeof(T),key);
            
        }
        public IList<T> Find(string property,string value)
        {
            var ts = (T[])FindAllByProperty(typeof(T), property, value);
            IList<T> list = new List<T>(ts);
            return list;
        }

        public IList<T> Find(string property, int id)
        {
            var ts = (T[])FindAllByProperty(typeof(T), property, id);
            IList<T> list = new List<T>(ts);
            return list;
        }

        public void Add(T entity)
        {
            Create(entity);
        }
        public void Delete(T entity)
        {
            ActiveRecordBase.Delete(entity);
        }
        public void Update(T entity)
        {
            ActiveRecordBase.Update(entity);
        }
    }
}
