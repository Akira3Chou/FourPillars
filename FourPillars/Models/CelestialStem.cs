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
    public DirectionType Direction => Type switch
    {
        CelestialStemType.Jia or CelestialStemType.Yi => DirectionType.East,
        CelestialStemType.Bing or CelestialStemType.Ding => DirectionType.South,
        CelestialStemType.Wu or CelestialStemType.Ji => DirectionType.Center,
        CelestialStemType.Geng or CelestialStemType.Xin => DirectionType.West,
        CelestialStemType.Ren or CelestialStemType.Gui => DirectionType.North,
        _ => DirectionType.None,
    };

    /// <summary>
    /// <para>方位</para>
    /// <para>青龙：甲乙</para>
    /// <para>朱雀：丙丁</para>
    /// <para>勾陈：戊</para>
    /// <para>腾蛇：己</para>
    /// <para>白虎：庚辛</para>
    /// <para>玄武：壬癸</para>
    /// </summary>
    public HexadDeitiesType HexadDeity => Type switch
    {
        CelestialStemType.Jia or CelestialStemType.Yi => HexadDeitiesType.AzureDragon,
        CelestialStemType.Bing or CelestialStemType.Ding => HexadDeitiesType.VermilionBird,
        CelestialStemType.Wu => HexadDeitiesType.GouChen,
        CelestialStemType.Ji => HexadDeitiesType.FlyingSerpent,
        CelestialStemType.Geng or CelestialStemType.Xin => HexadDeitiesType.WhiteTiger,
        CelestialStemType.Ren or CelestialStemType.Gui => HexadDeitiesType.BlackTortoise,
        _ => HexadDeitiesType.None,
    };

    /// <summary>
    /// <para>四时</para>
    /// <para>木：春</para>
    /// <para>火：夏</para>
    /// <para>土：季夏（长夏）</para>
    /// <para>金：秋</para>
    /// <para>水：冬</para>
    /// </summary>
    public SeasonType Season => (SeasonType)(((byte)Type + 1) / 2);

    /// <summary>
    /// <para>身体</para>
    /// <para>头：甲</para>
    /// <para>肩：乙</para>
    /// <para>额：丙</para>
    /// <para>口：丁</para>
    /// <para>鼻面：戊己</para>
    /// <para>筋：庚</para>
    /// <para>胸：辛</para>
    /// <para>胫：壬</para>
    /// <para>足：癸</para>
    /// </summary>
    public BodyPartsType BodyPart => Type switch
    {
        CelestialStemType.Jia => BodyPartsType.Head,
        CelestialStemType.Yi => BodyPartsType.Shoulder,
        CelestialStemType.Bing => BodyPartsType.Forehead,
        CelestialStemType.Ding => BodyPartsType.Mouth,
        CelestialStemType.Wu or CelestialStemType.Ji => BodyPartsType.NoseAndFace,
        CelestialStemType.Geng => BodyPartsType.Tendon,
        CelestialStemType.Xin => BodyPartsType.Chest,
        CelestialStemType.Ren => BodyPartsType.Shin,
        CelestialStemType.Gui => BodyPartsType.Foot,
        _ => BodyPartsType.None,
    };

    /// <summary>
    /// 脏腑器官
    /// </summary>
    public ZangFuOrgansType Organ => Type switch
    {

        CelestialStemType.Jia => ZangFuOrgansType.Gallbladder,
        CelestialStemType.Yi => ZangFuOrgansType.Liver,
        CelestialStemType.Bing => ZangFuOrgansType.SmallIntestine,
        CelestialStemType.Ding => ZangFuOrgansType.Heart,
        CelestialStemType.Wu => ZangFuOrgansType.Stomach,
        CelestialStemType.Ji => ZangFuOrgansType.Spleen,
        CelestialStemType.Geng => ZangFuOrgansType.LargeIntestine,
        CelestialStemType.Xin => ZangFuOrgansType.Lung,
        CelestialStemType.Ren => ZangFuOrgansType.Bladder,
        CelestialStemType.Gui => ZangFuOrgansType.Kidney,
        _ => ZangFuOrgansType.None,
    };

    /// <summary>
    /// 脏腑
    /// </summary>
    public ZangFuType ZangFu =>
        Organ == ZangFuOrgansType.None
        ? ZangFuType.None
        : (int)Organ % 2 == 0
            ? ZangFuType.Zang
            : ZangFuType.Fu;


    public CelestialStem(CelestialStemType type)
    {
        Type = type;
    }

}
