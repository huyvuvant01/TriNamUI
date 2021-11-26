// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramConnectionEndCapSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramConnectionEndCapSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DiagramConnectionEndCapFillSettings<TShapeModel, TConnectionModel> Fill { get; } = new DiagramConnectionEndCapFillSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionEndCapStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramConnectionEndCapStrokeSettings<TShapeModel, TConnectionModel>();

    public string Type { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Fill.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["fill"] = (object) source1;
      Dictionary<string, object> source2 = this.Stroke.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["stroke"] = (object) source2;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      return dictionary;
    }
  }
}
