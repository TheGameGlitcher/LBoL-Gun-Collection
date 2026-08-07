using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class KomaSpellAPiece0Def : TestModPiece // Red jellybean wave
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(444001);

            config.Projectile = "DanmaBigOval";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.6f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Red } };

            config.Way = new int[][] { new int[] { 1 } };

            config.Range = new float[][] { new float[] { 360f } };

            config.GAngle = new float[][] { new float[] { 0f }, new float[] { 8f } };

            config.Aim = 1;

            config.StartTime = 0;

            config.Group = 45;

            config.GInterval = 1;

            config.Life = new int[][] { new int[] { 240 } };

            config.StartSpeed = new float[][] { new float[] { 3.9f } };

            return config;
        }
    }

    public sealed class KomaSpellAPiece1Def : TestModPiece // Red coin wave
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(444001, 1);

            config.Projectile = "WishDanmaCopper";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Red } };

            config.Way = new int[][] { new int[] { 1 } };

            config.Range = new float[][] { new float[] { 360f } };

            config.GAngle = new float[][] { new float[] { 0f }, new float[] { 8f } };

            config.Aim = 1;

            config.StartTime = 5;

            config.Group = 45;

            config.GInterval = 1;

            config.Life = new int[][] { new int[] { 240 } };

            config.StartSpeed = new float[][] { new float[] { 3.9f } };

            return config;
        }
    }

    public sealed class KomaSpellAPiece2Def : TestModPiece // Yellow jellybean wave
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(444001, 2);

            config.Projectile = "DanmaBigOval";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = false;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.6f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Orange } };

            config.Way = new int[][] { new int[] { 3 } };

            config.Range = new float[][] { new float[] { 75f } };

            config.Aim = 1;

            config.StartTime = 30;

            config.GInterval = 10;

            config.Group = 10;

            config.Life = new int[][] { new int[] { 240 } };

            config.StartSpeed = new float[][] { new float[] { 14f } };

            return config;
        }
    }

    public sealed class KomaSpellAPiece3Def : TestModPiece // Yellow coin wave
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(444001, 3);

            config.Projectile = "WishDanmaCopper";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = false;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Orange } };

            config.Way = new int[][] { new int[] { 8 } };

            config.Range = new float[][] { new float[] { 40f } };

            config.Aim = 1;

            config.StartTime = 30;

            config.GInterval = 20;

            config.Group = 5;

            config.Life = new int[][] { new int[] { 240 } };

            config.StartSpeed = new float[][] { new float[] { 7f } };

            return config;
        }
    }

    public sealed class KomaSpellAPieceVFXDef : TestModPiece // Background darkening effect
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(444001, 4);

            config.Projectile = "Dark2sf";

            config.ShootType = 0;

            config.LastWave = false;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { };

            config.Color = new int[][] { };

            config.Aim = 0;

            config.StartTime = 0;

            config.GInterval = 0;

            config.Group = 1;

            return config;
        }
    }
}
