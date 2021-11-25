// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramConnectionDefaultsSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramConnectionDefaultsSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DiagramConnectionDefaultsContentSettings<TShapeModel, TConnectionModel> Content { get; } = new DiagramConnectionDefaultsContentSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionDefaultsEditableSettings<TShapeModel, TConnectionModel> Editable { get; } = new DiagramConnectionDefaultsEditableSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionDefaultsEndCapSettings<TShapeModel, TConnectionModel> EndCap { get; } = new DiagramConnectionDefaultsEndCapSettings<TShapeModel, TConnectionModel>();

    public string FromConnector { get; set; }

    public DiagramConnectionDefaultsHoverSettings<TShapeModel, TConnectionModel> Hover { get; } = new DiagramConnectionDefaultsHoverSettings<TShapeModel, TConnectionModel>();

    public bool? Selectable { get; set; }

    public DiagramConnectionDefaultsSelectionSettings<TShapeModel, TConnectionModel> Selection { get; } = new DiagramConnectionDefaultsSelectionSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionDefaultsStartCapSettings<TShapeModel, TConnectionModel> StartCap { get; } = new DiagramConnectionDefaultsStartCapSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionDefaultsStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramConnectionDefaultsStrokeSettings<TShapeModel, TConnectionModel>();

    public string ToConnector { get; set; }

    public DiagramConnectionType? Type { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Content.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["content"] = (object) source1;
      Dictionary<string, object> source2 = this.Editable.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["editable"] = (object) source2;
      else if (this.Editable.Enabled.HasValue)
        dictionary1["editable"] = (object) this.Editable.Enabled;
      Dictionary<string, object> source3 = this.EndCap.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["endCap"] = (object) source3;
      string fromConnector = this.FromConnector;
      if ((fromConnector != null ? (fromConnector.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["fromConnector"] = (object) this.FromConnector;
      Dictionary<string, object> source4 = this.Hover.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["hover"] = (object) source4;
      if (this.Selectable.HasValue)
        dictionary1["selectable"] = (object) this.Selectable;
      Dictionary<string, object> source5 = this.Selection.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["selection"] = (object) source5;
      Dictionary<string, object> source6 = this.StartCap.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary1["startCap"] = (object) source6;
      Dictionary<string, object> source7 = this.Stroke.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["stroke"] = (object) source7;
      string toConnector = this.ToConnector;
      if ((toConnector != null ? (toConnector.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["toConnector"] = (object) this.ToConnector;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        DiagramConnectionType? type = this.Type;
        ref DiagramConnectionType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
