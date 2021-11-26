// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapMarkerTooltip
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MapMarkerTooltip : Tooltip
  {
    public MapMarkerTooltip(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public string Template { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
