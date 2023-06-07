namespace Bing.Serialization;

/// <summary>
/// Toml 序列化器
/// </summary>
public interface ITomlSerializer : IObjectSerializer, ITextSerializer
{
}

/// <summary>
/// Toml序列化器(<see cref="ITomlSerializer"/>) 扩展
/// </summary>
public static class TomlSerializerExtensions
{
    /// <summary>
    /// 将Toml字符串反序列化为对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="toml">Toml字符串</param>
    /// <returns>如果 toml 为 null 或为空，将返回 TValue 的默认值</returns>
    public static TValue FromToml<TValue>(this ITomlSerializer serializer, string toml) =>
        serializer.FromText<TValue>(toml);

    /// <summary>
    /// 将Toml字符串反序列化为对象
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="toml">Toml字符串</param>
    /// <returns>如果 toml 为 null 或为空，将返回 type 的默认值</returns>
    public static object FromToml(this ITomlSerializer serializer, Type type, string toml) =>
        serializer.FromText(type, toml);

    /// <summary>
    /// 将对象序列化为Toml字符串
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="value">值</param>
    public static string ToToml<TValue>(this ITomlSerializer serializer, TValue value) => serializer.ToText(value);

    /// <summary>
    /// 将对象序列化为Toml字符串
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    public static string ToToml(this ITomlSerializer serializer, Type type, object value) =>
        serializer.ToText(type, value);
}