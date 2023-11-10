namespace Core.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        IGeneric<T> Entity { get;}

        void Save();
    }
}
