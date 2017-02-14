namespace IS.Dashboard.Service
{
    interface IService<T> where T : class 
    {
        T FindOne(string username);
        T FindOne(int id);
    }
}
