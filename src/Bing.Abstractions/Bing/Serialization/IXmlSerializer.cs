namespace Bing.Serialization;

/// <summary>
/// XML 序列化器
/// </summary>
public interface IXmlSerializer : IObjectSerializer, ITextSerializer
{
}

/// <summary>
/// Xml序列化器(<see cref="IXmlSerializer"/>) 扩展
/// </summary>
public static class XmlSerializerExtensions
{
    /// <summary>
    /// 将XML字符串反序列化为对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="xml">xml字符串</param>
    /// <returns>如果 xml 为 null 或为空，将返回 TValue 的默认值</returns>
    public static TValue FromXml<TValue>(this IXmlSerializer serializer, string xml) =>
        serializer.FromText<TValue>(xml);

    /// <summary>
    /// 将XML字符串反序列化为对象
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="xml">xml字符串</param>
    /// <returns>如果 xml 为 null 或为空，将返回 type 的默认值</returns>
    public static object FromXml(this IXmlSerializer serializer, Type type, string xml) =>
        serializer.FromText(type, xml);

    /// <summary>
    /// 将对象序列化为XML字符串
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="value">值</param>
    public static string ToXml<TValue>(this IXmlSerializer serializer, TValue value) => serializer.ToText(value);

    /// <summary>
    /// 将对象序列化为XML字符串
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    public static string ToXml(this IXmlSerializer serializer, Type type, object value) =>
        serializer.ToText(type, value);
}