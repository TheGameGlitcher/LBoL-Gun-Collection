using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class WilloWispPieceFront0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90014);

            config.Projectile = "JunkoJade";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = true;

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.Y = new float[][] { new float[] { 0.3f } };

            config.Aim = 1;

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.StartSpeed = new float[][] { new float[] { 6.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 30 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 120 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 5f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Homing, 1 } };

            return config;
        }
    }

    public sealed class WilloWispPieceFront1Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90014, 1);

            config.Projectile = "JunkoJade";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = true;

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.Y = new float[][] { new float[] { -0.3f } };

            config.Aim = 1;

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.StartSpeed = new float[][] { new float[] { 6.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 30 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 120 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 5f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Homing, 1 } };

            return config;
        }
    }

    public sealed class WilloWispPieceBack0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90014, 2);

            config.Projectile = "JunkoJade";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = true;

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.X = new float[][] { new float[] { -0.4f } };

            config.Y = new float[][] { new float[] { 0.5f } };

            config.Aim = 1;

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.StartSpeed = new float[][] { new float[] { 6.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 30 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 120 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 5f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Homing, 1 } };

            return config;
        }
    }

    public sealed class WilloWispPieceBack1Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90014, 3);

            config.Projectile = "JunkoJade";

            config.Type = false;

            config.ShootType = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = true;

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.X = new float[][] { new float[] { -0.4f } };

            config.Y = new float[][] { new float[] { -0.5f } };

            config.Aim = 1;

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.StartSpeed = new float[][] { new float[] { 6.5f } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 30 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 120 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 5f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Homing, 1 } };

            return config;
        }
    }
}
