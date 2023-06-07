namespace Bing.Serialization;

public partial interface IStreamSerializerAsync
{
    /// <summary>
    /// 异步反序列化
    /// </summary>
    /// <typeparam name="TValue">被反序列化对象类型</typeparam>
    /// <param name="stream">流</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>反序列化对象</returns>
    Task<TValue> FromStreamAsync<TValue>(Stream stream, CancellationToken cancellationToken = default);

    /// <summary>
    /// 异步反序列化
    /// </summary>
    /// <param name="type">被反序列化对象类型</param>
    /// <param name="stream">流</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>反序列化对象</returns>
    Task<object> FromStreamAsync(Type type, Stream stream, CancellationToken cancellationToken = default);
}