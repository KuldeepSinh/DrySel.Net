namespace DrySelJSON.Reflection.Abstractions
{
    public interface IReflector<T> where T : class
    {
        T GetInstance(string instanceOf);
    }
}