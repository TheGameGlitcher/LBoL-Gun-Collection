using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class DreamfinitePieceDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90011);

            config.Projectile = "ReimuLightorb";

            config.ShootType = 1;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.3f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.RandomPalette } };

            config.Aim = 0;

            config.StartTime = 0;

            config.GInterval = 12;

            config.Group = 3;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { 0f, 180f } };

            config.Range = new float[][] { new float[] { 360f } };

            config.StartSpeed = new float[][] { new float[] { 5, 1 } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 0 } },
                                             new int[][] { new int[] { 27 } },
                                             new int[][] { new int[] { 30 } },
                                             new int[][] { new int[] { 55 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 25 } },
                                                new int[][] { new int[] { 75 } },
                                                new int[][] { new int[] { 25 } },
                                                new int[][] { new int[] { 125 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 1f } },
                                                new float[][] { new float[] { 30f } },
                                                new float[][] { new float[] { 4f } },
                                                new float[][] { new float[] { 12f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Speed, 1 },
                                          new int[] { (int)BulletEventType.Speed },
                                          new int[] { (int)BulletEventType.Homing, 1 },
                                          new int[] { (int)BulletEventType.Homing, 1 } };

            return config;
        }
    }
}
