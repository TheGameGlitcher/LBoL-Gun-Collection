using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;
using UnityEngine;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class IllusionaryDominanceOriginPieceDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90030);

            config.Projectile = "DanmaRice";

            config.Type = false;

            config.ShootType = 1;

            config.LastWave = false;

            config.ZeroHitNotDie = true;

            config.HitAmount = 1;

            config.Scale = new float[][] { new float[] { 3f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Default } };

            config.RootType = 1;

            config.Radius = new float[][] { new float[] { 15f } };

            config.RadiusA = new float[][] { new float[] { 180f } };

            config.Aim = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { 0f, 3f } };

            config.Range = new float[][] { new float[] { 3f } };

            config.StartTime = 0;

            config.Life = new int[][] { new int[] { 120 } };

            config.StartSpeed = new float[][] { new float[] { 0.1f } };

            config.LaunchSfx = "";

            config.HitBodySfx = "";

            return config;
        }

        public sealed class IllusionaryDominancePiece0Def : TestModPiece
        {
            public override PieceConfig MakeConfig()
            {
                PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

                config.Id = ConvertGunId(90030, 1);

                config.Projectile = "DanmaRice";

                config.Type = false;

                config.ShootType = 2;

                config.ParentPiece = 0;

                config.LastWave = false;

                config.ZeroHitNotDie = true;

                config.HitAmount = 1;

                config.Scale = new float[][] { new float[] { 3f } };

                config.Color = new int[][] { new int[] { (int)BulletColor.Red } };

                config.Aim = 3;

                config.Group = 1;

                config.Way = new int[][] { new int[] { 1 } };

                config.StartTime = 2;

                config.Life = new int[][] { new int[] { 20 } };

                config.StartSpeed = new float[][] { new float[] { 120f } };

                config.EvStart = new int[][][] { new int[][] { new int[] { 0 } } };

                config.EvDuration = new int[][][] { new int[][] { new int[] { 1 } } };

                config.EvNumber = new float[][][] { new float[][] { new float[] { 4f } } };

                config.EvType = new int[][] { new int[] { (int)BulletEventType.ScaleX } };

                return config;
            }
        }

        public sealed class IllusionaryDominancePiece1Def : TestModPiece
        {
            public override PieceConfig MakeConfig()
            {
                PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

                config.Id = ConvertGunId(90030, 2);

                config.Projectile = "DanmaRice";

                config.Type = false;

                config.ShootType = 2;

                config.ParentPiece = 0;

                config.LastWave = true;

                config.ZeroHitNotDie = true;

                config.HitAmount = 1;

                config.Scale = new float[][] { new float[] { 3f } };

                config.Color = new int[][] { new int[] { (int)BulletColor.Red } };

                config.Radius = new float[][] { new float[] { -30f } };

                config.RadiusA = new float[][] { new float[] { 180f } };

                config.Aim = 3;

                config.Group = 1;

                config.Way = new int[][] { new int[] { 1 } };

                config.StartTime = 17;

                config.Life = new int[][] { new int[] { 20 } };

                config.StartSpeed = new float[][] { new float[] { 120f } };

                config.EvStart = new int[][][] { new int[][] { new int[] { 0 } } };

                config.EvDuration = new int[][][] { new int[][] { new int[] { 1 } } };

                config.EvNumber = new float[][][] { new float[][] { new float[] { 4f } } };

                config.EvType = new int[][] { new int[] { (int)BulletEventType.ScaleX } };

                return config;
            }
        }
    }
}
