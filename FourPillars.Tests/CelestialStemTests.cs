using FourPillars.Models;
using FourPillars.Enums;
using Shouldly;

namespace FourPillars.Tests;

public class CelestialStemTests
{
    [Fact]
    public void Test_Type()
    {
        new CelestialStem(CelestialStemType.Jia).Type.ShouldBe(CelestialStemType.Jia);
        new CelestialStem(CelestialStemType.Yi).Type.ShouldBe(CelestialStemType.Yi);
        new CelestialStem(CelestialStemType.Bing).Type.ShouldBe(CelestialStemType.Bing);
        new CelestialStem(CelestialStemType.Ding).Type.ShouldBe(CelestialStemType.Ding);
        new CelestialStem(CelestialStemType.Wu).Type.ShouldBe(CelestialStemType.Wu);
        new CelestialStem(CelestialStemType.Ji).Type.ShouldBe(CelestialStemType.Ji);
        new CelestialStem(CelestialStemType.Geng).Type.ShouldBe(CelestialStemType.Geng);
        new CelestialStem(CelestialStemType.Xin).Type.ShouldBe(CelestialStemType.Xin);
        new CelestialStem(CelestialStemType.Ren).Type.ShouldBe(CelestialStemType.Ren);
        new CelestialStem(CelestialStemType.Gui).Type.ShouldBe(CelestialStemType.Gui);
    }

    [Fact]
    public void Test_YinYang()
    {
        // Ñô¸É£º¼× ±û Îì ¸ý ÈÉ
        new CelestialStem(CelestialStemType.Jia).YinYang.ShouldBe(YinYangType.Yang);
        new CelestialStem(CelestialStemType.Bing).YinYang.ShouldBe(YinYangType.Yang);
        new CelestialStem(CelestialStemType.Wu).YinYang.ShouldBe(YinYangType.Yang);
        new CelestialStem(CelestialStemType.Geng).YinYang.ShouldBe(YinYangType.Yang);
        new CelestialStem(CelestialStemType.Ren).YinYang.ShouldBe(YinYangType.Yang);

        // Òõ¸É£ºÒÒ ¶¡ ¼º ÐÁ ¹ï
        new CelestialStem(CelestialStemType.Yi).YinYang.ShouldBe(YinYangType.Yin);
        new CelestialStem(CelestialStemType.Ding).YinYang.ShouldBe(YinYangType.Yin);
        new CelestialStem(CelestialStemType.Ji).YinYang.ShouldBe(YinYangType.Yin);
        new CelestialStem(CelestialStemType.Xin).YinYang.ShouldBe(YinYangType.Yin);
        new CelestialStem(CelestialStemType.Gui).YinYang.ShouldBe(YinYangType.Yin);

    }

    [Fact]
    public void Test_FivePhases()
    {
        // Ä¾£º¼×ÒÒ
        new CelestialStem(CelestialStemType.Jia).Phase.ShouldBe(FivePhasesType.Wood);
        new CelestialStem(CelestialStemType.Yi).Phase.ShouldBe(FivePhasesType.Wood);

        // »ð£º±û¶¡
        new CelestialStem(CelestialStemType.Bing).Phase.ShouldBe(FivePhasesType.Fire);
        new CelestialStem(CelestialStemType.Ding).Phase.ShouldBe(FivePhasesType.Fire);

        // ÍÁ£ºÎì¼º
        new CelestialStem(CelestialStemType.Wu).Phase.ShouldBe(FivePhasesType.Earth);
        new CelestialStem(CelestialStemType.Ji).Phase.ShouldBe(FivePhasesType.Earth);

        // ½ð£º¸ýÐÁ
        new CelestialStem(CelestialStemType.Geng).Phase.ShouldBe(FivePhasesType.Metal);
        new CelestialStem(CelestialStemType.Xin).Phase.ShouldBe(FivePhasesType.Metal);

        // Ë®£ºÈÉ¹ï
        new CelestialStem(CelestialStemType.Ren).Phase.ShouldBe(FivePhasesType.Water);
        new CelestialStem(CelestialStemType.Gui).Phase.ShouldBe(FivePhasesType.Water);

    }

