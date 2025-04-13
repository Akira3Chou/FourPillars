namespace FourPillars.Enums;

/// <summary>
/// <para>方位</para>
/// <para>震东，兑西，离南，坎北，乾西北，坤西南，艮东北，巽东南</para>
/// <para>一数坎兮二数坤，三震四巽数中分;</para>
/// <para>五为中宫六乾是，七兑八艮九离门。</para>
/// </summary>
public enum DirectionType : byte
{
    /// <summary>
    /// 无
    /// </summary>
    None,

    /// <summary>
    /// 正北
    /// </summary>
    North,

    /// <summary>
    /// 西南
    /// </summary>
    Southwest,

    /// <summary>
    /// 正东
    /// </summary>
    East,

    /// <summary>
    /// 东南
    /// </summary>
    Southeast,

    /// <summary>
    /// 中宫
    /// </summary>
    Center,

    /// <summary>
    /// 西北
    /// </summary>
    Northwest,

    /// <summary>
    /// 正西
    /// </summary>
    West,

    /// <summary>
    /// 东北
    /// </summary>
    Northeast,

    /// <summary>
    /// 正南
    /// </summary>
    South,

}
