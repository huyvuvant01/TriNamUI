// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TileLayoutContainer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TileLayoutContainer
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string BodyTemplate { get; set; }

    public string BodyTemplateId { get; set; }

    public double? ColSpan { get; set; }

    public TileLayoutContainerHeaderSettings Header { get; } = new TileLayoutContainerHeaderSettings();

    public double? RowSpan { get; set; }

    public TileLayout TileLayout { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.BodyTemplateId.HasValue())
        dictionary["bodyTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TileLayout.IdPrefix, (object) this.BodyTemplateId)
        };
      else if (this.BodyTemplate.HasValue())
        dictionary["bodyTemplate"] = (object) this.BodyTemplate;
      if (this.ColSpan.HasValue)
        dictionary["colSpan"] = (object) this.ColSpan;
      Dictionary<string, object> source = this.Header.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["header"] = (object) source;
      if (this.RowSpan.HasValue)
        dictionary["rowSpan"] = (object) this.RowSpan;
      return dictionary;
    }
  }
}
