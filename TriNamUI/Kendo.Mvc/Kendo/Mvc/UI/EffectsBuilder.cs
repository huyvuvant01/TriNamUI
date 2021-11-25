// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EffectsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class EffectsBuilder : IHideObjectMembers
  {
    public EffectsBuilder(Effects effects)
    {
      this.Effects = effects;
      this.Container.Clear();
    }

    protected Effects Effects { get; set; }

    protected IList<string> Container => this.Effects.Container;

    private EffectsBuilder Add(string effect)
    {
      this.Container.Add(effect);
      return this;
    }

    private EffectsBuilder Add(string effect, string direction)
    {
      this.Container.Add("{0}:{1}".FormatWith((object) effect, (object) direction));
      return this;
    }

    public EffectsBuilder Fade(FadeDirection direction) => this.Add("fade", direction.ToString().ToLower());

    public EffectsBuilder Zoom(ZoomDirection direction) => this.Add("zoom", direction.ToString().ToLower());

    public EffectsBuilder SlideIn(SlideDirection direction) => this.Add("slideIn", direction.ToString().ToLower());

    public EffectsBuilder Expand() => this.Add("expand");

    public EffectsBuilder Expand(ExpandDirection direction) => this.Add("expand", direction.ToString().ToLower());

    public EffectsBuilder Duration(int value)
    {
      this.Effects.Duration = value;
      return this;
    }

    public EffectsBuilder Reverse(bool value)
    {
      this.Effects.Reverse = value;
      return this;
    }

    public EffectsBuilder Duration(AnimationDuration value) => this.Duration((int) value);

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
