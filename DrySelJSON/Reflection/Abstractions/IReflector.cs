namespace DrySelJSON.Reflection.Abstractions
{
    public interface IReflector<T> where T : class
    {
        string TypeNamePrefix { get; set; }

        T GetInstance(string instanceOf);
    }
}