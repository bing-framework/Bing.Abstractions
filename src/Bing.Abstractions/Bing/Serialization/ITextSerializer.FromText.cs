namespace Bing.Serialization;

/// <summary>
/// 文本对象序列化器元接口
/// </summary>
public partial interface ITextSerializer : IBytesSerializer
{
    /// <summary>
    /// 将字符串反序列化为对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="text">文本</param>
    /// <returns>如果 text 为 null 或为空，将返回 TValue 的默认值</returns>
    TValue FromText<TValue>(string text);

    /// <summary>
    /// 将字符串反序列化为对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="text">文本</param>
    /// <returns>如果 text 为 null 或为空，将返回 type 的默认值</returns>
    object FromText(Type type, string text);
}