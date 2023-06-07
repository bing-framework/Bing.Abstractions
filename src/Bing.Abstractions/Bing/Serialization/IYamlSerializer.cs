namespace Bing.Serialization;

/// <summary>
/// Yaml 序列化器
/// </summary>
public interface IYamlSerializer : IObjectSerializer, ITextSerializer
{
}

/// <summary>
/// Yaml序列化器(<see cref="IYamlSerializer"/>) 扩展
/// </summary>
public static class YamlSerializerExtensions
{
    /// <summary>
    /// 将YAML字符串反序列化为对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="yaml">yaml字符串</param>
    /// <returns>如果 yaml 为 null 或为空，将返回 TValue 的默认值</returns>
    public static TValue FromYaml<TValue>(this IYamlSerializer serializer, string yaml) =>
        serializer.FromText<TValue>(yaml);

    /// <summary>
    /// 将YAML字符串反序列化为对象
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="yaml">yaml字符串</param>
    /// <returns>如果 yaml 为 null 或为空，将返回 type 的默认值</returns>
    public static object FromYaml(this IYamlSerializer serializer, Type type, string yaml) =>
        serializer.FromText(type, yaml);

    /// <summary>
    /// 将对象序列化为YAML字符串
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="serializer">序列化器</param>
    /// <param name="value">值</param>
    public static string ToYaml<TValue>(this IYamlSerializer serializer, TValue value) => serializer.ToText(value);

    /// <summary>
    /// 将对象序列化为YAML字符串
    /// </summary>
    /// <param name="serializer">序列化器</param>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    public static string ToYaml(this IYamlSerializer serializer, Type type, object value) =>
        serializer.ToText(type, value);
}
