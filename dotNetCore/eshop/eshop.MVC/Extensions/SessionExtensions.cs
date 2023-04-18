using System.Text.Json;

namespace eshop.MVC.Extensions
{
    public static class SessionExtensions
    {
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            var serialized = JsonSerializer.Serialize(value);
            session.SetString(key, serialized);

        }

        public static T? GetJson<T>(this ISession session, string key) where T : class, new()
        {
            var result = session.GetString(key);
            //if (!string.IsNullOrEmpty(result))
            //{
            //    return JsonSerializer.Deserialize<T>(result);
            //}
            //return default(T?);
            return result == null ? default(T?) : JsonSerializer.Deserialize<T>(result);
        }
    }
}
