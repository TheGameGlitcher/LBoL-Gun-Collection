using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces.Yukari.DanmakuBelow
{
    public sealed class DanmakuBelowPiece0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178004);

            config.Projectile = "DanmaBigMagic";

            config.ShootType = 0;

            config.LastWave = false;

            config.HitAmount = 0;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Grayscale } };

            config.Aim = 1;

            config.RootType = 1;

            config.X = new float[][] { new float[] { -2.3f, 0.2f } };

            config.Y = new float[][] { new float[] { -2.3f, 0.2f } };

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.Life = new int[][] { new int[] { 75 } };

            config.StartSpeed = new float[][] { new float[] { 4f } };

            config.VanishV3 = new UnityEngine.Vector3(1f, 1f, 1f);

            return config;
        }
    }

    public sealed class DanmakuBelowPiece1Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178004, 1);

            config.Projectile = "DanmaKunai";

            config.ShootType = 2;

            config.ParentPiece = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Purple } };

            config.Aim = 1;

            config.StartTime = 0;

            config.GInterval = 12;

            config.Group = 6;

            config.Way = new int[][] { new int[] { 12 } };

            config.Range = new float[][] { new float[] { 360f } };

            config.Life = new int[][] { new int[] { 60 } };

            config.StartSpeed = new float[][] { new float[] { 6f } };

            return config;
        }
    }
}
