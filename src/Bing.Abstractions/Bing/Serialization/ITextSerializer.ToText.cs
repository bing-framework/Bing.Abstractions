namespace Bing.Serialization;

public partial interface ITextSerializer
{
    /// <summary>
    /// 序列化为字符串
    /// </summary>
    /// <typeparam name="TValue">序列化对象类型</typeparam>
    /// <param name="value">值</param>
    string ToText<TValue>(TValue value);

    /// <summary>
    /// 序列化为字符串
    /// </summary>
    /// <param name="type">序列化对象类型</param>
    /// <param name="value">值</param>
    string ToText(Type type, object value);
}