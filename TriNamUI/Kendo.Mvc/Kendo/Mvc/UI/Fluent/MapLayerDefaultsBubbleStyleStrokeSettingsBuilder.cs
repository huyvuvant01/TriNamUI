﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapLayerDefaultsBubbleStyleStrokeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MapLayerDefaultsBubbleStyleStrokeSettingsBuilder
  {
    public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder(
      MapLayerDefaultsBubbleStyleStrokeSettings container)
    {
      this.Container = container;
    }

    protected MapLayerDefaultsBubbleStyleStrokeSettings Container { get; private set; }

    public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder DashType(
      string value)
    {
      this.Container.DashType = value;
      return this;
    }

    public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
