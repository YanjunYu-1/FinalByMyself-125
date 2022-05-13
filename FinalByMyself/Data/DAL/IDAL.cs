namespace FinalByMyself.Data.DAL
{
    public interface IDAL<T> where T : class
    {
        //Create
        void Add(T entity);
        T Get(T id);


        //Read
        T Get(Func<T, bool> func);
        ICollection<T> GetAll();
        ICollection<T> GetList(Func<T, bool> wherefunc);

        //Update
        void Update(T entity);

        //Delete
        void Delete(T entity);

        void Save();
    }
}
