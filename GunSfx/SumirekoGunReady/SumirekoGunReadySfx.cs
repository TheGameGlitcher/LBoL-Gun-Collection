using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using TestMod.Source.Config;
using UnityEngine;

namespace TestMod.Source.Sounds
{
    public sealed class SumirekoGunReadySfx : SfxTemplate
    {
        public static DirectorySource sfx_dir = new DirectorySource(PInfo.GUID, "SFX");

        public override IdContainer GetId()
        {
            return TestModDefaultConfig.DefaultID(this);
        }

        public override SfxConfig MakeConfig()
        {
            SfxConfig config = DefaultConfig();

            config.Name = "SumirekoGunReady";

            config.Folder = "SFX";

            config.Path = "SumirekoGunReady.wav";

            config.Volume = 1;

            return config;
        }

        public override List<UniTask<AudioClip>> LoadSfxListAsync()
        {
            return new List<UniTask<AudioClip>>
            {
                ResourceLoader.LoadAudioClip("SumirekoGunReady" + ".wav", AudioType.WAV, sfx_dir)
            };
        }
    }
}
