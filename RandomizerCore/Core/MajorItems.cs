﻿namespace RandomizerCore.Core;

public static class MajorItems
{
    public static bool IsMajorItem(ItemType type)
    {
        return type switch
        {
            ItemType.Untyped => false,
            ItemType.SmithSword => true,
            ItemType.GreenSword => true,
            ItemType.RedSword => true,
            ItemType.BlueSword => true,
            ItemType.ProgressiveItem => true,
            ItemType.FourSword => true,
            ItemType.Bombs => true,
            ItemType.RemoteBombs => true,
            ItemType.Bow => true,
            ItemType.LightArrow => true,
            ItemType.Boomerang => true,
            ItemType.MagicBoomerang => true,
            ItemType.Shield => true,
            ItemType.MirrorShield => true,
            ItemType.Lantern => true,
            ItemType.GustJar => true,
            ItemType.PacciCane => true,
            ItemType.MoleMitts => true,
            ItemType.RocsCape => true,
            ItemType.PegasusBoots => true,
            ItemType.Firerod => true,
            ItemType.Ocarina => true,
            ItemType.GreenClock => true,
            ItemType.BlueClock => true,
            ItemType.RedClock => true,
            ItemType.Trap => true,
            ItemType.Bottle1 => true,
            ItemType.Bottle2 => true,
            ItemType.Bottle3 => true,
            ItemType.Bottle => true,
            ItemType.BottleEmpty => true,
            ItemType.BottleButter => true,
            ItemType.BottleMilk => true,
            ItemType.BottleHalfMilk => true,
            ItemType.BottleRedPotion => true,
            ItemType.BottleBluePotion => true,
            ItemType.BottleWater => true,
            ItemType.BottleMineralWater => true,
            ItemType.BottleFairy => true,
            ItemType.BottlePicolyteRed => true,
            ItemType.BottlePicolyteOrange => true,
            ItemType.BottlePicolyteYellow => true,
            ItemType.BottlePiclolyteGreen => true,
            ItemType.BottlePicolyteBlue => true,
            ItemType.BottlePicolyteWhite => true,
            ItemType.BottleCharmNayru => true,
            ItemType.BottleCharmFarore => true,
            ItemType.BottleCharmDin => true,
            ItemType.SmithSwordQuest => false,
            ItemType.BrokenPicoriBlade => false,
            ItemType.DogFoodBottle => true,
            ItemType.LonLonKey => false,
            ItemType.WakeUpMushroom => true,
            ItemType.RedBook => true,
            ItemType.GreenBook => true,
            ItemType.BlueBook => true,
            ItemType.GraveyardKey => true,
            ItemType.TingleTrophy => true,
            ItemType.CarlovMedal => true,
            ItemType.Shells => false,
            ItemType.EarthElement => true,
            ItemType.FireElement => true,
            ItemType.WaterElement => true,
            ItemType.WindElement => true,
            ItemType.GripRing => true,
            ItemType.PowerBracelets => true,
            ItemType.Flippers => true,
            ItemType.HyruleMap => true,
            ItemType.SpinAttack => true,
            ItemType.RollAttack => true,
            ItemType.DashAttack => true,
            ItemType.RockBreaker => true,
            ItemType.SwordBeam => true,
            ItemType.GreatSpin => true,
            ItemType.DownThrust => true,
            ItemType.PerilBeam => true,
            ItemType.DungeonMap => false,
            ItemType.Compass => false,
            ItemType.BigKey => true,
            ItemType.SmallKey => true,
            ItemType.Rupee1 => false,
            ItemType.Rupee5 => false,
            ItemType.Rupee20 => false,
            ItemType.Rupee50 => false,
            ItemType.Rupee100 => false,
            ItemType.Rupee200 => false,
            ItemType.JabberNut => true,
            ItemType.Kinstone => true,
            ItemType.Bombs5 => false,
            ItemType.Arrows5 => false,
            ItemType.SmallHeart => false,
            ItemType.Fairy => false,
            ItemType.Shells30 => false,
            ItemType.HeartContainer => true,
            ItemType.PieceOfHeart => true,
            ItemType.Wallet => true,
            ItemType.BombBag => true,
            ItemType.LargeQuiver => true,
            ItemType.Figurine => true,
            ItemType.Brioche => false,
            ItemType.Croissant => false,
            ItemType.PieSlice => false,
            ItemType.CakeSlice => false,
            ItemType.Bombs10 => false,
            ItemType.Bombs30 => false,
            ItemType.Arrows10 => false,
            ItemType.Arrows30 => false,
            ItemType.ArrowButterfly => true,
            ItemType.DigButterfly => true,
            ItemType.SwimButterfly => true,
            ItemType.FastSpin => true,
            ItemType.FastSplit => true,
            ItemType.LongSpin => true,
            ItemType.Entrance => true,
            ItemType.Music => false,
            ItemType.ToDKeys => false,
            ItemType.Fusion => false,
            _ => false
        };
    }
}
