namespace Bing.Serialization;

public partial interface IStreamSerializer
{
    /// <summary>
    /// 反序列化
    /// </summary>
    /// <typeparam name="TValue">被反序列化对象类型</typeparam>
    /// <param name="stream">流</param>
    /// <returns>反序列化对象</returns>
    TValue FromStream<TValue>(Stream stream);

    /// <summary>
    /// 反序列化
    /// </summary>
    /// <param name="type">被反序列化对象类型</param>
    /// <param name="stream">流</param>
    /// <returns>反序列化对象</returns>
    object FromStream(Type type, Stream stream);
}