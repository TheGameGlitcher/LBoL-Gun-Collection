using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces.Yukari.DreamsAndReality
{
    public sealed class DreamsAndRealityPiece0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178006);

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

            config.Life = new int[][] { new int[] { 18 } };

            config.StartSpeed = new float[][] { new float[] { 3.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 8 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 1 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 17f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Speed, 1 } };

            config.VanishV3 = new UnityEngine.Vector3(1f, 1f, 1f);

            return config;
        }
    }

    public sealed class DreamsAndRealityPiece1Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178006, 1);

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
}
