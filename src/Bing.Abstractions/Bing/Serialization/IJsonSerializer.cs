namespace Bing.Serialization;

/// <summary>
/// Json 序列化器
/// </summary>
public interface IJsonSerializer : IObjectSerializer, ITextSerializer
{
}

/// <summary>
/// Json序列化器(<see cref="IJsonSerializer"/>) 扩展
/// </summary>
public static class JsonSerializerExtension
{
    /// <summary>
    /// 将Json字符串反序列化为对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="json">Json字符串</param>
    /// <returns>如果 json 为 null 或为空，将返回 TValue 的默认值</returns>
    public static TValue FromJson<TValue>(this IJsonSerializer serializer, string json) =>
        serializer.FromText<TValue>(json);

    /// <summary>
    /// 将Json字符串反序列化为对象
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="json">Json字符串</param>
    /// <returns>如果 json 为 null 或为空，将返回 type 的默认值</returns>
    public static object FromJson(this IJsonSerializer serializer, Type type, string json) =>
        serializer.FromText(type, json);

    /// <summary>
    /// 将对象序列化为Json字符串
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="value">值</param>
    public static string ToJson<TValue>(this IJsonSerializer serializer, TValue value) => serializer.ToText(value);

    /// <summary>
    /// 将对象序列化为Json字符串
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    public static string ToJson(this IJsonSerializer serializer, Type type, object value) =>
        serializer.ToText(type, value);
}