// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramShapeFillGradientSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramShapeFillGradientSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Type { get; set; }

    public double? Radius { get; set; }

    public List<DiagramShapeFillGradientSettingsStop<TShapeModel, TConnectionModel>> Stops { get; set; } = new List<DiagramShapeFillGradientSettingsStop<TShapeModel, TConnectionModel>>();

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      if (this.Radius.HasValue)
        dictionary["radius"] = (object) this.Radius;
      IEnumerable<Dictionary<string, object>> source = this.Stops.Select<DiagramShapeFillGradientSettingsStop<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramShapeFillGradientSettingsStop<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["stops"] = (object) source;
      return dictionary;
    }
  }
}
