namespace Bing.Serialization;

public partial interface IStreamSerializer
{
    /// <summary>
    /// 序列化对象并打包到流中
    /// </summary>
    /// <typeparam name="TValue">序列化对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    void Pack<TValue>(TValue value, Stream stream);

    /// <summary>
    /// 序列化对象并打包到流中
    /// </summary>
    /// <param name="type">序列化对象类型</param>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    void Pack(Type type, object value, Stream stream);
}