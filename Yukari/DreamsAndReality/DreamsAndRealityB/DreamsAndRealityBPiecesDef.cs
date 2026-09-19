using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces.Yukari.DreamsAndReality
{
    public sealed class DreamsAndRealityBPiece0ADef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178007);

            config.Projectile = "DanmaBigPoint";

            config.ShootType = 0;

            config.LastWave = false;

            config.HitAmount = 0;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.8f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { 38f } };

            config.Life = new int[][] { new int[] { 22 } };

            config.StartSpeed = new float[][] { new float[] { 3.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 8 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 1 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 17f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Speed, 1 } };

            config.VanishV3 = new UnityEngine.Vector3(1f, 1f, 1f);

            return config;
        }
    }

    public sealed class DreamsAndRealityBPiece1ADef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178007, 1);

            config.Projectile = "DanmaBigPoint";

            config.ShootType = 0;

            config.LastWave = false;

            config.HitAmount = 0;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.8f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { -38f } };

            config.Life = new int[][] { new int[] { 22 } };

            config.StartSpeed = new float[][] { new float[] { 3.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 8 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 1 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 17f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Speed, 1 } };

            config.VanishV3 = new UnityEngine.Vector3(1f, 1f, 1f);

            return config;
        }
    }

    public sealed class DreamsAndRealityBPiece0BDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178007, 2);

            config.Projectile = "DanmaRice";

            config.ShootType = 3;

            config.ParentPiece = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.Aim = 1;

            config.StartTime = 0;

            config.GInterval = 6;

            config.Group = 6;

            config.Way = new int[][] { new int[] { 4 } };

            config.Range = new float[][] { new float[] { 360f } };

            config.GAngle = new float[][] { new float[] { 0f, 10f }, new float[] { 10f } };

            config.Life = new int[][] { new int[] { 80 } };

            config.StartSpeed = new float[][] { new float[] { 6.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 10 } },
                                             new int[][] { new int[] { 18 } },
                                             new int[][] { new int[] { 21 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 8 } },
                                                new int[][] { new int[] { 1 } },
                                                new int[][] { new int[] { 1 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 0f } },
                                                new float[][] { new float[] { 0f } },
                                                new float[][] { new float[] { 6.5f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Speed, 1 },
                                          new int[] { (int)BulletEventType.Homing },
                                          new int[] { (int)BulletEventType.Speed } };

            return config;
        }
    }

    public sealed class DreamsAndRealityBPiece1BDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178007, 3);

            config.Projectile = "DanmaFish";

            config.ShootType = 3;

            config.ParentPiece = 1;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.YellowGreen } };

            config.Aim = 1;

            config.StartTime = 0;

            config.GInterval = 0;

            config.Group = 8;

            config.Way = new int[][] { new int[] { 4 } };

            config.Range = new float[][] { new float[] { 360f } };

            config.Radius = new float[][] { new float[] { 0.75f } };

            config.RadiusA = new float[][] { new float[] { 0f }, new float[] { 45f } };

            config.Life = new int[][] { new int[] { 120 } };

            config.StartSpeed = new float[][] { new float[] { 3f } };

            return config;
        }
    }

    public sealed class DreamsAndRealityBPiece1CDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178007, 4);

            config.Projectile = "DanmaFish";

            config.ShootType = 3;

            config.ParentPiece = 1;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Lime } };

            config.Aim = 1;

            config.StartTime = 5;

            config.GInterval = 0;

            config.Group = 8;

            config.Way = new int[][] { new int[] { 4 } };

            config.Range = new float[][] { new float[] { 360f } };

            config.Radius = new float[][] { new float[] { 1.5f } };

            config.RadiusA = new float[][] { new float[] { 0f }, new float[] { 45f } };

            config.Life = new int[][] { new int[] { 120 } };

            config.StartSpeed = new float[][] { new float[] { 3f } };

            return config;
        }
    }

    public sealed class DreamsAndRealityBPiece1DDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178007, 5);

            config.Projectile = "DanmaFish";

            config.ShootType = 3;

            config.ParentPiece = 1;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Lime } };

            config.Aim = 1;

            config.StartTime = 5;

            config.GInterval = 0;

            config.Group = 8;

            config.Way = new int[][] { new int[] { 4 } };

            config.Range = new float[][] { new float[] { 360f } };

            config.GAngle = new float[][] { new float[] { 45f } };

            config.Radius = new float[][] { new float[] { 1.9f } };

            config.RadiusA = new float[][] { new float[] { 0f }, new float[] { 45f } };

            config.Life = new int[][] { new int[] { 120 } };

            config.StartSpeed = new float[][] { new float[] { 3f } };

            return config;
        }
    }
}
