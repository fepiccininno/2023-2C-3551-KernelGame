﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.Cameras;
using TGC.MonoGame.TP.Types.Props;
using TGC.MonoGame.TP.Types.Tanks;
using TGC.MonoGame.TP.Utils.Models;

namespace TGC.MonoGame.TP.Types;

public abstract class Map
{
    public Scenary Scenary { get; set; }
    public SkyDome SkyDome { get; set; }
    public List<StaticProp> Props { get; set; } 
    public Tank Player { get; set; }
    public List<Tank> Tanks { get; set; }

    public abstract void Load(GraphicsDevice graphicsDevice,ContentManager content);

    public abstract void Draw(Camera camera, RenderTarget2D ShadowMapRenderTarget, GraphicsDevice GraphicsDevice,
        Camera TargetLightCamera, BoundingFrustum BoundingFrustum);
    public abstract void Update(GameTime gameTime);
}