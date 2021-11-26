// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MapMarkerTooltipBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MapMarkerTooltipBuilder : TooltipBuilderBase<MapMarkerTooltipBuilder>
  {
    public MapMarkerTooltipBuilder(MapMarkerTooltip tooltip)
      : base((Kendo.Mvc.UI.Tooltip) tooltip)
    {
      this.Tooltip = tooltip;
    }

    private MapMarkerTooltip Tooltip { get; set; }

    public MapMarkerTooltipBuilder Template(string value)
    {
      this.Tooltip.Template = value;
      return this;
    }
  }
}
