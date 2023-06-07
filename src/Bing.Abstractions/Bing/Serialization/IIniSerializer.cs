namespace Bing.Serialization;

/// <summary>
/// Ini 序列化器
/// </summary>
public interface IIniSerializer : IObjectSerializer, ITextSerializer
{
}

/// <summary>
/// Ini序列化器(<see cref="IIniSerializer"/>) 扩展
/// </summary>
public static class IniSerializerExtensions
{
    /// <summary>
    /// 将INI字符串反序列化为对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="ini">ini字符串</param>
    /// <returns>如果 ini 为 null 或为空，将返回 TValue 的默认值</returns>
    public static TValue FromIni<TValue>(this IIniSerializer serializer, string ini) =>
        serializer.FromText<TValue>(ini);

    /// <summary>
    /// 将INI字符串反序列化为对象
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="ini">ini字符串</param>
    /// <returns>如果 ini 为 null 或为空，将返回 type 的默认值</returns>
    public static object FromIni(this IIniSerializer serializer, Type type, string ini) =>
        serializer.FromText(type, ini);

    /// <summary>
    /// 将对象序列化为INI字符串
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="value">值</param>
    public static string ToIni<TValue>(this IIniSerializer serializer, TValue value) => serializer.ToText(value);

    /// <summary>
    /// 将对象序列化为INI字符串
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    public static string ToIni(this IIniSerializer serializer, Type type, object value) =>
        serializer.ToText(type, value);
}
