namespace Bing.Serialization;

public partial interface IBytesSerializer
{
    /// <summary>
    /// 将对象序列化为字节数组
    /// </summary>
    /// <typeparam name="TValue">序列化对象类型</typeparam>
    /// <param name="value">值</param>
    byte[] ToBytes<TValue>(TValue value);

    /// <summary>
    /// 将对象序列化为字节数组
    /// </summary>
    /// <param name="type">序列化对象类型</param>
    /// <param name="value">值</param>
    byte[] ToBytes(Type type, object value);
}