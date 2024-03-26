namespace CarApi.Shared
{
    public interface IReadAndParseJson
    {
        List<T> ReadJson<T>();
    }
}