    [Fact]
    public void Test_Direction()
    {
        // ¶«£º¼×ÒÒ
        new CelestialStem(CelestialStemType.Jia).Direction.ShouldBe(DirectionType.East);
        new CelestialStem(CelestialStemType.Yi).Direction.ShouldBe(DirectionType.East);

        // ÄÏ£º±û¶¡
        new CelestialStem(CelestialStemType.Bing).Direction.ShouldBe(DirectionType.South);
        new CelestialStem(CelestialStemType.Ding).Direction.ShouldBe(DirectionType.South);

        // ÖÐ£ºÎì¼º
        new CelestialStem(CelestialStemType.Wu).Direction.ShouldBe(DirectionType.Center);
        new CelestialStem(CelestialStemType.Ji).Direction.ShouldBe(DirectionType.Center);

        // Î÷£º¸ýÐÁ
        new CelestialStem(CelestialStemType.Geng).Direction.ShouldBe(DirectionType.West);
        new CelestialStem(CelestialStemType.Xin).Direction.ShouldBe(DirectionType.West);

        // ±±£ºÈÉ¹ï
        new CelestialStem(CelestialStemType.Ren).Direction.ShouldBe(DirectionType.North);
        new CelestialStem(CelestialStemType.Gui).Direction.ShouldBe(DirectionType.North);

    }

    [Fact]
    public void Test_HexadDeity()
    {
        // ÇàÁú£º¼×ÒÒ
        new CelestialStem(CelestialStemType.Jia).HexadDeity.ShouldBe(HexadDeitiesType.AzureDragon);
        new CelestialStem(CelestialStemType.Yi).HexadDeity.ShouldBe(HexadDeitiesType.AzureDragon);

        // ÖìÈ¸£º±û¶¡
        new CelestialStem(CelestialStemType.Bing).HexadDeity.ShouldBe(HexadDeitiesType.VermilionBird);
        new CelestialStem(CelestialStemType.Ding).HexadDeity.ShouldBe(HexadDeitiesType.VermilionBird);

        // ¹´³Â£ºÎì
        new CelestialStem(CelestialStemType.Wu).HexadDeity.ShouldBe(HexadDeitiesType.GouChen);

        // ÌÚÉß£º¼º
        new CelestialStem(CelestialStemType.Ji).HexadDeity.ShouldBe(HexadDeitiesType.FlyingSerpent);

        // °×»¢£º¸ýÐÁ
        new CelestialStem(CelestialStemType.Geng).HexadDeity.ShouldBe(HexadDeitiesType.WhiteTiger);
        new CelestialStem(CelestialStemType.Xin).HexadDeity.ShouldBe(HexadDeitiesType.WhiteTiger);

        // ÐþÎä£ºÈÉ¹ï
        new CelestialStem(CelestialStemType.Ren).HexadDeity.ShouldBe(HexadDeitiesType.BlackTortoise);
        new CelestialStem(CelestialStemType.Gui).HexadDeity.ShouldBe(HexadDeitiesType.BlackTortoise);

    }

    [Fact]
    public void Test_Season()
    {
        // ´º£º¼×ÒÒ
        new CelestialStem(CelestialStemType.Jia).Season.ShouldBe(SeasonType.Spring);
        new CelestialStem(CelestialStemType.Yi).Season.ShouldBe(SeasonType.Spring);

        // ÏÄ£º±û¶¡
        new CelestialStem(CelestialStemType.Bing).Season.ShouldBe(SeasonType.Summer);
        new CelestialStem(CelestialStemType.Ding).Season.ShouldBe(SeasonType.Summer);

        // ¼¾ÏÄ£ºÎì¼º                        
        new CelestialStem(CelestialStemType.Wu).Season.ShouldBe(SeasonType.LateSummer);
        new CelestialStem(CelestialStemType.Ji).Season.ShouldBe(SeasonType.LateSummer);

        // Çï£º¸ýÐÁ
        new CelestialStem(CelestialStemType.Geng).Season.ShouldBe(SeasonType.Autumn);
        new CelestialStem(CelestialStemType.Xin).Season.ShouldBe(SeasonType.Autumn);

        // ¶¬£ºÈÉ¹ï
        new CelestialStem(CelestialStemType.Ren).Season.ShouldBe(SeasonType.Winter);
        new CelestialStem(CelestialStemType.Gui).Season.ShouldBe(SeasonType.Winter);

    }

