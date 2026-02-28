using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class PurifyingStrikeBPiece0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90013);

            config.Projectile = "ReimuAmuletrectangleHighlight";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Orange } };

            config.RootType = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { 0f }, new float[] { 8f } };

            config.Range = new float[][] { new float[] { 360f } };

            config.Radius = new float[][] { new float[] { 2f } };

            config.Aim = 0;

            config.StartTime = 0;

            config.GInterval = 1;

            config.Group = 45;

            config.StartSpeed = new float[][] { new float[] { 0f } };

            config.Life = new int[][] { new int[] { 240 } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 0 } },
                                             new int[][] { new int[] { 50 }, new int[] { -1 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 1 } },
                                                new int[][] { new int[] { 7 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 180f } },
                                                new float[][] { new float[] { 30f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Angle },
                                          new int[] { (int)BulletEventType.Speed } };

            return config;
        }
    }

    public sealed class PurifyingStrikeBPiece1Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90013, 1);

            config.Projectile = "ReimuAmuletrectangleHighlight";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Orange } };

            config.RootType = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { 0f }, new float[] { -15f } };

            config.Range = new float[][] { new float[] { 360f } };

            config.Radius = new float[][] { new float[] { 1.5f } };

            config.Aim = 0;

            config.StartTime = 15;

            config.GInterval = 1;

            config.Group = 24;

            config.StartSpeed = new float[][] { new float[] { 0f } };

            config.Life = new int[][] { new int[] { 240 } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 0 } },
                                             new int[][] { new int[] { 29 }, new int[] { -1 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 1 } },
                                                new int[][] { new int[] { 7 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 180f } },
                                                new float[][] { new float[] { 30f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Angle },
                                          new int[] { (int)BulletEventType.Speed } };

            return config;
        }
    }
}
