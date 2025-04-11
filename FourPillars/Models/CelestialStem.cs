using FourPillars.Enums;

namespace FourPillars.Models;

public sealed class CelestialStem
{
    public CelestialStemType Type { get; private set; }

    /// <summary>
    /// <para>阴阳</para>
    /// <para>阳干：甲 丙 戊 庚 壬</para>
    /// <para>阴干：乙 丁 己 辛 癸</para>
    /// </summary>
    public YinYangType YinYang => (byte)Type % 2 == 0 ? YinYangType.Yin : YinYangType.Yang;

    /// <summary>
    /// <para>五行</para>
    /// <para>木：甲乙</para>
    /// <para>火：丙丁</para>
    /// <para>土：戊己</para>
    /// <para>金：庚辛</para>
    /// <para>水：壬癸</para>
    /// </summary>
    public FivePhasesType Phase => (FivePhasesType)(((byte)Type + 1) / 2);

    /// <summary>
    /// <para>方位</para>
    /// <para>东：甲乙</para>
    /// <para>南：丙丁</para>
    /// <para>中：戊己</para>
    /// <para>西：庚辛</para>
    /// <para>北：壬癸</para>
    /// </summary>
    public DirectionType Direction => (DirectionType)(((byte)Type + 1) / 2);

    public CelestialStem(CelestialStemType type)
    {
        Type = type;
    }

}
