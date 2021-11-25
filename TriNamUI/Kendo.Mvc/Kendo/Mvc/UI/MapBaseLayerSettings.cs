// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapBaseLayerSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public abstract class MapBaseLayerSettings
  {
    private MapMarkerTooltip tooltip;

    protected abstract ViewContext ViewContext { get; }

    public MapMarkerTooltip Tooltip
    {
      get
      {
        if (this.tooltip == null && this.ViewContext != null)
          this.tooltip = new MapMarkerTooltip(this.ViewContext);
        return this.tooltip;
      }
    }

    protected void SerializeTooltip(IDictionary<string, object> settings)
    {
      if (this.tooltip == null)
        return;
      Dictionary<string, object> source = this.tooltip.Serialize();
      if (!source.Any<KeyValuePair<string, object>>())
        return;
      settings["tooltip"] = (object) source;
    }
  }
}
