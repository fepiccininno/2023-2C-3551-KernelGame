﻿using TGC.MonoGame.TP.Types.References;

namespace TGC.MonoGame.TP.Utils.Effects;

public static class Effects
{
    public static readonly EffectReference BasicShader = new EffectReference(
        $"{ContentFolder.Effects}/BasicShader"
    );
    
    public static readonly EffectReference TextureShader = new EffectReference(
        $"{ContentFolder.Effects}/TextureShader"
    );

    public static readonly EffectReference HealthHud = new EffectReference(
        $"{ContentFolder.Effects}/HealthHud"
    );
    
    public static readonly EffectReference ShootHud = new EffectReference(
        $"{ContentFolder.Effects}/ShootHud"
    );
}