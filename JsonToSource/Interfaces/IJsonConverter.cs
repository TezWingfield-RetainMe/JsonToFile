namespace JsonToSource.Interfaces
{
    public interface IJsonConverter<T>
    {
        void ConvertJsonToSource(string jsonString, string fileName);
        void ConvertObjectToSource(T obj, string fileName);
    }
}
