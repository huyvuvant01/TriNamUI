// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramConnectionDefaultsHoverSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramConnectionDefaultsHoverSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DiagramConnectionDefaultsHoverStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramConnectionDefaultsHoverStrokeSettings<TShapeModel, TConnectionModel>();

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source = this.Stroke.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["stroke"] = (object) source;
      return dictionary;
    }
  }
}
