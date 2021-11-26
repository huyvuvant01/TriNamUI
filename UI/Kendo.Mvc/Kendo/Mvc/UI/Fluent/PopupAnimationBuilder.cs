// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PopupAnimationBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PopupAnimationBuilder
  {
    public PopupAnimationBuilder(PopupAnimation animation) => this.Animation = animation;

    protected PopupAnimation Animation { get; private set; }

    public void Enable(bool enable) => this.Animation.Enabled = enable;

    public PopupAnimationBuilder Open(Action<EffectsBuilder> effectsAction)
    {
      effectsAction(new EffectsBuilder(this.Animation.Open));
      return this;
    }

    public PopupAnimationBuilder Close(Action<EffectsBuilder> effectsAction)
    {
      effectsAction(new EffectsBuilder(this.Animation.Close));
      return this;
    }
  }
}
