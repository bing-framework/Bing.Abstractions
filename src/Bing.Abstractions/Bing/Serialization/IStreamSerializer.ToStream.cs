namespace Bing.Serialization;

/// <summary>
/// 流对象序列化器元接口
/// </summary>
public partial interface IStreamSerializer
{
    /// <summary>
    /// 将对象序列化成流
    /// </summary>
    /// <typeparam name="TValue">序列化对象类型</typeparam>
    /// <param name="value">值</param>
    /// <returns>序列化流</returns>
    /// <returns>内存流</returns>
    MemoryStream ToStream<TValue>(TValue value);

    /// <summary>
    /// 将对象序列化成流
    /// </summary>
    /// <param name="type">序列化对象类型</param>
    /// <param name="value">值</param>
    /// <returns>内存流</returns>
    MemoryStream ToStream(Type type, object value);
}