namespace composite_pattern.Component
{
    public interface IOperations<T> where T : class
    {
        public void Add(T obj);
        public void Remove(T obj);
    }
}
