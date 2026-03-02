using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;
using UnityEngine;

namespace TestMod.Source.Guns.Pieces.PrintedGunPieces
{
    public sealed class PrintedGun7Piece0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90023);

            config.Projectile = "DanmaBigBullet";

            config.Type = false;

            config.ShootType = 1;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.6f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Purple } };

            config.Aim = 0;

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.StartSpeed = new float[][] { new float[] { 40f } };

            config.Life = new int[][] { new int[] { 30 } };

            config.LaunchSfx = "SumirekoGunShoot";

            config.HitBodySfx = "CommonHitBody";

            return config;
        }
    }

    public sealed class PrintedGun7Piece1Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90023, 1);

            config.Projectile = "ReimuLightorb";

            config.ShootType = 1;

            config.Type = false;

            config.LastWave = false;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.3f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Purple } };

            config.X = new float[][] { new float[] { -0.6f } };

            config.Y = new float[][] { new float[] { -0.4f } };

            config.Radius = new float[][] { new float[] { 1.8f } };

            config.RadiusA = new float[][] { new float[] { 90f } };

            config.Aim = 0;

            config.StartTime = 0;

            config.GInterval = 0;

            config.Group = 7;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { 0f }, new float[] { 51.4285714286f } };

            config.Range = new float[][] { new float[] { 360f } };

            config.StartSpeed = new float[][] { new float[] { 15f } };

            config.Life = new int[][] { new int[] { 60 } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 0 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 60 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 360f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Angle } };

            config.VanishV3 = new Vector3(1f, 1f, 1f);

            return config;
        }
    }
}
