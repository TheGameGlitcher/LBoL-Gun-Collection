public static GunConfig DefaultGunConfig()
{
    return new GunConfig(
        Id: 120000,
        Name: "",
        Spell: "",
        Sequence: "",
        Animation: "shoot1",
        ForceHitTime: null,
        ForceHitAnimation: false,
        ForceHitAnimationSpeed: 1f,
        ForceShowEndStartTime: null,
        Shooter: "Direct",
        ShakePower: 1f
        );
}