    [Fact]
    public void Test_BodyPart()
    {
        // Í·£º¼×
        new CelestialStem(CelestialStemType.Jia).BodyPart.ShouldBe(BodyPartsType.Head);

        // ¼ç£ºÒÒ
        new CelestialStem(CelestialStemType.Yi).BodyPart.ShouldBe(BodyPartsType.Shoulder);

        // ¶î£º±û
        new CelestialStem(CelestialStemType.Bing).BodyPart.ShouldBe(BodyPartsType.Forehead);

        // ¿Ú£º¶¡
        new CelestialStem(CelestialStemType.Ding).BodyPart.ShouldBe(BodyPartsType.Mouth);

        // ±ÇÃæ£ºÎì¼º
        new CelestialStem(CelestialStemType.Wu).BodyPart.ShouldBe(BodyPartsType.NoseAndFace);
        new CelestialStem(CelestialStemType.Ji).BodyPart.ShouldBe(BodyPartsType.NoseAndFace);

        // ½î£º¸ý
        new CelestialStem(CelestialStemType.Geng).BodyPart.ShouldBe(BodyPartsType.Tendon);

        // ÐØ£ºÐÁ
        new CelestialStem(CelestialStemType.Xin).BodyPart.ShouldBe(BodyPartsType.Chest);

        // ëÖ£ºÈÉ
        new CelestialStem(CelestialStemType.Ren).BodyPart.ShouldBe(BodyPartsType.Shin);

        // ×ã£º¹ï
        new CelestialStem(CelestialStemType.Gui).BodyPart.ShouldBe(BodyPartsType.Foot);

    }

    [Fact]
    public void Test_Organ()
    {
        // µ¨£º¼×
        new CelestialStem(CelestialStemType.Jia).Organ.ShouldBe(ZangFuOrgansType.Gallbladder);

        // ¸Î£ºÒÒ
        new CelestialStem(CelestialStemType.Yi).Organ.ShouldBe(ZangFuOrgansType.Liver);

        // Ð¡³¦£º±û
        new CelestialStem(CelestialStemType.Bing).Organ.ShouldBe(ZangFuOrgansType.SmallIntestine);

        // ÐÄ£º¶¡
        new CelestialStem(CelestialStemType.Ding).Organ.ShouldBe(ZangFuOrgansType.Heart);

        // Î¸£ºÎì
        new CelestialStem(CelestialStemType.Wu).Organ.ShouldBe(ZangFuOrgansType.Stomach);

        // Æ¢£º¼º
        new CelestialStem(CelestialStemType.Ji).Organ.ShouldBe(ZangFuOrgansType.Spleen);

        // ´ó³¦£º¸ý
        new CelestialStem(CelestialStemType.Geng).Organ.ShouldBe(ZangFuOrgansType.LargeIntestine);

        // ·Î£ºÐÁ
        new CelestialStem(CelestialStemType.Xin).Organ.ShouldBe(ZangFuOrgansType.Lung);

        // °òë×£ºÈÉ
        new CelestialStem(CelestialStemType.Ren).Organ.ShouldBe(ZangFuOrgansType.Bladder);

        // Éö£º¹ï
        new CelestialStem(CelestialStemType.Gui).Organ.ShouldBe(ZangFuOrgansType.Kidney);

    }

    [Fact]
    public void Test_ZangFu()
    {
        // ¸­£º¼×±ûÎì¸ýÈÉ
        new CelestialStem(CelestialStemType.Jia).ZangFu.ShouldBe(ZangFuType.Fu);
        new CelestialStem(CelestialStemType.Bing).ZangFu.ShouldBe(ZangFuType.Fu);
        new CelestialStem(CelestialStemType.Wu).ZangFu.ShouldBe(ZangFuType.Fu);
        new CelestialStem(CelestialStemType.Geng).ZangFu.ShouldBe(ZangFuType.Fu);
        new CelestialStem(CelestialStemType.Ren).ZangFu.ShouldBe(ZangFuType.Fu);

        // Ôà£ºÒÒ¶¡¼ºÐÁ¹ï
        new CelestialStem(CelestialStemType.Yi).ZangFu.ShouldBe(ZangFuType.Zang);
        new CelestialStem(CelestialStemType.Ding).ZangFu.ShouldBe(ZangFuType.Zang);
        new CelestialStem(CelestialStemType.Ji).ZangFu.ShouldBe(ZangFuType.Zang);
        new CelestialStem(CelestialStemType.Xin).ZangFu.ShouldBe(ZangFuType.Zang);
        new CelestialStem(CelestialStemType.Gui).ZangFu.ShouldBe(ZangFuType.Zang);

    }

}