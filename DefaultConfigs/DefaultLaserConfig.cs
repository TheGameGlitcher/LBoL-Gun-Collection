public static LaserConfig DefaultLaserConfig()
{
    return new LaserConfig(
        Name: "Empty",
        Widget: "",
        LaunchSfx: "MarisaLaserMain",
        Size: new Vector2(20f, 0.30f),
        Offset: new Vector2(10f, 0f),
        Start: 0,
        HitBody: "HitBody",
        HitBodySfx: "CommonHitBody",
        HitShield: "HitShield",
        HitShieldSfx: "CommonHitShield",
        HitBlock: "HitBlock",
        HitBlockSfx: "CommonHitShield",
        Graze: "",
        GrazeSfx: "CommonGraze"
        );
}
    }