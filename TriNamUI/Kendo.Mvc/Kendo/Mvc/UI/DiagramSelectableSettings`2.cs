// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramSelectableSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramSelectableSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Multiple { get; set; }

    public DiagramSelectableStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramSelectableStrokeSettings<TShapeModel, TConnectionModel>();

    public DiagramSelectableKey? Key { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Multiple.HasValue)
        dictionary1["multiple"] = (object) this.Multiple;
      Dictionary<string, object> source = this.Stroke.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["stroke"] = (object) source;
      if (this.Key.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        DiagramSelectableKey? key = this.Key;
        ref DiagramSelectableKey? local = ref key;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["key"] = (object) str;
      }
      return dictionary1;
    }
  }
}
