﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SRTPluginProviderOoT
{
    class Structs
    {
        public enum Entrance : ushort
        {
            DekuTree = 0x00,
            DodongosCavern = 0x04,
            GerudoTrainingGrounds = 0x08,
            ForestTempleBoss = 0x0C,
            WaterTemple = 0x10,
            LostScene = 0x14,
            ActionTestingRoom = 0x18,
            StalfosMiddleRoom = 0x1C,
            StalfosBossRoom = 0x20,
            ItemTestingRoom = 0x24,
            InsideJabuJabusBelly = 0x28,
            RoyalFamilysTomb = 0x2D,
            MarketEntrance = 0x33,
            ShadowTemple = 0x37,
            ShootingGallery = 0x3B,
            Grottos = 0x3F,
            LakesideLaboratory = 0x43,
            DarkLinkTestingArea = 0x47,
            GraveWithShield = 0x4B,
            LonLonRanchBuildings = 0x4F,
            TempleOfTime = 0x53,
            TreasureBoxShop = 0x63,
            BackAlley = 0x67,
            ChamberOfSages = 0x6B,
            GrannysPotionShop = 0x72,
            BetaCastleCourtyard = 0x76,
            CastleCourtyard = 0x7A,
            LotsOPots = 0x7E,
            SpiritTemple = 0x82,
            IceCavern = 0x88,
            SpiritTempleBoss = 0x8D,
            CollisionTestingArena = 0x94,
            BottomOfTheWell = 0x98,
            HouseOfTwins = 0x9C,
            CutsceneMap = 0xA0,
            BackAlley2 = 0xAD,
            Market = 0xB1,
            DepthTest = 0xB6,
            Bazaar = 0xB7,
            LinksHouse = 0xBB,
            KokiriShop = 0xC1,
            DodongosCavern2 = 0xC5,
            KnowItAllBrothers = 0xC9,
            HyruleField = 0xCD,
            KakarikoVillage = 0xDB,
            Graveyard = 0xE4,
            ZoraRiver = 0xEA,
            KokiriForest = 0xEE,
            SacredForestMeadow = 0xFC,
            LakeHylia = 0x102,
            ZorasDomain = 0x108,
            ZorasFountain = 0x10E,
            GerudoValley = 0x117,
            LostWoods2 = 0x11E,
            DesertColossus = 0x123,
            GerudoFortress = 0x129,
            HauntedWasteland = 0x130,
            TowerCollapseInterior = 0x134,
            HyruleCastle = 0x138,
            GanonsCastle = 0x13A,
            DeathMountainTrail = 0x13D,
            DeathMountainCrater = 0x147,
            GoronCity = 0x14D,
            ZorasDomain2 = 0x153,
            ZorasFountain2 = 0x10E,
            GerudoValley2 = 0x117,
            LostWoods = 0x11E,
            DesertColossus2 = 0x123,
            GerudoFortress2 = 0x129,
            HauntedWasteland2 = 0x130,
            TowerCollapseInterior2 = 0x134,
            HyruleCastle2 = 0x138,
            GanonsCastle2 = 0x13A,
            DeathMountainTrail2 = 0x13D,
            DeathMountainCrater2 = 0x147,
            GoronCity2 = 0x14D,
            ZorasDomain3 = 0x153,
            LonLonRanch = 0x157,
            FireTemple = 0x165,
            BridgeBetweenFieldAndForest = 0x011E,
            ForestToRiver = 0x1DD,
            WrongWarp = 0x256,
            InsideJabuJabusBellyBoss = 0x301,
            VolvagiaBattle = 0x305,
            GanondorfDead = 0x330,
            RichardZHouse = 0x398,
            DodongoBattle = 0x40B,
            ShadowTempleBoss = 0x413,
            WaterTempleBoss = 0x417,
            FishingPond = 0x45F,
            GanonBattle = 0x517,
            LonLonWindMill = 0x5D0,
            None = 0xFFFF
        }

        public enum Item : byte
        {
            DekuSticks = 0x00,
            DekuNuts = 0x01,
            Bombs = 0x02,
            Bow = 0x03,
            FireArrows = 0x04,
            DinsFire = 0x05,
            Slingshot = 0x06,
            FairyOcarina = 0x07,
            OcarinaOfTime = 0x08,
            Bombchus = 0x09,
            Hookshot = 0x0A,
            Longshot = 0x0B,
            IceArrows = 0x0C,
            FaroresWind = 0x0D,
            Boomerang = 0x0E,
            LensOfTruth = 0x0F,
            MagicBeans = 0x10,
            MegatonHammer = 0x11,
            LightArrows = 0x12,
            NayrusLove = 0x13,
            EmptyBottle = 0x14,
            RedPotion = 0x15,
            GreenPotion = 0x16,
            BluePotion = 0x17,
            BottledFairy = 0x18,
            Fish = 0x19,
            LonLonMilk = 0x1A,
            Letter = 0x1B,
            BlueFire = 0x1C,
            Bug = 0x1D,
            BigPoe = 0x1E,
            LonLonMilkHalf = 0x1F,
            Poe = 0x20,
            WeirdEgg = 0x21,
            Chicken = 0x22,
            ZeldasLetter = 0x23,
            KeatonMask = 0x24,
            SkullMask = 0x25,
            SpookyMask = 0x26,
            BunnyHood = 0x27,
            GoronMask = 0x28,
            ZoraMask = 0x29,
            GerudoMask = 0x2A,
            MaskOfTruth = 0x2B,
            SoldOut = 0x2C,
            PocketEgg = 0x2D,
            PocketCucco = 0x2E,
            Cojiro = 0x2F,
            OddMushroom = 0x30,
            OddPotion = 0x31,
            PoachersSaw = 0x32,
            BrokenGoronsSword = 0x33,
            Prescription = 0x34,
            EyeBallFrog = 0x35,
            EyeDrops = 0x36,
            ClaimCheck = 0x37,
            BowWithFireArrows = 0x38,
            BowWithIceArrows = 0x39,
            BowWithLightArrows = 0x3A,
            KokiriSword = 0x3B,
            MasterSword = 0x3C,
            BiggoronSword = 0x3D,
            DekuShield = 0x3E,
            HylianShield = 0x3F,
            MirrorShield = 0x40,
            KokiriTunic = 0x41,
            GoronTunic = 0x42,
            ZoraTunic = 0x43,
            KokiriBoots = 0x44,
            IronBoots = 0x45,
            HoverBoots = 0x46,
            BulletBag30 = 0x47,
            BulletBag40 = 0x48,
            BulletBag50 = 0x49,
            Quiver30 = 0x4A,
            Quiver40 = 0x4B,
            Quiver50 = 0x4C,
            BombBag20 = 0x4D,
            BombBag30 = 0x4E,
            BombBag40 = 0x4F,
            GoronsBracelet = 0x50,
            SilverGauntlets = 0x51,
            GoldenGauntlets = 0x52,
            SilverScale = 0x53,
            GoldenScale = 0x54,
            GiantsKnifeBroken = 0x55,
            AdultsWallet = 0x56,
            GiantsWallet = 0x57,
            DekuSeeds = 0x58,
            FishingRod = 0x59,
            MinuetOfForest = 0x5A,
            BoleroOfFire = 0x5B,
            SerenadeOfWater = 0x5C,
            RequiemOfSpirit = 0x5D,
            NocturneOfShadow = 0x5E,
            PreludeOfLight = 0x5F,
            ZeldasLullaby = 0x60,
            EponasSong = 0x61,
            SariasSong = 0x62,
            SunsSong = 0x63,
            SongOfTime = 0x64,
            SongOfStorms = 0x65,
            ForestMedallion = 0x66,
            FireMedallion = 0x67,
            WaterMedallion = 0x68,
            SpiritMedallion = 0x69,
            ShadowMedallion = 0x6A,
            LightMedallion = 0x6B,
            KokiriEmerald = 0x6C,
            GoronsRuby = 0x6D,
            ZorasSapphire = 0x6E,
            StoneOfAgony = 0x6F,
            GerudosCard = 0x70,
            GoldSkulltula = 0x71,
            PieceOfHeart = 0x72,
            JPText1 = 0x73,
            BossKey = 0x74,
            Compass = 0x75,
            DungeonMap = 0x76,
            None = 0xFF
        }

        [Flags]
        public enum SwordsAndShields : byte
        {
            None = 0x0,
            KokiriSword = 0x1,
            MasterSword = 0x2,
            BiggoronSword = 0x4,
            DekuShield = 0x10,
            HylianShield = 0x20,
            MirrorShield = 0x40
        }

        [Flags]
        public enum TunicsAndBoots : byte
        {
            None = 0x0,
            KokiriTunic = 0x1,
            GoronTunic = 0x2,
            ZoraTunic = 0x4,
            KokiriBoots = 0x10,
            IronBoots = 0x20,
            HoverBoots = 0x40
        }

        public enum Upgrade : int
        {
            Quiver = 0 + 0 * 8,
            BombBag = 3 + 0 * 8,
            Gauntlet = 6 + 0 * 8,
            Scale = 1 + 1 * 8,
            Wallet = 4 + 1 * 8,
            BulletBag = 6 + 1 * 8,
            DekuSticks = 1 + 2 * 8,
            DekuNuts = 4 + 2 * 8
        }

        [Flags]
        public enum MedallionsAndSongs : byte
        {
            None = 0x0,
            ForestMedallion = 0x1,
            FireMedallion = 0x2,
            WaterMedallion = 0x4,
            SpiritMedallion = 0x8,
            ShadowMedallion = 0x10,
            LightMedallion = 0x20,
            MinuetOfTheForest = 0x40,
            BoleroOfFire = 0x80
        }

        [Flags]
        public enum Songs : byte
        {
            None = 0x0,
            SerenadeOfWater = 0x1,
            RequiemOfSpirit = 0x2,
            NocturneOfShadow = 0x4,
            PreludeOfLight = 0x8,
            ZeldasLullaby = 0x10,
            EponasSong = 0x20,
            SariasSong = 0x40,
            SunsSong = 0x80
        }

        [Flags]
        public enum Misc : byte
        {
            None = 0x0,
            SongOfTime = 0x1,
            SongOfStorms = 0x2,
            KokirisEmerald = 0x4,
            GoronsRuby = 0x8,
            ZorasSapphire = 0x10,
            StoneOfAgony = 0x20,
            GerudoMemberShipCard = 0x40,
            HasCollectedAGoldSkulltula = 0x80
        }
    }
    
}
