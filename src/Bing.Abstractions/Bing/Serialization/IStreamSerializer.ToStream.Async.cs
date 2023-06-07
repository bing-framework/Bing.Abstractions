namespace Bing.Serialization;

public partial interface IStreamSerializerAsync
{
    /// <summary>
    /// 异步序列化
    /// </summary>
    /// <typeparam name="TValue">序列化对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>内存流</returns>
    Task<MemoryStream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default);

    /// <summary>
    /// 异步序列化
    /// </summary>
    /// <param name="type">序列化对象类型</param>
    /// <param name="value">值</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>内存流</returns>
    Task<MemoryStream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default);
}