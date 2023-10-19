namespace ConsoleAppRepositoryPattern.Interfaces
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Guid id);
    }
}
